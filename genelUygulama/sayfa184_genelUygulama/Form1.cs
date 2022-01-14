using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa184_genelUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim dosyaları | .bmp;.jpeg;.gif;.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
            radioButton_normal.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDataObject pano_resmi = Clipboard.GetDataObject();
            if (pano_resmi.GetDataPresent(DataFormats.Bitmap))
            {
                pictureBox1.Image = (Bitmap)pano_resmi.GetData(DataFormats.Bitmap);
            }
            else
            {
                MessageBox.Show("Panoda uygun resim yok");
            }
        }

        private void radioButton_normal_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void radioButton_sıgdır_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void radioButton_otoboyut_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void radioButton_ortala_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Width = ClientSize.Width;
            pictureBox1.Height = ClientSize.Height - pictureBox1.Top;
        }

        private void checkBox_dose_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_dose.Checked)
            {
                pictureBox1.BackgroundImage = pictureBox1.Image;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }
        }
    }
}
