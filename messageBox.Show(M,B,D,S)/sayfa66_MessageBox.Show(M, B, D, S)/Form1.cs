using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa66_MessageBox.Show_M__B__D__S_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkamak İstediğinizden Emin Misiniz?", "ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkamak İstediğinizden Emin Misiniz?", "ONAY", MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Warning);
        }
    }
}
