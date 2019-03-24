namespace WindowsFormsCarService
{
    partial class FormManageChassis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageChassis));
            this.panelAddChassis = new System.Windows.Forms.Panel();
            this.buttonAddNewChassis = new System.Windows.Forms.Button();
            this.textBoxChassisName = new System.Windows.Forms.TextBox();
            this.labelChassisName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelChassisCode = new System.Windows.Forms.Label();
            this.textBoxChassisCode = new System.Windows.Forms.TextBox();
            this.panelAddChassis.SuspendLayout();
            this.SuspendLayout();
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
            this.panelAddChassis.Location = new System.Drawing.Point(0, 1);
            this.panelAddChassis.Name = "panelAddChassis";
            this.panelAddChassis.Size = new System.Drawing.Size(436, 213);
            this.panelAddChassis.TabIndex = 10;
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
            this.textBoxChassisName.Size = new System.Drawing.Size(368, 22);
            this.textBoxChassisName.TabIndex = 10;
            // 
            // labelChassisName
            // 
            this.labelChassisName.AutoSize = true;
            this.labelChassisName.Location = new System.Drawing.Point(24, 80);
            this.labelChassisName.Name = "labelChassisName";
            this.labelChassisName.Size = new System.Drawing.Size(45, 17);
            this.labelChassisName.TabIndex = 9;
            this.labelChassisName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 8;
            // 
            // labelChassisCode
            // 
            this.labelChassisCode.AutoSize = true;
            this.labelChassisCode.Location = new System.Drawing.Point(24, 13);
            this.labelChassisCode.Name = "labelChassisCode";
            this.labelChassisCode.Size = new System.Drawing.Size(41, 17);
            this.labelChassisCode.TabIndex = 3;
            this.labelChassisCode.Text = "Code";
            // 
            // textBoxChassisCode
            // 
            this.textBoxChassisCode.Location = new System.Drawing.Point(28, 41);
            this.textBoxChassisCode.Name = "textBoxChassisCode";
            this.textBoxChassisCode.Size = new System.Drawing.Size(93, 22);
            this.textBoxChassisCode.TabIndex = 1;
            // 
            // FormAddChassis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.Controls.Add(this.panelAddChassis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddChassis";
            this.Text = "Add chassis";
            this.panelAddChassis.ResumeLayout(false);
            this.panelAddChassis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddChassis;
        private System.Windows.Forms.Button buttonAddNewChassis;
        private System.Windows.Forms.TextBox textBoxChassisName;
        private System.Windows.Forms.Label labelChassisName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelChassisCode;
        private System.Windows.Forms.TextBox textBoxChassisCode;
    }
}