using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dk_H_3_9
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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "1000以内的完数为：\n";
            for(int i = 2; i <= 1000; i++)
            {
                string str = "1";
                int s = 1;
                int a = 0;
                for(int j = 2; j <= (int)Math.Sqrt(i); j++)
                {
                    if(i % j == 0 && i != j)
                    {
                        a = i / j;
                        s += j + a;
                        str += string.Format("+ {0} + {1}", j, a);
                    }
                }
                if(s == i)
                {
                    str += "\n";
                    richTextBox1.Text += i.ToString() + "=" + str;
                }
            }
        }
    }
}
