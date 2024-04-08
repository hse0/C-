using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace _0401Project2
{
    public partial class Form1 : Form
    {
        
        static bool IsNumberInArray(int[] ar, int num)
        {
            bool dupYN = false;

            for (int i =0; i< ar.Length; i++)
            {
                if (ar[i] == num)
                    dupYN = true;
            }
            return dupYN;
        }

        static Random rnd = new Random();

        static void GetLotto(int[]ary)
        {
            int idx = 0;
            int pickNum;

            while(true)
            {
                pickNum = rnd.Next(1,12);
                if (IsNumberInArray(ary, pickNum))
                    continue;
                ary[idx] = pickNum;
                if (idx >= 5)
                    break;
                idx++;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.LightCyan;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int swidth = 600, sheight = 600;
            this.Text = "시계";
            this.ClientSize =new Size(swidth, sheight);
            Turtle.Delay = 50;

            int[] Time = new int[6];

            GetLotto(Time);
            Array.Sort(Time, 0, 6);

            string lottoText = "";
            foreach (int n in Time)
            {
                lottoText += n.ToString() + " ";
            }
            tb_lotto.Text = lottoText;

            Turtle.PenSize = 5;
            for (int i = 0; i < 45; i++)
            {
                Turtle.PenColor = Color.Gray;
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(i * 8);
                Turtle.Forward(150);        
            }

            Turtle.PenSize = 10;
            for (int i = 0;i <Time.Length;i++)
            {
                int R = rnd.Next(0, 256);
                int G = rnd.Next(0, 256);
                int B = rnd.Next(0, 256);
                Turtle.PenColor = Color.FromArgb(R,G,B);
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(Time[i]*12);
                Turtle.Forward(150);
            }
        }

        private void button2_Click(object sender, EventArgs e) //초기화
        {
            Turtle.Init();
        }
    }
}
