using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PersonalAgenda
{
    public partial class FormPersonalAgenda : Form
    {
        private const string EmailRequired = "Email is required";
        private const string InvalidEmailFormat = "Invalid email address format. Example: ion_popescu@yahoo.com";
        private const string PhoneRequired = "Phone number required.";
        private const string InvalidPhoneFormat = "Invalid phone number format. Example: +40111222333";
        private const string NameRequired = "Name required.";
        private const string InvalidNameFormat = "Invalid name. Example: Popescu or Popescu-Andronache";
        private const string NamePattern = @"^[A-Z][a-z'-]+$";
        private const string PhonePattern = @"^[+]\d{11}$";
        private const string EmailPattern = @"^[a-zA-Z0-9_.-]+@[a-z.]+.[a-z]+$";
        private const string AgeRequired = "Age required.";
        private const string InvalidAgeValue = "Age must be a value between 10 and 120.";
        private const string FirstNameRequired = "First name required.";
        private const string FirstNamePattern = @"^[A-Z][a-z'-]+$";
        private const string InvalidFirstNameFormat = "Invalid first name format.";
        private const string Path = "C:\\facultate\\an3\\sem2\\topici-avansate-net\\personal-agenda.txt";

        private readonly PersonalAgenda _personalAgenda = new PersonalAgenda();

        public FormPersonalAgenda()
        {
            InitializeComponent();
        }

        private void text_age_TextChanged(object sender, EventArgs e)
        {
        }

        private void text_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void text_age_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_age.Text))
            {
                MessageBox.Show(AgeRequired);
            }
            else
            {
                var age = int.Parse(text_age.Text);

                if (age >= 10 && age <= 120) return;

                MessageBox.Show(InvalidAgeValue);
                e.Cancel = true;
            }
        }

        private void text_email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_email.Text))
            {
                MessageBox.Show(EmailRequired);
            }
            else
            {
                var regex = new Regex(EmailPattern);
                Validate(text_email.Text, regex, InvalidEmailFormat, e);
            }
        }

        private void text_phone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_phone.Text))
            {
                MessageBox.Show(PhoneRequired);
            }
            else
            {
                var regex = new Regex(PhonePattern);
                Validate(text_phone.Text, regex, InvalidPhoneFormat, e);
            }
        }

        private void text_name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_name.Text))
            {
                MessageBox.Show(NameRequired);
            }
            else
            {
                var regex = new Regex(NamePattern);
                Validate(text_name.Text, regex, InvalidNameFormat, e);
            }
        }

        private void text_first_name_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(text_first_name.Text))
            {
                MessageBox.Show(FirstNameRequired);
            }
            else
            {
                var regex = new Regex(FirstNamePattern);
                Validate(text_name.Text, regex, InvalidFirstNameFormat, e);
            }
        }

        private static void Validate(string input, Regex regex, string message, System.ComponentModel.CancelEventArgs e)
        {
            if (regex.IsMatch(input)) return;

            MessageBox.Show(message);
            e.Cancel = true;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            var contact = TextBoxInfoToContact();
            _personalAgenda.AddContact(contact);

            BinarySerialization.Serialize(Path, _personalAgenda);

            list_saved_contacts.Items.Add(contact.Name + " " + contact.FirstName);

            CleanForm();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var selectedContact = list_saved_contacts.SelectedItem.ToString();
            list_saved_contacts.Items.Remove(selectedContact);

            var name = GetNameFromListBox(selectedContact);
            var firstName = GetFirstNameFromListBox(selectedContact);

            _personalAgenda.RemoveBy(name, firstName);

            BinarySerialization.DeleteContent(Path);
            BinarySerialization.Serialize(Path, _personalAgenda);
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            var selectedItem = list_saved_contacts.SelectedItem;

            if (selectedItem == null) return;

            var selectedContact = selectedItem.ToString();
            var name = GetNameFromListBox(selectedContact);
            var firstName = GetFirstNameFromListBox(selectedContact);
            var personalAgenda = BinarySerialization.Deserialize(Path);

            var contact = personalAgenda.FindBy(name, firstName);

            if (contact == null) return;

            DisplayContactInfoToTextBox(contact);

            UpdateSelectedContact(contact);
        }

        private static string GetFirstNameFromListBox(string selectedContact)
        {
            return selectedContact.Substring(selectedContact.IndexOf(" ", StringComparison.Ordinal) + 1);
        }

        private static string GetNameFromListBox(string selectedContact)
        {
            return selectedContact.Substring(0, selectedContact.IndexOf(" ", StringComparison.Ordinal));
        }

        private void UpdateSelectedContact(Contact contact)
        {
            _personalAgenda.RemoveBy(contact.Name, contact.FirstName);

            BinarySerialization.DeleteContent(Path);
            BinarySerialization.Serialize(Path, _personalAgenda);

            var selectedContact = list_saved_contacts.SelectedItem.ToString();
            list_saved_contacts.Items.Remove(selectedContact);
        }

        private void DisplayContactInfoToTextBox(Contact contact)
        {
            text_name.Text = contact.Name;
            text_first_name.Text = contact.FirstName;
            text_age.Text = contact.Age.ToString();
            text_email.Text = contact.Email;
            text_phone.Text = contact.Phone;
            text_other.Text = contact.Other;
        }

        private Contact TextBoxInfoToContact()
        {
            var name = text_name.Text;
            var firstName = text_first_name.Text;
            var age = int.Parse(text_age.Text);
            var email = text_email.Text;
            var phone = text_phone.Text;
            var other = text_other.Text;

            return new Contact(name, firstName, age, email, phone, other);
        }

        private void CleanForm()
        {
            foreach (var control in Controls)
            {
                if (control is TextBox box)
                {
                    box.Text = string.Empty;
                }
            }
        }
    }
}