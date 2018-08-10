using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIDrawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics(); //new Graphics();
            Pen pen = new Pen(Brushes.Red);
            Point p1 = new Point(30, 50);
            Point p2 = new Point(250, 250);
            g.DrawLine(pen, p1, p2);

        }

        int i = 0;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            i++;
            label1.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Graphics g = this.CreateGraphics(); //new Graphics();
            Pen pen = new Pen(Brushes.Red);
            
            g.DrawRectangle(pen,new Rectangle(new Point(10,50),new Size(new Point(70,90))));
        }


    }
}
