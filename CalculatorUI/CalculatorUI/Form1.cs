using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }






//Numbers
        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "7";
            this.richTextBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "4";
            this.richTextBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "1";
            this.richTextBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "0";
            this.richTextBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "8";
            this.richTextBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "5";
            this.richTextBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "2";
            this.richTextBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += ".";
            this.richTextBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "9";
            this.richTextBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "6";
            this.richTextBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "3";
            this.richTextBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "=";
            this.richTextBox1.Text += input;
        }









//Operands
        private void button14_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '^';
            input = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '%';
            input = string.Empty;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;

            // this splits the operand values into num 1 and num 2
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if (operation == '+')
            {
                result = num1 + num2;
                richTextBox1.Text = result.ToString();
                result = num1;
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                richTextBox1.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    richTextBox1.Text = result.ToString();
                }
                else
                {
                    richTextBox1.Text = "DIV/Zero!";
                }
            }
        }
    }
}
