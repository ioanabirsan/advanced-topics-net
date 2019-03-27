using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageMaterial : Form
    {
        private readonly CarServiceApi _carService;
        private string MaterialNamePattern = @"^[A-Za-z ]{3,50}$";

        public FormManageMaterial()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
            buttonAddNewMaterial.Enabled = false;
        }

        private void buttonAddNewMaterial_Click(object sender, EventArgs e)
        {
            string name = textBoxAddMaterialName.Text;
            string quantityText = textBoxAddMaterialQuantity.Text;
            string priceText = textBoxAddMaterialPrice.Text;
            string dateSupplyText = dateTimePickerAddMaterialDateSupply.Text;

            if (!FieldsCompleted(name, quantityText, priceText))
            {
                labelAddMaterial.Text = @"Must complete mandatory fields.";
            }
            else
            {
                Material material = new Material()
                {
                    Denumire = name,
                    Cantitate = Convert.ToDecimal(quantityText),
                    DataAprovizionare = Convert.ToDateTime(dateSupplyText),
                    Pret = Convert.ToDecimal(priceText)
                };

                _carService.AddMaterial(material);

                labelAddMaterial.Text = @"Material added.";
                labelAddMaterial.Visible = true;
            }
        }

        private bool FieldsCompleted(string name, string quantity, string price)
        {
            return !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(quantity) && !string.IsNullOrEmpty(price);
        }

        private void buttonNewMaterial_Click(object sender, EventArgs e)
        {
            labelAddMaterial.Visible = false;
            textBoxAddMaterialName.Text = "";
            textBoxAddMaterialPrice.Text = "";
            textBoxAddMaterialQuantity.Text = "";
        }

        private void textBoxAddMaterialName_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(MaterialNamePattern);
            var isValidExpression = regex.IsMatch(textBoxAddMaterialName.Text);

            buttonAddNewMaterial.Enabled = isValidExpression;
            labelAddMaterial.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }
    }
}