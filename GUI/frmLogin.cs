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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public Form NextForm { get; private set; } // Lưu form tiếp theo
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "123" && txtName.Text == "ad")
            {
                NextForm = new frmAdMain();
            }
            else
            {
                NextForm = new frmMain();
            }
            // Đăng nhập thành công
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
