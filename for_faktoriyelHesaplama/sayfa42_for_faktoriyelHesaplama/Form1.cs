using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa42_for_faktoriyelHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal faktoriyel = 1;

            for (int i = 1; i <= 10; i++)
            {
                faktoriyel = faktoriyel * i;
                listBox1.Items.Add(i.ToString() + "!  = " + faktoriyel.ToString());
            }
        }
    }
}
