using MENU2.Properties;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static int[] Buynum = { 0, 0, 0 };
        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            if (Form2.picnum == 1)
            {
                pictureBox1.Image = Resources.images;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Form2.picnum == 2)
            {
                pictureBox1.Image = Resources.images__1_;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            if (Form2.picnum == 3)
            {
                pictureBox1.Image = Resources.images__2_;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text)+1).ToString();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
        }
        //點我加入購物車
        private void button3_Click(object sender, EventArgs e)
        {
            if (Form2.picnum == 1)
            {
                Buynum[0] += int.Parse(textBox1.Text);
            }
            if (Form2.picnum == 2)
            {
                Buynum[1] += int.Parse(textBox1.Text);
            }
            if (Form2.picnum == 3)
            {
                Buynum[2] += int.Parse(textBox1.Text);
            }


        }
    }
}
