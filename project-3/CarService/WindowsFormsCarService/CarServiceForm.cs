using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsCarService
{
    public partial class CarServiceForm : Form
    {
        public CarServiceForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(65, 0);
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
            FormManageMecanic addMechanicForm = new FormManageMecanic();
            addMechanicForm.Show();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            FormManageImage addImageForm = new FormManageImage();
            addImageForm.Show();
        }

        private void buttonDisplayOrders_Click(object sender, EventArgs e)
        {
            FormDisplayOrders displayOrdersForm = new FormDisplayOrders();
            displayOrdersForm.Show();
        }

        private void buttonDisplayChassis_Click(object sender, EventArgs e)
        {
            FormDisplayChassis displayChassisForm = new FormDisplayChassis();
            displayChassisForm.Show();
        }

        private void buttonDisplayDetails_Click(object sender, EventArgs e)
        {
            FormDisplayDetails displayDetailsForms = new FormDisplayDetails();
            displayDetailsForms.Show();
        }
    }
}