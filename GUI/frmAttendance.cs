using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmAttendance : Form
    {
        private readonly BLL_Attendance bLL_Attendance = new();
        private readonly BLL_ShiftAssignment bLL_ShiftAssignment = new();
        private readonly BLL_Employee bLL_Employee = new();
        public frmAttendance()
        {
            InitializeComponent();
        }

        private void LoadStatus()
        {
            var status = new List<string>
            {
                "Đúng giờ",
                "Đi muộn",
                "Về sớm",
                "Vắng mặt",
                "Nghỉ phép"
            };
            cbStatus.DataSource = status;
            cbStatus.SelectedIndex = 0;

        }
    
        private void LoadDgvEmployee(string key = "")
        {
                var today = DateTime.Now;

                var filtered = bLL_ShiftAssignment.GetAll()
                    .Where(s => s.Shift != null && s.Shift.WorkDate == DateOnly.FromDateTime(today))
                    .Select(s => new
                    {
                        s.EmployeeId,
                        Name = s.Employee != null ? s.Employee.EmployeeName : "Lỗi hiển thị",
                        Role = s.Employee != null ? s.Employee.Role : "Lỗi hiển thị",


                    }).ToList();
                dgvEmployee.DataSource = filtered;
        }
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            dgvEmployee.MultiSelect = false;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.ReadOnly = true;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAttendance.MultiSelect = false;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.ReadOnly = true;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadStatus();
            LoadDgvEmployee();
        }

        private void LoaddgvAttendance(string key = null)
        {
            if (!string.IsNullOrEmpty(key))
            {
                var filtered = bLL_Attendance.GetAll()
                    .Where(a => a.Employee.EmployeeName.Contains(key, StringComparison.OrdinalIgnoreCase)
                             || a.Branch.BranchName.Contains(key, StringComparison.OrdinalIgnoreCase)
                             || a.ShiftId.Contains(key, StringComparison.OrdinalIgnoreCase))
                    .Select(a => new
                    {
                        a.Id,
                        EmployeeName = a.Employee.EmployeeName,
                        a.ShiftId,
                        BranchName = a.Branch.BranchName,
                        a.CheckIn,
                        a.CheckOut,
                        a.OvertimeHours,
                        a.Status,
                        a.Method,
                        a.ApprovedBy,
                        a.Note
                    });
                dgvAttendance.DataSource = filtered;
                return;
            }

            var attendanceList = bLL_Attendance.GetAll()
                .Select(a => new
                {
                    a.Id,
                    EmployeeName = a.Employee.EmployeeName,
                    a.ShiftId,
                    BranchName = a.Branch.BranchName,
                    a.CheckIn,
                    a.CheckOut,
                    a.OvertimeHours,
                    a.Status,
                    a.Method,
                    a.ApprovedBy,
                    a.Note
                });
            dgvAttendance.DataSource = attendanceList;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                var attendance = new Attendance
                {
                    Id = txtId.Text,
                    ShiftId = txtShift.Text,
                    CheckIn = dtCheckIn.Value,
                    CheckOut = dtCheckOut.Value,
                    Status = cbStatus.SelectedItem.ToString(),
                    Note = txtNote.Text,
                    // WorkDate = dateTimePicker3.Value
                };
                bLL_Attendance.Add(attendance);
                MessageBox.Show("Điểm danh thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi điểm danh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                var attendance = new Attendance
                {
                    Id = txtId.Text,
                    ShiftId = txtShift.Text,
                    CheckIn = dtCheckIn.Value,
                    CheckOut = dtCheckOut.Value,
                    Status = cbStatus.SelectedItem.ToString(),
                    Note = txtNote.Text,
                    // WorkDate = dateTimePicker3.Value
                };
                bLL_Attendance.Add(attendance);
                MessageBox.Show("Đánh vắng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddgvAttendance();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đánh vắng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)
            {
                var selectedRow = dgvAttendance.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtShift.Text = selectedRow.Cells["ShiftId"].Value.ToString();
                dtCheckIn.Value = Convert.ToDateTime(selectedRow.Cells["CheckIn"].Value);
                dtCheckOut.Value = Convert.ToDateTime(selectedRow.Cells["CheckOut"].Value);
                cbStatus.SelectedIndex = cbStatus.FindStringExact(selectedRow.Cells["Status"].Value.ToString());
                txtNote.Text = selectedRow.Cells["Note"].Value.ToString();
            }
                
        }
    }
}
