using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    // Audi A6 2005-2010
    public partial class FormManageChassis : Form
    {
        private readonly CarServiceApi _carService;
        private string ChassisCodePattern = @"^[0-9][A-Z]$";
        private string ChassisNamePattern = @"^[A-Z][A-Za-z0-9 -]{3,24}$";

        public FormManageChassis()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
            buttonAddNewChassis.Enabled = false;
        }

        private void buttonAddNewChassis_Click(object sender, EventArgs e)
        {
            var chassisCode = textBoxChassisCode.Text;
            var chassisName = textBoxChassisName.Text;

            if (!FieldsCompleted(chassisName, chassisCode))
            {
                labelAddChassis.Text = @"Must complete mandatory fields.";
            } else
            {
                buttonAddNewChassis.Enabled = true;
                Sasiu sasiu = new Sasiu()
                {
                    CodSasiu = chassisCode,
                    Denumire = chassisName
                };

                _carService.AddChassis(sasiu);

                labelAddChassis.Text = @"Chassis added.";
                labelAddChassis.Visible = true;
            }
        }

        private bool FieldsCompleted(string chassisName, string chassisCode)
        {
            return !string.IsNullOrEmpty(chassisCode) && !string.IsNullOrEmpty(chassisName);
        }

        private void buttonNewChassis_Click(object sender, EventArgs e)
        {
            textBoxChassisCode.Text = "";
            textBoxChassisName.Text = "";
            labelAddChassis.Visible = false;
        }

        private void textBoxChassisCode_TextChanged(object sender, EventArgs e)
        {
            ValidateField(ChassisCodePattern, textBoxChassisCode);
        }

        private void textBoxChassisName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(ChassisNamePattern, textBoxChassisName);
        }

        private void ValidateField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            buttonAddNewChassis.Enabled = isValidExpression;
            labelAddChassis.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        
    }
}