namespace WindowsFormsCarService
{
    partial class FormManageOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageOperation));
            this.panelAddOperation = new System.Windows.Forms.Panel();
            this.buttonAddNewOperation = new System.Windows.Forms.Button();
            this.textBoxAddOperationExecutionTime = new System.Windows.Forms.TextBox();
            this.labelAddOperationExecutionTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxAddOperationName = new System.Windows.Forms.TextBox();
            this.panelAddOperation.SuspendLayout();
            this.SuspendLayout();
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
            this.panelAddOperation.Location = new System.Drawing.Point(3, 2);
            this.panelAddOperation.Name = "panelAddOperation";
            this.panelAddOperation.Size = new System.Drawing.Size(443, 211);
            this.panelAddOperation.TabIndex = 26;
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
            this.textBoxAddOperationExecutionTime.Size = new System.Drawing.Size(111, 22);
            this.textBoxAddOperationExecutionTime.TabIndex = 10;
            // 
            // labelAddOperationExecutionTime
            // 
            this.labelAddOperationExecutionTime.AutoSize = true;
            this.labelAddOperationExecutionTime.Location = new System.Drawing.Point(24, 80);
            this.labelAddOperationExecutionTime.Name = "labelAddOperationExecutionTime";
            this.labelAddOperationExecutionTime.Size = new System.Drawing.Size(99, 17);
            this.labelAddOperationExecutionTime.TabIndex = 9;
            this.labelAddOperationExecutionTime.Text = "Execution time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 3;
            this.label10.Text = "Name";
            // 
            // textBoxAddOperationName
            // 
            this.textBoxAddOperationName.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddOperationName.Name = "textBoxAddOperationName";
            this.textBoxAddOperationName.Size = new System.Drawing.Size(368, 22);
            this.textBoxAddOperationName.TabIndex = 1;
            // 
            // FormAddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(442, 210);
            this.Controls.Add(this.panelAddOperation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddOperation";
            this.Text = "Add operation";
            this.panelAddOperation.ResumeLayout(false);
            this.panelAddOperation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddOperation;
        private System.Windows.Forms.Button buttonAddNewOperation;
        private System.Windows.Forms.TextBox textBoxAddOperationExecutionTime;
        private System.Windows.Forms.Label labelAddOperationExecutionTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxAddOperationName;
    }
}