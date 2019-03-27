using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageOperation : Form
    {
        private readonly CarServiceApi _carService;
        private string OperationNamePattern = "^[A-Z][A-Za-z ]{3,255}$";

        public FormManageOperation()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
            buttonAddNewOperation.Enabled = false;
        }

        private void buttonAddNewOperation_Click(object sender, EventArgs e)
        {
            string name = textBoxAddOperationName.Text;
            string executionTime = textBoxAddOperationExecutionTime.Text;

            if (!FieldsCompleted(name, executionTime))
            {
                labelAddOperation.Text = @"Must complete mandatory fields.";
            }
            else
            {
                buttonAddNewOperation.Enabled = true;
                Operatie operation = new Operatie()
                {
                    Denumire = name,
                    TimpExecutie = Convert.ToDecimal(executionTime)
                };

                _carService.AddOperation(operation);

                labelAddOperation.Text = @"Operation added.";
                labelAddOperation.Visible = true;
            }
        }

        private bool FieldsCompleted(string name, string executionTime)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(executionTime);
        }

        private void buttonNewOperation_Click(object sender, EventArgs e)
        {
            labelAddOperation.Visible = false;
            textBoxAddOperationExecutionTime.Text = "";
            textBoxAddOperationName.Text = "";
        }

        private void textBoxAddOperationName_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(OperationNamePattern);
            var isValidExpression = regex.IsMatch(textBoxAddOperationName.Text);

            buttonAddNewOperation.Enabled = isValidExpression;
            labelAddOperation.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void textBoxAddOperationExecutionTime_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxAddOperationExecutionTime.Text))
            {
                var isValidExpression = Convert.ToDecimal(textBoxAddOperationExecutionTime.Text) > 0;
                buttonAddNewOperation.Enabled = isValidExpression;
                labelAddOperation.Text = !isValidExpression ? "Value must be bigger than 0." : string.Empty;
            }
        }
    }
}