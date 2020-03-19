using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        double operand01 = 0;

        String operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void operandos(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (label1.Text == "0")
            {
                label1.Text = button.Text;
            }
            else
            {
                label1.Text = label1.Text + button.Text;
            }
        }

        private void decim (object sender, EventArgs e)
        {
            if (!label1.Text.Contains(",")){
                label1.Text = label1.Text + ",";
            }
        }

        private void retr(object sender, EventArgs e)
        {
            if (label1.Text.Length == 1) label1.Text = "0";
            else label1.Text = label1.Text.Remove(label1.Text.Length - 1);
        }

        private void operationPressed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            operand01 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void igual(object sender, EventArgs e)
        {
            double operand02 = Convert.ToDouble(label1.Text);
            double result = 0;
            if (operation == "+")  result = operand01 + operand02;
            else if (operation == "-") result = operand01 - operand02;
            else if (operation == "*") result = operand01 * operand02;
            else if (operation == "/") result = operand01 / operand02;
            else if (operation == "X ^ Y") result = Math.Pow(operand01, operand02);
            label1.Text = Convert.ToString(result);
        }

        private void perc(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Convert.ToDouble(label1.Text) / 100);
        }

        private void clear(object sender, EventArgs e)
        {
            label1.Text = "0";
            operand01 = 0;
            operation = "";
        }

        private void invert(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(-1 * Convert.ToDouble(label1.Text));
        }

        private void squareRoot(object sender, EventArgs e)
        {
            if (Convert.ToString(Math.Sqrt(Convert.ToDouble(label1.Text))) == "NaN")
            {
                label1.Text = "0";
            }
            else
            {
                label1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(label1.Text)));
            }
        }
        private void pow2(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(label1.Text), 2));
        }
        private void pow3(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(Math.Pow(Convert.ToDouble(label1.Text), 3));
        }
    }
}
