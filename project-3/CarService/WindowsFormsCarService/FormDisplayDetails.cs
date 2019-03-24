using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormDisplayDetails : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormDisplayDetails()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
        }

        private void FormDisplayDetails_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Mecanici";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewDisplayMechanics.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Imagini";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewDisplayImage.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Materiale";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewDisplayMaterials.DataSource = dataTable;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Operatii";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewDisplayOperations.DataSource = dataTable;
            }
        }

        private void buttonUpdateMecanic_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayMechanics.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Mecanic mecanic = _carService.FindMecanicById(id);

                mecanic.Nume = row.Cells[1].Value.ToString();
                mecanic.Prenume = row.Cells[2].Value.ToString();
                _carService.UpdateMecanic(mecanic);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }

        private void buttonDeleteMecanic_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayMechanics.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _carService.DeleteMecanic(id);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }

        private void buttonUpdateImage_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayImage.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Imagine image = _carService.FindImageById(id);

                image.Titlu = row.Cells[1].Value.ToString();
                image.Data = Convert.ToDateTime(row.Cells[2].Value);
                image.Foto = Convert.ToByte(row.Cells[3].Value);
                image.Descriere = row.Cells[4].Value.ToString();

                _carService.UpdateImage(image);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayImage.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _carService.DeleteImage(id);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }

        private void buttonUpdateMaterial_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayMaterials.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Material material = _carService.FindMaterialById(id);

                material.Denumire = row.Cells[1].Value.ToString();
                material.Cantitate = Convert.ToDecimal(row.Cells[2].Value);
                material.Pret = Convert.ToDecimal(row.Cells[3].Value);
                material.DataAprovizionare = Convert.ToDateTime(row.Cells[4].Value.ToString());

                _carService.UpdateMaterial(material);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }

        private void buttonDeleteMaterial_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayMaterials.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _carService.DeleteMaterial(id);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }

        private void buttonUpdateOperation_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayOperations.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                Operatie operation = _carService.FindOperationById(id);

                operation.Denumire = row.Cells[1].Value.ToString();
                operation.TimpExecutie = Convert.ToDecimal(row.Cells[2].Value);

                _carService.UpdateOperation(operation);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }

        private void buttonDeleteOperation_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayOperations.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _carService.DeleteOperation(id);
            }

            // reload to view changes
            FormDisplayDetails_Load(sender, e);
        }
    }
}
