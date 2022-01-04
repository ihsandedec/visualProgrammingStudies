using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa16_KrediUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime son_odeme_tarihi, odendigi_tarih;
            double taksit_tutari = 0, fark = 0, ceza = 0;

            taksit_tutari = Convert.ToDouble(textBox1.Text);
            son_odeme_tarihi = DateTime.Parse(textBox2.Text);
            odendigi_tarih = DateTime.Parse(textBox3.Text);
            fark = (double)(odendigi_tarih.ToOADate() - son_odeme_tarihi.ToOADate());

            if (fark > 0)
            {
                ceza = fark * taksit_tutari * 2 / 1000;
                textBox4.Text = ceza.ToString("#,#");
                double ara_hesaр;
                ara_hesaр = taksit_tutari + ceza;
                textBox5.Text = ara_hesaр.ToString("#,#");
                MessageBox.Show(fark + " gün geç ödendi." + textBox4.Text + " TL ceza ödenecektir.");
            }
            else if (fark == 0)
            {
                ceza = 0;
                textBox4.Text = "0";
                textBox5.Text = taksit_tutari.ToString("#,#");
                MessageBox.Show("Tam gününde ödendi");
            }
            else
            {
                ceza = 5;
                textBox4.Text = ceza.ToString("#,#");
                double ara_hesap2;
                ara_hesap2 = taksit_tutari - ceza;
                textBox5.Text = ara_hesap2.ToString("#,#");
                MessageBox.Show(fark + " gün erken ödendi." + textBox4.Text + " TL indirimli ödenecektir");
            }
        }
    }
}
