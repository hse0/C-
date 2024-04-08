using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x1,x2,y1,y2;
        int pSize = 1;
        Pen pen = new Pen(Color.Black, 1);


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void 선두께입력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("선두께 입력");
            pSize = int.Parse(str);
            pen = new Pen(pen.Color, pSize);
        }

        private void 초기화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void 색상선택toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.ShowDialog();
            pen = new Pen(dlg.Color, pSize);
        }

        private void 선두께ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = Microsoft.VisualBasic.Interaction.InputBox("선두께 입력");
            pSize = int.Parse(str);
            pen = new Pen(pen.Color, pSize);
        }

        private void Form1_mouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X; 
            y1 = e.Y;
        }

        private void Form1_mouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            Graphics g = CreateGraphics();
            g.DrawLine(pen, x1, y1, x2, y2);    
        }
    }
}
