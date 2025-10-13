using System.Runtime.InteropServices;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool sideBarExpand = true;


        // Gọi API xử lý sự kiện kéo
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void tmSideBar_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                flpSideBar.Width -= 190;
                if (flpSideBar.Width <= 50)
                {
                    sideBarExpand = false;
                    tmSideBar.Stop();

                }
            }
            else
            {
                flpSideBar.Width += 190;
                if (flpSideBar.Width >= 240)
                {
                    sideBarExpand = true;
                    tmSideBar.Stop();
                }
            }
        }

        private void pbSideBar_Click(object sender, EventArgs e)
        {
            tmSideBar.Start();
        }

        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(FindForm().Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private Button button = new Button();
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrder fr = new frmOrder();

            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnOrder.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnOrder.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnOrder;


            OpenMain(fr);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            frmHistory fr = new frmHistory();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnHistory.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnHistory.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnHistory;
            OpenMain(fr);
        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            frmFinancial fr = new frmFinancial();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnFinancial.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnFinancial.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnFinancial;
            OpenMain(fr);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmSchedule fr = new frmSchedule();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnSchedule.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnSchedule.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnSchedule;
            OpenMain(fr);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory frm = new frmInventory();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnInventory.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnInventory.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnInventory;
            OpenMain(frm);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnEmployee.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnEmployee.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnEmployee;
            OpenMain(frm);
        }

        private void btnNotification_Click(object sender, EventArgs e)
        {
            frmNotification frm = new frmNotification();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnNotification.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnNotification.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnNotification;
            OpenMain(frm);
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance frm = new frmAttendance();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnAttendance.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnAttendance.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnAttendance;
            OpenMain(frm);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pnTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            frmTable fr = new frmTable();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnTable.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnTable.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnTable;
            OpenMain(fr);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnLogOut.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnLogOut.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnLogOut;
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            frmPromotion fr = new frmPromotion();
            button.BackColor = ColorTranslator.FromHtml("#3B3030");
            button.ForeColor = ColorTranslator.FromHtml("#F9F5EE");
            btnPromotion.BackColor = ColorTranslator.FromHtml("#F9F5EE");
            btnPromotion.ForeColor = ColorTranslator.FromHtml("#3B3030");
            button = btnPromotion;
            OpenMain(fr);
        }
    }
}
