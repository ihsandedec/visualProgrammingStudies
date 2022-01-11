using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa198_contextMenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void büyükHarfeÇevirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToUpper();
        }

        private void küçükHarfeÇevirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.ToLower();
        }
    }
}
