using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Расчёт_ступени_ЦВД_паровой_турбины_2
{
    public partial class Form3 : Form
    {
        public double v2;
        public bool close = false;

        public Form3(bool otsek)
        {
            InitializeComponent();
            if (otsek)
                label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            v2 = Convert.ToDouble(v2_.Text);
            close = true;
            Close();
        }
    }
}
