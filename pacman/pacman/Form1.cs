using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        bool goup, godown, goleft, goright = false;
        PictureBox[] pictureBoxes;
        Panel[] panels;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Enabled = true;
            panels = new Panel[]
            {
                  panel1,panel2,panel3
            };

            pictureBoxes = new PictureBox[11]
            {
                pictureBox2,
                pictureBox3, 
                pictureBox4, 
                pictureBox5, 
                pictureBox6, 
                pictureBox7, 
                pictureBox8,
                pictureBox11,
                pictureBox1,
                pictureBox9,
                pictureBox10
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (goup)
            {
                pacman.Top -= 5;
            }
            if (godown)
            {
                pacman.Top += 5;
            }
            if (goright)
            {
                pacman.Left += 5;
            }
            if (goleft)
            {
                pacman.Left -= 5;
            }


            for (int i = 0; i < 11; i++)
            {

                if (pacman.Bounds.IntersectsWith(pictureBoxes[i].Bounds))
                {
                    pictureBoxes[i].Visible = false;
                }
            }
            for (int i = 0; i < 3; i++)
            {

                if (pacman.Bounds.IntersectsWith(panels[i].Bounds))
                {
                    goup = godown = goleft = goright = false;
                }
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            goup = godown = goleft = goright = false;
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                pacman.Image = Properties.Resources.pacmanup;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                pacman.Image = Properties.Resources.pacmandown;
            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                pacman.Image = Properties.Resources.pacmanleft;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                pacman.Image = Properties.Resources.pacman;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    goup = false;
            //}
            //if (e.KeyCode == Keys.Down)
            //{
            //    godown = false;
            //}
            //if (e.KeyCode == Keys.Left)
            //{
            //    goleft = false;
            //}
            //if (e.KeyCode == Keys.Right)
            //{
            //    goright = false;
            //}
        }
    }
}







   
