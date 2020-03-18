using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void operationPressed(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            operand01 = Convert.ToDouble(label1.Text);
            label1.Text = "0";
        }

        private void igual(Object sender, EventArgs e)
        {
            double operand02 = Convert.ToDouble(label1.Text);
            double result = 0;
            if (operation == "+")
            {
                result = operand01 + operand02;
            }
            else if (operation == "-")
            {
                result = operand01 - operand02;
            }
            label1.Text = Convert.ToString(result);
        }
    }
}
