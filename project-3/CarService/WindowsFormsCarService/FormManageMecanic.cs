using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageMecanic : Form
    {
        private readonly CarServiceApi _carService;
        private string NamePattern = @"^[A-Z][A-Za-z -]{2,14}$";

        public FormManageMecanic()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
            buttonAddNewMechanic.Enabled = false;
        }

        private void buttonAddNewMechanic_Click(object sender, EventArgs e)
        {
            string name = textBoxAddMechanicName.Text;
            string firstName = textBoxAddMechanicFirstName.Text;

            if (!FieldsCompleted(name, firstName))
            {
                labelAddMecanic.Text = @"Must complete mandatory fields.";
            }
            else
            {
                buttonAddNewMechanic.Enabled = true;
                Mecanic mechanic = new Mecanic()
                {
                    Nume = textBoxAddMechanicName.Text,
                    Prenume = textBoxAddMechanicFirstName.Text
                };

                _carService.AddMecanic(mechanic);

                labelAddMecanic.Text = @"Mecanic added.";
                labelAddMecanic.Visible = true;
            }
        }

        private bool FieldsCompleted(string name, string firstName)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(firstName);
        }

        private void buttonNewMecanic_Click(object sender, EventArgs e)
        {
            labelAddMecanic.Visible = false;
            textBoxAddMechanicFirstName.Text = "";
            textBoxAddMechanicName.Text = "";
        }

        private void textBoxAddMechanicName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(NamePattern, textBoxAddMechanicName);
        }

        private void textBoxAddMechanicFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(NamePattern, textBoxAddMechanicFirstName);
        }

        private void ValidateField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            buttonAddNewMechanic.Enabled = isValidExpression;
            labelAddMecanic.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }
    }
}