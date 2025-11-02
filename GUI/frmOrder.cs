using BLL;
using DTO;
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
        private Employee employee = new();
        private readonly BLL_Category bLL_Category = new();
        private readonly BLL_Product bLL_Product = new();

        public frmOrder(Employee em)
        {
            InitializeComponent();
            employee = em;
        }

        //private void button14_Click(object sender, EventArgs e)
        //{
        //    tabMain.SelectedTab = tpOrder;
        //}

        private void LoadPnlTable()
        {

        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            
        }
    }
}
