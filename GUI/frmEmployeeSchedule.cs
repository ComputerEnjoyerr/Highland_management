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
    public partial class frmEmployeeSchedule : Form
    {
        private readonly BLL_ShiftAssignment bLL_ShiftAssignment = new();
        private Employee employee;
        public frmEmployeeSchedule(Employee emp)
        {
            InitializeComponent();
            employee = emp;
        }

        private void frmEmployeeSchedule_Load(object sender, EventArgs e)
        {
            this.Text = $"Lịch làm việc của {employee.EmployeeName}";
            LoadEmployeeSchedule();
        }

        // Hàm load lịch làm việc của nhân viên
        private void LoadEmployeeSchedule(string keyword = "")
        {
            var assignments = bLL_ShiftAssignment.GetByEmployeeId(employee.Id);

            if (assignments == null || assignments.Count == 0)
            {
                MessageBox.Show("Nhân viên này chưa đăng ký ca làm việc nào.",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvEmployeeSchedule.DataSource = null;
                return;
            }

            // Nếu có từ khóa tìm kiếm thì lọc dữ liệu
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                keyword = keyword.Trim().ToLower();
                assignments = assignments.Where(a =>
                    (a.Shift?.WorkDate.ToString("dd/MM/yyyy").Contains(keyword) ?? false) ||
                    (a.Shift?.ShiftType?.ToLower().Contains(keyword) ?? false) ||
                    (a.Shift?.WorkSchedule?.Branch?.BranchName?.ToLower().Contains(keyword) ?? false) ||
                    (!string.IsNullOrEmpty(a.Note) && a.Note.ToLower().Contains(keyword))
                ).ToList();
            }

            // Sau khi lọc, nếu không còn dữ liệu thì xóa bảng
            if (assignments.Count == 0)
            {
                dgvEmployeeSchedule.DataSource = null;
                return;
            }

            // Chuyển dữ liệu sang dạng hiển thị
            var data = assignments.Select(a => new
            {
                WorkDate = a.Shift?.WorkDate.ToString("dd/MM/yyyy"),
                Shift = a.Shift?.ShiftType,
                StartTime = a.Shift != null
                    ? $"{a.Shift.StartTime:hh\\:mm} {(a.Shift.StartTime.Hour < 12 ? "AM" : "PM")}"
                    : "",
                EndTime = a.Shift != null
                    ? $"{a.Shift.EndTime:hh\\:mm} {(a.Shift.EndTime.Hour < 12 ? "AM" : "PM")}"
                    : "",
                Branch = a.Shift?.WorkSchedule?.Branch?.BranchName ?? "(Unknown)",
                Note = string.IsNullOrEmpty(a.Note) ? "" : a.Note
            }).ToList();

            // Gán dữ liệu lên DataGridView
            dgvEmployeeSchedule.DataSource = data;
            dgvEmployeeSchedule.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployeeSchedule.MultiSelect = false;
            dgvEmployeeSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeSchedule.ReadOnly = true;
        }


        // Biển theo dõi công tác nhập liệu
        private CancellationTokenSource _cts = new();
        private async void txtFind_TextChanged(object sender, EventArgs e)
        {
            string input = txtFind.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadEmployeeSchedule(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }
    }
}
