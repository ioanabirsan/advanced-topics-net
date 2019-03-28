using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormDisplayChassis : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormDisplayChassis()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
        }

        private void FormDisplayChassis_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Sasiuri";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewDisplayChassis.DataSource = dataTable;
                dataGridViewDisplayChassis.EnableHeadersVisualStyles = false;
                dataGridViewDisplayChassis.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
                dataGridViewDisplayChassis.Columns[0].ReadOnly = true;
            }
        }

        private void buttonUpdateChassis_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayChassis.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Sasiu chassis = _carService.FindChassisById(id);

                chassis.CodSasiu = row.Cells[1].Value.ToString();
                chassis.Denumire = row.Cells[2].Value.ToString();
                _carService.UpdateChassis(chassis);
            }

            // reload to view changes
            FormDisplayChassis_Load(sender, e);
        }

        private void buttonDeleteChassis_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayChassis.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _carService.DeleteChassis(id);
            }

            // reload to view changes
            FormDisplayChassis_Load(sender, e);
        }
    }
}
