using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa86_Koordinat_Boyut06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ifadeler = { "Yok", "Sağa", "Sola", "Üste", "Alta", "İçine" };
            comboBox1.Items.AddRange(ifadeler);
            comboBox2.Items.AddRange(ifadeler);
            comboBox3.Items.AddRange(ifadeler);
        }

        private void dock_ayarlari(object sender, EventArgs e)
        {
            if ((sender as ComboBox).Text == "Yok")
            {
                (sender as ComboBox).Parent.Dock = DockStyle.None;
            }
            else if ((sender as ComboBox).Text == "Sağa")
            {
                (sender as ComboBox).Parent.Dock = DockStyle.Right;
            }
            else if ((sender as ComboBox).Text == "Sola")
            {
                (sender as ComboBox).Parent.Dock = DockStyle.Left;
            }
            else if ((sender as ComboBox).Text == "Üste")
            {
                (sender as ComboBox).Parent.Dock = DockStyle.Top;
            }
            else if ((sender as ComboBox).Text == "Alta")
            {
                (sender as ComboBox).Parent.Dock = DockStyle.Bottom;
            }
            else if ((sender as ComboBox).Text == "İçine")
            {
                (sender as ComboBox).Parent.Dock = DockStyle.Fill;
            }
        }

        
    }
}
