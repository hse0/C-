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

namespace Exam06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_draw_Click(object sender, EventArgs e)
        {
            int swidth = 800, sheight = 300;
            float curX, curY;
            int num;
            string binary;

            this.Text = "거북이로 2진수 표현하기";
            this.ClientSize = new Size(swidth, sheight);

            num = int.Parse(tb_num.Text.ToString());
            binary = Convert.ToString(num, 2);
            curX = swidth / 2 - 50;
            curY = -50;

            Turtle.Delay = 200;
            for (int i=0; i < binary.Length; i++)
            {   Turtle.PenUp();
                Turtle.MoveTo(curX, curY);
                Turtle.PenDown();
                if ( (num & 1) == 1)
                {   Turtle.PenColor = Color.Red;
                    Turtle.PenSize = 10;
                    Turtle.Forward(80);
                }
                else
                {   Turtle.PenColor = Color.Blue;
                    Turtle.PenSize = 5;
                    Turtle.Forward(40);
                }
                curX -= 50;
                num >>= 1;
            }            
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }
    }
}
