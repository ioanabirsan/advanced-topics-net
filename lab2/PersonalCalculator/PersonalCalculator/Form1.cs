using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace PersonalCalculator
{
    public partial class FormPersonalCalculator : Form
    {
        public string ArithmeticOperationPatten = "^(\\d+\\s*[+\\-*/]\\s*\\d+)$";

        public FormPersonalCalculator()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonOne.Text;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonTwo.Text;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonThree.Text;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonFour.Text;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonFive.Text;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonSix.Text;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            string seven = buttonSeven.Text;
            textInput.Text += seven;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonEight.Text;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonNine.Text;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonZero.Text;
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {
            var regex = new Regex(ArithmeticOperationPatten);
            var isValidExpression = regex.IsMatch(textInput.Text);

            buttonCompute.Enabled = isValidExpression;
            buttonAdd.Enabled = isValidExpression;
            buttonEqual.Enabled = isValidExpression;

            textBoxWarning.Text = !isValidExpression ? "The expression is not valid." : string.Empty;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            buttonCompute_Click(sender, e);
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonPlus.Text;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonMinus.Text;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonMultiply.Text;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textInput.Text += buttonDivide.Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonCompute_Click(sender, e);
            var expression = textInput.Text + " = " + textOutput.Text;
            listViewHistory.Items.Add(expression);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string s = textInput.Text;
            s = s.Length > 1 ? s.Substring(0, s.Length - 1) : string.Empty;
            textInput.Text = s;
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            var expression = textInput.Text;
            var result = ArithmeticExpression.ComputeResult(expression);

            textOutput.Text = result.ToString();
        }

        private void listViewHistory_Click(object sender, EventArgs e)
        {
            var lastIndex = listViewHistory.SelectedIndices.Count - 1;
            var index = listViewHistory.SelectedIndices[lastIndex];

            if (index == 0)
            {
                return;
            }

            var expressions = listViewHistory.Items.Cast<ListViewItem>().Select(item => item.Text).ToList();
            var result = ArithmeticExpression.AddResults(expressions, index);

            textOutput.Text = result.ToString();
        }
    }
}