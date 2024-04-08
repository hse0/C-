﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;


namespace HomeWork0401
{
    public partial class Form1 : Form
    {
        static bool IsTime(int[] ar, int num)
        {
            bool dupYN = false;

            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] == num)
                    dupYN = true;
            }
            return dupYN;
        }

        static Random rnd = new Random();

        static void GetLotto(int[] ary)
        {
            int idx = 0;
            int pickNum;

            while (true)
            {
                pickNum = rnd.Next(1, 12);
                if (IsTime(ary, pickNum))
                    continue;
                ary[idx] = pickNum;
                idx++;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int swidth = 600, sheight = 600;
            this.Text = "시계";
            this.ClientSize = new Size(swidth, sheight);
            Turtle.Delay = 50;

            int[] Time = new int[0];

            GetLotto(Time);
            Array.Sort(Time, 0,0);

            string CurTime = "";
            foreach (int n in Time)
            {
                CurTime += n.ToString() + " ";
            }
            button1.Text = CurTime;

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

            Turtle.PenSize = 15;
            for (int i = 0; i < Time.Length; i++)
            {
                int R = rnd.Next(0, 256);
                int G = rnd.Next(0, 256);
                int B = rnd.Next(0, 256);
                Turtle.PenColor = Color.FromArgb(R, G, B);
                Turtle.PenUp();
                Turtle.MoveTo(0, 0);
                Turtle.PenDown();
                Turtle.RotateTo(Time[i] * 30);
                Turtle.Forward(170);
            }
            
          
                

            

        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            Turtle.Init();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("F");
            BackColor = Color.Blue;
        }
    }
}

