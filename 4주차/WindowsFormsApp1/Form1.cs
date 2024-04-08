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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_init_Click(object sender, EventArgs e)
        {
            Turtle.Init(this);
        }

        
        // 논리곱
        private void button1_Click_1(object sender, EventArgs e)
        {
            int sw = 800, sh = 600;
            float cX, cY;
            int n;
            int n2;
            string b;
            string b2;

            this.Text = "앙";
            this.ClientSize = new Size(sw, sh);

            n = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            b = Convert.ToString(n, 2);
            b2 = Convert.ToString(n2, 2);
            cX = sw / 2 - 50;
            cY = -220;

            Turtle.Delay = 200;
            for (int i = 0; i < b.Length; i++)
            {
                Turtle.PenUp();
                Turtle.MoveTo(cX, cY);
                Turtle.PenDown();
                if ( (n & 1) == 1)
                {
                    Turtle.PenColor = Color.Green;
                    Turtle.PenSize = 10;
                    Turtle.Forward(80);
                }
                else
                {
                    Turtle.PenColor = Color.Purple;
                    Turtle.PenSize = 5;
                    Turtle.Forward(40);
                }
                cX -= 50;
                n >>= 1;
                
            }
        }
        // 논리 합
        private void button2_Click(object sender, EventArgs e)
        {
            int sw = 800, sh = 600;
            float cX, cY;
            float cX2, cY2;
            int n;
            int n2;
            string b;
            string b2;
            int n3 = n + n2;

            this.Text = "앙";
            this.ClientSize = new Size(sw, sh);
            n = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            b = Convert.ToString(n, 2);
            b2 = Convert.ToString(n2, 2);
            cX2 = sw / 2 - 50;
            cY2 = -100;
            cX = sw / 2 - 50;
            cY = 10;
            

            Turtle.Delay = 200;
            for (int i = 0; i < b.Length; i++)
            {
                Turtle.PenUp();
                Turtle.MoveTo(cX, cY);
                Turtle.PenDown();
                if ((n & 1) == 1)
                {
                    Turtle.PenColor = Color.Red;
                    Turtle.PenSize = 10;
                    Turtle.Forward(80);
                }
                else
                {
                    Turtle.PenColor = Color.Blue;
                    Turtle.PenSize = 5;
                    Turtle.Forward(40);
                }
                cX -= 50;
                n >>= 1;
                
            }
            for (int k = 0; k < b2.Length; k++)
            {
                Turtle.PenUp();
                Turtle.MoveTo(cX2, cY2);
                Turtle.PenDown();
                if ((n2 & 1) == 1)
                {
                    Turtle.PenColor = Color.Red;
                    Turtle.PenSize = 10;
                    Turtle.Forward(80);
                }
                else
                {
                    Turtle.PenColor = Color.Blue;
                    Turtle.PenSize = 5;
                    Turtle.Forward(40);
                }
                cX2 -= 50;
                n2 >>= 1;

            }
            for (int k = 0; k < b3.Length; k++)
            {
                Turtle.PenUp();
                Turtle.MoveTo(cX2, cY2);
                Turtle.PenDown();
                if ((n3 | 1) == 1)
                {
                    Turtle.PenColor = Color.Red;
                    Turtle.PenSize = 10;
                    Turtle.Forward(80);
                }
                else
                {
                    Turtle.PenColor = Color.Blue;
                    Turtle.PenSize = 5;
                    Turtle.Forward(40);
                }
                cX2 -= 50;
                n2 >>= 1;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            string b = Convert.ToString(n, 2);
            label1.Text = b;
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           int n = int.Parse(textBox2.Text);
            string b = Convert.ToString(n, 2);
            label2.Text = b;
        }
    }
}
