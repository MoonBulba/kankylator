using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kankylator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void a_TextChanged(object sender, EventArgs e)
        {

        }

        private void b_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int operand1 = int.Parse(operand1TextBox.Text);
                int operand2 = int.Parse(operand2TextBox.Text);
                int result = operand1 + operand2;
                resultTextBox.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int operand1 = int.Parse(operand1TextBox.Text);
                int operand2 = int.Parse(operand2TextBox.Text);
                int result = operand1 - operand2;
                resultTextBox.Text = result.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                int operand1 = int.Parse(operand1TextBox.Text);
                int operand2 = int.Parse(operand2TextBox.Text);
                int result = operand1 * operand2;
                resultTextBox.Text = result.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                int operand1 = int.Parse(operand1TextBox.Text);
                int operand2 = int.Parse(operand2TextBox.Text);
                int result = operand1 / operand2;
                resultTextBox.Text = result.ToString();
            }
        }
    }
}
