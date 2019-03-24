namespace WindowsFormsCarService
{
    partial class FormDisplayOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayOrders));
            this.dataGridViewDisplayOrders = new System.Windows.Forms.DataGridView();
            this.buttonUpdateOrders = new System.Windows.Forms.Button();
            this.buttonDeleteOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplayOrders
            // 
            this.dataGridViewDisplayOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDisplayOrders.Name = "dataGridViewDisplayOrders";
            this.dataGridViewDisplayOrders.RowTemplate.Height = 24;
            this.dataGridViewDisplayOrders.Size = new System.Drawing.Size(1393, 687);
            this.dataGridViewDisplayOrders.TabIndex = 0;
            // 
            // buttonUpdateOrders
            // 
            this.buttonUpdateOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateOrders.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateOrders.Location = new System.Drawing.Point(12, 717);
            this.buttonUpdateOrders.Name = "buttonUpdateOrders";
            this.buttonUpdateOrders.Size = new System.Drawing.Size(231, 42);
            this.buttonUpdateOrders.TabIndex = 13;
            this.buttonUpdateOrders.Text = "Update";
            this.buttonUpdateOrders.UseVisualStyleBackColor = false;
            this.buttonUpdateOrders.Click += new System.EventHandler(this.buttonUpdateOrders_Click);
            // 
            // buttonDeleteOrders
            // 
            this.buttonDeleteOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteOrders.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteOrders.Location = new System.Drawing.Point(267, 717);
            this.buttonDeleteOrders.Name = "buttonDeleteOrders";
            this.buttonDeleteOrders.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteOrders.TabIndex = 14;
            this.buttonDeleteOrders.Text = "Delete";
            this.buttonDeleteOrders.UseVisualStyleBackColor = false;
            this.buttonDeleteOrders.Click += new System.EventHandler(this.buttonDeleteOrders_Click);
            // 
            // FormDisplayOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1417, 771);
            this.Controls.Add(this.buttonDeleteOrders);
            this.Controls.Add(this.buttonUpdateOrders);
            this.Controls.Add(this.dataGridViewDisplayOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDisplayOrders";
            this.Text = "Display orders";
            this.Load += new System.EventHandler(this.FormDisplayOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplayOrders;
        private System.Windows.Forms.Button buttonUpdateOrders;
        private System.Windows.Forms.Button buttonDeleteOrders;
    }
}