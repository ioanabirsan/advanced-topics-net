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

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Nume, Prenume FROM Clienti";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddOrderSelectClient.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Denumire FROM Materiale";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsMaterials.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Denumire FROM Operatii";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsOperations.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Nume, Prenume FROM Mecanici";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsMechanics.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Titlu, Data FROM Imagini";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailsImages.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT Id, Descriere FROM Comenzi";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewAddDetailByOrder.DataSource = dataTable;
            }
        }

        private void buttonAddNewOrder_Click(object sender, EventArgs e)
        {
            string startDateText = dateTimePickerStartDate.Text;
            string endDateText = dateTimePickerEndDate.Text;
            string stateText = comboBoxAddOrderState.SelectedItem.ToString();
            string description = textBoxAddOrderDescription.Text;
            string inService = comboBoxAddOrderInService.SelectedItem.ToString();

            if (inService.Equals("Yes"))
            {
                textBoxAddOrderKm.Enabled = true;
            }

            int index = dataGridViewAddOrderSelectClient.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewAddOrderSelectClient.Rows[index];
            string clientIdText = selectedRow.Cells[0].Value.ToString();
            int clientId = Convert.ToInt32(clientIdText);

            Comanda order = new Comanda()
            {
                ClientId = clientId,
                DataFinalizare = Convert.ToDateTime(endDateText),
                DataProgramare = Convert.ToDateTime(startDateText),
                DataSystem = DateTime.Now,
                Descriere = description,
                KmBord = Convert.ToInt32(textBoxAddOrderKm.Text),
                StareComanda = StareComanda.InAsteptare,
                ValoarePiese = 0m
            };

            _carService.AddOrder(order);

            labelAddOrder.Text = "Order added.";
            labelAddOrder.Visible = true;
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

            labelAddDetails.Text = "Order details added.";
            labelAddDetails.Visible = true;
        }
    }
}
