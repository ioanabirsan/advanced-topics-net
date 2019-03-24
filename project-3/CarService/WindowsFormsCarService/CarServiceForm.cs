using System;
using System.Windows.Forms;

namespace WindowsFormsCarService
{
    public partial class CarServiceForm : Form
    {
        public CarServiceForm()
        {
            InitializeComponent();
        }

        private void CarServiceForm_Load(object sender, EventArgs e)
        {
        }

        private void buttonSelectCustomer_Click(object sender, EventArgs e)
        {
            FormSearchCustomer searchCustomerForm = new FormSearchCustomer();
            searchCustomerForm.Show();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormManageCustomer addCustomerForm = new FormManageCustomer();
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
            FormManageChassis addChassisForm = new FormManageChassis();
            addChassisForm.Show();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            FormManageOrder formAddOrder = new FormManageOrder();
            formAddOrder.Show();
        }

        private void buttonAddMaterial_Click(object sender, EventArgs e)
        {
            FormManageMaterial addMaterialForm = new FormManageMaterial();
            addMaterialForm.Show();
        }

        private void buttonAddOperation_Click(object sender, EventArgs e)
        {
            FormManageOperation addOperationForm = new FormManageOperation();
            addOperationForm.Show();
        }

        private void buttonAddMechanic_Click(object sender, EventArgs e)
        {
            FormManageMechanic addMechanicForm = new FormManageMechanic();
            addMechanicForm.Show();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            FormManageImage addImageForm = new FormManageImage();
            addImageForm.Show();
        }
    }
}