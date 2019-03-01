namespace ToUpper
{
    partial class FormEventType
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
            this.label_current_input = new System.Windows.Forms.Label();
            this.label_uppercase = new System.Windows.Forms.Label();
            this.text_input = new System.Windows.Forms.TextBox();
            this.text_uppercase = new System.Windows.Forms.TextBox();
            this.label_whithout_whitespaces = new System.Windows.Forms.Label();
            this.text_whitout_spaces = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label_current_input
            // 
            this.label_current_input.AutoSize = true;
            this.label_current_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_input.Location = new System.Drawing.Point(27, 55);
            this.label_current_input.Name = "label_current_input";
            this.label_current_input.Size = new System.Drawing.Size(124, 25);
            this.label_current_input.TabIndex = 0;
            this.label_current_input.Text = "Current input";
            // 
            // label_uppercase
            // 
            this.label_uppercase.AutoSize = true;
            this.label_uppercase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_uppercase.Location = new System.Drawing.Point(27, 232);
            this.label_uppercase.Name = "label_uppercase";
            this.label_uppercase.Size = new System.Drawing.Size(107, 25);
            this.label_uppercase.TabIndex = 1;
            this.label_uppercase.Text = "Uppercase";
            // 
            // text_input
            // 
            this.text_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_input.Location = new System.Drawing.Point(31, 88);
            this.text_input.MaxLength = 200;
            this.text_input.Multiline = true;
            this.text_input.Name = "text_input";
            this.text_input.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_input.Size = new System.Drawing.Size(639, 119);
            this.text_input.TabIndex = 2;
            this.text_input.TextChanged += new System.EventHandler(this.text_input_TextChanged);
            // 
            // text_uppercase
            // 
            this.text_uppercase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_uppercase.Location = new System.Drawing.Point(31, 264);
            this.text_uppercase.MaxLength = 200;
            this.text_uppercase.Multiline = true;
            this.text_uppercase.Name = "text_uppercase";
            this.text_uppercase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_uppercase.Size = new System.Drawing.Size(639, 123);
            this.text_uppercase.TabIndex = 3;
            // 
            // label_whithout_whitespaces
            // 
            this.label_whithout_whitespaces.AutoSize = true;
            this.label_whithout_whitespaces.Location = new System.Drawing.Point(27, 410);
            this.label_whithout_whitespaces.Name = "label_whithout_whitespaces";
            this.label_whithout_whitespaces.Size = new System.Drawing.Size(192, 25);
            this.label_whithout_whitespaces.TabIndex = 4;
            this.label_whithout_whitespaces.Text = "Without whitespaces";
            // 
            // text_whitout_spaces
            // 
            this.text_whitout_spaces.Location = new System.Drawing.Point(31, 444);
            this.text_whitout_spaces.Multiline = true;
            this.text_whitout_spaces.Name = "text_whitout_spaces";
            this.text_whitout_spaces.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.text_whitout_spaces.Size = new System.Drawing.Size(639, 123);
            this.text_whitout_spaces.TabIndex = 5;
            // 
            // FormEventType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 678);
            this.Controls.Add(this.text_whitout_spaces);
            this.Controls.Add(this.label_whithout_whitespaces);
            this.Controls.Add(this.text_uppercase);
            this.Controls.Add(this.text_input);
            this.Controls.Add(this.label_uppercase);
            this.Controls.Add(this.label_current_input);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEventType";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.FormEventType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_current_input;
        private System.Windows.Forms.Label label_uppercase;
        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.TextBox text_uppercase;
        private System.Windows.Forms.Label label_whithout_whitespaces;
        private System.Windows.Forms.TextBox text_whitout_spaces;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

