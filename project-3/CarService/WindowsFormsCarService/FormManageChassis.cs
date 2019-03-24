using System;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageChassis : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormManageChassis()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, 100);
        }

        private void buttonAddNewChassis_Click(object sender, EventArgs e)
        {
            var chassisCode = textBoxChassisCode.Text;
            var chassisName = textBoxChassisName.Text;

            Sasiu sasiu = new Sasiu()
            {
                CodSasiu = chassisCode,
                Denumire = chassisName
            };

            _carService.AddChassis(sasiu);
        }
    }
}
