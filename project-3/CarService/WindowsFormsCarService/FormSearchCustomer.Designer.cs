namespace WindowsFormsCarService
{
    partial class FormSearchCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearchCustomer));
            this.panelSearchCustomer = new System.Windows.Forms.Panel();
            this.labelSearchDisplayInfo = new System.Windows.Forms.Label();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.labelSearchEmail = new System.Windows.Forms.Label();
            this.textBoxSearchEmail = new System.Windows.Forms.TextBox();
            this.labelSearchFirstName = new System.Windows.Forms.Label();
            this.labelSearchName = new System.Windows.Forms.Label();
            this.textBoxSearchFirstName = new System.Windows.Forms.TextBox();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomerCars = new System.Windows.Forms.DataGridView();
            this.panelAddCustomerCar = new System.Windows.Forms.Panel();
            this.buttonAddCustomerCar = new System.Windows.Forms.Button();
            this.dataGridViewChassisOptions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChassisSeries = new System.Windows.Forms.Label();
            this.textBoxChassisSeries = new System.Windows.Forms.TextBox();
            this.labelChassis = new System.Windows.Forms.Label();
            this.labelAutoNumber = new System.Windows.Forms.Label();
            this.textBoxAutoNumber = new System.Windows.Forms.TextBox();
            this.panelSearchCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerCars)).BeginInit();
            this.panelAddCustomerCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChassisOptions)).BeginInit();
            this.SuspendLayout();
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
            this.panelSearchCustomer.Location = new System.Drawing.Point(2, 46);
            this.panelSearchCustomer.Name = "panelSearchCustomer";
            this.panelSearchCustomer.Size = new System.Drawing.Size(1022, 131);
            this.panelSearchCustomer.TabIndex = 1;
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
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click_1);
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
            // dataGridViewCustomerCars
            // 
            this.dataGridViewCustomerCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomerCars.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomerCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomerCars.Location = new System.Drawing.Point(2, 220);
            this.dataGridViewCustomerCars.Name = "dataGridViewCustomerCars";
            this.dataGridViewCustomerCars.RowTemplate.Height = 24;
            this.dataGridViewCustomerCars.Size = new System.Drawing.Size(1022, 248);
            this.dataGridViewCustomerCars.TabIndex = 3;
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
            this.panelAddCustomerCar.Location = new System.Drawing.Point(2, 509);
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
            this.buttonAddCustomerCar.Click += new System.EventHandler(this.buttonAddCustomerCar_Click_1);
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
            // FormSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1021, 764);
            this.Controls.Add(this.panelAddCustomerCar);
            this.Controls.Add(this.dataGridViewCustomerCars);
            this.Controls.Add(this.panelSearchCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearchCustomer";
            this.Text = "Search customer";
            this.panelSearchCustomer.ResumeLayout(false);
            this.panelSearchCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomerCars)).EndInit();
            this.panelAddCustomerCar.ResumeLayout(false);
            this.panelAddCustomerCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChassisOptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}