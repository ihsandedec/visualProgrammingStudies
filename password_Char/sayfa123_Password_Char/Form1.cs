using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa123_Password_Char
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            this.CancelButton = btn_iptal;
            this.AcceptButton = btn_tamam;
        }
        int hak = 0;

        private void btn_tamam_Click(object sender, EventArgs e)
        {
            hak++;
            if (textBox1.Text == "1234")
            {
                MessageBox.Show("Ana Giriş Menüsüne Gönderiliyorsunuz");
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Yanlış Şifre Girdiniz");

                if (hak==3)
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Şifreyi 3 defadan fazla girdiniz" + "Program Kapatılacaktır.");
                    this.Close();
                }
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
