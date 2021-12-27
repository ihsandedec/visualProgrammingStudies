using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa19_GlobalAndLocal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Local Tanımlama
            int a;
            a = 10;
        }

        int a;
        private void button2_Click(object sender, EventArgs e)
        {
            //Global Tanımlama
            a = 10;
        }
    }
}
