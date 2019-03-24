using System;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageMechanic : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormManageMechanic()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, 100);
        }

        private void buttonAddNewMechanic_Click(object sender, EventArgs e)
        {
            Mecanic mechanic = new Mecanic()
            {
                Nume = textBoxAddMechanicName.Text,
                Prenume = textBoxAddMechanicFirstName.Text
            };

            _carService.AddMechnic(mechanic);
        }
    }
}