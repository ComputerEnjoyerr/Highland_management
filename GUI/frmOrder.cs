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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabMain.SelectedTab = tpOrder;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
