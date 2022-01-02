using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa20_struct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct personel
        {
            public string adi;
            public string soyadi;
            public string ev_adresi;
            public string ev_telefonu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel personel_kayit = new personel();
            personel_kayit.adi = "İhsan";
            personel_kayit.soyadi = "Dedeç";
            personel_kayit.ev_adresi = "Denizli";
            personel_kayit.ev_telefonu = "xxxxxxxx";
            MessageBox.Show(personel_kayit.adi.ToString()+ " "+personel_kayit.soyadi.ToString()+ " " + personel_kayit.ev_adresi.ToString()+ " " + personel_kayit.ev_telefonu.ToString());
        }
    }
}
