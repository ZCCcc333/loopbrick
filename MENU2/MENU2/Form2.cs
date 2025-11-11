using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MENU2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int picnum = 0;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 1;
            form3.ShowDialog();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 2;
            form3.ShowDialog();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            picnum = 3;
            form3.ShowDialog();
            
        }
        private void refresh()
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "已選取" + Form3.Buynum[0]+"隻";
            label2.Text = "已選取" + Form3.Buynum[1]+"隻";
            label3.Text = "已選取" + Form3.Buynum[2]+"隻";
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            label1.Text = "已選取" + Form3.Buynum[0] + "隻";
            label2.Text = "已選取" + Form3.Buynum[1] + "隻";
            label3.Text = "已選取" + Form3.Buynum[2] + "隻";
        }
    }
}
