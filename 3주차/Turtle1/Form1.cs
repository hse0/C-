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


namespace Turtle1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turtle.Init(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.PenColor= Color.Red;
            Turtle.PenUp();
            Turtle.MoveTo(-150, 0);
            for (int i = 0; i < 9; i++)
            {
                Turtle.PenDown();
                Turtle.Rotate(20);
                Turtle.Forward(50);
                Turtle.PenUp();
                Turtle.Rotate(20);
                Turtle.Forward(50);
            }
            
            
        }
    }
}
