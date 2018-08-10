using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._06._05PassValueFormsWithDelegate
{
    public delegate void DelTest(string text);
    public partial class Form2 : Form
    {
        private DelTest _del;
        public Form2(DelTest del)
        {
            this._del = del;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _del(textBox1.Text.Trim());
        }
    }
}
