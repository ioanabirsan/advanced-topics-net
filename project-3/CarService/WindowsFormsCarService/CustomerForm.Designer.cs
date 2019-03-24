namespace WindowsFormsCarService
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.buttonEditCustomer = new System.Windows.Forms.Button();
            this.buttonDeleteCustomer = new System.Windows.Forms.Button();
            this.buttonDisplayCustomers = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonSelectCustomer = new System.Windows.Forms.Button();
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
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
            this.panelSearchCustomer = new System.Windows.Forms.Panel();
            this.panelAddCustomer = new System.Windows.Forms.Panel();
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
            this.labelSearchDisplayInfo = new System.Windows.Forms.Label();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.labelSearchEmail = new System.Windows.Forms.Label();
            this.textBoxSearchEmail = new System.Windows.Forms.TextBox();
            this.labelSearchFirstName = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.panelAddCustomerCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChassisOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerCars)).BeginInit();
            this.panelSearchCustomer.SuspendLayout();
            this.panelAddCustomer.SuspendLayout();
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
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxCustomers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.panelAddCustomer);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewCustomers);
            this.splitContainer1.Panel2.Controls.Add(this.panelAddCustomerCar);
            this.splitContainer1.Panel2.Controls.Add(this.panelSearchCustomer);
            this.splitContainer1.Size = new System.Drawing.Size(1462, 845);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCustomers.Controls.Add(this.buttonEditCustomer);
            this.groupBoxCustomers.Controls.Add(this.buttonDeleteCustomer);
            this.groupBoxCustomers.Controls.Add(this.buttonDisplayCustomers);
            this.groupBoxCustomers.Controls.Add(this.buttonAddCustomer);
            this.groupBoxCustomers.Controls.Add(this.buttonSelectCustomer);
            this.groupBoxCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomers.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(243, 270);
            this.groupBoxCustomers.TabIndex = 1;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Customers";
            // 
            // buttonEditCustomer
            // 
            this.buttonEditCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEditCustomer.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCustomer.Location = new System.Drawing.Point(6, 122);
            this.buttonEditCustomer.Name = "buttonEditCustomer";
            this.buttonEditCustomer.Size = new System.Drawing.Size(231, 42);
            this.buttonEditCustomer.TabIndex = 5;
            this.buttonEditCustomer.Text = "Edit";
            this.buttonEditCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteCustomer
            // 
            this.buttonDeleteCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteCustomer.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCustomer.Location = new System.Drawing.Point(6, 170);
            this.buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            this.buttonDeleteCustomer.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteCustomer.TabIndex = 4;
            this.buttonDeleteCustomer.Text = "Delete";
            this.buttonDeleteCustomer.UseVisualStyleBackColor = false;
            // 
            // buttonDisplayCustomers
            // 
            this.buttonDisplayCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayCustomers.Location = new System.Drawing.Point(6, 218);
            this.buttonDisplayCustomers.Name = "buttonDisplayCustomers";
            this.buttonDisplayCustomers.Size = new System.Drawing.Size(231, 42);
            this.buttonDisplayCustomers.TabIndex = 3;
            this.buttonDisplayCustomers.Text = "View all";
            this.buttonDisplayCustomers.UseVisualStyleBackColor = false;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.Location = new System.Drawing.Point(6, 74);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(231, 42);
            this.buttonAddCustomer.TabIndex = 1;
            this.buttonAddCustomer.Text = "Add";
            this.buttonAddCustomer.UseVisualStyleBackColor = false;
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
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(83, 190);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1022, 359);
            this.dataGridViewCustomers.TabIndex = 11;
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
            this.panelAddCustomerCar.Location = new System.Drawing.Point(83, 539);
            this.panelAddCustomerCar.Name = "panelAddCustomerCar";
            this.panelAddCustomerCar.Size = new System.Drawing.Size(1022, 262);
            this.panelAddCustomerCar.TabIndex = 10;
            // 
            // buttonAddCustomerCar
            // 
            this.buttonAddCustomerCar.Location = new System.Drawing.Point(28, 203);
            this.buttonAddCustomerCar.Name = "buttonAddCustomerCar";
            this.buttonAddCustomerCar.Size = new System.Drawing.Size(110, 35);
            this.buttonAddCustomerCar.TabIndex = 10;
            this.buttonAddCustomerCar.Text = "Add";
            this.buttonAddCustomerCar.UseVisualStyleBackColor = true;
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
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 8;
            // 
            // labelChassisSeries
            // 
            this.labelChassisSeries.AutoSize = true;
            this.labelChassisSeries.Location = new System.Drawing.Point(30, 87);
            this.labelChassisSeries.Name = "labelChassisSeries";
            this.labelChassisSeries.Size = new System.Drawing.Size(99, 17);
            this.labelChassisSeries.TabIndex = 6;
            this.labelChassisSeries.Text = "Chassis series";
            // 
            // textBoxChassisSeries
            // 
            this.textBoxChassisSeries.Location = new System.Drawing.Point(28, 110);
            this.textBoxChassisSeries.Name = "textBoxChassisSeries";
            this.textBoxChassisSeries.Size = new System.Drawing.Size(323, 22);
            this.textBoxChassisSeries.TabIndex = 5;
            // 
            // labelChassis
            // 
            this.labelChassis.AutoSize = true;
            this.labelChassis.Location = new System.Drawing.Point(491, 13);
            this.labelChassis.Name = "labelChassis";
            this.labelChassis.Size = new System.Drawing.Size(57, 17);
            this.labelChassis.TabIndex = 4;
            this.labelChassis.Text = "Chassis";
            // 
            // labelAutoNumber
            // 
            this.labelAutoNumber.AutoSize = true;
            this.labelAutoNumber.Location = new System.Drawing.Point(24, 13);
            this.labelAutoNumber.Name = "labelAutoNumber";
            this.labelAutoNumber.Size = new System.Drawing.Size(89, 17);
            this.labelAutoNumber.TabIndex = 3;
            this.labelAutoNumber.Text = "Auto number";
            // 
            // textBoxAutoNumber
            // 
            this.textBoxAutoNumber.Location = new System.Drawing.Point(28, 41);
            this.textBoxAutoNumber.Name = "textBoxAutoNumber";
            this.textBoxAutoNumber.Size = new System.Drawing.Size(201, 22);
            this.textBoxAutoNumber.TabIndex = 1;
            // 
            // dataGridViewCustomerCars
            // 
            this.dataGridViewCustomerCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomerCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerCars.Location = new System.Drawing.Point(0, 162);
            this.dataGridViewCustomerCars.Name = "dataGridViewCustomerCars";
            this.dataGridViewCustomerCars.RowTemplate.Height = 24;
            this.dataGridViewCustomerCars.Size = new System.Drawing.Size(1022, 323);
            this.dataGridViewCustomerCars.TabIndex = 3;
            // 
            // panelSearchCustomer
            // 
            this.panelSearchCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSearchCustomer.Controls.Add(this.labelSearchDisplayInfo);
            this.panelSearchCustomer.Controls.Add(this.buttonSearchCustomer);
            this.panelSearchCustomer.Controls.Add(this.labelSearchEmail);
            this.panelSearchCustomer.Controls.Add(this.textBoxSearchEmail);
            this.panelSearchCustomer.Controls.Add(this.labelSearchFirstName);
            this.panelSearchCustomer.Controls.Add(this.labelSearchName);
            this.panelSearchCustomer.Controls.Add(this.textBoxSearchFirstName);
            this.panelSearchCustomer.Controls.Add(this.textBoxSearchName);
            this.panelSearchCustomer.Location = new System.Drawing.Point(83, 38);
            this.panelSearchCustomer.Name = "panelSearchCustomer";
            this.panelSearchCustomer.Size = new System.Drawing.Size(1022, 131);
            this.panelSearchCustomer.TabIndex = 1;
            // 
            // panelAddCustomer
            // 
            this.panelAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddCustomer.Controls.Add(this.labelAddCustomerDisplayInfo);
            this.panelAddCustomer.Controls.Add(this.textBoxAddEmail);
            this.panelAddCustomer.Controls.Add(this.labelAddEmail);
            this.panelAddCustomer.Controls.Add(this.dataGridViewCustomerCars);
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
            this.panelAddCustomer.Location = new System.Drawing.Point(83, 38);
            this.panelAddCustomer.Name = "panelAddCustomer";
            this.panelAddCustomer.Size = new System.Drawing.Size(427, 567);
            this.panelAddCustomer.TabIndex = 11;
            // 
            // labelAddCustomerDisplayInfo
            // 
            this.labelAddCustomerDisplayInfo.AutoSize = true;
            this.labelAddCustomerDisplayInfo.Location = new System.Drawing.Point(24, 520);
            this.labelAddCustomerDisplayInfo.Name = "labelAddCustomerDisplayInfo";
            this.labelAddCustomerDisplayInfo.Size = new System.Drawing.Size(0, 17);
            this.labelAddCustomerDisplayInfo.TabIndex = 18;
            // 
            // textBoxAddEmail
            // 
            this.textBoxAddEmail.Location = new System.Drawing.Point(27, 410);
            this.textBoxAddEmail.Name = "textBoxAddEmail";
            this.textBoxAddEmail.Size = new System.Drawing.Size(344, 22);
            this.textBoxAddEmail.TabIndex = 17;
            // 
            // labelAddEmail
            // 
            this.labelAddEmail.AutoSize = true;
            this.labelAddEmail.Location = new System.Drawing.Point(24, 373);
            this.labelAddEmail.Name = "labelAddEmail";
            this.labelAddEmail.Size = new System.Drawing.Size(42, 17);
            this.labelAddEmail.TabIndex = 16;
            this.labelAddEmail.Text = "Email";
            // 
            // labelAddPhoneNumber
            // 
            this.labelAddPhoneNumber.AutoSize = true;
            this.labelAddPhoneNumber.Location = new System.Drawing.Point(24, 314);
            this.labelAddPhoneNumber.Name = "labelAddPhoneNumber";
            this.labelAddPhoneNumber.Size = new System.Drawing.Size(101, 17);
            this.labelAddPhoneNumber.TabIndex = 15;
            this.labelAddPhoneNumber.Text = "Phone number";
            // 
            // textBoxAddPhoneNumber
            // 
            this.textBoxAddPhoneNumber.Location = new System.Drawing.Point(27, 337);
            this.textBoxAddPhoneNumber.Name = "textBoxAddPhoneNumber";
            this.textBoxAddPhoneNumber.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddPhoneNumber.TabIndex = 14;
            // 
            // textBoxAddCounty
            // 
            this.textBoxAddCounty.Location = new System.Drawing.Point(27, 278);
            this.textBoxAddCounty.Name = "textBoxAddCounty";
            this.textBoxAddCounty.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddCounty.TabIndex = 13;
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Location = new System.Drawing.Point(28, 224);
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddCity.TabIndex = 12;
            // 
            // labelAddCounty
            // 
            this.labelAddCounty.AutoSize = true;
            this.labelAddCounty.Location = new System.Drawing.Point(24, 255);
            this.labelAddCounty.Name = "labelAddCounty";
            this.labelAddCounty.Size = new System.Drawing.Size(52, 17);
            this.labelAddCounty.TabIndex = 11;
            this.labelAddCounty.Text = "County";
            // 
            // labelAddCity
            // 
            this.labelAddCity.AutoSize = true;
            this.labelAddCity.Location = new System.Drawing.Point(24, 201);
            this.labelAddCity.Name = "labelAddCity";
            this.labelAddCity.Size = new System.Drawing.Size(31, 17);
            this.labelAddCity.TabIndex = 10;
            this.labelAddCity.Text = "City";
            // 
            // labelAddAddress
            // 
            this.labelAddAddress.AutoSize = true;
            this.labelAddAddress.Location = new System.Drawing.Point(24, 137);
            this.labelAddAddress.Name = "labelAddAddress";
            this.labelAddAddress.Size = new System.Drawing.Size(60, 17);
            this.labelAddAddress.TabIndex = 9;
            this.labelAddAddress.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
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
            // 
            // textBoxAddAddress
            // 
            this.textBoxAddAddress.Location = new System.Drawing.Point(28, 162);
            this.textBoxAddAddress.Name = "textBoxAddAddress";
            this.textBoxAddAddress.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddAddress.TabIndex = 5;
            // 
            // labelAddFirstName
            // 
            this.labelAddFirstName.AutoSize = true;
            this.labelAddFirstName.Location = new System.Drawing.Point(24, 77);
            this.labelAddFirstName.Name = "labelAddFirstName";
            this.labelAddFirstName.Size = new System.Drawing.Size(74, 17);
            this.labelAddFirstName.TabIndex = 4;
            this.labelAddFirstName.Text = "First name";
            // 
            // labelAddName
            // 
            this.labelAddName.AutoSize = true;
            this.labelAddName.Location = new System.Drawing.Point(24, 18);
            this.labelAddName.Name = "labelAddName";
            this.labelAddName.Size = new System.Drawing.Size(45, 17);
            this.labelAddName.TabIndex = 3;
            this.labelAddName.Text = "Name";
            // 
            // textBoxAddFirstName
            // 
            this.textBoxAddFirstName.Location = new System.Drawing.Point(27, 100);
            this.textBoxAddFirstName.Name = "textBoxAddFirstName";
            this.textBoxAddFirstName.Size = new System.Drawing.Size(254, 22);
            this.textBoxAddFirstName.TabIndex = 2;
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddName.TabIndex = 1;
            // 
            // labelSearchDisplayInfo
            // 
            this.labelSearchDisplayInfo.AutoSize = true;
            this.labelSearchDisplayInfo.Location = new System.Drawing.Point(24, 100);
            this.labelSearchDisplayInfo.Name = "labelSearchDisplayInfo";
            this.labelSearchDisplayInfo.Size = new System.Drawing.Size(0, 17);
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
            // 
            // labelSearchEmail
            // 
            this.labelSearchEmail.AutoSize = true;
            this.labelSearchEmail.Location = new System.Drawing.Point(475, 13);
            this.labelSearchEmail.Name = "labelSearchEmail";
            this.labelSearchEmail.Size = new System.Drawing.Size(42, 17);
            this.labelSearchEmail.TabIndex = 6;
            this.labelSearchEmail.Text = "Email";
            // 
            // textBoxSearchEmail
            // 
            this.textBoxSearchEmail.Location = new System.Drawing.Point(479, 41);
            this.textBoxSearchEmail.Name = "textBoxSearchEmail";
            this.textBoxSearchEmail.Size = new System.Drawing.Size(323, 22);
            this.textBoxSearchEmail.TabIndex = 5;
            // 
            // labelSearchFirstName
            // 
            this.labelSearchFirstName.AutoSize = true;
            this.labelSearchFirstName.Location = new System.Drawing.Point(242, 13);
            this.labelSearchFirstName.Name = "labelSearchFirstName";
            this.labelSearchFirstName.Size = new System.Drawing.Size(74, 17);
            this.labelSearchFirstName.TabIndex = 4;
            this.labelSearchFirstName.Text = "First name";
            // 
            // labelSearchName
            // 
            this.labelSearchName.AutoSize = true;
            this.labelSearchName.Location = new System.Drawing.Point(24, 13);
            this.labelSearchName.Name = "labelSearchName";
            this.labelSearchName.Size = new System.Drawing.Size(45, 17);
            this.labelSearchName.TabIndex = 3;
            this.labelSearchName.Text = "Name";
            // 
            // textBoxSearchFirstName
            // 
            this.textBoxSearchFirstName.Location = new System.Drawing.Point(246, 41);
            this.textBoxSearchFirstName.Name = "textBoxSearchFirstName";
            this.textBoxSearchFirstName.Size = new System.Drawing.Size(216, 22);
            this.textBoxSearchFirstName.TabIndex = 2;
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(28, 41);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(201, 22);
            this.textBoxSearchName.TabIndex = 1;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 845);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerForm";
            this.Text = "Customers";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.panelAddCustomerCar.ResumeLayout(false);
            this.panelAddCustomerCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChassisOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerCars)).EndInit();
            this.panelSearchCustomer.ResumeLayout(false);
            this.panelSearchCustomer.PerformLayout();
            this.panelAddCustomer.ResumeLayout(false);
            this.panelAddCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Button buttonDisplayCustomers;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonSelectCustomer;
        private System.Windows.Forms.Button buttonDeleteCustomer;
        private System.Windows.Forms.Button buttonEditCustomer;
        private System.Windows.Forms.Panel panelSearchCustomer;
        private System.Windows.Forms.Label labelSearchDisplayInfo;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.Label labelSearchEmail;
        private System.Windows.Forms.TextBox textBoxSearchEmail;
        private System.Windows.Forms.Label labelSearchFirstName;
        private System.Windows.Forms.Label labelSearchName;
        private System.Windows.Forms.TextBox textBoxSearchFirstName;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.DataGridView dataGridViewCustomerCars;
        private System.Windows.Forms.Panel panelAddCustomerCar;
        private System.Windows.Forms.Button buttonAddCustomerCar;
        private System.Windows.Forms.DataGridView dataGridViewChassisOptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChassisSeries;
        private System.Windows.Forms.TextBox textBoxChassisSeries;
        private System.Windows.Forms.Label labelChassis;
        private System.Windows.Forms.Label labelAutoNumber;
        private System.Windows.Forms.TextBox textBoxAutoNumber;
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
        private System.Windows.Forms.DataGridView dataGridViewCustomers;
    }
}