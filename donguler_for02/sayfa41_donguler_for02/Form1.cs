using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa41_donguler_for02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi, sayi2;
            listBox1.Items.Add("sayi 1 \t sayi 2");

            int i, j;
            for (i = 0, j = 20; i <= 100 && j <= 100; i += 2, j += 5)
            {
                sayi = i;
                sayi2 = j;
                listBox1.Items.Add(sayi.ToString() + "\t" + sayi2.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("sayi 1 \t sayi 2");

            int i, j;
            for (i = 0, j = 20; i <= 100 && j <= 100; i += 2, j += 5)
            {

                listBox1.Items.Add(i.ToString() + "\t" + "  " + j.ToString());
            }
        }
    }
}
