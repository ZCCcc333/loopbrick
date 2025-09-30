using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double ans = 0;

            for (double i = 0.5; i <= 10; i = i + 0.5)
            {
                ans += ans + i;
                textBox1.Text = ans.ToString();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double ans = 0;
            double start = double.Parse(textBox4.Text);
            double end = double.Parse(textBox5.Text);
            double interva1 = double.Parse(textBox6.Text);

            for (double i = start; i <= end; i = i + interva1)
            {
                ans = ans + i;
                textBox1.Text = ans.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double ans = 0;
            double start = double.Parse(textBox4.Text);
            double end = double.Parse(textBox5.Text);
            double interva1 = double.Parse(textBox6.Text);

            for (double i = start; i <= end; i = i + interva1)
            {
                ans = ans + i;
                textBox1.Text = ans.ToString();
            }
        }
    }
}


