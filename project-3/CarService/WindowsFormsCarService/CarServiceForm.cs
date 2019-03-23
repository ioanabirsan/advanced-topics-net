using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CarService;
using CarService.Api;
using System.Data.SqlClient;

namespace WindowsFormsCarService
{
    public partial class CarServiceForm : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public CarServiceForm()
        {
            InitializeComponent();
            _carService = new CarServiceApi();
        }

        private void CarServiceForm_Load(object sender, EventArgs e)
        {
            panelSearchCustomer.Visible = false;
            panelAddCustomer.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddChassis.Visible = false;
        }

        private void buttonSelectCustomer_Click(object sender, EventArgs e)
        {
            panelSearchCustomer.Visible = true;
            labelSearchDisplayInfo.Text = "";
            textBoxSearchName.Text = "";
            textBoxSearchFirstName.Text = "";
            textBoxSearchEmail.Text = "";

            panelAddCustomer.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddChassis.Visible = false;
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string email = textBoxSearchEmail.Text;

            Client client = _carService.FindCustomer(name, firstName, email);

            if (client == null)
            {
                labelSearchDisplayInfo.Text = "There is no customer with these specification. Please add new customer.";
            }
            else
            {
                labelSearchDisplayInfo.Text = "Customer cars are displayed bellow.";
                panelAddCustomerCar.Visible = true;

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string queryString = "SELECT CodSasiu, Denumire FROM Sasiuri";
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dataGridViewChassisOptions.DataSource = dataTable;
                    dataGridViewChassisOptions.Visible = true;
                }

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();
                    string queryString = "SELECT * FROM Automobile WHERE ClientId = " + client.Id;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);

                    dataGridViewCustomerCars.DataSource = dataTable;
                    dataGridViewCustomerCars.Visible = true;
                }
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            panelSearchCustomer.Visible = false;
            panelAddCustomer.Visible = true;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
            dataGridViewChassisOptions.Visible = false;
            panelAddChassis.Visible = false;

            textBoxAddName.Text = "";
            textBoxAddFirstName.Text = "";
            textBoxAddAddress.Text = "";
            textBoxAddCity.Text = "";
            textBoxAddCounty.Text = "";
            textBoxAddPhoneNumber.Text = "";
            textBoxAddEmail.Text = "";
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxAddName.Text;
            string firstName = textBoxAddFirstName.Text;
            string address = textBoxAddAddress.Text;
            string city = textBoxAddCity.Text;
            string county = textBoxAddCounty.Text;
            string phoneNumber = textBoxAddPhoneNumber.Text;
            string email = textBoxAddEmail.Text;

            List<Auto> autos = new List<Auto>();
            Client client = new Client()
            {
                Nume = name,
                Prenume = firstName,
                Adresa = address,
                Localitate = city,
                Judet = county,
                Telefon = phoneNumber,
                Email = email,
                Automobile = autos
            };

            _carService.AddCustomer(client);

            labelAddCustomerDisplayInfo.Text = "Client added.";
            labelSearchDisplayInfo.Visible = true;
        }

        private void buttonCustomerDetails_Click(object sender, EventArgs e)
        {
        }

        // https://www.youtube.com/watch?v=C9s0H6yeFLQ
        private void buttonDisplayCustomers_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Clienti";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewCustomers.DataSource = dataTable;
                dataGridViewCustomers.Visible = true;
            }
        }

        private void buttonAddCustomerCar_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string email = textBoxSearchEmail.Text;

            Client client = _carService.FindCustomer(name, firstName, email);

            int index = dataGridViewChassisOptions.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewChassisOptions.Rows[index];

            string autoNumber = textBoxAutoNumber.Text;
            string chassisSeries = textBoxChassisSeries.Text;

            Auto auto = new Auto()
            {

            };
        }

        private void buttonAddChassis_Click(object sender, EventArgs e)
        {
            panelAddChassis.Visible = true;
        }

        private void buttonAddNewChassis_Click(object sender, EventArgs e)
        {
            var chassisCode = textBoxChassisCode.Text;
            var chassisName = textBoxChassisName.Text;

            Sasiu sasiu = new Sasiu()
            {
                CodSasiu = chassisCode,
                Denumire = chassisName
            };

            _carService.AddChassis(sasiu);
        }
    }
}