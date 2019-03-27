using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageOrder : Form
    {
        private readonly CarServiceApi _carService;
        private decimal TotalCost = 0m;
        private decimal ServiceFee = 50m;

        private string OrderDescriptionPattern = @"^[A-Z][A-Za-z -,.0-9]{3,1023}$";
        private string OrderKmPattern = @"^[1-9][0-9]*$";

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormManageOrder()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);

            buttonAddNewOrder.Enabled = false;
        }

        private void FormManageOrder_Load(object sender, EventArgs e)
        {
            string getClientsQuery = "SELECT Id, Nume, Prenume FROM Clienti";
            ExecuteQuery(getClientsQuery, dataGridViewAddOrderSelectClient);

            string getMaterialsQuery = "SELECT Id, Denumire FROM Materiale";
            ExecuteQuery(getMaterialsQuery, dataGridViewAddDetailsMaterials);

            string getOperationsQuery = "SELECT Id, Denumire FROM Operatii";
            ExecuteQuery(getOperationsQuery, dataGridViewAddDetailsOperations);

            string getMechanicsQuery = "SELECT Id, Nume, Prenume FROM Mecanici";
            ExecuteQuery(getMechanicsQuery, dataGridViewAddDetailsMechanics);

            string getImagesQuery = "SELECT Id, Titlu, Data FROM Imagini";
            ExecuteQuery(getImagesQuery, dataGridViewAddDetailsImages);

            string getOrdersQuery = "SELECT Id, Descriere, StareComanda FROM Comenzi";
            ExecuteQuery(getOrdersQuery, dataGridViewAddDetailByOrder);
        }

        private void buttonAddNewOrder_Click(object sender, EventArgs e)
        {
            int index = dataGridViewAddOrderSelectClient.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAddOrderSelectClient.Rows[index];
            string clientIdText = selectedRow.Cells[0].Value.ToString();
            int clientId = Convert.ToInt32(clientIdText);

            string startDate = dateTimePickerStartDate.Text;
            string endDate = dateTimePickerEndDate.Text;
            string state = comboBoxAddOrderState.SelectedItem.ToString();
            string description = textBoxAddOrderDescription.Text;

            if (string.IsNullOrEmpty(description) || string.IsNullOrEmpty(state))
            {
                labelAddOrder.Text = @"Must complete all mandatory fields.";
            }
            else
            {
                buttonAddNewOrder.Enabled = true;
                Comanda order = new Comanda()
                {
                    ClientId = clientId,
                    DataFinalizare = Convert.ToDateTime(endDate),
                    DataProgramare = Convert.ToDateTime(startDate),
                    DataSystem = DateTime.Now,
                    Descriere = description,
                    KmBord = Convert.ToInt32(textBoxAddOrderKm.Text),
                    StareComanda = getOrderState(state),
                    ValoarePiese = TotalCost
                };

                _carService.AddOrder(order);

                labelAddOrder.Text = @"Order added.";
                labelAddOrder.Visible = true;

                string getOrdersQuery = "SELECT Id, Descriere, StareComanda FROM Comenzi";
                ExecuteQuery(getOrdersQuery, dataGridViewAddDetailByOrder);
            }
        }

        private StareComanda getOrderState(string state)
        {
            switch (state)
            {
                case "Waiting":
                    return StareComanda.InAsteptare;
                case "Executed":
                    return StareComanda.Executata;
                case "Rejected":
                    return StareComanda.Refuzata;
                default:
                    return StareComanda.Necunoscuta;
            }
        }

        private void buttonAddDetails_Click(object sender, EventArgs e)
        {
            List<Material> materials = new List<Material>();
            List<Operatie> operations = new List<Operatie>();
            List<Mecanic> mechanics = new List<Mecanic>();
            List<Imagine> images = new List<Imagine>();

            int index = dataGridViewAddDetailByOrder.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAddDetailByOrder.Rows[index];
            int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);

            foreach (DataGridViewRow row in dataGridViewAddDetailsMaterials.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);

                Material material = _carService.FindMaterialById(id);
                TotalCost += material.Pret;

                material.Cantitate -= 1;
                _carService.UpdateMaterial(material);

                materials.Add(material);
            }

            foreach (DataGridViewRow row in dataGridViewAddDetailsOperations.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);

                Operatie operation = _carService.FindOperationById(id);
                operations.Add(operation);
            }

            foreach (DataGridViewRow row in dataGridViewAddDetailsMechanics.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);

                Mecanic mecanic = _carService.FindMecanicById(id);
                mechanics.Add(mecanic);
            }

            foreach (DataGridViewRow row in dataGridViewAddDetailsImages.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);

                Imagine image = _carService.FindImageById(id);
                images.Add(image);
            }

            DetaliuComanda orderDetails = new DetaliuComanda()
            {
                ComandaId = orderId,
                Imagini = images,
                Mecanici = mechanics,
                Materiale = materials,
                Operatii = operations
            };

            _carService.AddOrderDetails(orderDetails);
            labelAddDetails.Text = @"Order details added.";
            labelAddDetails.Visible = true;

            Comanda order = _carService.FindOrderById(orderId);
            order.ValoarePiese = TotalCost + ServiceFee;
            _carService.UpdateOrder(order);
        }

        private void checkBoxAddOrderInService_Click(object sender, EventArgs e)
        {
            textBoxAddOrderKm.Enabled = checkBoxAddOrderInService.Checked;
        }

        private void dataGridViewAddOrderSelectClient_SelectionChanged(object sender, EventArgs e)
        {
            int index = dataGridViewAddOrderSelectClient.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAddOrderSelectClient.Rows[index];
            string clientIdText = selectedRow.Cells[0].Value.ToString();
            int clientId = Convert.ToInt32(clientIdText);

            string getClientCars = $"SELECT Id, NumarAuto, SerieSasiu FROM Automobile WHERE ClientId = {clientId}";
            ExecuteQuery(getClientCars, dataGridViewClientCars);
        }

        private void ExecuteQuery(string query, DataGridView dataGridView)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridView.DataSource = dataTable;
            }
        }

        private void textBoxAddOrderDescription_TextChanged(object sender, EventArgs e)
        {
            Validate(OrderDescriptionPattern, textBoxAddOrderDescription);
        }

        private void textBoxAddOrderKm_TextChanged(object sender, EventArgs e)
        {
            Validate(OrderKmPattern, textBoxAddOrderKm);
        }

        private void Validate(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            buttonAddNewOrder.Enabled = isValidExpression;
            labelAddOrder.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }
    }
}