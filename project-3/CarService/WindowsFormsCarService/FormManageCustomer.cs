using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageCustomer : Form
    {
        private readonly CarServiceApi _carService;
        
        public FormManageCustomer()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            string name = textBoxAddName.Text;
            string firstName = textBoxAddFirstName.Text;
            string address = textBoxAddAddress.Text;
            string city = textBoxAddCity.Text;
            string county = textBoxAddCounty.Text;
            string phoneNumber = textBoxAddPhoneNumber.Text;
            string email = textBoxAddEmail.Text;

            List<Auto> autos = new List<Auto>();
            Client client = new Client()
            {
                Nume = name,
                Prenume = firstName,
                Adresa = address,
                Localitate = city,
                Judet = county,
                Telefon = phoneNumber,
                Email = email,
                Automobile = autos
            };

            _carService.AddCustomer(client);

            labelAddCustomerDisplayInfo.Text = "Client added.";
            labelAddCustomerDisplayInfo.Visible = true;
        }

        private void buttonNewCustomer_Click(object sender, EventArgs e)
        {
            labelAddCustomerDisplayInfo.Visible = false;
            textBoxAddName.Text = "";
            textBoxAddFirstName.Text = "";
            textBoxAddAddress.Text = "";
            textBoxAddCity.Text = "";
            textBoxAddCounty.Text = "";
            textBoxAddPhoneNumber.Text = "";
            textBoxAddEmail.Text = "";
        }
    }
}
