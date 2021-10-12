using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stringBirlestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ifade1 = "Visual C# ile";
            string ifade2 = "nesneye yönelik programlama";
            string ifade3;
            ifade3 = string.Concat(ifade1, ifade2); //ifade3 = ifade1 + ifade2 de yazılabilir.
            MessageBox.Show(ifade3.ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ifade1 = "Visual C# ile";
            string ifade2 = "nesneye yönelik programlama";
            ifade1 = ifade1.Insert(0, "merhaba ");
            ifade2 = ifade2.Insert(7, " (dayalı) ");
            MessageBox.Show(ifade1.ToString());
            MessageBox.Show(ifade2.ToString());
        }
    }
}
