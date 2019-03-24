namespace WindowsFormsCarService
{
    partial class CarServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarServiceForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAddMechanic = new System.Windows.Forms.Button();
            this.buttonAddOperation = new System.Windows.Forms.Button();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.buttonAddMaterial = new System.Windows.Forms.Button();
            this.groupBoxChassis = new System.Windows.Forms.GroupBox();
            this.buttonAddChassis = new System.Windows.Forms.Button();
            this.groupBoxOrders = new System.Windows.Forms.GroupBox();
            this.buttonDisplayOrders = new System.Windows.Forms.Button();
            this.buttonAddOrder = new System.Windows.Forms.Button();
            this.buttonSelectOrder = new System.Windows.Forms.Button();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.buttonDisplayCustomers = new System.Windows.Forms.Button();
            this.buttonCustomerDetails = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonSelectCustomer = new System.Windows.Forms.Button();
            this.panelAddMaterial = new System.Windows.Forms.Panel();
            this.dateTimePickerAddMaterialDateSupply = new System.Windows.Forms.DateTimePicker();
            this.labelAddMaterialDateSupply = new System.Windows.Forms.Label();
            this.textBoxAddMaterialPrice = new System.Windows.Forms.TextBox();
            this.labelAddMaterialPrice = new System.Windows.Forms.Label();
            this.buttonAddNewMaterial = new System.Windows.Forms.Button();
            this.textBoxAddMaterialQuantity = new System.Windows.Forms.TextBox();
            this.labelAddMaterialQuantity = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelAddMaterialName = new System.Windows.Forms.Label();
            this.textBoxAddMaterialName = new System.Windows.Forms.TextBox();
            this.panelAddOperation = new System.Windows.Forms.Panel();
            this.buttonAddNewOperation = new System.Windows.Forms.Button();
            this.textBoxAddOperationExecutionTime = new System.Windows.Forms.TextBox();
            this.labelAddOperationExecutionTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAddOperationName = new System.Windows.Forms.TextBox();
            this.panelAddMechanic = new System.Windows.Forms.Panel();
            this.buttonAddNewMechanic = new System.Windows.Forms.Button();
            this.textBoxAddMechanicFirstName = new System.Windows.Forms.TextBox();
            this.labelAddMechanicFirstName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAddMechanicName = new System.Windows.Forms.Label();
            this.textBoxAddMechanicName = new System.Windows.Forms.TextBox();
            this.panelAddOrder = new System.Windows.Forms.Panel();
            this.dataGridViewAddOrderSelectClient = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddOrderKm = new System.Windows.Forms.TextBox();
            this.labelAddOrderKm = new System.Windows.Forms.Label();
            this.comboBoxAddOrderInService = new System.Windows.Forms.ComboBox();
            this.comboBoxAddOrderState = new System.Windows.Forms.ComboBox();
            this.groupBoxCommandDetails = new System.Windows.Forms.GroupBox();
            this.buttonAddDetailsImage = new System.Windows.Forms.Button();
            this.buttonAddDetailsMechanic = new System.Windows.Forms.Button();
            this.buttonAddDetailsOperation = new System.Windows.Forms.Button();
            this.buttonAddDetailsMaterial = new System.Windows.Forms.Button();
            this.dataGridViewAddDetailsImages = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddDetailsMechanics = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddDetailsOperations = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddDetailsMaterials = new System.Windows.Forms.DataGridView();
            this.textBoxAddOrderPiecesValue = new System.Windows.Forms.TextBox();
            this.labelAddOrderPiecesValue = new System.Windows.Forms.Label();
            this.labelAddOrderState = new System.Windows.Forms.Label();
            this.labelAddOrderInService = new System.Windows.Forms.Label();
            this.labelAddOrderDescription = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddNewOrder = new System.Windows.Forms.Button();
            this.textBoxAddOrderDescription = new System.Windows.Forms.TextBox();
            this.labelAddOrderEndDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAddOrderStartDate = new System.Windows.Forms.Label();
            this.panelAddCustomerCar = new System.Windows.Forms.Panel();
            this.buttonAddCustomerCar = new System.Windows.Forms.Button();
            this.dataGridViewChassisOptions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChassisSeries = new System.Windows.Forms.Label();
            this.textBoxChassisSeries = new System.Windows.Forms.TextBox();
            this.labelChassis = new System.Windows.Forms.Label();
            this.labelAutoNumber = new System.Windows.Forms.Label();
            this.textBoxAutoNumber = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomerCars = new System.Windows.Forms.DataGridView();
            this.panelAddCustomer = new System.Windows.Forms.Panel();
            this.panelAddChassis = new System.Windows.Forms.Panel();
            this.buttonAddNewChassis = new System.Windows.Forms.Button();
            this.textBoxChassisName = new System.Windows.Forms.TextBox();
            this.labelChassisName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChassisCode = new System.Windows.Forms.Label();
            this.textBoxChassisCode = new System.Windows.Forms.TextBox();
            this.labelAddCustomerDisplayInfo = new System.Windows.Forms.Label();
            this.textBoxAddEmail = new System.Windows.Forms.TextBox();
            this.labelAddEmail = new System.Windows.Forms.Label();
            this.labelAddPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddCounty = new System.Windows.Forms.TextBox();
            this.textBoxAddCity = new System.Windows.Forms.TextBox();
            this.labelAddCounty = new System.Windows.Forms.Label();
            this.labelAddCity = new System.Windows.Forms.Label();
            this.labelAddAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddNewCustomer = new System.Windows.Forms.Button();
            this.textBoxAddAddress = new System.Windows.Forms.TextBox();
            this.labelAddFirstName = new System.Windows.Forms.Label();
            this.labelAddName = new System.Windows.Forms.Label();
            this.textBoxAddFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAddName = new System.Windows.Forms.TextBox();
            this.panelSearchCustomer = new System.Windows.Forms.Panel();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.labelSearchDisplayInfo = new System.Windows.Forms.Label();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.labelSearchEmail = new System.Windows.Forms.Label();
            this.textBoxSearchEmail = new System.Windows.Forms.TextBox();
            this.labelSearchFirstName = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonDisplayDetails = new System.Windows.Forms.Button();
            this.panelAddNewImage = new System.Windows.Forms.Panel();
            this.buttonAddNewImage = new System.Windows.Forms.Button();
            this.labelAddImageDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelAddImageTitle = new System.Windows.Forms.Label();
            this.textBoxAddImageTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerAddImageDate = new System.Windows.Forms.DateTimePicker();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddImagePhotoUpload = new System.Windows.Forms.Button();
            this.labelAddImageDescription = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxAddImageDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxChassis.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.groupBoxCustomers.SuspendLayout();
            this.panelAddMaterial.SuspendLayout();
            this.panelAddOperation.SuspendLayout();
            this.panelAddMechanic.SuspendLayout();
            this.panelAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOrderSelectClient)).BeginInit();
            this.groupBoxCommandDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMechanics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMaterials)).BeginInit();
            this.panelAddCustomerCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChassisOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerCars)).BeginInit();
            this.panelAddCustomer.SuspendLayout();
            this.panelAddChassis.SuspendLayout();
            this.panelSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.panelAddNewImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "LeftPanel";
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDetails);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxChassis);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxOrders);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCustomers);
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AccessibleName = "RightPanel";
            this.splitContainer1.Panel2.Controls.Add(this.panelAddNewImage);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddMaterial);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddOperation);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddMechanic);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddOrder);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddCustomerCar);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCustomerCars);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddCustomer);
            this.splitContainer1.Panel2.Controls.Add(this.panelSearchCustomer);
            this.splitContainer1.Size = new System.Drawing.Size(1462, 802);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonAddMechanic
            // 
            this.buttonAddMechanic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddMechanic.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMechanic.Location = new System.Drawing.Point(6, 122);
            this.buttonAddMechanic.Name = "buttonAddMechanic";
            this.buttonAddMechanic.Size = new System.Drawing.Size(231, 42);
            this.buttonAddMechanic.TabIndex = 1;
            this.buttonAddMechanic.Text = "Add mechanic";
            this.buttonAddMechanic.UseVisualStyleBackColor = false;
            this.buttonAddMechanic.Click += new System.EventHandler(this.buttonAddMechanic_Click);
            // 
            // buttonAddOperation
            // 
            this.buttonAddOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddOperation.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOperation.Location = new System.Drawing.Point(6, 74);
            this.buttonAddOperation.Name = "buttonAddOperation";
            this.buttonAddOperation.Size = new System.Drawing.Size(231, 42);
            this.buttonAddOperation.TabIndex = 1;
            this.buttonAddOperation.Text = "Add operation";
            this.buttonAddOperation.UseVisualStyleBackColor = false;
            this.buttonAddOperation.Click += new System.EventHandler(this.buttonAddOperation_Click);
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxDetails.Controls.Add(this.buttonDisplayDetails);
            this.groupBoxDetails.Controls.Add(this.buttonAddImage);
            this.groupBoxDetails.Controls.Add(this.buttonAddMechanic);
            this.groupBoxDetails.Controls.Add(this.buttonAddOperation);
            this.groupBoxDetails.Controls.Add(this.buttonAddMaterial);
            this.groupBoxDetails.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 523);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(243, 267);
            this.groupBoxDetails.TabIndex = 5;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Details";
            // 
            // buttonAddMaterial
            // 
            this.buttonAddMaterial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddMaterial.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMaterial.Location = new System.Drawing.Point(6, 26);
            this.buttonAddMaterial.Name = "buttonAddMaterial";
            this.buttonAddMaterial.Size = new System.Drawing.Size(231, 42);
            this.buttonAddMaterial.TabIndex = 1;
            this.buttonAddMaterial.Text = "Add material";
            this.buttonAddMaterial.UseVisualStyleBackColor = false;
            this.buttonAddMaterial.Click += new System.EventHandler(this.buttonAddMaterial_Click);
            // 
            // groupBoxChassis
            // 
            this.groupBoxChassis.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxChassis.Controls.Add(this.buttonAddChassis);
            this.groupBoxChassis.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChassis.Location = new System.Drawing.Point(12, 440);
            this.groupBoxChassis.Name = "groupBoxChassis";
            this.groupBoxChassis.Size = new System.Drawing.Size(243, 74);
            this.groupBoxChassis.TabIndex = 4;
            this.groupBoxChassis.TabStop = false;
            this.groupBoxChassis.Text = "Chassis";
            // 
            // buttonAddChassis
            // 
            this.buttonAddChassis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddChassis.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddChassis.Location = new System.Drawing.Point(6, 26);
            this.buttonAddChassis.Name = "buttonAddChassis";
            this.buttonAddChassis.Size = new System.Drawing.Size(231, 42);
            this.buttonAddChassis.TabIndex = 1;
            this.buttonAddChassis.Text = "Add chassis";
            this.buttonAddChassis.UseVisualStyleBackColor = false;
            this.buttonAddChassis.Click += new System.EventHandler(this.buttonAddChassis_Click);
            // 
            // groupBoxOrders
            // 
            this.groupBoxOrders.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxOrders.Controls.Add(this.buttonDisplayOrders);
            this.groupBoxOrders.Controls.Add(this.buttonAddOrder);
            this.groupBoxOrders.Controls.Add(this.buttonSelectOrder);
            this.groupBoxOrders.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrders.Location = new System.Drawing.Point(12, 257);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(243, 177);
            this.groupBoxOrders.TabIndex = 3;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Orders";
            // 
            // buttonDisplayOrders
            // 
            this.buttonDisplayOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayOrders.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayOrders.Location = new System.Drawing.Point(6, 122);
            this.buttonDisplayOrders.Name = "buttonDisplayOrders";
            this.buttonDisplayOrders.Size = new System.Drawing.Size(231, 42);
            this.buttonDisplayOrders.TabIndex = 3;
            this.buttonDisplayOrders.Text = "View all";
            this.buttonDisplayOrders.UseVisualStyleBackColor = false;
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddOrder.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrder.Location = new System.Drawing.Point(6, 74);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(231, 42);
            this.buttonAddOrder.TabIndex = 1;
            this.buttonAddOrder.Text = "Add order";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // buttonSelectOrder
            // 
            this.buttonSelectOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSelectOrder.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectOrder.Location = new System.Drawing.Point(6, 26);
            this.buttonSelectOrder.Name = "buttonSelectOrder";
            this.buttonSelectOrder.Size = new System.Drawing.Size(231, 42);
            this.buttonSelectOrder.TabIndex = 0;
            this.buttonSelectOrder.Text = "Select order";
            this.buttonSelectOrder.UseVisualStyleBackColor = false;
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCustomers.Controls.Add(this.buttonDisplayCustomers);
            this.groupBoxCustomers.Controls.Add(this.buttonCustomerDetails);
            this.groupBoxCustomers.Controls.Add(this.buttonAddCustomer);
            this.groupBoxCustomers.Controls.Add(this.buttonSelectCustomer);
            this.groupBoxCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomers.Location = new System.Drawing.Point(12, 30);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(243, 221);
            this.groupBoxCustomers.TabIndex = 0;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Customers";
            // 
            // buttonDisplayCustomers
            // 
            this.buttonDisplayCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayCustomers.Location = new System.Drawing.Point(6, 170);
            this.buttonDisplayCustomers.Name = "buttonDisplayCustomers";
            this.buttonDisplayCustomers.Size = new System.Drawing.Size(231, 42);
            this.buttonDisplayCustomers.TabIndex = 3;
            this.buttonDisplayCustomers.Text = "View all";
            this.buttonDisplayCustomers.UseVisualStyleBackColor = false;
            this.buttonDisplayCustomers.Click += new System.EventHandler(this.buttonDisplayCustomers_Click);
            // 
            // buttonCustomerDetails
            // 
            this.buttonCustomerDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCustomerDetails.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomerDetails.Location = new System.Drawing.Point(6, 122);
            this.buttonCustomerDetails.Name = "buttonCustomerDetails";
            this.buttonCustomerDetails.Size = new System.Drawing.Size(231, 42);
            this.buttonCustomerDetails.TabIndex = 2;
            this.buttonCustomerDetails.Text = "Customer details";
            this.buttonCustomerDetails.UseVisualStyleBackColor = false;
            this.buttonCustomerDetails.Click += new System.EventHandler(this.buttonCustomerDetails_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(6, 74);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(231, 42);
            this.buttonAddCustomer.TabIndex = 1;
            this.buttonAddCustomer.Text = "Add customer";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // buttonSelectCustomer
            // 
            this.buttonSelectCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonSelectCustomer.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectCustomer.Location = new System.Drawing.Point(6, 26);
            this.buttonSelectCustomer.Name = "buttonSelectCustomer";
            this.buttonSelectCustomer.Size = new System.Drawing.Size(231, 42);
            this.buttonSelectCustomer.TabIndex = 0;
            this.buttonSelectCustomer.Text = "Select customer";
            this.buttonSelectCustomer.UseVisualStyleBackColor = false;
            this.buttonSelectCustomer.Click += new System.EventHandler(this.buttonSelectCustomer_Click);
            // 
            // panelAddMaterial
            // 
            this.panelAddMaterial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddMaterial.Controls.Add(this.dateTimePickerAddMaterialDateSupply);
            this.panelAddMaterial.Controls.Add(this.labelAddMaterialDateSupply);
            this.panelAddMaterial.Controls.Add(this.textBoxAddMaterialPrice);
            this.panelAddMaterial.Controls.Add(this.labelAddMaterialPrice);
            this.panelAddMaterial.Controls.Add(this.buttonAddNewMaterial);
            this.panelAddMaterial.Controls.Add(this.textBoxAddMaterialQuantity);
            this.panelAddMaterial.Controls.Add(this.labelAddMaterialQuantity);
            this.panelAddMaterial.Controls.Add(this.label13);
            this.panelAddMaterial.Controls.Add(this.labelAddMaterialName);
            this.panelAddMaterial.Controls.Add(this.textBoxAddMaterialName);
            this.panelAddMaterial.Location = new System.Drawing.Point(86, 30);
            this.panelAddMaterial.Name = "panelAddMaterial";
            this.panelAddMaterial.Size = new System.Drawing.Size(443, 275);
            this.panelAddMaterial.TabIndex = 13;
            // 
            // dateTimePickerAddMaterialDateSupply
            // 
            this.dateTimePickerAddMaterialDateSupply.Location = new System.Drawing.Point(28, 179);
            this.dateTimePickerAddMaterialDateSupply.Name = "dateTimePickerAddMaterialDateSupply";
            this.dateTimePickerAddMaterialDateSupply.Size = new System.Drawing.Size(288, 27);
            this.dateTimePickerAddMaterialDateSupply.TabIndex = 24;
            // 
            // labelAddMaterialDateSupply
            // 
            this.labelAddMaterialDateSupply.AutoSize = true;
            this.labelAddMaterialDateSupply.Location = new System.Drawing.Point(24, 153);
            this.labelAddMaterialDateSupply.Name = "labelAddMaterialDateSupply";
            this.labelAddMaterialDateSupply.Size = new System.Drawing.Size(94, 20);
            this.labelAddMaterialDateSupply.TabIndex = 14;
            this.labelAddMaterialDateSupply.Text = "Date supply";
            // 
            // textBoxAddMaterialPrice
            // 
            this.textBoxAddMaterialPrice.Location = new System.Drawing.Point(165, 104);
            this.textBoxAddMaterialPrice.Name = "textBoxAddMaterialPrice";
            this.textBoxAddMaterialPrice.Size = new System.Drawing.Size(111, 27);
            this.textBoxAddMaterialPrice.TabIndex = 13;
            // 
            // labelAddMaterialPrice
            // 
            this.labelAddMaterialPrice.AutoSize = true;
            this.labelAddMaterialPrice.Location = new System.Drawing.Point(165, 80);
            this.labelAddMaterialPrice.Name = "labelAddMaterialPrice";
            this.labelAddMaterialPrice.Size = new System.Drawing.Size(47, 20);
            this.labelAddMaterialPrice.TabIndex = 12;
            this.labelAddMaterialPrice.Text = "Price";
            // 
            // buttonAddNewMaterial
            // 
            this.buttonAddNewMaterial.Location = new System.Drawing.Point(28, 225);
            this.buttonAddNewMaterial.Name = "buttonAddNewMaterial";
            this.buttonAddNewMaterial.Size = new System.Drawing.Size(111, 34);
            this.buttonAddNewMaterial.TabIndex = 11;
            this.buttonAddNewMaterial.Text = "Add";
            this.buttonAddNewMaterial.UseVisualStyleBackColor = true;
            this.buttonAddNewMaterial.Click += new System.EventHandler(this.buttonAddNewMaterial_Click);
            // 
            // textBoxAddMaterialQuantity
            // 
            this.textBoxAddMaterialQuantity.Location = new System.Drawing.Point(28, 104);
            this.textBoxAddMaterialQuantity.Name = "textBoxAddMaterialQuantity";
            this.textBoxAddMaterialQuantity.Size = new System.Drawing.Size(111, 27);
            this.textBoxAddMaterialQuantity.TabIndex = 10;
            // 
            // labelAddMaterialQuantity
            // 
            this.labelAddMaterialQuantity.AutoSize = true;
            this.labelAddMaterialQuantity.Location = new System.Drawing.Point(24, 80);
            this.labelAddMaterialQuantity.Name = "labelAddMaterialQuantity";
            this.labelAddMaterialQuantity.Size = new System.Drawing.Size(72, 20);
            this.labelAddMaterialQuantity.TabIndex = 9;
            this.labelAddMaterialQuantity.Text = "Quantity";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 20);
            this.label13.TabIndex = 8;
            // 
            // labelAddMaterialName
            // 
            this.labelAddMaterialName.AutoSize = true;
            this.labelAddMaterialName.Location = new System.Drawing.Point(24, 13);
            this.labelAddMaterialName.Name = "labelAddMaterialName";
            this.labelAddMaterialName.Size = new System.Drawing.Size(51, 20);
            this.labelAddMaterialName.TabIndex = 3;
            this.labelAddMaterialName.Text = "Name";
            // 
            // textBoxAddMaterialName
            // 
            this.textBoxAddMaterialName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddMaterialName.Name = "textBoxAddMaterialName";
            this.textBoxAddMaterialName.Size = new System.Drawing.Size(368, 27);
            this.textBoxAddMaterialName.TabIndex = 1;
            // 
            // panelAddOperation
            // 
            this.panelAddOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddOperation.Controls.Add(this.buttonAddNewOperation);
            this.panelAddOperation.Controls.Add(this.textBoxAddOperationExecutionTime);
            this.panelAddOperation.Controls.Add(this.labelAddOperationExecutionTime);
            this.panelAddOperation.Controls.Add(this.label9);
            this.panelAddOperation.Controls.Add(this.label10);
            this.panelAddOperation.Controls.Add(this.textBoxAddOperationName);
            this.panelAddOperation.Location = new System.Drawing.Point(86, 30);
            this.panelAddOperation.Name = "panelAddOperation";
            this.panelAddOperation.Size = new System.Drawing.Size(443, 211);
            this.panelAddOperation.TabIndex = 25;
            this.panelAddOperation.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddOperation_Paint);
            // 
            // buttonAddNewOperation
            // 
            this.buttonAddNewOperation.Location = new System.Drawing.Point(26, 159);
            this.buttonAddNewOperation.Name = "buttonAddNewOperation";
            this.buttonAddNewOperation.Size = new System.Drawing.Size(111, 34);
            this.buttonAddNewOperation.TabIndex = 11;
            this.buttonAddNewOperation.Text = "Add";
            this.buttonAddNewOperation.UseVisualStyleBackColor = true;
            this.buttonAddNewOperation.Click += new System.EventHandler(this.buttonAddNewOperation_Click);
            // 
            // textBoxAddOperationExecutionTime
            // 
            this.textBoxAddOperationExecutionTime.Location = new System.Drawing.Point(28, 104);
            this.textBoxAddOperationExecutionTime.Name = "textBoxAddOperationExecutionTime";
            this.textBoxAddOperationExecutionTime.Size = new System.Drawing.Size(111, 27);
            this.textBoxAddOperationExecutionTime.TabIndex = 10;
            // 
            // labelAddOperationExecutionTime
            // 
            this.labelAddOperationExecutionTime.AutoSize = true;
            this.labelAddOperationExecutionTime.Location = new System.Drawing.Point(24, 80);
            this.labelAddOperationExecutionTime.Name = "labelAddOperationExecutionTime";
            this.labelAddOperationExecutionTime.Size = new System.Drawing.Size(118, 20);
            this.labelAddOperationExecutionTime.TabIndex = 9;
            this.labelAddOperationExecutionTime.Text = "Execution time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 20);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Name";
            // 
            // textBoxAddOperationName
            // 
            this.textBoxAddOperationName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddOperationName.Name = "textBoxAddOperationName";
            this.textBoxAddOperationName.Size = new System.Drawing.Size(368, 27);
            this.textBoxAddOperationName.TabIndex = 1;
            // 
            // panelAddMechanic
            // 
            this.panelAddMechanic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddMechanic.Controls.Add(this.buttonAddNewMechanic);
            this.panelAddMechanic.Controls.Add(this.textBoxAddMechanicFirstName);
            this.panelAddMechanic.Controls.Add(this.labelAddMechanicFirstName);
            this.panelAddMechanic.Controls.Add(this.label7);
            this.panelAddMechanic.Controls.Add(this.labelAddMechanicName);
            this.panelAddMechanic.Controls.Add(this.textBoxAddMechanicName);
            this.panelAddMechanic.Location = new System.Drawing.Point(86, 30);
            this.panelAddMechanic.Name = "panelAddMechanic";
            this.panelAddMechanic.Size = new System.Drawing.Size(374, 213);
            this.panelAddMechanic.TabIndex = 26;
            // 
            // buttonAddNewMechanic
            // 
            this.buttonAddNewMechanic.Location = new System.Drawing.Point(26, 159);
            this.buttonAddNewMechanic.Name = "buttonAddNewMechanic";
            this.buttonAddNewMechanic.Size = new System.Drawing.Size(111, 34);
            this.buttonAddNewMechanic.TabIndex = 11;
            this.buttonAddNewMechanic.Text = "Add";
            this.buttonAddNewMechanic.UseVisualStyleBackColor = true;
            this.buttonAddNewMechanic.Click += new System.EventHandler(this.buttonAddNewMechanic_Click);
            // 
            // textBoxAddMechanicFirstName
            // 
            this.textBoxAddMechanicFirstName.Location = new System.Drawing.Point(28, 104);
            this.textBoxAddMechanicFirstName.Name = "textBoxAddMechanicFirstName";
            this.textBoxAddMechanicFirstName.Size = new System.Drawing.Size(224, 27);
            this.textBoxAddMechanicFirstName.TabIndex = 10;
            // 
            // labelAddMechanicFirstName
            // 
            this.labelAddMechanicFirstName.AutoSize = true;
            this.labelAddMechanicFirstName.Location = new System.Drawing.Point(24, 80);
            this.labelAddMechanicFirstName.Name = "labelAddMechanicFirstName";
            this.labelAddMechanicFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelAddMechanicFirstName.TabIndex = 9;
            this.labelAddMechanicFirstName.Text = "First name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 8;
            // 
            // labelAddMechanicName
            // 
            this.labelAddMechanicName.AutoSize = true;
            this.labelAddMechanicName.Location = new System.Drawing.Point(24, 13);
            this.labelAddMechanicName.Name = "labelAddMechanicName";
            this.labelAddMechanicName.Size = new System.Drawing.Size(51, 20);
            this.labelAddMechanicName.TabIndex = 3;
            this.labelAddMechanicName.Text = "Name";
            // 
            // textBoxAddMechanicName
            // 
            this.textBoxAddMechanicName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddMechanicName.Name = "textBoxAddMechanicName";
            this.textBoxAddMechanicName.Size = new System.Drawing.Size(224, 27);
            this.textBoxAddMechanicName.TabIndex = 1;
            // 
            // panelAddOrder
            // 
            this.panelAddOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddOrder.Controls.Add(this.dataGridViewAddOrderSelectClient);
            this.panelAddOrder.Controls.Add(this.label4);
            this.panelAddOrder.Controls.Add(this.textBoxAddOrderKm);
            this.panelAddOrder.Controls.Add(this.labelAddOrderKm);
            this.panelAddOrder.Controls.Add(this.comboBoxAddOrderInService);
            this.panelAddOrder.Controls.Add(this.comboBoxAddOrderState);
            this.panelAddOrder.Controls.Add(this.groupBoxCommandDetails);
            this.panelAddOrder.Controls.Add(this.textBoxAddOrderPiecesValue);
            this.panelAddOrder.Controls.Add(this.labelAddOrderPiecesValue);
            this.panelAddOrder.Controls.Add(this.labelAddOrderState);
            this.panelAddOrder.Controls.Add(this.labelAddOrderInService);
            this.panelAddOrder.Controls.Add(this.labelAddOrderDescription);
            this.panelAddOrder.Controls.Add(this.dateTimePickerEndDate);
            this.panelAddOrder.Controls.Add(this.dateTimePickerStartDate);
            this.panelAddOrder.Controls.Add(this.buttonAddNewOrder);
            this.panelAddOrder.Controls.Add(this.textBoxAddOrderDescription);
            this.panelAddOrder.Controls.Add(this.labelAddOrderEndDate);
            this.panelAddOrder.Controls.Add(this.label5);
            this.panelAddOrder.Controls.Add(this.labelAddOrderStartDate);
            this.panelAddOrder.Location = new System.Drawing.Point(27, 30);
            this.panelAddOrder.Name = "panelAddOrder";
            this.panelAddOrder.Size = new System.Drawing.Size(1142, 733);
            this.panelAddOrder.TabIndex = 12;
            // 
            // dataGridViewAddOrderSelectClient
            // 
            this.dataGridViewAddOrderSelectClient.AccessibleName = "";
            this.dataGridViewAddOrderSelectClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddOrderSelectClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddOrderSelectClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddOrderSelectClient.Location = new System.Drawing.Point(28, 41);
            this.dataGridViewAddOrderSelectClient.Name = "dataGridViewAddOrderSelectClient";
            this.dataGridViewAddOrderSelectClient.RowTemplate.Height = 24;
            this.dataGridViewAddOrderSelectClient.Size = new System.Drawing.Size(291, 102);
            this.dataGridViewAddOrderSelectClient.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AccessibleName = "labelAddOrderClient";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Client";
            // 
            // textBoxAddOrderKm
            // 
            this.textBoxAddOrderKm.Enabled = false;
            this.textBoxAddOrderKm.Location = new System.Drawing.Point(575, 170);
            this.textBoxAddOrderKm.Name = "textBoxAddOrderKm";
            this.textBoxAddOrderKm.Size = new System.Drawing.Size(176, 27);
            this.textBoxAddOrderKm.TabIndex = 26;
            this.textBoxAddOrderKm.Text = "0";
            // 
            // labelAddOrderKm
            // 
            this.labelAddOrderKm.AutoSize = true;
            this.labelAddOrderKm.Location = new System.Drawing.Point(571, 144);
            this.labelAddOrderKm.Name = "labelAddOrderKm";
            this.labelAddOrderKm.Size = new System.Drawing.Size(34, 20);
            this.labelAddOrderKm.TabIndex = 25;
            this.labelAddOrderKm.Text = "Km";
            // 
            // comboBoxAddOrderInService
            // 
            this.comboBoxAddOrderInService.FormattingEnabled = true;
            this.comboBoxAddOrderInService.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxAddOrderInService.Location = new System.Drawing.Point(425, 169);
            this.comboBoxAddOrderInService.Name = "comboBoxAddOrderInService";
            this.comboBoxAddOrderInService.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAddOrderInService.TabIndex = 24;
            // 
            // comboBoxAddOrderState
            // 
            this.comboBoxAddOrderState.FormattingEnabled = true;
            this.comboBoxAddOrderState.Items.AddRange(new object[] {
            "Waiting",
            "In execution",
            "Rejected"});
            this.comboBoxAddOrderState.Location = new System.Drawing.Point(988, 42);
            this.comboBoxAddOrderState.Name = "comboBoxAddOrderState";
            this.comboBoxAddOrderState.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAddOrderState.TabIndex = 23;
            // 
            // groupBoxCommandDetails
            // 
            this.groupBoxCommandDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCommandDetails.Controls.Add(this.buttonAddDetailsImage);
            this.groupBoxCommandDetails.Controls.Add(this.buttonAddDetailsMechanic);
            this.groupBoxCommandDetails.Controls.Add(this.buttonAddDetailsOperation);
            this.groupBoxCommandDetails.Controls.Add(this.buttonAddDetailsMaterial);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsImages);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsMechanics);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsOperations);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsMaterials);
            this.groupBoxCommandDetails.Location = new System.Drawing.Point(28, 227);
            this.groupBoxCommandDetails.Name = "groupBoxCommandDetails";
            this.groupBoxCommandDetails.Size = new System.Drawing.Size(1081, 478);
            this.groupBoxCommandDetails.TabIndex = 22;
            this.groupBoxCommandDetails.TabStop = false;
            this.groupBoxCommandDetails.Text = "Details";
            // 
            // buttonAddDetailsImage
            // 
            this.buttonAddDetailsImage.Location = new System.Drawing.Point(397, 418);
            this.buttonAddDetailsImage.Name = "buttonAddDetailsImage";
            this.buttonAddDetailsImage.Size = new System.Drawing.Size(209, 36);
            this.buttonAddDetailsImage.TabIndex = 7;
            this.buttonAddDetailsImage.Text = "Add selected image";
            this.buttonAddDetailsImage.UseVisualStyleBackColor = true;
            // 
            // buttonAddDetailsMechanic
            // 
            this.buttonAddDetailsMechanic.Location = new System.Drawing.Point(31, 418);
            this.buttonAddDetailsMechanic.Name = "buttonAddDetailsMechanic";
            this.buttonAddDetailsMechanic.Size = new System.Drawing.Size(209, 36);
            this.buttonAddDetailsMechanic.TabIndex = 6;
            this.buttonAddDetailsMechanic.Text = "Add selected mechanic";
            this.buttonAddDetailsMechanic.UseVisualStyleBackColor = true;
            // 
            // buttonAddDetailsOperation
            // 
            this.buttonAddDetailsOperation.Location = new System.Drawing.Point(397, 209);
            this.buttonAddDetailsOperation.Name = "buttonAddDetailsOperation";
            this.buttonAddDetailsOperation.Size = new System.Drawing.Size(209, 36);
            this.buttonAddDetailsOperation.TabIndex = 5;
            this.buttonAddDetailsOperation.Text = "Add selected operation";
            this.buttonAddDetailsOperation.UseVisualStyleBackColor = true;
            // 
            // buttonAddDetailsMaterial
            // 
            this.buttonAddDetailsMaterial.Location = new System.Drawing.Point(34, 206);
            this.buttonAddDetailsMaterial.Name = "buttonAddDetailsMaterial";
            this.buttonAddDetailsMaterial.Size = new System.Drawing.Size(209, 36);
            this.buttonAddDetailsMaterial.TabIndex = 4;
            this.buttonAddDetailsMaterial.Text = "Add selected material";
            this.buttonAddDetailsMaterial.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAddDetailsImages
            // 
            this.dataGridViewAddDetailsImages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddDetailsImages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddDetailsImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddDetailsImages.Location = new System.Drawing.Point(397, 263);
            this.dataGridViewAddDetailsImages.Name = "dataGridViewAddDetailsImages";
            this.dataGridViewAddDetailsImages.RowTemplate.Height = 24;
            this.dataGridViewAddDetailsImages.Size = new System.Drawing.Size(337, 134);
            this.dataGridViewAddDetailsImages.TabIndex = 3;
            // 
            // dataGridViewAddDetailsMechanics
            // 
            this.dataGridViewAddDetailsMechanics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddDetailsMechanics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddDetailsMechanics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddDetailsMechanics.Location = new System.Drawing.Point(34, 263);
            this.dataGridViewAddDetailsMechanics.Name = "dataGridViewAddDetailsMechanics";
            this.dataGridViewAddDetailsMechanics.RowTemplate.Height = 24;
            this.dataGridViewAddDetailsMechanics.Size = new System.Drawing.Size(337, 134);
            this.dataGridViewAddDetailsMechanics.TabIndex = 2;
            // 
            // dataGridViewAddDetailsOperations
            // 
            this.dataGridViewAddDetailsOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddDetailsOperations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddDetailsOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddDetailsOperations.Location = new System.Drawing.Point(397, 51);
            this.dataGridViewAddDetailsOperations.Name = "dataGridViewAddDetailsOperations";
            this.dataGridViewAddDetailsOperations.RowTemplate.Height = 24;
            this.dataGridViewAddDetailsOperations.Size = new System.Drawing.Size(337, 134);
            this.dataGridViewAddDetailsOperations.TabIndex = 1;
            // 
            // dataGridViewAddDetailsMaterials
            // 
            this.dataGridViewAddDetailsMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddDetailsMaterials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddDetailsMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddDetailsMaterials.Location = new System.Drawing.Point(31, 51);
            this.dataGridViewAddDetailsMaterials.Name = "dataGridViewAddDetailsMaterials";
            this.dataGridViewAddDetailsMaterials.RowTemplate.Height = 24;
            this.dataGridViewAddDetailsMaterials.Size = new System.Drawing.Size(337, 134);
            this.dataGridViewAddDetailsMaterials.TabIndex = 0;
            // 
            // textBoxAddOrderPiecesValue
            // 
            this.textBoxAddOrderPiecesValue.Enabled = false;
            this.textBoxAddOrderPiecesValue.Location = new System.Drawing.Point(774, 170);
            this.textBoxAddOrderPiecesValue.Name = "textBoxAddOrderPiecesValue";
            this.textBoxAddOrderPiecesValue.Size = new System.Drawing.Size(100, 27);
            this.textBoxAddOrderPiecesValue.TabIndex = 21;
            // 
            // labelAddOrderPiecesValue
            // 
            this.labelAddOrderPiecesValue.AutoSize = true;
            this.labelAddOrderPiecesValue.Location = new System.Drawing.Point(770, 147);
            this.labelAddOrderPiecesValue.Name = "labelAddOrderPiecesValue";
            this.labelAddOrderPiecesValue.Size = new System.Drawing.Size(98, 20);
            this.labelAddOrderPiecesValue.TabIndex = 20;
            this.labelAddOrderPiecesValue.Text = "Pieces value";
            // 
            // labelAddOrderState
            // 
            this.labelAddOrderState.AutoSize = true;
            this.labelAddOrderState.Location = new System.Drawing.Point(987, 18);
            this.labelAddOrderState.Name = "labelAddOrderState";
            this.labelAddOrderState.Size = new System.Drawing.Size(45, 20);
            this.labelAddOrderState.TabIndex = 18;
            this.labelAddOrderState.Text = "State";
            // 
            // labelAddOrderInService
            // 
            this.labelAddOrderInService.AutoSize = true;
            this.labelAddOrderInService.Location = new System.Drawing.Point(421, 144);
            this.labelAddOrderInService.Name = "labelAddOrderInService";
            this.labelAddOrderInService.Size = new System.Drawing.Size(80, 20);
            this.labelAddOrderInService.TabIndex = 15;
            this.labelAddOrderInService.Text = "In service";
            // 
            // labelAddOrderDescription
            // 
            this.labelAddOrderDescription.AutoSize = true;
            this.labelAddOrderDescription.Location = new System.Drawing.Point(24, 144);
            this.labelAddOrderDescription.Name = "labelAddOrderDescription";
            this.labelAddOrderDescription.Size = new System.Drawing.Size(93, 20);
            this.labelAddOrderDescription.TabIndex = 14;
            this.labelAddOrderDescription.Text = "Description";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(670, 43);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(288, 27);
            this.dateTimePickerEndDate.TabIndex = 13;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(356, 43);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(288, 27);
            this.dateTimePickerStartDate.TabIndex = 12;
            // 
            // buttonAddNewOrder
            // 
            this.buttonAddNewOrder.Enabled = false;
            this.buttonAddNewOrder.Location = new System.Drawing.Point(996, 170);
            this.buttonAddNewOrder.Name = "buttonAddNewOrder";
            this.buttonAddNewOrder.Size = new System.Drawing.Size(113, 34);
            this.buttonAddNewOrder.TabIndex = 11;
            this.buttonAddNewOrder.Text = "Add";
            this.buttonAddNewOrder.UseVisualStyleBackColor = true;
            this.buttonAddNewOrder.Click += new System.EventHandler(this.buttonAddNewOrder_Click);
            // 
            // textBoxAddOrderDescription
            // 
            this.textBoxAddOrderDescription.Location = new System.Drawing.Point(28, 170);
            this.textBoxAddOrderDescription.Multiline = true;
            this.textBoxAddOrderDescription.Name = "textBoxAddOrderDescription";
            this.textBoxAddOrderDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddOrderDescription.Size = new System.Drawing.Size(368, 27);
            this.textBoxAddOrderDescription.TabIndex = 10;
            // 
            // labelAddOrderEndDate
            // 
            this.labelAddOrderEndDate.AutoSize = true;
            this.labelAddOrderEndDate.Location = new System.Drawing.Point(666, 18);
            this.labelAddOrderEndDate.Name = "labelAddOrderEndDate";
            this.labelAddOrderEndDate.Size = new System.Drawing.Size(72, 20);
            this.labelAddOrderEndDate.TabIndex = 9;
            this.labelAddOrderEndDate.Text = "End date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 8;
            // 
            // labelAddOrderStartDate
            // 
            this.labelAddOrderStartDate.AutoSize = true;
            this.labelAddOrderStartDate.Location = new System.Drawing.Point(352, 18);
            this.labelAddOrderStartDate.Name = "labelAddOrderStartDate";
            this.labelAddOrderStartDate.Size = new System.Drawing.Size(79, 20);
            this.labelAddOrderStartDate.TabIndex = 3;
            this.labelAddOrderStartDate.Text = "Start date";
            // 
            // panelAddCustomerCar
            // 
            this.panelAddCustomerCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddCustomerCar.Controls.Add(this.buttonAddCustomerCar);
            this.panelAddCustomerCar.Controls.Add(this.dataGridViewChassisOptions);
            this.panelAddCustomerCar.Controls.Add(this.label2);
            this.panelAddCustomerCar.Controls.Add(this.labelChassisSeries);
            this.panelAddCustomerCar.Controls.Add(this.textBoxChassisSeries);
            this.panelAddCustomerCar.Controls.Add(this.labelChassis);
            this.panelAddCustomerCar.Controls.Add(this.labelAutoNumber);
            this.panelAddCustomerCar.Controls.Add(this.textBoxAutoNumber);
            this.panelAddCustomerCar.Location = new System.Drawing.Point(86, 463);
            this.panelAddCustomerCar.Name = "panelAddCustomerCar";
            this.panelAddCustomerCar.Size = new System.Drawing.Size(1022, 262);
            this.panelAddCustomerCar.TabIndex = 9;
            // 
            // buttonAddCustomerCar
            // 
            this.buttonAddCustomerCar.Location = new System.Drawing.Point(28, 203);
            this.buttonAddCustomerCar.Name = "buttonAddCustomerCar";
            this.buttonAddCustomerCar.Size = new System.Drawing.Size(110, 35);
            this.buttonAddCustomerCar.TabIndex = 10;
            this.buttonAddCustomerCar.Text = "Add";
            this.buttonAddCustomerCar.UseVisualStyleBackColor = true;
            this.buttonAddCustomerCar.Click += new System.EventHandler(this.buttonAddCustomerCar_Click);
            // 
            // dataGridViewChassisOptions
            // 
            this.dataGridViewChassisOptions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewChassisOptions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewChassisOptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChassisOptions.Location = new System.Drawing.Point(495, 41);
            this.dataGridViewChassisOptions.Name = "dataGridViewChassisOptions";
            this.dataGridViewChassisOptions.RowTemplate.Height = 24;
            this.dataGridViewChassisOptions.Size = new System.Drawing.Size(496, 150);
            this.dataGridViewChassisOptions.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // labelChassisSeries
            // 
            this.labelChassisSeries.AutoSize = true;
            this.labelChassisSeries.Location = new System.Drawing.Point(30, 87);
            this.labelChassisSeries.Name = "labelChassisSeries";
            this.labelChassisSeries.Size = new System.Drawing.Size(108, 20);
            this.labelChassisSeries.TabIndex = 6;
            this.labelChassisSeries.Text = "Chassis series";
            // 
            // textBoxChassisSeries
            // 
            this.textBoxChassisSeries.Location = new System.Drawing.Point(28, 110);
            this.textBoxChassisSeries.Name = "textBoxChassisSeries";
            this.textBoxChassisSeries.Size = new System.Drawing.Size(323, 27);
            this.textBoxChassisSeries.TabIndex = 5;
            // 
            // labelChassis
            // 
            this.labelChassis.AutoSize = true;
            this.labelChassis.Location = new System.Drawing.Point(491, 13);
            this.labelChassis.Name = "labelChassis";
            this.labelChassis.Size = new System.Drawing.Size(62, 20);
            this.labelChassis.TabIndex = 4;
            this.labelChassis.Text = "Chassis";
            // 
            // labelAutoNumber
            // 
            this.labelAutoNumber.AutoSize = true;
            this.labelAutoNumber.Location = new System.Drawing.Point(24, 13);
            this.labelAutoNumber.Name = "labelAutoNumber";
            this.labelAutoNumber.Size = new System.Drawing.Size(104, 20);
            this.labelAutoNumber.TabIndex = 3;
            this.labelAutoNumber.Text = "Auto number";
            // 
            // textBoxAutoNumber
            // 
            this.textBoxAutoNumber.Location = new System.Drawing.Point(28, 41);
            this.textBoxAutoNumber.Name = "textBoxAutoNumber";
            this.textBoxAutoNumber.Size = new System.Drawing.Size(201, 27);
            this.textBoxAutoNumber.TabIndex = 1;
            // 
            // dataGridViewCustomerCars
            // 
            this.dataGridViewCustomerCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomerCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerCars.Location = new System.Drawing.Point(86, 186);
            this.dataGridViewCustomerCars.Name = "dataGridViewCustomerCars";
            this.dataGridViewCustomerCars.RowTemplate.Height = 24;
            this.dataGridViewCustomerCars.Size = new System.Drawing.Size(1022, 248);
            this.dataGridViewCustomerCars.TabIndex = 2;
            // 
            // panelAddCustomer
            // 
            this.panelAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddCustomer.Controls.Add(this.panelAddChassis);
            this.panelAddCustomer.Controls.Add(this.labelAddCustomerDisplayInfo);
            this.panelAddCustomer.Controls.Add(this.textBoxAddEmail);
            this.panelAddCustomer.Controls.Add(this.labelAddEmail);
            this.panelAddCustomer.Controls.Add(this.labelAddPhoneNumber);
            this.panelAddCustomer.Controls.Add(this.textBoxAddPhoneNumber);
            this.panelAddCustomer.Controls.Add(this.textBoxAddCounty);
            this.panelAddCustomer.Controls.Add(this.textBoxAddCity);
            this.panelAddCustomer.Controls.Add(this.labelAddCounty);
            this.panelAddCustomer.Controls.Add(this.labelAddCity);
            this.panelAddCustomer.Controls.Add(this.labelAddAddress);
            this.panelAddCustomer.Controls.Add(this.label1);
            this.panelAddCustomer.Controls.Add(this.buttonAddNewCustomer);
            this.panelAddCustomer.Controls.Add(this.textBoxAddAddress);
            this.panelAddCustomer.Controls.Add(this.labelAddFirstName);
            this.panelAddCustomer.Controls.Add(this.labelAddName);
            this.panelAddCustomer.Controls.Add(this.textBoxAddFirstName);
            this.panelAddCustomer.Controls.Add(this.textBoxAddName);
            this.panelAddCustomer.Location = new System.Drawing.Point(86, 30);
            this.panelAddCustomer.Name = "panelAddCustomer";
            this.panelAddCustomer.Size = new System.Drawing.Size(427, 567);
            this.panelAddCustomer.TabIndex = 1;
            // 
            // panelAddChassis
            // 
            this.panelAddChassis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddChassis.Controls.Add(this.buttonAddNewChassis);
            this.panelAddChassis.Controls.Add(this.textBoxChassisName);
            this.panelAddChassis.Controls.Add(this.labelChassisName);
            this.panelAddChassis.Controls.Add(this.label3);
            this.panelAddChassis.Controls.Add(this.labelChassisCode);
            this.panelAddChassis.Controls.Add(this.textBoxChassisCode);
            this.panelAddChassis.Location = new System.Drawing.Point(0, 0);
            this.panelAddChassis.Name = "panelAddChassis";
            this.panelAddChassis.Size = new System.Drawing.Size(436, 201);
            this.panelAddChassis.TabIndex = 9;
            // 
            // buttonAddNewChassis
            // 
            this.buttonAddNewChassis.Location = new System.Drawing.Point(28, 149);
            this.buttonAddNewChassis.Name = "buttonAddNewChassis";
            this.buttonAddNewChassis.Size = new System.Drawing.Size(111, 34);
            this.buttonAddNewChassis.TabIndex = 11;
            this.buttonAddNewChassis.Text = "Add";
            this.buttonAddNewChassis.UseVisualStyleBackColor = true;
            this.buttonAddNewChassis.Click += new System.EventHandler(this.buttonAddNewChassis_Click);
            // 
            // textBoxChassisName
            // 
            this.textBoxChassisName.Location = new System.Drawing.Point(28, 104);
            this.textBoxChassisName.Name = "textBoxChassisName";
            this.textBoxChassisName.Size = new System.Drawing.Size(368, 27);
            this.textBoxChassisName.TabIndex = 10;
            // 
            // labelChassisName
            // 
            this.labelChassisName.AutoSize = true;
            this.labelChassisName.Location = new System.Drawing.Point(24, 80);
            this.labelChassisName.Name = "labelChassisName";
            this.labelChassisName.Size = new System.Drawing.Size(51, 20);
            this.labelChassisName.TabIndex = 9;
            this.labelChassisName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // labelChassisCode
            // 
            this.labelChassisCode.AutoSize = true;
            this.labelChassisCode.Location = new System.Drawing.Point(24, 13);
            this.labelChassisCode.Name = "labelChassisCode";
            this.labelChassisCode.Size = new System.Drawing.Size(45, 20);
            this.labelChassisCode.TabIndex = 3;
            this.labelChassisCode.Text = "Code";
            // 
            // textBoxChassisCode
            // 
            this.textBoxChassisCode.Location = new System.Drawing.Point(28, 41);
            this.textBoxChassisCode.Name = "textBoxChassisCode";
            this.textBoxChassisCode.Size = new System.Drawing.Size(93, 27);
            this.textBoxChassisCode.TabIndex = 1;
            // 
            // labelAddCustomerDisplayInfo
            // 
            this.labelAddCustomerDisplayInfo.AutoSize = true;
            this.labelAddCustomerDisplayInfo.Location = new System.Drawing.Point(24, 520);
            this.labelAddCustomerDisplayInfo.Name = "labelAddCustomerDisplayInfo";
            this.labelAddCustomerDisplayInfo.Size = new System.Drawing.Size(0, 20);
            this.labelAddCustomerDisplayInfo.TabIndex = 18;
            // 
            // textBoxAddEmail
            // 
            this.textBoxAddEmail.Location = new System.Drawing.Point(27, 410);
            this.textBoxAddEmail.Name = "textBoxAddEmail";
            this.textBoxAddEmail.Size = new System.Drawing.Size(344, 27);
            this.textBoxAddEmail.TabIndex = 17;
            // 
            // labelAddEmail
            // 
            this.labelAddEmail.AutoSize = true;
            this.labelAddEmail.Location = new System.Drawing.Point(24, 373);
            this.labelAddEmail.Name = "labelAddEmail";
            this.labelAddEmail.Size = new System.Drawing.Size(51, 20);
            this.labelAddEmail.TabIndex = 16;
            this.labelAddEmail.Text = "Email";
            // 
            // labelAddPhoneNumber
            // 
            this.labelAddPhoneNumber.AutoSize = true;
            this.labelAddPhoneNumber.Location = new System.Drawing.Point(24, 314);
            this.labelAddPhoneNumber.Name = "labelAddPhoneNumber";
            this.labelAddPhoneNumber.Size = new System.Drawing.Size(114, 20);
            this.labelAddPhoneNumber.TabIndex = 15;
            this.labelAddPhoneNumber.Text = "Phone number";
            // 
            // textBoxAddPhoneNumber
            // 
            this.textBoxAddPhoneNumber.Location = new System.Drawing.Point(27, 337);
            this.textBoxAddPhoneNumber.Name = "textBoxAddPhoneNumber";
            this.textBoxAddPhoneNumber.Size = new System.Drawing.Size(253, 27);
            this.textBoxAddPhoneNumber.TabIndex = 14;
            // 
            // textBoxAddCounty
            // 
            this.textBoxAddCounty.Location = new System.Drawing.Point(27, 278);
            this.textBoxAddCounty.Name = "textBoxAddCounty";
            this.textBoxAddCounty.Size = new System.Drawing.Size(253, 27);
            this.textBoxAddCounty.TabIndex = 13;
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Location = new System.Drawing.Point(28, 224);
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(253, 27);
            this.textBoxAddCity.TabIndex = 12;
            // 
            // labelAddCounty
            // 
            this.labelAddCounty.AutoSize = true;
            this.labelAddCounty.Location = new System.Drawing.Point(24, 255);
            this.labelAddCounty.Name = "labelAddCounty";
            this.labelAddCounty.Size = new System.Drawing.Size(61, 20);
            this.labelAddCounty.TabIndex = 11;
            this.labelAddCounty.Text = "County";
            // 
            // labelAddCity
            // 
            this.labelAddCity.AutoSize = true;
            this.labelAddCity.Location = new System.Drawing.Point(24, 201);
            this.labelAddCity.Name = "labelAddCity";
            this.labelAddCity.Size = new System.Drawing.Size(39, 20);
            this.labelAddCity.TabIndex = 10;
            this.labelAddCity.Text = "City";
            // 
            // labelAddAddress
            // 
            this.labelAddAddress.AutoSize = true;
            this.labelAddAddress.Location = new System.Drawing.Point(24, 137);
            this.labelAddAddress.Name = "labelAddAddress";
            this.labelAddAddress.Size = new System.Drawing.Size(67, 20);
            this.labelAddAddress.TabIndex = 9;
            this.labelAddAddress.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // buttonAddNewCustomer
            // 
            this.buttonAddNewCustomer.Location = new System.Drawing.Point(28, 459);
            this.buttonAddNewCustomer.Name = "buttonAddNewCustomer";
            this.buttonAddNewCustomer.Size = new System.Drawing.Size(142, 36);
            this.buttonAddNewCustomer.TabIndex = 7;
            this.buttonAddNewCustomer.Text = "Add";
            this.buttonAddNewCustomer.UseVisualStyleBackColor = true;
            this.buttonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // textBoxAddAddress
            // 
            this.textBoxAddAddress.Location = new System.Drawing.Point(28, 162);
            this.textBoxAddAddress.Name = "textBoxAddAddress";
            this.textBoxAddAddress.Size = new System.Drawing.Size(253, 27);
            this.textBoxAddAddress.TabIndex = 5;
            // 
            // labelAddFirstName
            // 
            this.labelAddFirstName.AutoSize = true;
            this.labelAddFirstName.Location = new System.Drawing.Point(24, 77);
            this.labelAddFirstName.Name = "labelAddFirstName";
            this.labelAddFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelAddFirstName.TabIndex = 4;
            this.labelAddFirstName.Text = "First name";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(24, 18);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(51, 20);
            this.labelAddName.TabIndex = 3;
            this.labelAddName.Text = "Name";
            // 
            // textBoxAddFirstName
            // 
            this.textBoxAddFirstName.Location = new System.Drawing.Point(27, 100);
            this.textBoxAddFirstName.Name = "textBoxAddFirstName";
            this.textBoxAddFirstName.Size = new System.Drawing.Size(254, 27);
            this.textBoxAddFirstName.TabIndex = 2;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(253, 27);
            this.textBoxAddName.TabIndex = 1;
            // 
            // panelSearchCustomer
            // 
            this.panelSearchCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSearchCustomer.Controls.Add(this.dataGridViewCustomers);
            this.panelSearchCustomer.Controls.Add(this.labelSearchDisplayInfo);
            this.panelSearchCustomer.Controls.Add(this.buttonSearchCustomer);
            this.panelSearchCustomer.Controls.Add(this.labelSearchEmail);
            this.panelSearchCustomer.Controls.Add(this.textBoxSearchEmail);
            this.panelSearchCustomer.Controls.Add(this.labelSearchFirstName);
            this.panelSearchCustomer.Controls.Add(this.labelSearchName);
            this.panelSearchCustomer.Controls.Add(this.textBoxSearchFirstName);
            this.panelSearchCustomer.Controls.Add(this.textBoxSearchName);
            this.panelSearchCustomer.Location = new System.Drawing.Point(86, 30);
            this.panelSearchCustomer.Name = "panelSearchCustomer";
            this.panelSearchCustomer.Size = new System.Drawing.Size(1022, 131);
            this.panelSearchCustomer.TabIndex = 0;
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1022, 427);
            this.dataGridViewCustomers.TabIndex = 10;
            // 
            // labelSearchDisplayInfo
            // 
            this.labelSearchDisplayInfo.AutoSize = true;
            this.labelSearchDisplayInfo.Location = new System.Drawing.Point(24, 100);
            this.labelSearchDisplayInfo.Name = "labelSearchDisplayInfo";
            this.labelSearchDisplayInfo.Size = new System.Drawing.Size(0, 20);
            this.labelSearchDisplayInfo.TabIndex = 8;
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Location = new System.Drawing.Point(831, 36);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(142, 36);
            this.buttonSearchCustomer.TabIndex = 7;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // labelSearchEmail
            // 
            this.labelSearchEmail.AutoSize = true;
            this.labelSearchEmail.Location = new System.Drawing.Point(475, 13);
            this.labelSearchEmail.Name = "labelSearchEmail";
            this.labelSearchEmail.Size = new System.Drawing.Size(51, 20);
            this.labelSearchEmail.TabIndex = 6;
            this.labelSearchEmail.Text = "Email";
            // 
            // textBoxSearchEmail
            // 
            this.textBoxSearchEmail.Location = new System.Drawing.Point(479, 41);
            this.textBoxSearchEmail.Name = "textBoxSearchEmail";
            this.textBoxSearchEmail.Size = new System.Drawing.Size(323, 27);
            this.textBoxSearchEmail.TabIndex = 5;
            // 
            // labelSearchFirstName
            // 
            this.labelSearchFirstName.AutoSize = true;
            this.labelSearchFirstName.Location = new System.Drawing.Point(242, 13);
            this.labelSearchFirstName.Name = "labelSearchFirstName";
            this.labelSearchFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelSearchFirstName.TabIndex = 4;
            this.labelSearchFirstName.Text = "First name";
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(24, 13);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(51, 20);
            this.labelSearchName.TabIndex = 3;
            this.labelSearchName.Text = "Name";
            // 
            // textBoxSearchFirstName
            // 
            this.textBoxSearchFirstName.Location = new System.Drawing.Point(246, 41);
            this.textBoxSearchFirstName.Name = "textBoxSearchFirstName";
            this.textBoxSearchFirstName.Size = new System.Drawing.Size(216, 27);
            this.textBoxSearchFirstName.TabIndex = 2;
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(28, 41);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(201, 27);
            this.textBoxSearchName.TabIndex = 1;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddImage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddImage.Location = new System.Drawing.Point(6, 170);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(231, 42);
            this.buttonAddImage.TabIndex = 2;
            this.buttonAddImage.Text = "Add image";
            this.buttonAddImage.UseVisualStyleBackColor = false;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // buttonDisplayDetails
            // 
            this.buttonDisplayDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayDetails.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayDetails.Location = new System.Drawing.Point(6, 218);
            this.buttonDisplayDetails.Name = "buttonDisplayDetails";
            this.buttonDisplayDetails.Size = new System.Drawing.Size(231, 42);
            this.buttonDisplayDetails.TabIndex = 3;
            this.buttonDisplayDetails.Text = "View all";
            this.buttonDisplayDetails.UseVisualStyleBackColor = false;
            // 
            // panelAddNewImage
            // 
            this.panelAddNewImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddNewImage.Controls.Add(this.textBoxAddImageDescription);
            this.panelAddNewImage.Controls.Add(this.labelAddImageDescription);
            this.panelAddNewImage.Controls.Add(this.buttonAddImagePhotoUpload);
            this.panelAddNewImage.Controls.Add(this.pictureBoxImage);
            this.panelAddNewImage.Controls.Add(this.dateTimePickerAddImageDate);
            this.panelAddNewImage.Controls.Add(this.buttonAddNewImage);
            this.panelAddNewImage.Controls.Add(this.labelAddImageDate);
            this.panelAddNewImage.Controls.Add(this.label12);
            this.panelAddNewImage.Controls.Add(this.labelAddImageTitle);
            this.panelAddNewImage.Controls.Add(this.textBoxAddImageTitle);
            this.panelAddNewImage.Location = new System.Drawing.Point(86, 30);
            this.panelAddNewImage.Name = "panelAddNewImage";
            this.panelAddNewImage.Size = new System.Drawing.Size(443, 601);
            this.panelAddNewImage.TabIndex = 25;
            // 
            // buttonAddNewImage
            // 
            this.buttonAddNewImage.Location = new System.Drawing.Point(26, 556);
            this.buttonAddNewImage.Name = "buttonAddNewImage";
            this.buttonAddNewImage.Size = new System.Drawing.Size(111, 34);
            this.buttonAddNewImage.TabIndex = 11;
            this.buttonAddNewImage.Text = "Add";
            this.buttonAddNewImage.UseVisualStyleBackColor = true;
            this.buttonAddNewImage.Click += new System.EventHandler(this.buttonAddNewImage_Click);
            // 
            // labelAddImageDate
            // 
            this.labelAddImageDate.AutoSize = true;
            this.labelAddImageDate.Location = new System.Drawing.Point(24, 80);
            this.labelAddImageDate.Name = "labelAddImageDate";
            this.labelAddImageDate.Size = new System.Drawing.Size(42, 20);
            this.labelAddImageDate.TabIndex = 9;
            this.labelAddImageDate.Text = "Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 20);
            this.label12.TabIndex = 8;
            // 
            // labelAddImageTitle
            // 
            this.labelAddImageTitle.AutoSize = true;
            this.labelAddImageTitle.Location = new System.Drawing.Point(24, 13);
            this.labelAddImageTitle.Name = "labelAddImageTitle";
            this.labelAddImageTitle.Size = new System.Drawing.Size(43, 20);
            this.labelAddImageTitle.TabIndex = 3;
            this.labelAddImageTitle.Text = "Title";
            // 
            // textBoxAddImageTitle
            // 
            this.textBoxAddImageTitle.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddImageTitle.Name = "textBoxAddImageTitle";
            this.textBoxAddImageTitle.Size = new System.Drawing.Size(385, 27);
            this.textBoxAddImageTitle.TabIndex = 1;
            // 
            // dateTimePickerAddImageDate
            // 
            this.dateTimePickerAddImageDate.Location = new System.Drawing.Point(28, 106);
            this.dateTimePickerAddImageDate.Name = "dateTimePickerAddImageDate";
            this.dateTimePickerAddImageDate.Size = new System.Drawing.Size(288, 27);
            this.dateTimePickerAddImageDate.TabIndex = 29;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "CarRepairBlue2.ico");
            this.imageList.Images.SetKeyName(1, "Atyourservice-Service-Categories-Car-Repair.ico");
            this.imageList.Images.SetKeyName(2, "car(1).ico");
            this.imageList.Images.SetKeyName(3, "--breakdown-car-driver-fix-petrol-icon--icon-search-engine-4.png");
            // 
            // buttonAddImagePhotoUpload
            // 
            this.buttonAddImagePhotoUpload.Location = new System.Drawing.Point(26, 207);
            this.buttonAddImagePhotoUpload.Name = "buttonAddImagePhotoUpload";
            this.buttonAddImagePhotoUpload.Size = new System.Drawing.Size(111, 36);
            this.buttonAddImagePhotoUpload.TabIndex = 33;
            this.buttonAddImagePhotoUpload.Text = "Upload";
            this.buttonAddImagePhotoUpload.UseVisualStyleBackColor = true;
            this.buttonAddImagePhotoUpload.Click += new System.EventHandler(this.buttonAddImagePhotoUpload_Click);
            // 
            // labelAddImageDescription
            // 
            this.labelAddImageDescription.AutoSize = true;
            this.labelAddImageDescription.Location = new System.Drawing.Point(26, 146);
            this.labelAddImageDescription.Name = "labelAddImageDescription";
            this.labelAddImageDescription.Size = new System.Drawing.Size(93, 20);
            this.labelAddImageDescription.TabIndex = 34;
            this.labelAddImageDescription.Text = "Description";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(26, 253);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(385, 284);
            this.pictureBoxImage.TabIndex = 32;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxAddImageDescription
            // 
            this.textBoxAddImageDescription.Location = new System.Drawing.Point(28, 171);
            this.textBoxAddImageDescription.Name = "textBoxAddImageDescription";
            this.textBoxAddImageDescription.Size = new System.Drawing.Size(385, 27);
            this.textBoxAddImageDescription.TabIndex = 35;
            // 
            // CarServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1462, 802);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CarServiceForm";
            this.Text = "Car Service";
            this.Load += new System.EventHandler(this.CarServiceForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxChassis.ResumeLayout(false);
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxCustomers.ResumeLayout(false);
            this.panelAddMaterial.ResumeLayout(false);
            this.panelAddMaterial.PerformLayout();
            this.panelAddOperation.ResumeLayout(false);
            this.panelAddOperation.PerformLayout();
            this.panelAddMechanic.ResumeLayout(false);
            this.panelAddMechanic.PerformLayout();
            this.panelAddOrder.ResumeLayout(false);
            this.panelAddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOrderSelectClient)).EndInit();
            this.groupBoxCommandDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMechanics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMaterials)).EndInit();
            this.panelAddCustomerCar.ResumeLayout(false);
            this.panelAddCustomerCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChassisOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerCars)).EndInit();
            this.panelAddCustomer.ResumeLayout(false);
            this.panelAddCustomer.PerformLayout();
            this.panelAddChassis.ResumeLayout(false);
            this.panelAddChassis.PerformLayout();
            this.panelSearchCustomer.ResumeLayout(false);
            this.panelSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.panelAddNewImage.ResumeLayout(false);
            this.panelAddNewImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Button buttonCustomerDetails;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonSelectCustomer;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.Button buttonAddOrder;
        private System.Windows.Forms.Button buttonSelectOrder;
        private System.Windows.Forms.Panel panelSearchCustomer;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.Label labelSearchEmail;
        private System.Windows.Forms.TextBox textBoxSearchEmail;
        private System.Windows.Forms.Label labelSearchFirstName;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchFirstName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label labelSearchDisplayInfo;
        private System.Windows.Forms.Panel panelAddCustomer;
        private System.Windows.Forms.Label labelAddCustomerDisplayInfo;
        private System.Windows.Forms.TextBox textBoxAddEmail;
        private System.Windows.Forms.Label labelAddEmail;
        private System.Windows.Forms.Label labelAddPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAddCounty;
        private System.Windows.Forms.TextBox textBoxAddCity;
        private System.Windows.Forms.Label labelAddCounty;
        private System.Windows.Forms.Label labelAddCity;
        private System.Windows.Forms.Label labelAddAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddNewCustomer;
        private System.Windows.Forms.TextBox textBoxAddAddress;
        private System.Windows.Forms.Label labelAddFirstName;
        private System.Windows.Forms.Label labelAddName;
        private System.Windows.Forms.TextBox textBoxAddFirstName;
        private System.Windows.Forms.TextBox textBoxAddName;
        private System.Windows.Forms.Button buttonDisplayCustomers;
       // private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.DataGridView dataGridViewCustomerCars;
        private System.Windows.Forms.Panel panelAddCustomerCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChassisSeries;
        private System.Windows.Forms.TextBox textBoxChassisSeries;
        private System.Windows.Forms.Label labelChassis;
        private System.Windows.Forms.Label labelAutoNumber;
        private System.Windows.Forms.TextBox textBoxAutoNumber;
        private System.Windows.Forms.DataGridView dataGridViewChassisOptions;
        private System.Windows.Forms.Button buttonAddCustomerCar;
        private System.Windows.Forms.GroupBox groupBoxChassis;
        private System.Windows.Forms.Button buttonAddChassis;
        private System.Windows.Forms.Button buttonDisplayOrders;
        private System.Windows.Forms.Panel panelAddChassis;
        private System.Windows.Forms.Button buttonAddNewChassis;
        private System.Windows.Forms.TextBox textBoxChassisName;
        private System.Windows.Forms.Label labelChassisName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelChassisCode;
        private System.Windows.Forms.TextBox textBoxChassisCode;
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Panel panelAddOrder;
        private System.Windows.Forms.Label labelAddOrderDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button buttonAddNewOrder;
        private System.Windows.Forms.TextBox textBoxAddOrderDescription;
        private System.Windows.Forms.Label labelAddOrderEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAddOrderStartDate;
        private System.Windows.Forms.Label labelAddOrderInService;
        private System.Windows.Forms.Label labelAddOrderState;
        private System.Windows.Forms.TextBox textBoxAddOrderPiecesValue;
        private System.Windows.Forms.Label labelAddOrderPiecesValue;
        private System.Windows.Forms.GroupBox groupBoxCommandDetails;
        private System.Windows.Forms.ComboBox comboBoxAddOrderState;
        private System.Windows.Forms.Button buttonAddMechanic;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Panel panelAddMaterial;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddMaterialDateSupply;
        private System.Windows.Forms.Label labelAddMaterialDateSupply;
        private System.Windows.Forms.TextBox textBoxAddMaterialPrice;
        private System.Windows.Forms.Label labelAddMaterialPrice;
        private System.Windows.Forms.Button buttonAddNewMaterial;
        private System.Windows.Forms.TextBox textBoxAddMaterialQuantity;
        private System.Windows.Forms.Label labelAddMaterialQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelAddMaterialName;
        private System.Windows.Forms.TextBox textBoxAddMaterialName;
        private System.Windows.Forms.ComboBox comboBoxAddOrderInService;
        private System.Windows.Forms.Label labelAddOrderKm;
        private System.Windows.Forms.TextBox textBoxAddOrderKm;
        private System.Windows.Forms.DataGridView dataGridViewAddOrderSelectClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsMaterials;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsOperations;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsMechanics;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsImages;
        private System.Windows.Forms.Button buttonAddDetailsMaterial;
        private System.Windows.Forms.Button buttonAddDetailsOperation;
        private System.Windows.Forms.Button buttonAddDetailsMechanic;
        private System.Windows.Forms.Button buttonAddDetailsImage;
        private System.Windows.Forms.Panel panelAddOperation;
        private System.Windows.Forms.Button buttonAddNewOperation;
        private System.Windows.Forms.TextBox textBoxAddOperationExecutionTime;
        private System.Windows.Forms.Label labelAddOperationExecutionTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddOperationName;
        private System.Windows.Forms.Panel panelAddMechanic;
        private System.Windows.Forms.Button buttonAddNewMechanic;
        private System.Windows.Forms.TextBox textBoxAddMechanicFirstName;
        private System.Windows.Forms.Label labelAddMechanicFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAddMechanicName;
        private System.Windows.Forms.TextBox textBoxAddMechanicName;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonDisplayDetails;
        private System.Windows.Forms.Panel panelAddNewImage;
        private System.Windows.Forms.Button buttonAddNewImage;
        private System.Windows.Forms.Label labelAddImageDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelAddImageTitle;
        private System.Windows.Forms.TextBox textBoxAddImageTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddImageDate;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button buttonAddImagePhotoUpload;
        private System.Windows.Forms.TextBox textBoxAddImageDescription;
        private System.Windows.Forms.Label labelAddImageDescription;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}

