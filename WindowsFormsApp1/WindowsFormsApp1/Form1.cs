using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string search = textBox2.Text;
            string msg = $"找不到{search}";
            int index = Array.IndexOf(singer, search);
            //當index找不到時 為-1
            if (index >= 0)
            {
                msg = "排名\t歌手\t歌曲" + Environment.NewLine;
                while (index >= 0) //只要index>=0就一直執行此迴圈
                {
                    msg += $"{no[index]}\t{singer[index]}\t{song[index]}" + Environment.NewLine;
                    index = Array.IndexOf(singer, search, index + 1);
                }
            }
            MessageBox.Show(msg, "查詢結果"); //查詢結果為msgbox的title
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] song = new string[] { "稻香", "屋梅子醬", "在樹上唱歌", "溫柔", "好不容易" };
        string[] singer = new string[] { "周杰倫", "李榮浩", "郭靜", "五月天", "告五人" };
        int[] no = new int[] { 1, 2, 3, 4, 5 };


        private void button1_Click(object sender, EventArgs e)  
        {
            int[] no2 = new int[5];
            no.CopyTo(no2, 0);
            Array.Sort(no, song);
            Array.Sort(no2, singer);
            string msg = "排名\t歌手\t歌曲" + Environment.NewLine;
            for (int i = 0; i < song.Length; i++)
            {
                msg += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
            textBox1.Text = msg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] song2 = new string[song.Length];
            song.CopyTo(song2, 0); // 將song陣列的資料 全部複製一份到song2陣列
            Array.Sort(song, no);
            Array.Sort(song2, singer);

            string msg = "排名\t歌手\t歌曲" + Environment.NewLine;
            for (int i = 0; i < song.Length; i++)
            {
                msg += $"{no[i]}\t{singer[i]}\t{song[i]}" + Environment.NewLine;
            }
            textBox1.Text = msg;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        //不會
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
