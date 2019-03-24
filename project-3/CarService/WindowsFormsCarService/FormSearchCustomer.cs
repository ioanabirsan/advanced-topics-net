using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormSearchCustomer : Form
    {
        private readonly CarServiceApi _carService;
        private string _imageLocation = "";

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormSearchCustomer()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);

            dataGridViewChassisOptions.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            panelAddCustomerCar.Visible = false;
        }

        private void buttonSearchCustomer_Click_1(object sender, EventArgs e)
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

        private void buttonAddCustomerCar_Click_1(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string email = textBoxSearchEmail.Text;
            Client client = _carService.FindCustomer(name, firstName, email);

            int index = dataGridViewChassisOptions.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewChassisOptions.Rows[index];

            string codSasiu = selectedRow.Cells[0].Value.ToString();
            Sasiu sasiu = _carService.FindChassisByCode(codSasiu);

            string autoNumber = textBoxAutoNumber.Text;
            string chassisSeries = textBoxChassisSeries.Text;
            Auto auto = new Auto()
            {
                SasiuId = sasiu.Id,
                ClientId = client.Id,
                NumarAuto = autoNumber,
                SerieSasiu = chassisSeries
            };

            _carService.AddAuto(auto);

            labelAddCar.Text = "Car added.";
            labelAddCar.Visible = true;
        }

        private void buttonNewSearch_Click(object sender, EventArgs e)
        {
            labelSearchDisplayInfo.Visible = false;
            textBoxSearchName.Text = "";
            textBoxSearchFirstName.Text = "";
            textBoxSearchEmail.Text = "";

            panelAddCustomerCar.Visible = false;
            dataGridViewCustomerCars.Visible = false;
            dataGridViewChassisOptions.Visible = false;
        }

        private void buttonNewCar_Click(object sender, EventArgs e)
        {
            labelAddCar.Visible = false;
            textBoxChassisSeries.Text = "";
            textBoxAutoNumber.Text = "";
        }
    }
}