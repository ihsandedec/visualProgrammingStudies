using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa196_checkBoxGibiMenuler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kalınToolStripMenuItem.Checked)
            {
                textBox1.Font = new Font(textBox1.Font,textBox1.Font.Style | FontStyle.Bold);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
            }
        }

        private void eğikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eğikToolStripMenuItem.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Italic);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);
            }
        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (altıÇiziliToolStripMenuItem.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style | FontStyle.Underline);
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline);
            }
        }
    }
}
