using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa112_Acilis_Formu02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 baslangic_formu = new Form1();
            baslangic_formu.ShowDialog();
        }
    }
}
