using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class FormManageCustomer : Form
    {
        private readonly CarServiceApi _carService;
        private string EmailPattern = @"^[a-zA-Z0-9_.-]+@[a-z.]+.[a-z]+$";
        private string NamePattern = @"^[A-Z][A-Za-z -]{2,14}$";
        private string AddressPattern = @"^[A-Za-z -.,0-9]{5,50}$";
        private string CityPattern = @"[A-Z][a-z]{3,9}$";
        private string CountyPattern = @"[A-Z][a-z]{3,9}$";
        private string PhoneNumberPattern = @"^\d{13}$";

        public FormManageCustomer()
        {
            InitializeComponent();
            _carService = new CarServiceApi();

            StartPosition = FormStartPosition.Manual;
            Location = new Point(365, 55);
            buttonAddNewCustomer.Enabled = false;
            textBoxAddEmail.Enabled = false;
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

            if (!FieldsCompleted(name, firstName, address, city, county, phoneNumber))
            {
                labelAddCustomerDisplayInfo.Text = @"Must complete mandatory fields.";
            } else
            {
                buttonAddNewCustomer.Enabled = true;
                List<Auto> cars = new List<Auto>();
                Client client = new Client()
                {
                    Nume = name,
                    Prenume = firstName,
                    Adresa = address,
                    Localitate = city,
                    Judet = county,
                    Telefon = phoneNumber,
                    Email = email,
                    Automobile = cars
                };

                _carService.AddCustomer(client);

                labelAddCustomerDisplayInfo.Text = @"Client added.";
                labelAddCustomerDisplayInfo.Visible = true;
            }
        }

        private bool FieldsCompleted(string name, string firstName, string address, string city, string county,
            string phoneNumber)
        {
            return !string.IsNullOrEmpty(name)
                   && !string.IsNullOrEmpty(firstName)
                   && !string.IsNullOrEmpty(address)
                   && !string.IsNullOrEmpty(city)
                   && !string.IsNullOrEmpty(county)
                   && !string.IsNullOrEmpty(phoneNumber);
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

        private void textBoxAddName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(NamePattern, textBoxAddName);
        }

        private void textBoxAddFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateField(NamePattern, textBoxAddFirstName);
        }

        private void textBoxAddAddress_TextChanged(object sender, EventArgs e)
        {
            ValidateField(AddressPattern, textBoxAddAddress);
        }

        private void textBoxAddCity_TextChanged(object sender, EventArgs e)
        {
            ValidateField(CityPattern, textBoxAddCity);
        }

        private void textBoxAddCounty_TextChanged(object sender, EventArgs e)
        {
            ValidateField(CountyPattern, textBoxAddCounty);
        }

        private void textBoxAddPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateField(PhoneNumberPattern, textBoxAddPhoneNumber);
        }
        
        private void checkBoxAddClientEmail_CheckedChanged(object sender, EventArgs e)
        {
            textBoxAddEmail.Enabled = checkBoxAddClientEmail.Checked;
        }

        private void ValidateField(string pattern, TextBox textBox)
        {
            var regex = new Regex(pattern);
            var isValidExpression = regex.IsMatch(textBox.Text);

            buttonAddNewCustomer.Enabled = isValidExpression;
            labelAddCustomerDisplayInfo.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void textBoxAddEmail_TextChanged(object sender, EventArgs e)
        {
            ValidateField(EmailPattern, textBoxAddEmail);

            bool invalidExpression = _carService.ExistsCustomer(textBoxAddEmail.Text);
            buttonAddNewCustomer.Enabled = !invalidExpression;
            labelAddCustomerDisplayInfo.Text = invalidExpression ? "Email is taken." : string.Empty;
        }
    }
}