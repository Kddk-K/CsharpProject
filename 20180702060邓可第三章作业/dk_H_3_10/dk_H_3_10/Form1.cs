using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dk_H_3_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox3.Text);
            double result = 0.0;

            if(textBox2.Text == "+")
            {
                result = a + b;
            }
            if (textBox2.Text == "-")
            {
                result = a - b;
            }
            if (textBox2.Text == "*")
            {
                result = a * b;
            }
            if (textBox2.Text == "/")
            {
                result = a / b;
            }
            textBox4.Text = Convert.ToString(result);
        }
    }
}
