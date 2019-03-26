using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageOrder : Form
    {
        private readonly CarServiceApi _carService;

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

            string getOrdersQuery = "SELECT Id, Descriere FROM Comenzi";
            ExecuteQuery(getOrdersQuery, dataGridViewAddDetailByOrder);
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
                labelAddOrder.Visible = true;
                buttonAddNewOrder.Enabled = false;
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
                    ValoarePiese = 0m
                };

                _carService.AddOrder(order);

                labelAddOrder.Text = @"Order added.";
                labelAddOrder.Visible = true;
            }
        }

        private StareComanda getOrderState(string state)
        {
            if (state.Equals("Waiting"))
            {
                return StareComanda.InAsteptare;
            }
            if (state.Equals("Executed"))
            {
                return StareComanda.Executata;
            }
            if (state.Equals("Rejected"))
            {
                return StareComanda.Refuzata;
            }

            return StareComanda.InAsteptare;
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
    }
}