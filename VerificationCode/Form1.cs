using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificationCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                str += r.Next(0, 10);
            }
            Bitmap bm = new Bitmap(120, 30);
            Graphics g = Graphics.FromImage(bm);

            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i * 20, 0);
                string[] fonts = { "Arial", "Broadway", "Century", "Ebrima", "Microsoft Himalaya" };
                Color[] color = { Color.Blue, Color.Yellow, Color.Red, Color.Gray, Color.Gold };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0,5)],20,FontStyle.Regular),new SolidBrush(color[r.Next(0,5)]),p);
            }

            for (int i = 0; i < 500; i++)
            {
                Point p = new Point(r.Next(0, bm.Width), r.Next(0, bm.Height));
                bm.SetPixel(p.X,p.Y,Color.Black);
            }

            pictureBox1.Image = bm;



        }
    }
}
