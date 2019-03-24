namespace WindowsFormsCarService
{
    partial class FormDisplayChassis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayChassis));
            this.dataGridViewDisplayChassis = new System.Windows.Forms.DataGridView();
            this.buttonUpdateChassis = new System.Windows.Forms.Button();
            this.buttonDeleteChassis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayChassis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplayChassis
            // 
            this.dataGridViewDisplayChassis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayChassis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayChassis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayChassis.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDisplayChassis.Name = "dataGridViewDisplayChassis";
            this.dataGridViewDisplayChassis.RowTemplate.Height = 24;
            this.dataGridViewDisplayChassis.Size = new System.Drawing.Size(497, 467);
            this.dataGridViewDisplayChassis.TabIndex = 0;
            // 
            // buttonUpdateChassis
            // 
            this.buttonUpdateChassis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateChassis.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateChassis.Location = new System.Drawing.Point(12, 499);
            this.buttonUpdateChassis.Name = "buttonUpdateChassis";
            this.buttonUpdateChassis.Size = new System.Drawing.Size(231, 42);
            this.buttonUpdateChassis.TabIndex = 13;
            this.buttonUpdateChassis.Text = "Update";
            this.buttonUpdateChassis.UseVisualStyleBackColor = false;
            this.buttonUpdateChassis.Click += new System.EventHandler(this.buttonUpdateChassis_Click);
            // 
            // buttonDeleteChassis
            // 
            this.buttonDeleteChassis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteChassis.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteChassis.Location = new System.Drawing.Point(278, 499);
            this.buttonDeleteChassis.Name = "buttonDeleteChassis";
            this.buttonDeleteChassis.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteChassis.TabIndex = 14;
            this.buttonDeleteChassis.Text = "Delete";
            this.buttonDeleteChassis.UseVisualStyleBackColor = false;
            this.buttonDeleteChassis.Click += new System.EventHandler(this.buttonDeleteChassis_Click);
            // 
            // FormDisplayChassis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(522, 553);
            this.Controls.Add(this.buttonDeleteChassis);
            this.Controls.Add(this.buttonUpdateChassis);
            this.Controls.Add(this.dataGridViewDisplayChassis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDisplayChassis";
            this.Text = "Display chassis";
            this.Load += new System.EventHandler(this.FormDisplayChassis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayChassis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplayChassis;
        private System.Windows.Forms.Button buttonUpdateChassis;
        private System.Windows.Forms.Button buttonDeleteChassis;
    }
}