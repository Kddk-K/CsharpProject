using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dk_E_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strName = textBox1.Text;
            string strPass = textBox2.Text;
            if(strName == "1" && strPass == "1")
            {
                MessageBox.Show("登陆成功！", "提示");
            }
            else
            {
                MessageBox.Show("登陆失败！", "提示");
            }
        }

        private void button2_Click(object sender,EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
