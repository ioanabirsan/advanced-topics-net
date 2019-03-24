using System;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageMecanic : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormManageMecanic()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
        }

        private void buttonAddNewMechanic_Click(object sender, EventArgs e)
        {
            Mecanic mechanic = new Mecanic()
            {
                Nume = textBoxAddMechanicName.Text,
                Prenume = textBoxAddMechanicFirstName.Text
            };

            _carService.AddMecanic(mechanic);

            labelAddMecanic.Text = "Mecanic added.";
            labelAddMecanic.Visible = true;
        }

        private void buttonNewMecanic_Click(object sender, EventArgs e)
        {
            labelAddMecanic.Visible = false;
            textBoxAddMechanicFirstName.Text = "";
            textBoxAddMechanicName.Text = "";
        }
    }
}