using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCustomerList fr = new frmCustomerList();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomerList fr = new frmCustomerList();
            fr.ShowDialog();
        }
    }
}
