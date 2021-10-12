using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringFormatlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text.PadRight(15, ' ') + " " + textBox2.Text.PadRight(20, ' ') + " " + 
            textBox3.Text.PadRight(15, ' ') + " " + textBox4.Text.PadRight(6, ' ') + " " + textBox5.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Font = new Font("Courier New", 10, FontStyle.Regular);
        }
    }
}
