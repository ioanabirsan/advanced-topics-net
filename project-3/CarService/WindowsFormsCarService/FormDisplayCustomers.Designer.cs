namespace WindowsFormsCarService
{
    partial class FormDisplayCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayCustomers));
            this.dataGridViewCustomers = new System.Windows.Forms.DataGridView();
            this.buttonUpdateCustomers = new System.Windows.Forms.Button();
            this.buttonDeleteCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            this.dataGridViewCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomers.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCustomers.Name = "dataGridViewCustomers";
            this.dataGridViewCustomers.RowTemplate.Height = 24;
            this.dataGridViewCustomers.Size = new System.Drawing.Size(1384, 631);
            this.dataGridViewCustomers.TabIndex = 11;
            // 
            // buttonUpdateCustomers
            // 
            this.buttonUpdateCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCustomers.Location = new System.Drawing.Point(12, 667);
            this.buttonUpdateCustomers.Name = "buttonUpdateCustomers";
            this.buttonUpdateCustomers.Size = new System.Drawing.Size(231, 42);
            this.buttonUpdateCustomers.TabIndex = 12;
            this.buttonUpdateCustomers.Text = "Update";
            this.buttonUpdateCustomers.UseVisualStyleBackColor = false;
            this.buttonUpdateCustomers.Click += new System.EventHandler(this.buttonUpdateCustomers_Click);
            // 
            // buttonDeleteCustomers
            // 
            this.buttonDeleteCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteCustomers.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCustomers.Location = new System.Drawing.Point(281, 667);
            this.buttonDeleteCustomers.Name = "buttonDeleteCustomers";
            this.buttonDeleteCustomers.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteCustomers.TabIndex = 13;
            this.buttonDeleteCustomers.Text = "Delete";
            this.buttonDeleteCustomers.UseVisualStyleBackColor = false;
            this.buttonDeleteCustomers.Click += new System.EventHandler(this.buttonDeleteCustomers_Click);
            // 
            // FormDisplayCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1408, 721);
            this.Controls.Add(this.buttonDeleteCustomers);
            this.Controls.Add(this.buttonUpdateCustomers);
            this.Controls.Add(this.dataGridViewCustomers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDisplayCustomers";
            this.Text = "Display customers";
            this.Load += new System.EventHandler(this.FormDisplayCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button buttonUpdateCustomers;
        private System.Windows.Forms.Button buttonDeleteCustomers;
    }
}