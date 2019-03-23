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
        private CarServiceApi _carService;
        //private string connectionString = "metadata=res://*/CarServiceModel.csdl|res://*/CarServiceModel.ssdl|res://*/CarServiceModel.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=localhost\SQLEXPRESS;initial catalog=AUTO;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient";
        private string connectionString = @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

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
        }

        private void buttonSelectCustomer_Click(object sender, EventArgs e)
        {
            // search customer area preparation
            panelSearchCustomer.Visible = true;
            labelSearchDisplayInfo.Text = "";
            textBoxSearchName.Text = "";
            textBoxSearchFirstName.Text = "";
            textBoxSearchEmail.Text = "";

            // add customer area preparation
            panelAddCustomer.Visible = false;

            // view customers area preparation
            dataGridViewCustomers.Visible = false;
        }

        private void buttonSearchCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string email = textBoxSearchEmail.Text;

            Client client = _carService.FindClient(name, firstName, email);

            if (client == null)
            {
                labelSearchDisplayInfo.Text =
                    "There is no customer with these specification. Please add new customer.";
                //labelSearchDisplayInfo.Visible = true;
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            panelSearchCustomer.Visible = false;
            panelAddCustomer.Visible = true;
            labelAddCustomerDisplayInfo.Visible = false;
            dataGridViewCustomers.Visible = false;

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

            _carService.AddClient(client);

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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Clienti", sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewCustomers.DataSource = dataTable;
                dataGridViewCustomers.Visible = true;
            }
        }
    }
}
