using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade;
            ifade = "Visual c# ile nesneye yönelik programlama";
            MessageBox.Show(ifade.IndexOf("yöne",0).ToString());
        }
    }
}
