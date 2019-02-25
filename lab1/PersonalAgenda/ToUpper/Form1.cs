using System;
using System.Windows.Forms;

namespace ToUpper
{
    public partial class FormEventType : Form
    {
        private ProcessString toUpper = new ProcessString(StringProcessingUtilities.ToUpper);
        private ProcessString removeSpaces = new ProcessString(StringProcessingUtilities.RemoveSpaces);

        public FormEventType()
        {
            InitializeComponent();
        }

        private void text_input_TextChanged(object sender, EventArgs e)
        {
            string inputText = text_input.Text;

            text_uppercase.Text = toUpper(inputText);
            text_whitout_spaces.Text = removeSpaces(inputText);
        }
    }
}
