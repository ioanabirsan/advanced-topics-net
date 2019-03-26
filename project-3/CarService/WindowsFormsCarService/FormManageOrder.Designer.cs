namespace WindowsFormsCarService
{
    partial class FormManageOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageOrder));
            this.panelAddOrder = new System.Windows.Forms.Panel();
            this.checkBoxAddOrderInService = new System.Windows.Forms.CheckBox();
            this.labelAddDetailsCars = new System.Windows.Forms.Label();
            this.dataGridViewClientCars = new System.Windows.Forms.DataGridView();
            this.labelAddOrder = new System.Windows.Forms.Label();
            this.dataGridViewAddOrderSelectClient = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAddOrderKm = new System.Windows.Forms.TextBox();
            this.labelAddOrderKm = new System.Windows.Forms.Label();
            this.comboBoxAddOrderState = new System.Windows.Forms.ComboBox();
            this.groupBoxCommandDetails = new System.Windows.Forms.GroupBox();
            this.labelAddDetailsOrders = new System.Windows.Forms.Label();
            this.labelAddDetailsImages = new System.Windows.Forms.Label();
            this.labelAddDetailsMechanics = new System.Windows.Forms.Label();
            this.labelAddDetailsOperations = new System.Windows.Forms.Label();
            this.labelAddDetailsMaterials = new System.Windows.Forms.Label();
            this.labelAddDetails = new System.Windows.Forms.Label();
            this.dataGridViewAddDetailByOrder = new System.Windows.Forms.DataGridView();
            this.buttonAddDetails = new System.Windows.Forms.Button();
            this.dataGridViewAddDetailsImages = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddDetailsMechanics = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddDetailsOperations = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddDetailsMaterials = new System.Windows.Forms.DataGridView();
            this.textBoxAddOrderPiecesValue = new System.Windows.Forms.TextBox();
            this.labelAddOrderPiecesValue = new System.Windows.Forms.Label();
            this.labelAddOrderState = new System.Windows.Forms.Label();
            this.labelAddOrderDescription = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddNewOrder = new System.Windows.Forms.Button();
            this.textBoxAddOrderDescription = new System.Windows.Forms.TextBox();
            this.labelAddOrderEndDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAddOrderStartDate = new System.Windows.Forms.Label();
            this.panelAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOrderSelectClient)).BeginInit();
            this.groupBoxCommandDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailByOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMechanics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddOrder
            // 
            this.panelAddOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddOrder.Controls.Add(this.checkBoxAddOrderInService);
            this.panelAddOrder.Controls.Add(this.labelAddDetailsCars);
            this.panelAddOrder.Controls.Add(this.dataGridViewClientCars);
            this.panelAddOrder.Controls.Add(this.labelAddOrder);
            this.panelAddOrder.Controls.Add(this.dataGridViewAddOrderSelectClient);
            this.panelAddOrder.Controls.Add(this.label4);
            this.panelAddOrder.Controls.Add(this.textBoxAddOrderKm);
            this.panelAddOrder.Controls.Add(this.labelAddOrderKm);
            this.panelAddOrder.Controls.Add(this.comboBoxAddOrderState);
            this.panelAddOrder.Controls.Add(this.groupBoxCommandDetails);
            this.panelAddOrder.Controls.Add(this.textBoxAddOrderPiecesValue);
            this.panelAddOrder.Controls.Add(this.labelAddOrderPiecesValue);
            this.panelAddOrder.Controls.Add(this.labelAddOrderState);
            this.panelAddOrder.Controls.Add(this.labelAddOrderDescription);
            this.panelAddOrder.Controls.Add(this.dateTimePickerEndDate);
            this.panelAddOrder.Controls.Add(this.dateTimePickerStartDate);
            this.panelAddOrder.Controls.Add(this.buttonAddNewOrder);
            this.panelAddOrder.Controls.Add(this.textBoxAddOrderDescription);
            this.panelAddOrder.Controls.Add(this.labelAddOrderEndDate);
            this.panelAddOrder.Controls.Add(this.label5);
            this.panelAddOrder.Controls.Add(this.labelAddOrderStartDate);
            this.panelAddOrder.Location = new System.Drawing.Point(12, 12);
            this.panelAddOrder.Name = "panelAddOrder";
            this.panelAddOrder.Size = new System.Drawing.Size(1182, 753);
            this.panelAddOrder.TabIndex = 13;
            // 
            // checkBoxAddOrderInService
            // 
            this.checkBoxAddOrderInService.AutoSize = true;
            this.checkBoxAddOrderInService.Location = new System.Drawing.Point(452, 111);
            this.checkBoxAddOrderInService.Name = "checkBoxAddOrderInService";
            this.checkBoxAddOrderInService.Size = new System.Drawing.Size(90, 21);
            this.checkBoxAddOrderInService.TabIndex = 32;
            this.checkBoxAddOrderInService.Text = "In service";
            this.checkBoxAddOrderInService.UseVisualStyleBackColor = true;
            this.checkBoxAddOrderInService.Click += new System.EventHandler(this.checkBoxAddOrderInService_Click);
            // 
            // labelAddDetailsCars
            // 
            this.labelAddDetailsCars.AccessibleName = "labelAddOrderClient";
            this.labelAddDetailsCars.AutoSize = true;
            this.labelAddDetailsCars.Location = new System.Drawing.Point(25, 162);
            this.labelAddDetailsCars.Name = "labelAddDetailsCars";
            this.labelAddDetailsCars.Size = new System.Drawing.Size(74, 17);
            this.labelAddDetailsCars.TabIndex = 31;
            this.labelAddDetailsCars.Text = "Client cars";
            // 
            // dataGridViewClientCars
            // 
            this.dataGridViewClientCars.AccessibleName = "";
            this.dataGridViewClientCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClientCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientCars.Location = new System.Drawing.Point(28, 182);
            this.dataGridViewClientCars.Name = "dataGridViewClientCars";
            this.dataGridViewClientCars.RowTemplate.Height = 24;
            this.dataGridViewClientCars.Size = new System.Drawing.Size(409, 102);
            this.dataGridViewClientCars.TabIndex = 30;
            // 
            // labelAddOrder
            // 
            this.labelAddOrder.AutoSize = true;
            this.labelAddOrder.Location = new System.Drawing.Point(601, 173);
            this.labelAddOrder.Name = "labelAddOrder";
            this.labelAddOrder.Size = new System.Drawing.Size(0, 17);
            this.labelAddOrder.TabIndex = 29;
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
            this.dataGridViewAddOrderSelectClient.Size = new System.Drawing.Size(409, 102);
            this.dataGridViewAddOrderSelectClient.TabIndex = 28;
            this.dataGridViewAddOrderSelectClient.SelectionChanged += new System.EventHandler(this.dataGridViewAddOrderSelectClient_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AccessibleName = "labelAddOrderClient";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Client";
            // 
            // textBoxAddOrderKm
            // 
            this.textBoxAddOrderKm.Enabled = false;
            this.textBoxAddOrderKm.Location = new System.Drawing.Point(570, 110);
            this.textBoxAddOrderKm.Name = "textBoxAddOrderKm";
            this.textBoxAddOrderKm.Size = new System.Drawing.Size(161, 22);
            this.textBoxAddOrderKm.TabIndex = 26;
            this.textBoxAddOrderKm.Text = "0";
            // 
            // labelAddOrderKm
            // 
            this.labelAddOrderKm.AutoSize = true;
            this.labelAddOrderKm.Location = new System.Drawing.Point(567, 90);
            this.labelAddOrderKm.Name = "labelAddOrderKm";
            this.labelAddOrderKm.Size = new System.Drawing.Size(28, 17);
            this.labelAddOrderKm.TabIndex = 25;
            this.labelAddOrderKm.Text = "Km";
            // 
            // comboBoxAddOrderState
            // 
            this.comboBoxAddOrderState.FormattingEnabled = true;
            this.comboBoxAddOrderState.Items.AddRange(new object[] {
            "Waiting",
            "In execution",
            "Rejected"});
            this.comboBoxAddOrderState.Location = new System.Drawing.Point(1029, 41);
            this.comboBoxAddOrderState.Name = "comboBoxAddOrderState";
            this.comboBoxAddOrderState.Size = new System.Drawing.Size(121, 24);
            this.comboBoxAddOrderState.TabIndex = 23;
            // 
            // groupBoxCommandDetails
            // 
            this.groupBoxCommandDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCommandDetails.Controls.Add(this.labelAddDetailsOrders);
            this.groupBoxCommandDetails.Controls.Add(this.labelAddDetailsImages);
            this.groupBoxCommandDetails.Controls.Add(this.labelAddDetailsMechanics);
            this.groupBoxCommandDetails.Controls.Add(this.labelAddDetailsOperations);
            this.groupBoxCommandDetails.Controls.Add(this.labelAddDetailsMaterials);
            this.groupBoxCommandDetails.Controls.Add(this.labelAddDetails);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailByOrder);
            this.groupBoxCommandDetails.Controls.Add(this.buttonAddDetails);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsImages);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsMechanics);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsOperations);
            this.groupBoxCommandDetails.Controls.Add(this.dataGridViewAddDetailsMaterials);
            this.groupBoxCommandDetails.Location = new System.Drawing.Point(28, 300);
            this.groupBoxCommandDetails.Name = "groupBoxCommandDetails";
            this.groupBoxCommandDetails.Size = new System.Drawing.Size(1122, 434);
            this.groupBoxCommandDetails.TabIndex = 22;
            this.groupBoxCommandDetails.TabStop = false;
            this.groupBoxCommandDetails.Text = "Details";
            // 
            // labelAddDetailsOrders
            // 
            this.labelAddDetailsOrders.AutoSize = true;
            this.labelAddDetailsOrders.Location = new System.Drawing.Point(759, 142);
            this.labelAddDetailsOrders.Name = "labelAddDetailsOrders";
            this.labelAddDetailsOrders.Size = new System.Drawing.Size(52, 17);
            this.labelAddDetailsOrders.TabIndex = 14;
            this.labelAddDetailsOrders.Text = "Orders";
            // 
            // labelAddDetailsImages
            // 
            this.labelAddDetailsImages.AutoSize = true;
            this.labelAddDetailsImages.Location = new System.Drawing.Point(394, 205);
            this.labelAddDetailsImages.Name = "labelAddDetailsImages";
            this.labelAddDetailsImages.Size = new System.Drawing.Size(53, 17);
            this.labelAddDetailsImages.TabIndex = 13;
            this.labelAddDetailsImages.Text = "Images";
            // 
            // labelAddDetailsMechanics
            // 
            this.labelAddDetailsMechanics.AutoSize = true;
            this.labelAddDetailsMechanics.Location = new System.Drawing.Point(31, 205);
            this.labelAddDetailsMechanics.Name = "labelAddDetailsMechanics";
            this.labelAddDetailsMechanics.Size = new System.Drawing.Size(75, 17);
            this.labelAddDetailsMechanics.TabIndex = 12;
            this.labelAddDetailsMechanics.Text = "Mechanics";
            // 
            // labelAddDetailsOperations
            // 
            this.labelAddDetailsOperations.AutoSize = true;
            this.labelAddDetailsOperations.Location = new System.Drawing.Point(394, 31);
            this.labelAddDetailsOperations.Name = "labelAddDetailsOperations";
            this.labelAddDetailsOperations.Size = new System.Drawing.Size(78, 17);
            this.labelAddDetailsOperations.TabIndex = 11;
            this.labelAddDetailsOperations.Text = "Operations";
            // 
            // labelAddDetailsMaterials
            // 
            this.labelAddDetailsMaterials.AutoSize = true;
            this.labelAddDetailsMaterials.Location = new System.Drawing.Point(31, 31);
            this.labelAddDetailsMaterials.Name = "labelAddDetailsMaterials";
            this.labelAddDetailsMaterials.Size = new System.Drawing.Size(65, 17);
            this.labelAddDetailsMaterials.TabIndex = 10;
            this.labelAddDetailsMaterials.Text = "Materials";
            // 
            // labelAddDetails
            // 
            this.labelAddDetails.AutoSize = true;
            this.labelAddDetails.Location = new System.Drawing.Point(31, 470);
            this.labelAddDetails.Name = "labelAddDetails";
            this.labelAddDetails.Size = new System.Drawing.Size(0, 17);
            this.labelAddDetails.TabIndex = 9;
            // 
            // dataGridViewAddDetailByOrder
            // 
            this.dataGridViewAddDetailByOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddDetailByOrder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddDetailByOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddDetailByOrder.Location = new System.Drawing.Point(761, 162);
            this.dataGridViewAddDetailByOrder.Name = "dataGridViewAddDetailByOrder";
            this.dataGridViewAddDetailByOrder.RowTemplate.Height = 24;
            this.dataGridViewAddDetailByOrder.Size = new System.Drawing.Size(337, 134);
            this.dataGridViewAddDetailByOrder.TabIndex = 7;
            // 
            // buttonAddDetails
            // 
            this.buttonAddDetails.Location = new System.Drawing.Point(34, 383);
            this.buttonAddDetails.Name = "buttonAddDetails";
            this.buttonAddDetails.Size = new System.Drawing.Size(132, 36);
            this.buttonAddDetails.TabIndex = 6;
            this.buttonAddDetails.Text = "Add";
            this.buttonAddDetails.UseVisualStyleBackColor = true;
            this.buttonAddDetails.Click += new System.EventHandler(this.buttonAddDetails_Click);
            // 
            // dataGridViewAddDetailsImages
            // 
            this.dataGridViewAddDetailsImages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddDetailsImages.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAddDetailsImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddDetailsImages.Location = new System.Drawing.Point(397, 225);
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
            this.dataGridViewAddDetailsMechanics.Location = new System.Drawing.Point(34, 225);
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
            this.dataGridViewAddDetailsMaterials.Location = new System.Drawing.Point(34, 51);
            this.dataGridViewAddDetailsMaterials.Name = "dataGridViewAddDetailsMaterials";
            this.dataGridViewAddDetailsMaterials.RowTemplate.Height = 24;
            this.dataGridViewAddDetailsMaterials.Size = new System.Drawing.Size(337, 134);
            this.dataGridViewAddDetailsMaterials.TabIndex = 0;
            // 
            // textBoxAddOrderPiecesValue
            // 
            this.textBoxAddOrderPiecesValue.Enabled = false;
            this.textBoxAddOrderPiecesValue.Location = new System.Drawing.Point(737, 110);
            this.textBoxAddOrderPiecesValue.Name = "textBoxAddOrderPiecesValue";
            this.textBoxAddOrderPiecesValue.Size = new System.Drawing.Size(115, 22);
            this.textBoxAddOrderPiecesValue.TabIndex = 21;
            // 
            // labelAddOrderPiecesValue
            // 
            this.labelAddOrderPiecesValue.AutoSize = true;
            this.labelAddOrderPiecesValue.Location = new System.Drawing.Point(749, 90);
            this.labelAddOrderPiecesValue.Name = "labelAddOrderPiecesValue";
            this.labelAddOrderPiecesValue.Size = new System.Drawing.Size(88, 17);
            this.labelAddOrderPiecesValue.TabIndex = 20;
            this.labelAddOrderPiecesValue.Text = "Pieces value";
            // 
            // labelAddOrderState
            // 
            this.labelAddOrderState.AutoSize = true;
            this.labelAddOrderState.Location = new System.Drawing.Point(1026, 18);
            this.labelAddOrderState.Name = "labelAddOrderState";
            this.labelAddOrderState.Size = new System.Drawing.Size(41, 17);
            this.labelAddOrderState.TabIndex = 18;
            this.labelAddOrderState.Text = "State";
            // 
            // labelAddOrderDescription
            // 
            this.labelAddOrderDescription.AutoSize = true;
            this.labelAddOrderDescription.Location = new System.Drawing.Point(855, 87);
            this.labelAddOrderDescription.Name = "labelAddOrderDescription";
            this.labelAddOrderDescription.Size = new System.Drawing.Size(79, 17);
            this.labelAddOrderDescription.TabIndex = 14;
            this.labelAddOrderDescription.Text = "Description";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(735, 43);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(288, 22);
            this.dateTimePickerEndDate.TabIndex = 13;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(443, 43);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(288, 22);
            this.dateTimePickerStartDate.TabIndex = 12;
            // 
            // buttonAddNewOrder
            // 
            this.buttonAddNewOrder.Location = new System.Drawing.Point(443, 163);
            this.buttonAddNewOrder.Name = "buttonAddNewOrder";
            this.buttonAddNewOrder.Size = new System.Drawing.Size(118, 34);
            this.buttonAddNewOrder.TabIndex = 11;
            this.buttonAddNewOrder.Text = "Add";
            this.buttonAddNewOrder.UseVisualStyleBackColor = true;
            this.buttonAddNewOrder.Click += new System.EventHandler(this.buttonAddNewOrder_Click);
            // 
            // textBoxAddOrderDescription
            // 
            this.textBoxAddOrderDescription.Location = new System.Drawing.Point(858, 107);
            this.textBoxAddOrderDescription.Multiline = true;
            this.textBoxAddOrderDescription.Name = "textBoxAddOrderDescription";
            this.textBoxAddOrderDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAddOrderDescription.Size = new System.Drawing.Size(292, 27);
            this.textBoxAddOrderDescription.TabIndex = 10;
            // 
            // labelAddOrderEndDate
            // 
            this.labelAddOrderEndDate.AutoSize = true;
            this.labelAddOrderEndDate.Location = new System.Drawing.Point(732, 18);
            this.labelAddOrderEndDate.Name = "labelAddOrderEndDate";
            this.labelAddOrderEndDate.Size = new System.Drawing.Size(65, 17);
            this.labelAddOrderEndDate.TabIndex = 9;
            this.labelAddOrderEndDate.Text = "End date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 8;
            // 
            // labelAddOrderStartDate
            // 
            this.labelAddOrderStartDate.AutoSize = true;
            this.labelAddOrderStartDate.Location = new System.Drawing.Point(440, 18);
            this.labelAddOrderStartDate.Name = "labelAddOrderStartDate";
            this.labelAddOrderStartDate.Size = new System.Drawing.Size(70, 17);
            this.labelAddOrderStartDate.TabIndex = 3;
            this.labelAddOrderStartDate.Text = "Start date";
            // 
            // FormManageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1208, 779);
            this.Controls.Add(this.panelAddOrder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageOrder";
            this.Text = "Add order";
            this.Load += new System.EventHandler(this.FormManageOrder_Load);
            this.panelAddOrder.ResumeLayout(false);
            this.panelAddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOrderSelectClient)).EndInit();
            this.groupBoxCommandDetails.ResumeLayout(false);
            this.groupBoxCommandDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailByOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMechanics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddDetailsMaterials)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddOrder;
        private System.Windows.Forms.DataGridView dataGridViewAddOrderSelectClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAddOrderKm;
        private System.Windows.Forms.Label labelAddOrderKm;
        private System.Windows.Forms.ComboBox comboBoxAddOrderState;
        private System.Windows.Forms.GroupBox groupBoxCommandDetails;
        private System.Windows.Forms.Button buttonAddDetails;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsImages;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsMechanics;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsOperations;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailsMaterials;
        private System.Windows.Forms.TextBox textBoxAddOrderPiecesValue;
        private System.Windows.Forms.Label labelAddOrderPiecesValue;
        private System.Windows.Forms.Label labelAddOrderState;
        private System.Windows.Forms.Label labelAddOrderDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Button buttonAddNewOrder;
        private System.Windows.Forms.TextBox textBoxAddOrderDescription;
        private System.Windows.Forms.Label labelAddOrderEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAddOrderStartDate;
        private System.Windows.Forms.DataGridView dataGridViewAddDetailByOrder;
        private System.Windows.Forms.Label labelAddOrder;
        private System.Windows.Forms.Label labelAddDetails;
        private System.Windows.Forms.DataGridView dataGridViewClientCars;
        private System.Windows.Forms.Label labelAddDetailsCars;
        private System.Windows.Forms.Label labelAddDetailsOrders;
        private System.Windows.Forms.Label labelAddDetailsImages;
        private System.Windows.Forms.Label labelAddDetailsMechanics;
        private System.Windows.Forms.Label labelAddDetailsOperations;
        private System.Windows.Forms.Label labelAddDetailsMaterials;
        private System.Windows.Forms.CheckBox checkBoxAddOrderInService;
    }
}