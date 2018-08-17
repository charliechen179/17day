using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._06._06WinformSimulateEvent
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
            PlayMusic p = new PlayMusic("Cool")
            { Del = Test };
            p.PlaySong();

        }

        void Test()
        {
            Console.WriteLine("Playing done!");
        }
    }
}
