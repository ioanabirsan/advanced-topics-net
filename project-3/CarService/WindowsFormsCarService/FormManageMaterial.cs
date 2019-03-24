using System;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageMaterial : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public FormManageMaterial()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, 100);
        }

        private void buttonAddNewMaterial_Click(object sender, EventArgs e)
        {
            string name = textBoxAddMaterialName.Text;
            string quantityText = textBoxAddMaterialQuantity.Text;
            string priceText = textBoxAddMaterialPrice.Text;
            string dateSupplyText = dateTimePickerAddMaterialDateSupply.Text;

            decimal quantity = Convert.ToDecimal(quantityText);
            decimal price = Convert.ToDecimal(priceText);
            DateTime dateSupply = Convert.ToDateTime(dateSupplyText);

            Material material = new Material()
            {
                Denumire = name,
                Cantitate = quantity,
                DataAprovizionare = dateSupply,
                Pret = price
            };

            _carService.AddMaterial(material);
        }
    }
}
