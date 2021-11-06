using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa43_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            int sayinin_karesi;

            listBox1.Items.Add("SAYI       SAYININ KARESİ");
            listBox1.Items.Add("--------       -------------------");

            int i = 0;
            while (i <= 100)
            {
                sayi = i;
                sayinin_karesi = i * i;
                listBox1.Items.Add(sayi.ToString() + "\t" + sayinin_karesi.ToString());

                i++;
            }
        }
    }
}
