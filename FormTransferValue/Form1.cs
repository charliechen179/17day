﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTransferValue
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

        void ShowMsg(string str)
        {
            label1.Text = str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(ShowMsg);
            form2.Show();
        }
    }
}
