﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa48_fonkCagirimindeParametre01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static double carpim(int a, int b)
        {
            double c = a * b;
            return c;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double sonuc = carpim(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show(Convert.ToString(sonuc));
        }
    }
}
