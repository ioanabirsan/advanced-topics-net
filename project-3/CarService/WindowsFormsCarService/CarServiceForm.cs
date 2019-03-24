using System;
using System.Windows.Forms;
using CarService;
using CarService.Api;

namespace WindowsFormsCarService
{
    public partial class CarServiceForm : Form
    {
        private readonly CarServiceApi _carService;

        private string connectionString =
            @"Data source=localhost\SQLEXPRESS; Initial Catalog=AUTO; Integrated Security=True";

        public CarServiceForm()
        {
            InitializeComponent();
            _carService = new CarServiceApi();
        }

        private void CarServiceForm_Load(object sender, EventArgs e)
        {
            panelAddMaterial.Visible = false;
            panelAddOperation.Visible = false;
            panelAddMechanic.Visible = false;
        }

        private void buttonSelectCustomer_Click(object sender, EventArgs e)
        {
            FormSearchCustomer searchCustomerForm = new FormSearchCustomer();
            searchCustomerForm.Show();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer addCustomerForm = new FormAddCustomer();
            addCustomerForm.Show();
        }

        // https://www.youtube.com/watch?v=C9s0H6yeFLQ
        private void buttonDisplayCustomers_Click(object sender, EventArgs e)
        {
            FormDisplayCustomers displayCustomersForm = new FormDisplayCustomers();
            displayCustomersForm.Show();
        }

        private void buttonAddChassis_Click(object sender, EventArgs e)
        {
            FormAddChassis addChassisForm = new FormAddChassis();
            addChassisForm.Show();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            FormAddOrder formAddOrder = new FormAddOrder();
            formAddOrder.Show();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            FormAddMaterial addMaterialForm = new FormAddMaterial();
            addMaterialForm.Show();
        }
        
        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            panelAddOperation.Visible = true;

            panelAddMaterial.Visible = false;
            panelAddMechanic.Visible = false;
        }

        private void buttonAddNewOperation_Click(object sender, EventArgs e)
        {
            string name = textBoxAddOperationName.Text;
            string executionTime = textBoxAddOperationExecutionTime.Text;

            Operatie operation = new Operatie()
            {
                Denumire = name,
                TimpExecutie = Convert.ToDecimal(executionTime)
            };

            _carService.AddOperation(operation);
        }

        private void buttonAddMechanic_Click(object sender, EventArgs e)
        {
            panelAddMechanic.Visible = true;

            panelAddOperation.Visible = false;
            panelAddMaterial.Visible = false;
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

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            FormAddImage addImageForm = new FormAddImage();
            addImageForm.Show();
        }
    }
}