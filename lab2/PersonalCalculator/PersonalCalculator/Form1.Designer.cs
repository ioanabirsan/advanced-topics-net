namespace PersonalCalculator
{
    partial class FormPersonalCalculator
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.tableDigits = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.tableOperations = new System.Windows.Forms.TableLayoutPanel();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.textInput = new System.Windows.Forms.TextBox();
            this.labelKeyboadInput = new System.Windows.Forms.Label();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.listViewHistory = new System.Windows.Forms.ListView();
            this.labelOperationsHistory = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.textBoxWarning = new System.Windows.Forms.TextBox();
            this.tableDigits.SuspendLayout();
            this.tableOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableDigits
            // 
            this.tableDigits.ColumnCount = 3;
            this.tableDigits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableDigits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableDigits.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableDigits.Controls.Add(this.buttonDelete, 0, 3);
            this.tableDigits.Controls.Add(this.buttonEqual, 2, 3);
            this.tableDigits.Controls.Add(this.buttonNine, 2, 2);
            this.tableDigits.Controls.Add(this.buttonEight, 1, 2);
            this.tableDigits.Controls.Add(this.buttonSeven, 0, 2);
            this.tableDigits.Controls.Add(this.buttonSix, 2, 1);
            this.tableDigits.Controls.Add(this.buttonFive, 1, 1);
            this.tableDigits.Controls.Add(this.buttonFour, 0, 1);
            this.tableDigits.Controls.Add(this.buttonTwo, 1, 0);
            this.tableDigits.Controls.Add(this.buttonOne, 0, 0);
            this.tableDigits.Controls.Add(this.buttonZero, 1, 3);
            this.tableDigits.Controls.Add(this.buttonThree, 2, 0);
            this.tableDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableDigits.Location = new System.Drawing.Point(12, 307);
            this.tableDigits.Name = "tableDigits";
            this.tableDigits.RowCount = 4;
            this.tableDigits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.59155F));
            this.tableDigits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.40845F));
            this.tableDigits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableDigits.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableDigits.Size = new System.Drawing.Size(294, 226);
            this.tableDigits.TabIndex = 0;
            this.tableDigits.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(3, 175);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(88, 48);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "C";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.Location = new System.Drawing.Point(196, 175);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(95, 48);
            this.buttonEqual.TabIndex = 4;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonNine
            // 
            this.buttonNine.Location = new System.Drawing.Point(196, 123);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(95, 46);
            this.buttonNine.TabIndex = 2;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = true;
            this.buttonNine.Click += new System.EventHandler(this.buttonNine_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Location = new System.Drawing.Point(98, 123);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(91, 46);
            this.buttonEight.TabIndex = 2;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonEight_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Location = new System.Drawing.Point(3, 123);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(88, 46);
            this.buttonSeven.TabIndex = 2;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonSeven_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Location = new System.Drawing.Point(196, 61);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(95, 55);
            this.buttonSix.TabIndex = 2;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonSix_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Location = new System.Drawing.Point(98, 61);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(91, 55);
            this.buttonFive.TabIndex = 2;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonFive_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Location = new System.Drawing.Point(3, 61);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(88, 55);
            this.buttonFour.TabIndex = 2;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonFour_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Location = new System.Drawing.Point(98, 3);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(91, 52);
            this.buttonTwo.TabIndex = 2;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Location = new System.Drawing.Point(3, 3);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(88, 52);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Location = new System.Drawing.Point(98, 175);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(91, 48);
            this.buttonZero.TabIndex = 2;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonZero_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Location = new System.Drawing.Point(196, 3);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(95, 52);
            this.buttonThree.TabIndex = 2;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonThree_Click);
            // 
            // tableOperations
            // 
            this.tableOperations.ColumnCount = 1;
            this.tableOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOperations.Controls.Add(this.buttonDivide, 0, 3);
            this.tableOperations.Controls.Add(this.buttonMultiply, 0, 2);
            this.tableOperations.Controls.Add(this.buttonMinus, 0, 1);
            this.tableOperations.Controls.Add(this.buttonPlus, 0, 0);
            this.tableOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableOperations.Location = new System.Drawing.Point(329, 307);
            this.tableOperations.Name = "tableOperations";
            this.tableOperations.RowCount = 4;
            this.tableOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableOperations.Size = new System.Drawing.Size(103, 226);
            this.tableOperations.TabIndex = 1;
            // 
            // buttonDivide
            // 
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(3, 175);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(96, 48);
            this.buttonDivide.TabIndex = 4;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(3, 118);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(96, 51);
            this.buttonMultiply.TabIndex = 4;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinus.Location = new System.Drawing.Point(3, 61);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(96, 51);
            this.buttonMinus.TabIndex = 4;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(3, 3);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(96, 52);
            this.buttonPlus.TabIndex = 3;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // textInput
            // 
            this.textInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.Location = new System.Drawing.Point(9, 67);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(297, 41);
            this.textInput.TabIndex = 2;
            this.textInput.TextChanged += new System.EventHandler(this.textInput_TextChanged);
            // 
            // labelKeyboadInput
            // 
            this.labelKeyboadInput.AutoSize = true;
            this.labelKeyboadInput.Location = new System.Drawing.Point(9, 47);
            this.labelKeyboadInput.Name = "labelKeyboadInput";
            this.labelKeyboadInput.Size = new System.Drawing.Size(39, 17);
            this.labelKeyboadInput.TabIndex = 4;
            this.labelKeyboadInput.Text = "Input";
            // 
            // textOutput
            // 
            this.textOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textOutput.Location = new System.Drawing.Point(9, 151);
            this.textOutput.MaxLength = 50;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(297, 41);
            this.textOutput.TabIndex = 5;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(9, 131);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(48, 17);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Result";
            // 
            // listViewHistory
            // 
            this.listViewHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHistory.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listViewHistory.LabelWrap = false;
            this.listViewHistory.Location = new System.Drawing.Point(434, 67);
            this.listViewHistory.Name = "listViewHistory";
            this.listViewHistory.Size = new System.Drawing.Size(561, 463);
            this.listViewHistory.TabIndex = 7;
            this.listViewHistory.UseCompatibleStateImageBehavior = false;
            this.listViewHistory.View = System.Windows.Forms.View.List;
            this.listViewHistory.Click += new System.EventHandler(this.listViewHistory_Click);
            // 
            // labelOperationsHistory
            // 
            this.labelOperationsHistory.AutoSize = true;
            this.labelOperationsHistory.Location = new System.Drawing.Point(435, 34);
            this.labelOperationsHistory.Name = "labelOperationsHistory";
            this.labelOperationsHistory.Size = new System.Drawing.Size(126, 17);
            this.labelOperationsHistory.TabIndex = 8;
            this.labelOperationsHistory.Text = "Operations History";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(312, 151);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(116, 41);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCompute
            // 
            this.buttonCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompute.Location = new System.Drawing.Point(312, 67);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(116, 41);
            this.buttonCompute.TabIndex = 10;
            this.buttonCompute.Text = "Compute";
            this.buttonCompute.UseVisualStyleBackColor = true;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // textBoxWarning
            // 
            this.textBoxWarning.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxWarning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWarning.Location = new System.Drawing.Point(9, 211);
            this.textBoxWarning.Name = "textBoxWarning";
            this.textBoxWarning.Size = new System.Drawing.Size(293, 23);
            this.textBoxWarning.TabIndex = 13;
            // 
            // FormPersonalCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 576);
            this.Controls.Add(this.textBoxWarning);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelOperationsHistory);
            this.Controls.Add(this.listViewHistory);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.labelKeyboadInput);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.tableOperations);
            this.Controls.Add(this.tableDigits);
            this.Name = "FormPersonalCalculator";
            this.Text = "Personal Calculator";
            this.tableDigits.ResumeLayout(false);
            this.tableOperations.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableDigits;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.TableLayoutPanel tableOperations;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Label labelKeyboadInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.ListView listViewHistory;
        private System.Windows.Forms.Label labelOperationsHistory;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.TextBox textBoxWarning;
    }
}

