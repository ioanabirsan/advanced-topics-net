using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormDisplayOrders : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormDisplayOrders()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
        }

        private void FormDisplayOrders_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string queryString = "SELECT * FROM Comenzi";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(queryString, sqlCon);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewDisplayOrders.DataSource = dataTable;
                dataGridViewDisplayOrders.EnableHeadersVisualStyles = false;
                dataGridViewDisplayOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
                dataGridViewDisplayOrders.Columns[0].ReadOnly = true;
                dataGridViewDisplayOrders.Columns[1].ReadOnly = true;
                dataGridViewDisplayOrders.Columns[8].ReadOnly = true;
            }
        }

        private void buttonUpdateOrders_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayOrders.SelectedRows)
            {
                int state = Convert.ToInt32(row.Cells[7].Value);
                StareComanda orderState = getOrderState(state);
                int id = Convert.ToInt32(row.Cells[0].Value);

                Comanda order = _carService.FindOrderById(id);
                order.DataProgramare = Convert.ToDateTime(row.Cells[2].Value);
                order.DataFinalizare = Convert.ToDateTime(row.Cells[3].Value);
                order.KmBord = Convert.ToInt32(row.Cells[4].Value);
                order.Descriere = row.Cells[5].Value.ToString();
                order.ValoarePiese = Convert.ToDecimal(row.Cells[6].Value);
                order.StareComanda = orderState;

                _carService.UpdateOrder(order);
            }

            FormDisplayOrders_Load(sender, e);
        }

        private StareComanda getOrderState(int state)
        {
            switch (state)
            {
                case 1:
                    return StareComanda.InAsteptare;
                case 2:
                    return StareComanda.Executata;
                case 3:
                    return StareComanda.Refuzata;
                default:
                    return StareComanda.Necunoscuta;
            }
        }

        private void buttonDeleteOrders_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDisplayOrders.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                _carService.DeleteOrder(id);
            }

            FormDisplayOrders_Load(sender, e);
        }
    }
}