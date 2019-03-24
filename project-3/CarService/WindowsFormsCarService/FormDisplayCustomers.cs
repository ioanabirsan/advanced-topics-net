using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormDisplayCustomers : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormDisplayCustomers()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
        }

        private void FormDisplayCustomers_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Clienti";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewCustomers.DataSource = dataTable;
            }
        }

        private void buttonUpdateCustomers_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewCustomers.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Client client = _carService.FindCustomerById(id);

                client.Nume = row.Cells[1].Value.ToString();
                client.Prenume = row.Cells[2].Value.ToString();
                client.Adresa = row.Cells[3].Value.ToString();
                client.Localitate = row.Cells[4].Value.ToString();
                client.Judet = row.Cells[5].Value.ToString();
                client.Telefon = row.Cells[6].Value.ToString();
                client.Email = row.Cells[7].Value.ToString();

                _carService.UpdateClient(client);
            }

            // reload to view changes
            FormDisplayCustomers_Load(sender, e);
        }

        private void buttonDeleteCustomers_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewCustomers.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _carService.DeleteClient(id);
            }

            // reload to view changes
            FormDisplayCustomers_Load(sender, e);
        }
    }
}