using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayfa117_MDI_Formlar02
{
    public partial class MDIParent1 : Form
    {
        

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form1 cocuk_form = new Form1();
            cocuk_form.MdiParent = this;
            cocuk_form.Show();
        }

        
    }
}
