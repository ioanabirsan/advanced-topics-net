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
            this.groupBoxCustomers = new System.Windows.Forms.GroupBox();
            this.buttonDisplayCustomers = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.buttonSelectCustomer = new System.Windows.Forms.Button();
            this.buttonDisplayChassis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.groupBoxChassis.SuspendLayout();
            this.groupBoxOrders.SuspendLayout();
            this.groupBoxCustomers.SuspendLayout();
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
            this.groupBoxDetails.Location = new System.Drawing.Point(12, 478);
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
            this.buttonDisplayDetails.Click += new System.EventHandler(this.buttonDisplayDetails_Click);
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
            this.buttonAddMechanic.Text = "Add mecanic";
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
            this.groupBoxChassis.Controls.Add(this.buttonDisplayChassis);
            this.groupBoxChassis.Controls.Add(this.buttonAddChassis);
            this.groupBoxChassis.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChassis.Location = new System.Drawing.Point(12, 344);
            this.groupBoxChassis.Name = "groupBoxChassis";
            this.groupBoxChassis.Size = new System.Drawing.Size(243, 128);
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
            this.groupBoxOrders.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrders.Location = new System.Drawing.Point(12, 210);
            this.groupBoxOrders.Name = "groupBoxOrders";
            this.groupBoxOrders.Size = new System.Drawing.Size(243, 128);
            this.groupBoxOrders.TabIndex = 3;
            this.groupBoxOrders.TabStop = false;
            this.groupBoxOrders.Text = "Orders";
            // 
            // buttonDisplayOrders
            // 
            this.buttonDisplayOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayOrders.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayOrders.Location = new System.Drawing.Point(6, 74);
            this.buttonDisplayOrders.Name = "buttonDisplayOrders";
            this.buttonDisplayOrders.Size = new System.Drawing.Size(231, 42);
            this.buttonDisplayOrders.TabIndex = 3;
            this.buttonDisplayOrders.Text = "View all";
            this.buttonDisplayOrders.UseVisualStyleBackColor = false;
            this.buttonDisplayOrders.Click += new System.EventHandler(this.buttonDisplayOrders_Click);
            // 
            // buttonAddOrder
            // 
            this.buttonAddOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddOrder.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOrder.Location = new System.Drawing.Point(6, 26);
            this.buttonAddOrder.Name = "buttonAddOrder";
            this.buttonAddOrder.Size = new System.Drawing.Size(231, 42);
            this.buttonAddOrder.TabIndex = 1;
            this.buttonAddOrder.Text = "Add order";
            this.buttonAddOrder.UseVisualStyleBackColor = false;
            this.buttonAddOrder.Click += new System.EventHandler(this.buttonAddOrder_Click);
            // 
            // groupBoxCustomers
            // 
            this.groupBoxCustomers.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCustomers.Controls.Add(this.buttonDisplayCustomers);
            this.groupBoxCustomers.Controls.Add(this.buttonAddCustomer);
            this.groupBoxCustomers.Controls.Add(this.buttonSelectCustomer);
            this.groupBoxCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomers.Location = new System.Drawing.Point(12, 30);
            this.groupBoxCustomers.Name = "groupBoxCustomers";
            this.groupBoxCustomers.Size = new System.Drawing.Size(243, 174);
            this.groupBoxCustomers.TabIndex = 0;
            this.groupBoxCustomers.TabStop = false;
            this.groupBoxCustomers.Text = "Customers";
            // 
            // buttonDisplayCustomers
            // 
            this.buttonDisplayCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayCustomers.Location = new System.Drawing.Point(6, 122);
            this.buttonDisplayCustomers.Name = "buttonDisplayCustomers";
            this.buttonDisplayCustomers.Size = new System.Drawing.Size(231, 42);
            this.buttonDisplayCustomers.TabIndex = 3;
            this.buttonDisplayCustomers.Text = "View all";
            this.buttonDisplayCustomers.UseVisualStyleBackColor = false;
            this.buttonDisplayCustomers.Click += new System.EventHandler(this.buttonDisplayCustomers_Click);
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
            // buttonDisplayChassis
            // 
            this.buttonDisplayChassis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDisplayChassis.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayChassis.Location = new System.Drawing.Point(6, 74);
            this.buttonDisplayChassis.Name = "buttonDisplayChassis";
            this.buttonDisplayChassis.Size = new System.Drawing.Size(231, 42);
            this.buttonDisplayChassis.TabIndex = 2;
            this.buttonDisplayChassis.Text = "View all";
            this.buttonDisplayChassis.UseVisualStyleBackColor = false;
            this.buttonDisplayChassis.Click += new System.EventHandler(this.buttonDisplayChassis_Click);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxChassis.ResumeLayout(false);
            this.groupBoxOrders.ResumeLayout(false);
            this.groupBoxCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxCustomers;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonSelectCustomer;
        private System.Windows.Forms.GroupBox groupBoxOrders;
        private System.Windows.Forms.Button buttonAddOrder;
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
        private System.Windows.Forms.Button buttonDisplayChassis;
    }
}

