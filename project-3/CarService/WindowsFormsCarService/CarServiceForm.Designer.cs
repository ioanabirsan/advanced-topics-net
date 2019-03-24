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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarServiceForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.buttonDisplayDetails = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonAddMechanic = new System.Windows.Forms.Button();
            this.buttonAddOperation = new System.Windows.Forms.Button();
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
            this.panelAddMechanic = new System.Windows.Forms.Panel();
            this.buttonAddNewMechanic = new System.Windows.Forms.Button();
            this.textBoxAddMechanicFirstName = new System.Windows.Forms.TextBox();
            this.labelAddMechanicFirstName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAddMechanicName = new System.Windows.Forms.Label();
            this.textBoxAddMechanicName = new System.Windows.Forms.TextBox();
            this.panelAddOperation = new System.Windows.Forms.Panel();
            this.buttonAddNewOperation = new System.Windows.Forms.Button();
            this.textBoxAddOperationExecutionTime = new System.Windows.Forms.TextBox();
            this.labelAddOperationExecutionTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAddOperationName = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxChassis.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.groupBoxCustomers.SuspendLayout();
            this.panelAddMechanic.SuspendLayout();
            this.panelAddOperation.SuspendLayout();
            this.panelAddMaterial.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.panelAddMechanic);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddOperation);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddMaterial);
            this.splitContainer1.Size = new System.Drawing.Size(1462, 802);
            this.splitContainer1.SplitterDistance = 262;
            this.splitContainer1.TabIndex = 0;
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
            // panelAddMechanic
            // 
            this.panelAddMechanic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddMechanic.Controls.Add(this.buttonAddNewMechanic);
            this.panelAddMechanic.Controls.Add(this.textBoxAddMechanicFirstName);
            this.panelAddMechanic.Controls.Add(this.labelAddMechanicFirstName);
            this.panelAddMechanic.Controls.Add(this.label7);
            this.panelAddMechanic.Controls.Add(this.labelAddMechanicName);
            this.panelAddMechanic.Controls.Add(this.textBoxAddMechanicName);
            this.panelAddMechanic.Location = new System.Drawing.Point(580, 38);
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
            // panelAddOperation
            // 
            this.panelAddOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddOperation.Controls.Add(this.buttonAddNewOperation);
            this.panelAddOperation.Controls.Add(this.textBoxAddOperationExecutionTime);
            this.panelAddOperation.Controls.Add(this.labelAddOperationExecutionTime);
            this.panelAddOperation.Controls.Add(this.label9);
            this.panelAddOperation.Controls.Add(this.label10);
            this.panelAddOperation.Controls.Add(this.textBoxAddOperationName);
            this.panelAddOperation.Location = new System.Drawing.Point(125, 379);
            this.panelAddOperation.Name = "panelAddOperation";
            this.panelAddOperation.Size = new System.Drawing.Size(443, 211);
            this.panelAddOperation.TabIndex = 25;
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
            this.panelAddMaterial.Location = new System.Drawing.Point(18, 3);
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
            this.panelAddMechanic.ResumeLayout(false);
            this.panelAddMechanic.PerformLayout();
            this.panelAddOperation.ResumeLayout(false);
            this.panelAddOperation.PerformLayout();
            this.panelAddMaterial.ResumeLayout(false);
            this.panelAddMaterial.PerformLayout();
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
        private System.Windows.Forms.Button buttonDisplayCustomers;
        private System.Windows.Forms.GroupBox groupBoxChassis;
        private System.Windows.Forms.Button buttonAddChassis;
        private System.Windows.Forms.Button buttonDisplayOrders;
        private System.Windows.Forms.Button buttonAddMechanic;
        private System.Windows.Forms.Button buttonAddOperation;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.Button buttonAddMaterial;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonDisplayDetails;
        private System.Windows.Forms.Panel panelAddMechanic;
        private System.Windows.Forms.Button buttonAddNewMechanic;
        private System.Windows.Forms.TextBox textBoxAddMechanicFirstName;
        private System.Windows.Forms.Label labelAddMechanicFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAddMechanicName;
        private System.Windows.Forms.TextBox textBoxAddMechanicName;
        private System.Windows.Forms.Panel panelAddOperation;
        private System.Windows.Forms.Button buttonAddNewOperation;
        private System.Windows.Forms.TextBox textBoxAddOperationExecutionTime;
        private System.Windows.Forms.Label labelAddOperationExecutionTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddOperationName;
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
    }
}

