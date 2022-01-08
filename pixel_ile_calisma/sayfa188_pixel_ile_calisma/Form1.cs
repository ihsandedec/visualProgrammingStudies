using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa188_pixel_ile_calisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_negatifgoruntu.Enabled = false;
            button_embossefekti.Enabled = false;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void button_resimyukle_Click(object sender, EventArgs e)
        {
            button_negatifgoruntu.Enabled = true;
            button_embossefekti.Enabled = true;

            openFileDialog1.Filter = "Resim dosyaları | .bmp;.jpeg;.gif;.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void button_negatifgoruntu_Click(object sender, EventArgs e)
        {
            Color r;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            progressBar1.Maximum = bmp.Width * bmp.Height;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    r = bmp.GetPixel(i, j);
                    r = Color.FromArgb(r.A, (byte)~r.R, (byte)~r.G, (byte)~r.B);
                    bmp.SetPixel(i, j, r);

                    if ((i % 10) == 0)
                    {
                        progressBar1.Value = i * bmp.Height + j;
                        Application.DoEvents();
                    }
                }
                pictureBox2.Image = bmp;
            }
        }

        private void button_embossefekti_Click(object sender, EventArgs e)
        {
            Color renk1, renk2, renk3;
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int r, g, b;
            progressBar1.Maximum = bmp.Width * bmp.Height;

            for (int i = 0; i < bmp.Width - 1; i++)
            {
                for (int j = 0; j < bmp.Height - 1; j++)
                {
                    renk1 = bmp.GetPixel(i, j);
                    renk2 = bmp.GetPixel(i + 1, j + 1);
                    r = Math.Abs((int)(renk1.R) - renk2.R) + 128;
                    if (r > 255)
                    {
                        r = 255;
                    }
                    g = Math.Abs((int)(renk1.G) - renk2.G) + 128;
                    if (g > 255)
                    {
                        g = 255;
                    }
                    b = Math.Abs((int)(renk1.B) - renk2.B) + 128;
                    if (b > 255)
                    {
                        b = 255;
                    }
                    renk3 = Color.FromArgb(r, g, b);
                    bmp.SetPixel(i, j, renk3);

                    if ((i % 10) == 0)
                    {
                        progressBar1.Value = i * bmp.Height + j;
                        Application.DoEvents();
                    }

                }
                pictureBox2.Image = bmp;
            }
        }
    }
}
