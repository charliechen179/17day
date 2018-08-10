using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleInstanceMode
{
    public partial class Form2 : Form
    {
        public static Form2 FrmSignle = null;
        private Form2()
        {
            InitializeComponent();
        }

        public static Form2 GetSingle()
        {
            if (FrmSignle == null)
            {
                FrmSignle = new Form2();
            }
            return FrmSignle;

        }
    }
}
