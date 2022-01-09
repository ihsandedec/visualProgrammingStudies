using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa205_richTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "RTF dosyaları | *.rtf | Metin dosyaları | *.txt | " + "Bütün dosyalar | *.*";
            openFileDialog1.Title = "Açılacak dosya";
            saveFileDialog1.Filter = openFileDialog1.Filter;
            saveFileDialog1.DefaultExt = "rtf";
            saveFileDialog1.Title = "Kaydedilecek dosyalar";
        }

        private void button_ac_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch
                {

                    try
                    {
                        richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    }
                    catch
                    {

                        MessageBox.Show(openFileDialog1.FileName + " bu dosya açıladı");
                    }
                }
            }
        }

        private void buttonkaydet_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.FileName == "")
            {
                richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
            }
        }

        private void button_farklıkaydet_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
            }
        }
    }
}
