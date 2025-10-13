using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmAdMain : Form
    {
        public frmAdMain()
        {
            InitializeComponent();
        }

        // Gọi API xử lý sự kiện kéo
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        // Biến tạm
        Form currentForm = new Form();
        private void OpenMain(Form childForm)
        {
            // Tắt form hiện tại để chuyển form mới
            if (currentForm != null)
            {
                currentForm.Close();
                currentForm.Dispose();
            }
            // Chỉnh sửa thuộc tính của form mới
            childForm.MdiParent = this;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            childForm.Dock = DockStyle.Fill;
            // Đưa form mới vào main menu
            childForm.Show();
            currentForm = childForm;
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmProduct fr = new frmProduct();
            OpenMain(fr);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmSupplier fr = new frmSupplier();
            OpenMain(fr);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmBranch fr = new frmBranch();
            OpenMain(fr);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmCusstomer fr = new frmCusstomer();
            OpenMain(fr);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAdPromotion fr = new frmAdPromotion();
            OpenMain(fr);
        }

        private void btnLogOut_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCusstomer fr = new frmCusstomer();
            OpenMain(fr);
        }
    }
}
