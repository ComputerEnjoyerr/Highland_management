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

        private void LoaddgvAttendance(string key = "")
        {
            DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker3.Value);

            var attendances = bLL_Attendance.GetAll()
                .Where(a => a.Shift != null && a.Shift.WorkDate == selectedDate)
                .Select(a => new
                {
                    Id = a.Id,
                    EmployeeId = a.EmployeeId,  // ✅ thêm dòng này
                    EmployeeName = a.Employee?.EmployeeName ?? "Không rõ",
                    ShiftType = a.Shift?.ShiftType ?? "",
                    Status = a.Status ?? "",
                    CheckIn = a.CheckIn.HasValue ? a.CheckIn.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                    CheckOut = a.CheckOut.HasValue ? a.CheckOut.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                    WorkDate = a.Shift?.WorkDate.ToString("dd/MM/yyyy") ?? ""
                })
                .ToList();

            dgvAttendance.DataSource = attendances;
        }

        private void LoaddgvAttendanceByDate(DateOnly workDate)
        {
            var attendances = bLL_Attendance.GetAll()
                .Where(a => a.Shift != null && a.Shift.WorkDate == workDate)
                .Select(a => new
                {
                    Id = a.Id,
                    EmployeeId = a.EmployeeId,  // ✅ thêm dòng này
                    EmployeeName = a.Employee?.EmployeeName ?? "Không rõ",
                    ShiftType = a.Shift?.ShiftType ?? "",
                    Status = a.Status ?? "",
                    CheckIn = a.CheckIn.HasValue ? a.CheckIn.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                    CheckOut = a.CheckOut.HasValue ? a.CheckOut.Value.ToString("yyyy-MM-dd HH:mm:ss") : "",
                    WorkDate = a.Shift?.WorkDate.ToString("dd/MM/yyyy") ?? ""
                })
                .ToList();

            dgvAttendance.DataSource = attendances;
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

            LoaddgvAttendance();
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
