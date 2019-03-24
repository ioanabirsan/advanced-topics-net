using System;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageOperation : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormManageOperation()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
        }

        private void buttonAddNewOperation_Click(object sender, EventArgs e)
        {
            string name = textBoxAddOperationName.Text;
            string executionTime = textBoxAddOperationExecutionTime.Text;

            Operatie operation = new Operatie()
            {
                Denumire = name,
                TimpExecutie = Convert.ToDecimal(executionTime)
            };

            _carService.AddOperation(operation);

            labelAddOperation.Text = "Operation added.";
            labelAddOperation.Visible = true;
        }

        private void buttonNewOperation_Click(object sender, EventArgs e)
        {
            labelAddOperation.Visible = false;
            textBoxAddOperationExecutionTime.Text = "";
            textBoxAddOperationName.Text = "";
        }
    }
}
