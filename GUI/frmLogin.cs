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
    public partial class frmLogin : Form
    {
        private readonly BLL_Account bLL_Account = new();
        private readonly BLL_Employee bLL_Employee = new();
        public frmLogin()
        {
            InitializeComponent();
        }
        public Form NextForm { get; private set; } // Lưu form tiếp theo

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string pass = txtPass.Text;
                var admin = bLL_Account.GetAll().First(); // Tài khoản admin
                var account = bLL_Account.GetAll().FirstOrDefault(a => a.AccountName.Trim().ToLower() == name.Trim().ToLower() && a.Password == pass);

                if (account != null)
                {
                    // Lấy nhân viên từ tài khoản
                    var employee = bLL_Employee.GetAll().FirstOrDefault(e => e.Id == account.EmployeeId);
                    if (employee != null)
                    {
                        if (account.AccountName == admin.AccountName && account.Password == admin.Password)
                            NextForm = new frmAdMain();
                        else if (employee.Role == "Quản lý" || employee.Role == "Nhân viên")
                            NextForm = new frmMain(employee);
                    }


                    // Đăng nhập thành công
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.\nVui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Danh sách tài khoản mẫu:\n1. Tên đăng nhập: admin | Mật khẩu: admin123 (Quyền: Quản trị viên)\n2. Tên đăng nhập: nguyenvana | Mật khẩu: 123456", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPass.Clear();
                    txtPass.Focus();
                }
            } catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Lỗi dữ liệu tài khoan.\nChi tiết lỗi: " + inner);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng này không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes) 
                Application.Exit();
        }
    }
}
