namespace WindowsFormsCarService
{
    partial class FormManageImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageImage));
            this.panelAddNewImage = new System.Windows.Forms.Panel();
            this.textBoxAddImageDescription = new System.Windows.Forms.TextBox();
            this.labelAddImageDescription = new System.Windows.Forms.Label();
            this.buttonAddImagePhotoUpload = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.dateTimePickerAddImageDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddNewImage = new System.Windows.Forms.Button();
            this.labelAddImageDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelAddImageTitle = new System.Windows.Forms.Label();
            this.textBoxAddImageTitle = new System.Windows.Forms.TextBox();
            this.buttonNewImage = new System.Windows.Forms.Button();
            this.labelAddImage = new System.Windows.Forms.Label();
            this.panelAddNewImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAddNewImage
            // 
            this.panelAddNewImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddNewImage.Controls.Add(this.labelAddImage);
            this.panelAddNewImage.Controls.Add(this.buttonNewImage);
            this.panelAddNewImage.Controls.Add(this.textBoxAddImageDescription);
            this.panelAddNewImage.Controls.Add(this.labelAddImageDescription);
            this.panelAddNewImage.Controls.Add(this.buttonAddImagePhotoUpload);
            this.panelAddNewImage.Controls.Add(this.pictureBoxImage);
            this.panelAddNewImage.Controls.Add(this.dateTimePickerAddImageDate);
            this.panelAddNewImage.Controls.Add(this.buttonAddNewImage);
            this.panelAddNewImage.Controls.Add(this.labelAddImageDate);
            this.panelAddNewImage.Controls.Add(this.label12);
            this.panelAddNewImage.Controls.Add(this.labelAddImageTitle);
            this.panelAddNewImage.Controls.Add(this.textBoxAddImageTitle);
            this.panelAddNewImage.Location = new System.Drawing.Point(12, 12);
            this.panelAddNewImage.Name = "panelAddNewImage";
            this.panelAddNewImage.Size = new System.Drawing.Size(443, 631);
            this.panelAddNewImage.TabIndex = 26;
            // 
            // textBoxAddImageDescription
            // 
            this.textBoxAddImageDescription.Location = new System.Drawing.Point(28, 171);
            this.textBoxAddImageDescription.Name = "textBoxAddImageDescription";
            this.textBoxAddImageDescription.Size = new System.Drawing.Size(385, 22);
            this.textBoxAddImageDescription.TabIndex = 35;
            // 
            // labelAddImageDescription
            // 
            this.labelAddImageDescription.AutoSize = true;
            this.labelAddImageDescription.Location = new System.Drawing.Point(26, 146);
            this.labelAddImageDescription.Name = "labelAddImageDescription";
            this.labelAddImageDescription.Size = new System.Drawing.Size(79, 17);
            this.labelAddImageDescription.TabIndex = 34;
            this.labelAddImageDescription.Text = "Description";
            // 
            // buttonAddImagePhotoUpload
            // 
            this.buttonAddImagePhotoUpload.Location = new System.Drawing.Point(26, 207);
            this.buttonAddImagePhotoUpload.Name = "buttonAddImagePhotoUpload";
            this.buttonAddImagePhotoUpload.Size = new System.Drawing.Size(111, 36);
            this.buttonAddImagePhotoUpload.TabIndex = 33;
            this.buttonAddImagePhotoUpload.Text = "Upload";
            this.buttonAddImagePhotoUpload.UseVisualStyleBackColor = true;
            this.buttonAddImagePhotoUpload.Click += new System.EventHandler(this.buttonAddImagePhotoUpload_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(26, 253);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(385, 284);
            this.pictureBoxImage.TabIndex = 32;
            this.pictureBoxImage.TabStop = false;
            // 
            // dateTimePickerAddImageDate
            // 
            this.dateTimePickerAddImageDate.Location = new System.Drawing.Point(28, 106);
            this.dateTimePickerAddImageDate.Name = "dateTimePickerAddImageDate";
            this.dateTimePickerAddImageDate.Size = new System.Drawing.Size(288, 22);
            this.dateTimePickerAddImageDate.TabIndex = 29;
            // 
            // buttonAddNewImage
            // 
            this.buttonAddNewImage.Location = new System.Drawing.Point(26, 556);
            this.buttonAddNewImage.Name = "buttonAddNewImage";
            this.buttonAddNewImage.Size = new System.Drawing.Size(111, 34);
            this.buttonAddNewImage.TabIndex = 11;
            this.buttonAddNewImage.Text = "Add";
            this.buttonAddNewImage.UseVisualStyleBackColor = true;
            this.buttonAddNewImage.Click += new System.EventHandler(this.buttonAddNewImage_Click);
            // 
            // labelAddImageDate
            // 
            this.labelAddImageDate.AutoSize = true;
            this.labelAddImageDate.Location = new System.Drawing.Point(24, 80);
            this.labelAddImageDate.Name = "labelAddImageDate";
            this.labelAddImageDate.Size = new System.Drawing.Size(38, 17);
            this.labelAddImageDate.TabIndex = 9;
            this.labelAddImageDate.Text = "Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 17);
            this.label12.TabIndex = 8;
            // 
            // labelAddImageTitle
            // 
            this.labelAddImageTitle.AutoSize = true;
            this.labelAddImageTitle.Location = new System.Drawing.Point(24, 13);
            this.labelAddImageTitle.Name = "labelAddImageTitle";
            this.labelAddImageTitle.Size = new System.Drawing.Size(35, 17);
            this.labelAddImageTitle.TabIndex = 3;
            this.labelAddImageTitle.Text = "Title";
            // 
            // textBoxAddImageTitle
            // 
            this.textBoxAddImageTitle.Location = new System.Drawing.Point(28, 41);
            this.textBoxAddImageTitle.Name = "textBoxAddImageTitle";
            this.textBoxAddImageTitle.Size = new System.Drawing.Size(385, 22);
            this.textBoxAddImageTitle.TabIndex = 1;
            // 
            // buttonNewImage
            // 
            this.buttonNewImage.Location = new System.Drawing.Point(163, 556);
            this.buttonNewImage.Name = "buttonNewImage";
            this.buttonNewImage.Size = new System.Drawing.Size(111, 34);
            this.buttonNewImage.TabIndex = 36;
            this.buttonNewImage.Text = "New";
            this.buttonNewImage.UseVisualStyleBackColor = true;
            this.buttonNewImage.Click += new System.EventHandler(this.buttonNewImage_Click);
            // 
            // labelAddImage
            // 
            this.labelAddImage.AutoSize = true;
            this.labelAddImage.Location = new System.Drawing.Point(26, 604);
            this.labelAddImage.Name = "labelAddImage";
            this.labelAddImage.Size = new System.Drawing.Size(0, 17);
            this.labelAddImage.TabIndex = 37;
            // 
            // FormManageImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(466, 655);
            this.Controls.Add(this.panelAddNewImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManageImage";
            this.Text = "Add image";
            this.panelAddNewImage.ResumeLayout(false);
            this.panelAddNewImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddNewImage;
        private System.Windows.Forms.TextBox textBoxAddImageDescription;
        private System.Windows.Forms.Label labelAddImageDescription;
        private System.Windows.Forms.Button buttonAddImagePhotoUpload;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddImageDate;
        private System.Windows.Forms.Button buttonAddNewImage;
        private System.Windows.Forms.Label labelAddImageDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelAddImageTitle;
        private System.Windows.Forms.TextBox textBoxAddImageTitle;
        private System.Windows.Forms.Button buttonNewImage;
        private System.Windows.Forms.Label labelAddImage;
    }
}