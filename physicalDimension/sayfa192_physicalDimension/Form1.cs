using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa192_physicalDimension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim dosyaları | .bmp;.jpeg;.gif;.tif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image resim;
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                resim = pictureBox1.Image;

                label6.Text = resim.PhysicalDimension.Width + "X" + resim.PhysicalDimension.Height;
                label7.Text = resim.PixelFormat.ToString();
                label8.Text = resim.HorizontalResolution.ToString();
                label9.Text = resim.VerticalResolution.ToString();

                Guid[] g;
                g = resim.FrameDimensionsList;
                System.Drawing.Imaging.FrameDimension f;
                f = new System.Drawing.Imaging.FrameDimension(g[0]);
                label10.Text = resim.GetFrameCount(f).ToString();

            }
        }
    }
}
