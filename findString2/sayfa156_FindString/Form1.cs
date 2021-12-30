using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa156_FindString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] meslekler = { "Mühendis", "Öğretmen", "Öğrenci", "İşçi", "Muhasebeci", "Ekonomist", "Avukat", "Doktor"};
            comboBox_meslek.Items.AddRange(meslekler);

            string[] birim = { "Satış", "Eğitim", "Pazarlama", "Reklam", "Üretim", "Network", "Yönetim", "Yazılım" };
            comboBox_meslek.Items.AddRange(birim);
            try
            {
                System.IO.TextReader dosya_ac = System.IO.File.OpenText("C:\\bilgi_kayit.dat");
                string satir = "";
                while ((satir = dosya_ac.ReadLine()) != null)
                {
                    listBox1.Items.Add(satir);

                    satir = dosya_ac.ReadLine();
                    listBox2.Items.Add(satir);

                    satir = dosya_ac.ReadLine();
                    listBox3.Items.Add(satir);

                    dosya_ac.Close();
                }
            }
            catch 
            {

            }

            label5.Text = listBox1.Items.Count.ToString();
            label8.Text = (listBox1.SelectedIndex + 1).ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.IO.TextWriter dosya_kaydet = System.IO.File.CreateText("C:\\bilgi_kayit.dat");

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                dosya_kaydet.WriteLine(listBox1.Items[i]);
                dosya_kaydet.WriteLine(listBox2.Items[i]);
                dosya_kaydet.WriteLine(listBox3.Items[i]);
            }
            dosya_kaydet.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indis;
            indis = (sender as ListBox).SelectedIndex;

            listBox1.SelectedIndex = indis;
            listBox2.SelectedIndex = indis;
            listBox3.SelectedIndex = indis;

            int top_indis;
            top_indis = (sender as ListBox).TopIndex;
            listBox1.TopIndex = top_indis;
            listBox2.TopIndex = top_indis;
            listBox3.TopIndex = top_indis;

            txt_adsoyad.Text = listBox1.Text;
            comboBox_meslek.Text = listBox2.Text;
            comboBox_birim.Text = listBox3.Text;

            label8.Text = (listBox1.SelectedIndex+1).ToString();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            int yer;
            
            yer = listBox1.FindStringExact(txt_adsoyad.Text);

            if (yer < 0)
            {
                listBox1.Items.Add(txt_adsoyad.Text);
                listBox1.Items.Add(comboBox_meslek.Text);
                listBox1.Items.Add(comboBox_birim.Text);
                label6.Text = listBox1.Items.Count.ToString();
            }
            else
            {
               
                listBox1.SelectedIndex = yer;
                MessageBox.Show("Bu eleman listede var");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex<0)
            {
                MessageBox.Show("önce silinecek elemanı seçiniz");
                return;
            }
            int indis;
            DialogResult c;
            indis = listBox1.SelectedIndex;
            c = MessageBox.Show(listBox1.SelectedIndex + " silinsin mi","Silme",MessageBoxButtons.YesNo);
            if (c==DialogResult.Yes)
            {
                listBox1.Items.RemoveAt(indis);
                listBox2.Items.RemoveAt(indis);
                listBox3.Items.RemoveAt(indis);

                label6.Text = listBox1.Items.Count.ToString();
            }
        }
        int yer = 1;
        string aranan;

        private void btn_bul_Click(object sender, EventArgs e)
        {
            aranan = textBox_aranan.Text;
            yer = listBox1.FindStringExact(aranan);
            if (yer<0)
            {
                yer = listBox1.FindStringExact(aranan);
                if (yer<0)
                {
                    MessageBox.Show("'"+aranan.ToString()+"'"+" ifadesi bulunamadı");
                }
            }

            if (yer>=0)
            {
                listBox1.SelectedIndex = yer;
            }
        }

        private void btn_sonraki_Click(object sender, EventArgs e)
        {
            if (yer<listBox1.Items.Count-1)
            {
                yer = listBox1.FindString(aranan,yer);
                if (yer>=0)
                {
                    listBox1.SelectedIndex = yer;
                }
            }
        }

        private void btn_degistir_Click(object sender, EventArgs e)
        {
            int indis;
            string adsoyad, meslek, birim;

            adsoyad = txt_adsoyad.Text;
            meslek = comboBox_meslek.Text;
            birim = comboBox_birim.Text;

            indis = listBox1.SelectedIndex;
            if (indis<0)
            {
                MessageBox.Show("Önce değiştirilecek kişiyi seçiniz");
            }
            else
            {
                listBox1.Items[indis]= adsoyad;
                listBox2.Items[indis]= meslek;
                listBox3.Items[indis]= birim;
            }

        }

        private void btn_arayaekle_Click(object sender, EventArgs e)
        {
            int indis;
            indis = listBox1.SelectedIndex;

            if (indis<0)
            {
                MessageBox.Show("Önce elemanın nereye ekleneceğini seçiniz");
            }
            else
            {
                int yer;
                yer = listBox1.FindStringExact(txt_adsoyad.Text);
                if (yer<0)
                {
                    listBox1.Items.Insert(indis,txt_adsoyad.Text);
                    listBox2.Items.Insert(indis, comboBox_meslek.Text);
                    listBox3.Items.Insert(indis, comboBox_birim.Text);
                    label6.Text = listBox1.Items.Count.ToString();
                }
                else
                {
                    listBox1.SelectedIndex = yer;
                    MessageBox.Show("Bu eleman zaten var");
                }
            }
        }

        private void btn_yenikisi_Click(object sender, EventArgs e)
        {
            textBox_aranan.Text = "";
            comboBox_meslek.Text = "";
            comboBox_birim.Text = "";
        }
    }
}
