using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm1 : Form
    {
        private double result = 0;
        private string operation = "";
        private bool isOperationPerformed = false;

        public CalculatorForm1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((Display.Text == "0") || (isOperationPerformed))
                Display.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            Display.Text = Display.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (result != 0)
            {
                buttonEq.PerformClick();
                operation = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operation = button.Text;
                result = Double.Parse(Display.Text);
                isOperationPerformed = true;
            }
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Display.Text = (result + Double.Parse(Display.Text)).ToString();
                    break;
                case "-":
                    Display.Text = (result - Double.Parse(Display.Text)).ToString();
                    break;
                case "*":
                    Display.Text = (result * Double.Parse(Display.Text)).ToString();
                    break;
                case "/":
                    Display.Text = (result / Double.Parse(Display.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(Display.Text);
            operation = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Display.Text = "0";
            result = 0;
            operation = "";
        }
    }
}
