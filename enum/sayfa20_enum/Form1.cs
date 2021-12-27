using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa20_enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum personel_bolum
        {
            satis=1,
            muhasebe=2,
            alım=3,
            hizmet=4,
            guvenlik = 5,
            pazarlık = 6,
        }
        private void button1_Click(object sender, EventArgs e)
        {
            personel_bolum bolum_adlari;
            bolum_adlari = personel_bolum.satis;
            bolum_adlari = personel_bolum.muhasebe;
            bolum_adlari = personel_bolum.alım;
            bolum_adlari = personel_bolum.hizmet;
            bolum_adlari = personel_bolum.guvenlik;
            bolum_adlari = personel_bolum.pazarlık;
            
        }
        personel_bolum bolum_adlandırma;
        private void button2_Click(object sender, EventArgs e)
        {
            Type tipler = typeof(personel_bolum);
            string deger = Enum.GetName(tipler, 3);//alım
        }
    }
}
