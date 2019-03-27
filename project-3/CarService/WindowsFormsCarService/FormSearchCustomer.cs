using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormSearchCustomer : Form
    {
        private readonly CarServiceApi _carService;
        private string EmailPattern = @"^[a-zA-Z0-9_.-]+@[a-z.]+.[a-z]+$";
        private string NamePattern = @"^[A-Z][A-Za-z -]{2,14}$";
        private string AutoNumberPattern = @"^([A-Z]{2}[0-9]{3}[A-Z]{3})|([A-Z]{2}[0-9]{8})$";
        private string ChassisSeriesPattern = @"^[A-Z0-9]{6}[0-9][A-Z][A-Z0-9]{1,17}$";
        private string PhoneNumberPattern = @"^\d{13}$";

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
            textBoxSearchEmail.Enabled = false;
            buttonSearchCustomer.Enabled = false;
        }

        private void buttonSearchCustomer_Click_1(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string phoneNumber = textBoxSearchPhoneNumber.Text;

            if (!FieldsCompleted(name, firstName, phoneNumber))
            {
                labelSearchDisplayInfo.Text = @"Must complete mandatory fields";
            } else
            {
                buttonSearchCustomer.Enabled = true;
                Client client = _carService.FindCustomer(name, firstName, phoneNumber);

                if (client == null)
                {
                    labelSearchDisplayInfo.Text =
                        @"There is no customer with these specification. Please add new customer.";
                }
                else
                {
                    labelSearchDisplayInfo.Text = @"Customer cars are displayed bellow.";
                    panelAddCustomerCar.Visible = true;

                    string getChassis = "SELECT CodSasiu, Denumire FROM Sasiuri";
                    ExecuteQuery(getChassis, dataGridViewChassisOptions);

                    string getClientCars = $"SELECT * FROM Automobile WHERE ClientId = {client.Id}";
                    ExecuteQuery(getClientCars, dataGridViewCustomerCars);
                }
            }
        }

        private bool FieldsCompleted(string name, string firstName, string phoneNumber)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(firstName) &&
                   !string.IsNullOrEmpty(phoneNumber);
        }

        private void buttonAddCustomerCar_Click_1(object sender, EventArgs e)
        {
            string name = textBoxSearchName.Text;
            string firstName = textBoxSearchFirstName.Text;
            string phoneNumber = textBoxSearchPhoneNumber.Text;
            Client client = _carService.FindCustomer(name, firstName, phoneNumber);

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

            labelAddCar.Text = @"Car added.";
            labelAddCar.Visible = true;
            /*
            string getClientCars = $"SELECT * FROM Automobile WHERE ClientId = {client.Id}";
            ExecuteQuery(getClientCars, dataGridViewCustomerCars);
            */
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

        private void textBoxSearchName_TextChanged(object sender, EventArgs e)
        {
            ValidateSearchField(NamePattern, textBoxSearchName);
        }

        private void textBoxSearchFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateSearchField(NamePattern, textBoxSearchFirstName);
        }

        private void textBoxSearchEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateSearchField(EmailPattern, textBoxSearchEmail);
        }

        private void textBoxAutoNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateAddCarField(AutoNumberPattern, textBoxAutoNumber);
        }

        private void textBoxChassisSeries_TextChanged(object sender, EventArgs e)
        {
            ValidateAddCarField(ChassisSeriesPattern, textBoxChassisSeries);

            int index = dataGridViewChassisOptions.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridViewChassisOptions.Rows[index];
            string codSasiu = selectedRow.Cells[0].Value.ToString();
            string chassisSeries = textBoxChassisSeries.Text;

            bool isValidExpression = chassisSeries[6].Equals(codSasiu[0]) && chassisSeries[7].Equals(codSasiu[1]);
            buttonAddCustomerCar.Enabled = isValidExpression;
            labelAddCar.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void ValidateSearchField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            buttonSearchCustomer.Enabled = isValidExpression;
            labelSearchDisplayInfo.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void ValidateAddCarField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            buttonAddCustomerCar.Enabled = isValidExpression;
            labelAddCar.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void checkBoxSearchEmail_Click(object sender, EventArgs e)
        {
            if (checkBoxSearchEmail.Checked)
            {
                textBoxSearchEmail.Enabled = true;
            }
        }

        private void textBoxSearchPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateSearchField(PhoneNumberPattern, textBoxSearchPhoneNumber);
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
                dataGridView.Visible = true;
            }
        }
    }
}