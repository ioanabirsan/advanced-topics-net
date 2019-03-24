namespace WindowsFormsCarService
{
    partial class FormManageMechanic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageMechanic));
            this.panelAddMechanic = new System.Windows.Forms.Panel();
            this.buttonAddNewMechanic = new System.Windows.Forms.Button();
            this.textBoxAddMechanicFirstName = new System.Windows.Forms.TextBox();
            this.labelAddMechanicFirstName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAddMechanicName = new System.Windows.Forms.Label();
            this.textBoxAddMechanicName = new System.Windows.Forms.TextBox();
            this.panelAddMechanic.SuspendLayout();
            this.SuspendLayout();
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
            this.panelAddMechanic.Location = new System.Drawing.Point(0, 0);
            this.panelAddMechanic.Name = "panelAddMechanic";
            this.panelAddMechanic.Size = new System.Drawing.Size(374, 213);
            this.panelAddMechanic.TabIndex = 27;
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
            this.textBoxAddMechanicFirstName.Size = new System.Drawing.Size(224, 22);
            this.textBoxAddMechanicFirstName.TabIndex = 10;
            // 
            // labelAddMechanicFirstName
            // 
            this.labelAddMechanicFirstName.AutoSize = true;
            this.labelAddMechanicFirstName.Location = new System.Drawing.Point(24, 80);
            this.labelAddMechanicFirstName.Name = "labelAddMechanicFirstName";
            this.labelAddMechanicFirstName.Size = new System.Drawing.Size(74, 17);
            this.labelAddMechanicFirstName.TabIndex = 9;
            this.labelAddMechanicFirstName.Text = "First name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 8;
            // 
            // labelAddMechanicName
            // 
            this.labelAddMechanicName.AutoSize = true;
            this.labelAddMechanicName.Location = new System.Drawing.Point(24, 13);
            this.labelAddMechanicName.Name = "labelAddMechanicName";
            this.labelAddMechanicName.Size = new System.Drawing.Size(45, 17);
            this.labelAddMechanicName.TabIndex = 3;
            this.labelAddMechanicName.Text = "Name";
            // 
            // textBoxAddMechanicName
            // 
            this.textBoxAddMechanicName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddMechanicName.Name = "textBoxAddMechanicName";
            this.textBoxAddMechanicName.Size = new System.Drawing.Size(224, 22);
            this.textBoxAddMechanicName.TabIndex = 1;
            // 
            // FormAddMechanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(372, 210);
            this.Controls.Add(this.panelAddMechanic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddMechanic";
            this.Text = "Add mechanic";
            this.panelAddMechanic.ResumeLayout(false);
            this.panelAddMechanic.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddMechanic;
        private System.Windows.Forms.Button buttonAddNewMechanic;
        private System.Windows.Forms.TextBox textBoxAddMechanicFirstName;
        private System.Windows.Forms.Label labelAddMechanicFirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelAddMechanicName;
        private System.Windows.Forms.TextBox textBoxAddMechanicName;
    }
}