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
    public partial class ctrTitleBar : UserControl
    {
        public ctrTitleBar()
        {
            InitializeComponent();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.WindowState = FormWindowState.Minimized;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát và đăng xuất khỏi ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes) 
                Application.Exit();
        }

        private void pbMax_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                if (parentForm.WindowState == FormWindowState.Maximized)
                    parentForm.WindowState = FormWindowState.Normal;
                else parentForm.WindowState = FormWindowState.Maximized;
            }
                
        }
    }
}
