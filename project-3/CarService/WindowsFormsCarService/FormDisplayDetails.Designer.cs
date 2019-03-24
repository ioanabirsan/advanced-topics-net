namespace WindowsFormsCarService
{
    partial class FormDisplayDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisplayDetails));
            this.tabControlDisplayDetails = new System.Windows.Forms.TabControl();
            this.tabPageMechanics = new System.Windows.Forms.TabPage();
            this.buttonDeleteMecanic = new System.Windows.Forms.Button();
            this.buttonUpdateMecanic = new System.Windows.Forms.Button();
            this.dataGridViewDisplayMechanics = new System.Windows.Forms.DataGridView();
            this.tabPageOperations = new System.Windows.Forms.TabPage();
            this.tabPageMaterials = new System.Windows.Forms.TabPage();
            this.tabPageImages = new System.Windows.Forms.TabPage();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonUpdateImage = new System.Windows.Forms.Button();
            this.dataGridViewDisplayImage = new System.Windows.Forms.DataGridView();
            this.dataGridViewDisplayMaterials = new System.Windows.Forms.DataGridView();
            this.buttonUpdateMaterial = new System.Windows.Forms.Button();
            this.buttonDeleteMaterial = new System.Windows.Forms.Button();
            this.dataGridViewDisplayOperations = new System.Windows.Forms.DataGridView();
            this.buttonUpdateOperation = new System.Windows.Forms.Button();
            this.buttonDeleteOperation = new System.Windows.Forms.Button();
            this.tabControlDisplayDetails.SuspendLayout();
            this.tabPageMechanics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayMechanics)).BeginInit();
            this.tabPageOperations.SuspendLayout();
            this.tabPageMaterials.SuspendLayout();
            this.tabPageImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayMaterials)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDisplayDetails
            // 
            this.tabControlDisplayDetails.Controls.Add(this.tabPageMechanics);
            this.tabControlDisplayDetails.Controls.Add(this.tabPageOperations);
            this.tabControlDisplayDetails.Controls.Add(this.tabPageMaterials);
            this.tabControlDisplayDetails.Controls.Add(this.tabPageImages);
            this.tabControlDisplayDetails.Location = new System.Drawing.Point(12, 12);
            this.tabControlDisplayDetails.Name = "tabControlDisplayDetails";
            this.tabControlDisplayDetails.SelectedIndex = 0;
            this.tabControlDisplayDetails.Size = new System.Drawing.Size(1202, 785);
            this.tabControlDisplayDetails.TabIndex = 0;
            // 
            // tabPageMechanics
            // 
            this.tabPageMechanics.Controls.Add(this.buttonDeleteMecanic);
            this.tabPageMechanics.Controls.Add(this.buttonUpdateMecanic);
            this.tabPageMechanics.Controls.Add(this.dataGridViewDisplayMechanics);
            this.tabPageMechanics.Location = new System.Drawing.Point(4, 25);
            this.tabPageMechanics.Name = "tabPageMechanics";
            this.tabPageMechanics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMechanics.Size = new System.Drawing.Size(1194, 756);
            this.tabPageMechanics.TabIndex = 0;
            this.tabPageMechanics.Text = "Mechanics";
            this.tabPageMechanics.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteMecanic
            // 
            this.buttonDeleteMecanic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteMecanic.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMecanic.Location = new System.Drawing.Point(335, 570);
            this.buttonDeleteMecanic.Name = "buttonDeleteMecanic";
            this.buttonDeleteMecanic.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteMecanic.TabIndex = 16;
            this.buttonDeleteMecanic.Text = "Delete";
            this.buttonDeleteMecanic.UseVisualStyleBackColor = false;
            this.buttonDeleteMecanic.Click += new System.EventHandler(this.buttonDeleteMecanic_Click);
            // 
            // buttonUpdateMecanic
            // 
            this.buttonUpdateMecanic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateMecanic.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateMecanic.Location = new System.Drawing.Point(26, 570);
            this.buttonUpdateMecanic.Name = "buttonUpdateMecanic";
            this.buttonUpdateMecanic.Size = new System.Drawing.Size(231, 42);
            this.buttonUpdateMecanic.TabIndex = 15;
            this.buttonUpdateMecanic.Text = "Update";
            this.buttonUpdateMecanic.UseVisualStyleBackColor = false;
            this.buttonUpdateMecanic.Click += new System.EventHandler(this.buttonUpdateMecanic_Click_1);
            // 
            // dataGridViewDisplayMechanics
            // 
            this.dataGridViewDisplayMechanics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayMechanics.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayMechanics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayMechanics.Location = new System.Drawing.Point(26, 25);
            this.dataGridViewDisplayMechanics.Name = "dataGridViewDisplayMechanics";
            this.dataGridViewDisplayMechanics.RowTemplate.Height = 24;
            this.dataGridViewDisplayMechanics.Size = new System.Drawing.Size(540, 516);
            this.dataGridViewDisplayMechanics.TabIndex = 1;
            // 
            // tabPageOperations
            // 
            this.tabPageOperations.Controls.Add(this.buttonDeleteOperation);
            this.tabPageOperations.Controls.Add(this.buttonUpdateOperation);
            this.tabPageOperations.Controls.Add(this.dataGridViewDisplayOperations);
            this.tabPageOperations.Location = new System.Drawing.Point(4, 25);
            this.tabPageOperations.Name = "tabPageOperations";
            this.tabPageOperations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperations.Size = new System.Drawing.Size(1194, 756);
            this.tabPageOperations.TabIndex = 1;
            this.tabPageOperations.Text = "Operations";
            this.tabPageOperations.UseVisualStyleBackColor = true;
            // 
            // tabPageMaterials
            // 
            this.tabPageMaterials.Controls.Add(this.buttonDeleteMaterial);
            this.tabPageMaterials.Controls.Add(this.buttonUpdateMaterial);
            this.tabPageMaterials.Controls.Add(this.dataGridViewDisplayMaterials);
            this.tabPageMaterials.Location = new System.Drawing.Point(4, 25);
            this.tabPageMaterials.Name = "tabPageMaterials";
            this.tabPageMaterials.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaterials.Size = new System.Drawing.Size(1194, 756);
            this.tabPageMaterials.TabIndex = 2;
            this.tabPageMaterials.Text = "Materials";
            this.tabPageMaterials.UseVisualStyleBackColor = true;
            // 
            // tabPageImages
            // 
            this.tabPageImages.Controls.Add(this.buttonDeleteImage);
            this.tabPageImages.Controls.Add(this.buttonUpdateImage);
            this.tabPageImages.Controls.Add(this.dataGridViewDisplayImage);
            this.tabPageImages.Location = new System.Drawing.Point(4, 25);
            this.tabPageImages.Name = "tabPageImages";
            this.tabPageImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImages.Size = new System.Drawing.Size(1194, 756);
            this.tabPageImages.TabIndex = 3;
            this.tabPageImages.Text = "Images";
            this.tabPageImages.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteImage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteImage.Location = new System.Drawing.Point(328, 551);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteImage.TabIndex = 15;
            this.buttonDeleteImage.Text = "Delete";
            this.buttonDeleteImage.UseVisualStyleBackColor = false;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // buttonUpdateImage
            // 
            this.buttonUpdateImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateImage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateImage.Location = new System.Drawing.Point(19, 551);
            this.buttonUpdateImage.Name = "buttonUpdateImage";
            this.buttonUpdateImage.Size = new System.Drawing.Size(231, 42);
            this.buttonUpdateImage.TabIndex = 14;
            this.buttonUpdateImage.Text = "Update";
            this.buttonUpdateImage.UseVisualStyleBackColor = false;
            this.buttonUpdateImage.Click += new System.EventHandler(this.buttonUpdateImage_Click);
            // 
            // dataGridViewDisplayImage
            // 
            this.dataGridViewDisplayImage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayImage.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayImage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayImage.Location = new System.Drawing.Point(19, 15);
            this.dataGridViewDisplayImage.Name = "dataGridViewDisplayImage";
            this.dataGridViewDisplayImage.RowTemplate.Height = 24;
            this.dataGridViewDisplayImage.Size = new System.Drawing.Size(1152, 516);
            this.dataGridViewDisplayImage.TabIndex = 0;
            // 
            // dataGridViewDisplayMaterials
            // 
            this.dataGridViewDisplayMaterials.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayMaterials.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayMaterials.Location = new System.Drawing.Point(24, 19);
            this.dataGridViewDisplayMaterials.Name = "dataGridViewDisplayMaterials";
            this.dataGridViewDisplayMaterials.RowTemplate.Height = 24;
            this.dataGridViewDisplayMaterials.Size = new System.Drawing.Size(1152, 516);
            this.dataGridViewDisplayMaterials.TabIndex = 1;
            // 
            // buttonUpdateMaterial
            // 
            this.buttonUpdateMaterial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateMaterial.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateMaterial.Location = new System.Drawing.Point(24, 559);
            this.buttonUpdateMaterial.Name = "buttonUpdateMaterial";
            this.buttonUpdateMaterial.Size = new System.Drawing.Size(231, 42);
            this.buttonUpdateMaterial.TabIndex = 15;
            this.buttonUpdateMaterial.Text = "Update";
            this.buttonUpdateMaterial.UseVisualStyleBackColor = false;
            this.buttonUpdateMaterial.Click += new System.EventHandler(this.buttonUpdateMaterial_Click);
            // 
            // buttonDeleteMaterial
            // 
            this.buttonDeleteMaterial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteMaterial.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteMaterial.Location = new System.Drawing.Point(315, 559);
            this.buttonDeleteMaterial.Name = "buttonDeleteMaterial";
            this.buttonDeleteMaterial.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteMaterial.TabIndex = 16;
            this.buttonDeleteMaterial.Text = "Delete";
            this.buttonDeleteMaterial.UseVisualStyleBackColor = false;
            this.buttonDeleteMaterial.Click += new System.EventHandler(this.buttonDeleteMaterial_Click);
            // 
            // dataGridViewDisplayOperations
            // 
            this.dataGridViewDisplayOperations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayOperations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDisplayOperations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayOperations.Location = new System.Drawing.Point(18, 20);
            this.dataGridViewDisplayOperations.Name = "dataGridViewDisplayOperations";
            this.dataGridViewDisplayOperations.RowTemplate.Height = 24;
            this.dataGridViewDisplayOperations.Size = new System.Drawing.Size(540, 516);
            this.dataGridViewDisplayOperations.TabIndex = 2;
            // 
            // buttonUpdateOperation
            // 
            this.buttonUpdateOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUpdateOperation.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateOperation.Location = new System.Drawing.Point(18, 563);
            this.buttonUpdateOperation.Name = "buttonUpdateOperation";
            this.buttonUpdateOperation.Size = new System.Drawing.Size(231, 42);
            this.buttonUpdateOperation.TabIndex = 16;
            this.buttonUpdateOperation.Text = "Update";
            this.buttonUpdateOperation.UseVisualStyleBackColor = false;
            this.buttonUpdateOperation.Click += new System.EventHandler(this.buttonUpdateOperation_Click);
            // 
            // buttonDeleteOperation
            // 
            this.buttonDeleteOperation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonDeleteOperation.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteOperation.Location = new System.Drawing.Point(327, 563);
            this.buttonDeleteOperation.Name = "buttonDeleteOperation";
            this.buttonDeleteOperation.Size = new System.Drawing.Size(231, 42);
            this.buttonDeleteOperation.TabIndex = 17;
            this.buttonDeleteOperation.Text = "Delete";
            this.buttonDeleteOperation.UseVisualStyleBackColor = false;
            this.buttonDeleteOperation.Click += new System.EventHandler(this.buttonDeleteOperation_Click);
            // 
            // FormDisplayDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1226, 809);
            this.Controls.Add(this.tabControlDisplayDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDisplayDetails";
            this.Text = "Display details";
            this.Load += new System.EventHandler(this.FormDisplayDetails_Load);
            this.tabControlDisplayDetails.ResumeLayout(false);
            this.tabPageMechanics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayMechanics)).EndInit();
            this.tabPageOperations.ResumeLayout(false);
            this.tabPageMaterials.ResumeLayout(false);
            this.tabPageImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayMaterials)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayOperations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDisplayDetails;
        private System.Windows.Forms.TabPage tabPageMechanics;
        private System.Windows.Forms.TabPage tabPageOperations;
        private System.Windows.Forms.TabPage tabPageMaterials;
        private System.Windows.Forms.TabPage tabPageImages;
        private System.Windows.Forms.DataGridView dataGridViewDisplayImage;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.Button buttonUpdateImage;
        private System.Windows.Forms.DataGridView dataGridViewDisplayMechanics;
        private System.Windows.Forms.Button buttonUpdateMecanic;
        private System.Windows.Forms.Button buttonDeleteMecanic;
        private System.Windows.Forms.DataGridView dataGridViewDisplayMaterials;
        private System.Windows.Forms.Button buttonDeleteMaterial;
        private System.Windows.Forms.Button buttonUpdateMaterial;
        private System.Windows.Forms.Button buttonDeleteOperation;
        private System.Windows.Forms.Button buttonUpdateOperation;
        private System.Windows.Forms.DataGridView dataGridViewDisplayOperations;
    }
}