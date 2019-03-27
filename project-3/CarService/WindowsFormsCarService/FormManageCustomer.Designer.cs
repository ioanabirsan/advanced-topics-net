namespace WindowsFormsCarService
{
    partial class FormManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageCustomer));
            this.panelAddCustomer = new System.Windows.Forms.Panel();
            this.checkBoxAddClientEmail = new System.Windows.Forms.CheckBox();
            this.buttonNewCustomer = new System.Windows.Forms.Button();
            this.labelAddCustomerDisplayInfo = new System.Windows.Forms.Label();
            this.textBoxAddEmail = new System.Windows.Forms.TextBox();
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
            this.panelAddCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddCustomer
            // 
            this.panelAddCustomer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddCustomer.Controls.Add(this.checkBoxAddClientEmail);
            this.panelAddCustomer.Controls.Add(this.buttonNewCustomer);
            this.panelAddCustomer.Controls.Add(this.labelAddCustomerDisplayInfo);
            this.panelAddCustomer.Controls.Add(this.textBoxAddEmail);
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
            this.panelAddCustomer.Location = new System.Drawing.Point(12, 12);
            this.panelAddCustomer.Name = "panelAddCustomer";
            this.panelAddCustomer.Size = new System.Drawing.Size(427, 567);
            this.panelAddCustomer.TabIndex = 2;
            // 
            // checkBoxAddClientEmail
            // 
            this.checkBoxAddClientEmail.AutoSize = true;
            this.checkBoxAddClientEmail.Location = new System.Drawing.Point(27, 383);
            this.checkBoxAddClientEmail.Name = "checkBoxAddClientEmail";
            this.checkBoxAddClientEmail.Size = new System.Drawing.Size(64, 21);
            this.checkBoxAddClientEmail.TabIndex = 20;
            this.checkBoxAddClientEmail.Text = "Email";
            this.checkBoxAddClientEmail.UseVisualStyleBackColor = true;
            this.checkBoxAddClientEmail.CheckedChanged += new System.EventHandler(this.checkBoxAddClientEmail_CheckedChanged);
            // 
            // buttonNewCustomer
            // 
            this.buttonNewCustomer.Location = new System.Drawing.Point(192, 459);
            this.buttonNewCustomer.Name = "buttonNewCustomer";
            this.buttonNewCustomer.Size = new System.Drawing.Size(142, 36);
            this.buttonNewCustomer.TabIndex = 19;
            this.buttonNewCustomer.Text = "New";
            this.buttonNewCustomer.UseVisualStyleBackColor = true;
            this.buttonNewCustomer.Click += new System.EventHandler(this.buttonNewCustomer_Click);
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
            this.textBoxAddEmail.TextChanged += new System.EventHandler(this.textBoxAddEmail_TextChanged);
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
            this.textBoxAddPhoneNumber.TextChanged += new System.EventHandler(this.textBoxAddPhoneNumber_TextChanged);
            // 
            // textBoxAddCounty
            // 
            this.textBoxAddCounty.Location = new System.Drawing.Point(27, 278);
            this.textBoxAddCounty.Name = "textBoxAddCounty";
            this.textBoxAddCounty.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddCounty.TabIndex = 13;
            this.textBoxAddCounty.TextChanged += new System.EventHandler(this.textBoxAddCounty_TextChanged);
            // 
            // textBoxAddCity
            // 
            this.textBoxAddCity.Location = new System.Drawing.Point(28, 224);
            this.textBoxAddCity.Name = "textBoxAddCity";
            this.textBoxAddCity.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddCity.TabIndex = 12;
            this.textBoxAddCity.TextChanged += new System.EventHandler(this.textBoxAddCity_TextChanged);
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
            this.buttonAddNewCustomer.Click += new System.EventHandler(this.buttonAddNewCustomer_Click);
            // 
            // textBoxAddAddress
            // 
            this.textBoxAddAddress.Location = new System.Drawing.Point(28, 162);
            this.textBoxAddAddress.Name = "textBoxAddAddress";
            this.textBoxAddAddress.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddAddress.TabIndex = 5;
            this.textBoxAddAddress.TextChanged += new System.EventHandler(this.textBoxAddAddress_TextChanged);
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
            this.textBoxAddFirstName.TextChanged += new System.EventHandler(this.textBoxAddFirstName_TextChanged);
            // 
            // textBoxAddName
            // 
            this.textBoxAddName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddName.Name = "textBoxAddName";
            this.textBoxAddName.Size = new System.Drawing.Size(253, 22);
            this.textBoxAddName.TabIndex = 1;
            this.textBoxAddName.TextChanged += new System.EventHandler(this.textBoxAddName_TextChanged);
            // 
            // FormManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(454, 593);
            this.Controls.Add(this.panelAddCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageCustomer";
            this.Text = "Add customer";
            this.panelAddCustomer.ResumeLayout(false);
            this.panelAddCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddCustomer;
        private System.Windows.Forms.Label labelAddCustomerDisplayInfo;
        private System.Windows.Forms.TextBox textBoxAddEmail;
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
        private System.Windows.Forms.Button buttonNewCustomer;
        private System.Windows.Forms.CheckBox checkBoxAddClientEmail;
    }
}