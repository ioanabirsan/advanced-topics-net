namespace PersonalAgenda
{
    partial class FormPersonalAgenda
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
            this.label_name = new System.Windows.Forms.Label();
            this.label_first_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_other = new System.Windows.Forms.Label();
            this.button_submit = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_first_name = new System.Windows.Forms.TextBox();
            this.text_age = new System.Windows.Forms.TextBox();
            this.text_email = new System.Windows.Forms.TextBox();
            this.text_phone = new System.Windows.Forms.TextBox();
            this.text_other = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_modify = new System.Windows.Forms.Button();
            this.list_saved_contacts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(12, 60);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(57, 20);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // label_first_name
            // 
            this.label_first_name.AutoSize = true;
            this.label_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_first_name.Location = new System.Drawing.Point(12, 107);
            this.label_first_name.Name = "label_first_name";
            this.label_first_name.Size = new System.Drawing.Size(99, 20);
            this.label_first_name.TabIndex = 1;
            this.label_first_name.Text = "First name";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_age.Location = new System.Drawing.Point(12, 156);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(41, 20);
            this.label_age.TabIndex = 2;
            this.label_age.Text = "Age";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(12, 206);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(56, 20);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "Email";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(12, 256);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(61, 20);
            this.label_phone.TabIndex = 4;
            this.label_phone.Text = "Phone";
            // 
            // label_other
            // 
            this.label_other.AutoSize = true;
            this.label_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_other.Location = new System.Drawing.Point(12, 307);
            this.label_other.Name = "label_other";
            this.label_other.Size = new System.Drawing.Size(56, 20);
            this.label_other.TabIndex = 5;
            this.label_other.Text = "Other";
            // 
            // button_submit
            // 
            this.button_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_submit.Location = new System.Drawing.Point(16, 386);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(96, 34);
            this.button_submit.TabIndex = 6;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_name.Location = new System.Drawing.Point(134, 60);
            this.text_name.MaxLength = 20;
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(343, 27);
            this.text_name.TabIndex = 7;
            this.text_name.Validating += new System.ComponentModel.CancelEventHandler(this.text_name_Validating);
            // 
            // text_first_name
            // 
            this.text_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_first_name.Location = new System.Drawing.Point(134, 107);
            this.text_first_name.MaxLength = 30;
            this.text_first_name.Name = "text_first_name";
            this.text_first_name.Size = new System.Drawing.Size(343, 27);
            this.text_first_name.TabIndex = 8;
            this.text_first_name.Validating += new System.ComponentModel.CancelEventHandler(this.text_first_name_Validating);
            // 
            // text_age
            // 
            this.text_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_age.Location = new System.Drawing.Point(134, 156);
            this.text_age.MaxLength = 3;
            this.text_age.Name = "text_age";
            this.text_age.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.text_age.Size = new System.Drawing.Size(76, 27);
            this.text_age.TabIndex = 9;
            this.text_age.TextChanged += new System.EventHandler(this.text_age_TextChanged);
            this.text_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_age_KeyPress);
            this.text_age.Validating += new System.ComponentModel.CancelEventHandler(this.text_age_Validating);
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.Location = new System.Drawing.Point(134, 206);
            this.text_email.MaxLength = 50;
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(343, 27);
            this.text_email.TabIndex = 10;
            this.text_email.Validating += new System.ComponentModel.CancelEventHandler(this.text_email_Validating);
            // 
            // text_phone
            // 
            this.text_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_phone.Location = new System.Drawing.Point(134, 256);
            this.text_phone.MaxLength = 12;
            this.text_phone.Name = "text_phone";
            this.text_phone.Size = new System.Drawing.Size(191, 27);
            this.text_phone.TabIndex = 11;
            this.text_phone.Validating += new System.ComponentModel.CancelEventHandler(this.text_phone_Validating);
            // 
            // text_other
            // 
            this.text_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_other.Location = new System.Drawing.Point(134, 307);
            this.text_other.MaxLength = 50;
            this.text_other.Name = "text_other";
            this.text_other.Size = new System.Drawing.Size(343, 27);
            this.text_other.TabIndex = 12;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(134, 386);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(106, 34);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_modify
            // 
            this.button_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modify.Location = new System.Drawing.Point(260, 386);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(107, 34);
            this.button_modify.TabIndex = 14;
            this.button_modify.Text = "Modify";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // list_saved_contacts
            // 
            this.list_saved_contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_saved_contacts.FormattingEnabled = true;
            this.list_saved_contacts.ItemHeight = 20;
            this.list_saved_contacts.Location = new System.Drawing.Point(548, 26);
            this.list_saved_contacts.Name = "list_saved_contacts";
            this.list_saved_contacts.ScrollAlwaysVisible = true;
            this.list_saved_contacts.Size = new System.Drawing.Size(449, 404);
            this.list_saved_contacts.TabIndex = 15;
            // 
            // FormPersonalAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.list_saved_contacts);
            this.Controls.Add(this.button_modify);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.text_other);
            this.Controls.Add(this.text_phone);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.text_age);
            this.Controls.Add(this.text_first_name);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.label_other);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_first_name);
            this.Controls.Add(this.label_name);
            this.Name = "FormPersonalAgenda";
            this.Text = "Contact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_first_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_other;
        private System.Windows.Forms.Button button_submit;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_first_name;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.TextBox text_phone;
        private System.Windows.Forms.TextBox text_other;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.ListBox list_saved_contacts;
    }
}

