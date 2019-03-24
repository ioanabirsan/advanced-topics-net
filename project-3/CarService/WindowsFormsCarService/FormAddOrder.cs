using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormAddOrder : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormAddOrder()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, 100);

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
        }

        private void buttonAddDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
