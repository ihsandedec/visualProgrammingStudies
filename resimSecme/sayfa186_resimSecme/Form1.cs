using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa186_resimSecme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Rectangle secili_alan = new Rectangle(0, 0, 0, 0);

        private void button_resimyukle_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim dosyaları | .bmp;.jpeg;.gif;.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                secili_alan.X = e.X;
                secili_alan.Y = e.Y;
                secili_alan.Width = 0;
                secili_alan.Height = 0;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                secili_alan.Width = Math.Abs(secili_alan.Left - e.X);
                secili_alan.Height = Math.Abs(secili_alan.Top - e.Y);
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Red), secili_alan);
        }

        private void button_kes_Click(object sender, EventArgs e)
        {
            if ((secili_alan.Height == 0) || (secili_alan.Width == 0))
            {
                MessageBox.Show("Seçili alan yok");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim yok");
                return;
            }
            Bitmap secili_resim = new Bitmap(secili_alan.Width, secili_alan.Height);
            Graphics grafik = Graphics.FromImage(secili_resim);
            grafik.DrawImage(pictureBox1.Image, 0, 0, secili_alan, GraphicsUnit.Pixel);
            pictureBox1.Image = secili_resim;
            grafik.Dispose();

            secili_alan.X = 0;
            secili_alan.Y = 0;
            secili_alan.Width = 0;
            secili_alan.Height = 0;
        }

        private void button_sagacevir_Click(object sender, EventArgs e)
        {
            if ((secili_alan.Height == 0) || (secili_alan.Width == 0))
            {
                MessageBox.Show("Seçili alan yok");
                return;
            }
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Resim yok");
                return;
            }
            Bitmap secili_resim = new Bitmap(secili_alan.Width, secili_alan.Height);
            Graphics grafik = Graphics.FromImage(secili_resim);
            grafik.RotateTransform(20);
            grafik.TranslateTransform(0, 0, System.Drawing.Drawing2D.MatrixOrder.Append);
            grafik.DrawImage(pictureBox1.Image, 0, 0, secili_alan, GraphicsUnit.Pixel);
            Graphics g;
            g = pictureBox1.CreateGraphics();
            g.DrawImage(secili_resim, secili_alan);
            grafik.Dispose();
            g.Dispose();
        }
    }
}
