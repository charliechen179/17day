using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProFactory;
using ProOperation;

namespace ProCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("Config.txt");

            int x = 139;
            int y = 154;
            foreach (var line in lines)
            {
                Button btn = new Button();
                btn.Location = new Point(x, y);
                btn.Size = new Size(75, 33);
                x += 80;
                btn.Text = line;
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int n1 = Convert.ToInt32(textBox1.Text.Trim());
            int n2 = Convert.ToInt32(textBox2.Text.Trim());
            Operation oper = Factory.GetOper(btn.Text, n1, n2);

            if (oper != null)
            {
                label1.Text = oper.GetResult().ToString();
            }
            else
            {
                MessageBox.Show("Invalid operator.");
            }
        }
    }
}
