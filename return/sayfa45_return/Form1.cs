using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa45_return
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int hangi_sayiya_kadar;
            hangi_sayiya_kadar = Convert.ToInt16(textBox1.Text);
            if (hangi_sayiya_kadar <= 0)
            {
                return;
            }
            for (int i = 1; i <= hangi_sayiya_kadar; i++)
            {
                listBox1.Items.Add("Log[" + i.ToString() + "] =" + Math.Log10(i).ToString());
            }
        }
    }
}
