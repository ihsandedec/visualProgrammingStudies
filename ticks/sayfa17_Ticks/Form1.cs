using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa17_Ticks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0.0, sure;
            sure = DateTime.Now.Ticks;
            for (int i = 0; i < 500000000; i++)
            {
                toplam = toplam + i;
            }
            sure = DateTime.Now.Ticks - sure;
            MessageBox.Show("for döngüsü " + (sure / 10000000) + " saniye sürmüştür"); //saniye cinsine döndürmek için 10000000 rakamına bölünür

        }
    }
}
