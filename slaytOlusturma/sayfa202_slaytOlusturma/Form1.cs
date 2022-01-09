using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa202_slaytOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 1000;

            openFileDialog1.ShowHelp = true;
            openFileDialog1.Filter = "Resim dosyaları | .bmp;.jpeg;.gif;.tif";
            openFileDialog1.Title = "Gösterilecek Resimleri Seçiniz";
            openFileDialog1.Multiselect = true;

            openFileDialog2.ShowHelp = true;
            openFileDialog2.Filter = "Geçici Dosyalar | *.tmp;*.~* |" + "Bütün Dosyalar | *.*";
            openFileDialog2.Title = "Silinecek Dosyaları Seçiniz";
            openFileDialog2.Multiselect = true;

        }

        private void button_resimgoster_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                timer1.Enabled = true;
            }
        }

        private void button_dosyasil_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog()==DialogResult.OK)
            {
                DialogResult c;
                c = MessageBox.Show("Seçtiğinz bütün dosyalar silinecektir.","Silme İşlemi",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
                if (c==DialogResult.OK)
                {
                    for (int i = 0; i < openFileDialog2.FileNames.Length; i++)
                    {
                        try
                        {
                            System.IO.FileInfo dosya = new System.IO.FileInfo(openFileDialog2.FileNames[i]);
                            dosya.Delete();
                        }
                        catch 
                        {

                            MessageBox.Show(openFileDialog2.FileNames[i]+"Dosya Silinemedi");
                        }
                    }
                }
            }
        }
        int say = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            say++;
            say = say % openFileDialog1.FileNames.Length;
            try
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileNames[say]);
            }
            catch (Exception)
            {

                MessageBox.Show(openFileDialog1.FileNames[say]+" dosyası geçersizdir");
            }
        }

        private void openFileDialog1_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Gösterilecek resimleri seçiniz. Birden fazla resmi seçebilmek" + " için Ctrl tuşuna basılı tutarak istediğiniz resmi seçiniz.");

        }

        private void openFileDialog2_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Silinecek resimleri seçiniz. Birden fazla resmi seçebilmek" + " için Ctrl tuşuna basılı tutarak istediğiniz resmi seçiniz.");
        }
    }
}
