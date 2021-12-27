using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa18_TipDonusumleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yazi_font_tipi = "Times Nwe Roman";
            double yazi_buyuklugu = 12;
            FontStyle font_style = FontStyle.Bold;
            Font belirlenen_font = new Font(yazi_font_tipi, (float) yazi_buyuklugu);
            
        }
    }
}
