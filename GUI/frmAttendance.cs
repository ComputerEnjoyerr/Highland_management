using BLL;
using DAL;
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
    public partial class frmAttendance : Form
    {
        private readonly BLL_Attendance bLL_Attendance = new();
        private readonly BLL_ShiftAssignment bLL_ShiftAssignment = new();
        private readonly BLL_Employee bLL_Employee = new();
        private readonly BLL_WorkShift bLL_WorkShift = new();

        private List<Attendance> attendanceList = new List<Attendance>();
        private List<Employee> employeeList = new List<Employee>();

        public frmAttendance()
        {
            InitializeComponent();
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            // Cấu hình DateTimePicker
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Format = DateTimePickerFormat.Short;

            // Tắt sự kiện tạm thời
            dateTimePicker3.ValueChanged -= dateTimePicker3_ValueChanged;
            dateTimePicker4.ValueChanged -= dateTimePicker4_ValueChanged;

            dateTimePicker3.Value = DateTime.Now;
            dateTimePicker4.Value = DateTime.Now;

            // Cấu hình dgvEmployee
            dgvEmployee.AutoGenerateColumns = true;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.MultiSelect = false;
            dgvEmployee.ReadOnly = true;
            dgvEmployee.AllowUserToAddRows = false;
            dgvEmployee.RowHeadersVisible = true; // tạm bật để thấy
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            


            // Cấu hình dgvAttendance
            dgvAttendance.AutoGenerateColumns = true;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.MultiSelect = false;
            dgvAttendance.ReadOnly = true;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.RowHeadersVisible = true;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Gán sự kiện
            dgvAttendance.CellClick += dgvAttendance_CellClick;
            dgvEmployee.CellClick += dgvEmployee_CellClick;

            dateTimePicker3.ValueChanged += dateTimePicker3_ValueChanged;
            dateTimePicker4.ValueChanged += dateTimePicker4_ValueChanged;

            LoadDataByDateRange();

            // Cấu hình ComboBox Status
            cbStatus.Items.Clear();

            dtCheckIn.Format = DateTimePickerFormat.Time;
            dtCheckIn.ShowUpDown = true;
            dtCheckOut.Format = DateTimePickerFormat.Time;
            dtCheckOut.ShowUpDown = true;

            // Chỉ hiển thị dữ liệu test

        }

        private void LoadDataByDateRange()
        {
            LoadEmployeeByShiftDate();        // dùng dateTimePicker4
            LoadAttendanceByAttendanceDate(); // dùng dateTimePicker3
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker3.Value);

                var assignments = bLL_ShiftAssignment.GetAll()
                    .Where(sa => sa.Shift != null && sa.Shift.WorkDate == selectedDate)
                    .ToList();

                if (!assignments.Any())
                {
                    MessageBox.Show("Không có ca làm trong ngày này.", "Thông báo");
                    return;
                }

                int created = 0, skipped = 0;

                foreach (var sa in assignments)
                {
                    var emp = sa.Employee;
                    if (emp == null || string.IsNullOrEmpty(emp.BranchId)) continue;

                    var existing = bLL_Attendance.GetAll()
                        .FirstOrDefault(a => a.EmployeeId == sa.EmployeeId && a.ShiftId == sa.ShiftId);

                    if (existing != null)
                    {
                        skipped++;
                        continue;
                    }

                    DateTime checkInTime = selectedDate.ToDateTime(sa.Shift.StartTime);
                    DateTime checkOutTime = selectedDate.ToDateTime(sa.Shift.EndTime);

                    var att = new Attendance
                    {
                        Id = bLL_Attendance.GenerateId(),
                        EmployeeId = sa.EmployeeId,
                        ShiftId = sa.ShiftId,
                        BranchId = emp.BranchId,
                        CheckIn = checkInTime,
                        CheckOut = checkOutTime,
                        Status = "Đúng giờ",
                        OvertimeHours = 0,
                        Method = "Tự động",
                        Note = ""
                    };

                    bLL_Attendance.Add(att);
                    created++;
                }

                LoadAttendanceByAttendanceDate();
                LoadEmployeeByShiftDate();
                ApplyRowColors();

                MessageBox.Show(
                    $"Check In hàng loạt thành công!\n" +
                    $"Đã chấm: {created} nhân viên\n",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAttendance.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn 1 nhân viên trong bảng điểm danh.", "Cảnh báo");
                    return;
                }

                var row = dgvAttendance.CurrentRow;
                string employeeId = row.Cells["EmployeeId"].Value?.ToString();
                string shiftId = row.Cells["Id"].Value?.ToString() ?? "";
                string name = row.Cells["EmployeeName"].Value?.ToString() ?? "Không rõ";
                string shiftType = row.Cells["ShiftType"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(employeeId))
                {
                    MessageBox.Show("Không xác định được nhân viên.", "Lỗi");
                    return;
                }

                DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker3.Value);

                // Tìm ca làm của nhân viên đang chọn
                var shiftAssign = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(sa => sa.EmployeeId == employeeId && sa.Shift.WorkDate == selectedDate);

                if (shiftAssign == null)
                {
                    MessageBox.Show("Nhân viên không có ca làm trong ngày này.", "Lỗi");
                    return;
                }

                var emp = bLL_Employee.GetById(employeeId);
                if (emp == null || string.IsNullOrEmpty(emp.BranchId))
                {
                    MessageBox.Show("Nhân viên không hợp lệ!", "Lỗi");
                    return;
                }


                //// TÌM CHÍNH XÁC BẢN GHI CỦA NHÂN VIÊN + CA
                //var existing = bLL_Attendance.GetAll()
                //    .FirstOrDefault(a => a.EmployeeId == employeeId && a.ShiftId == shiftAssign.ShiftId);

                // TÌM BẢN GHI ĐIỂM DANH CHÍNH XÁC THEO Id (Attendance.Id)
                var existing = bLL_Attendance.GetAll()
                    .FirstOrDefault(a => a.Id == shiftId);
                if (existing == null)
                {
                    MessageBox.Show("Không tìm thấy bản ghi điểm danh.", "Lỗi");
                    return;
                }

                //// Nếu đã điểm danh (có giờ vào hoặc ra) → CẤM đánh vắng
                //if (existing != null && (existing.CheckIn.HasValue || existing.CheckOut.HasValue))
                //{
                //    MessageBox.Show($"Không thể đánh vắng vì {name} đã điểm danh!", "Cảnh báo");
                //    return;
                //}

                // Tạo mới nếu chưa có
                if (existing == null)
                {
                    var newAtt = new Attendance
                    {
                        Id = bLL_Attendance.GenerateId(),
                        EmployeeId = employeeId,
                        ShiftId = shiftAssign.ShiftId,
                        BranchId = emp.BranchId,
                        CheckIn = null,
                        CheckOut = null,
                        Status = "Vắng mặt",
                        Method = "Thủ công",
                        Note = string.IsNullOrWhiteSpace(txtNote.Text) ? "Không phép" : txtNote.Text.Trim(),
                        OvertimeHours = 0
                    };
                    bLL_Attendance.Add(newAtt);
                    txtId.Text = newAtt.Id; // Cập nhật form
                }
                else
                {
                    // Xóa giờ nếu có, đặt lại trạng thái
                    existing.CheckIn = null;
                    existing.CheckOut = null;
                    existing.Status = "Vắng mặt";
                    existing.Note = string.IsNullOrWhiteSpace(txtNote.Text) ? "Không phép" : txtNote.Text.Trim();
                    existing.OvertimeHours = 0;
                    bLL_Attendance.Update(existing);
                }

                MessageBox.Show($"Đã đánh vắng: {name} - Ca: {shiftType}", "Thành công");

                // Làm mới dữ liệu
                LoadAttendanceByAttendanceDate();
                LoadEmployeeByShiftDate();
                ApplyRowColors();
                //UpdateCheckInOutControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
            }
        }

        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvAttendance.Rows[e.RowIndex];

            txtId.Text = row.Cells["Id"].Value?.ToString() ?? "";
            txtEmployeeId.Text = row.Cells["EmployeeId"].Value?.ToString() ?? "";
            txtEnployeeName.Text = row.Cells["EmployeeName"].Value?.ToString() ?? "";
            txtShift.Text = row.Cells["ShiftType"].Value?.ToString() ?? "";
            txtNote.Text = row.Cells["Note"].Value?.ToString() ?? "";
            cbStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";

            // Lấy giờ vào
            string checkInStr = row.Cells["CheckIn"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(checkInStr) && DateTime.TryParse(checkInStr, out DateTime ci))
                dtCheckIn.Value = ci;
            else
                dtCheckIn.Value = DateOnly.FromDateTime(dateTimePicker3.Value).ToDateTime(TimeOnly.Parse("08:00"));

            // Lấy giờ ra
            string checkOutStr = row.Cells["CheckOut"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(checkOutStr) && DateTime.TryParse(checkOutStr, out DateTime co))
                dtCheckOut.Value = co;
            else
                dtCheckOut.Value = DateTime.Now;

            var emp = bLL_Employee.GetById(txtEmployeeId.Text);
            if (emp != null)
            {
                txtRole.Text = emp.Role ?? "";
                txtSalaryPerHour.Text = emp.SalaryPerHour.ToString();
                txtPhone.Text = emp.Phone ?? "";
            }

            //UpdateCheckInOutControls(); // QUAN TRỌNG
            ApplyRowColors();

        }
        private void ClearForm()
        {
            txtId.Clear();
            txtEmployeeId.Clear();
            txtEnployeeName.Clear();
            txtRole.Clear();
            txtPhone.Clear();
            txtShift.Clear();
            txtSalaryPerHour.Clear();
            txtNote.Clear();
            cbStatus.Text = "";
            cbStatus.SelectedIndex = -1;
            dtCheckIn.Value = DateTime.Now;
            dtCheckOut.Value = DateTime.Now;
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            var row = dgvEmployee.Rows[e.RowIndex];
            txtEmployeeId.Text = row.Cells["ID"].Value?.ToString() ?? "";
            txtEnployeeName.Text = row.Cells["Name"].Value?.ToString() ?? "";
            txtRole.Text = row.Cells["Role"].Value?.ToString() ?? "";
            txtSalaryPerHour.Text = row.Cells["SalaryPerHour"].Value?.ToString() ?? "";
            txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? "";
            txtShift.Text = row.Cells["ShiftType"].Value?.ToString() ?? "";

            DateOnly workDate = DateOnly.FromDateTime(dateTimePicker3.Value);

            var attendance = bLL_Attendance.GetAll()
                .FirstOrDefault(a => a.EmployeeId == txtEmployeeId.Text
                                  && a.Shift != null
                                  && a.Shift.WorkDate == workDate);

            if (attendance != null)
            {
                txtId.Text = attendance.Id;
                cbStatus.Text = attendance.Status ?? "";
                txtNote.Text = attendance.Note ?? "Không phép";
            }
            else
            {
                txtId.Text = bLL_Attendance.GenerateId();
                cbStatus.Text = "";

                txtNote.Clear();
            }

            // CẬP NHẬT TRẠNG THÁI dtCheckIn & dtCheckOut
           // UpdateCheckInOutControls();

            LoadAttendanceForEmployee(txtEmployeeId.Text);
        }

        private void LoadAttendanceForEmployee(string employeeId)
        {
            if (string.IsNullOrWhiteSpace(employeeId))
            {
                LoadAttendanceByAttendanceDate(); // dùng picker3
                return;
            }

            DateOnly attendanceDate = DateOnly.FromDateTime(dateTimePicker3.Value);

            var attendances = bLL_Attendance.GetAll()
                .Where(a => a.EmployeeId == employeeId && a.Shift != null && a.Shift.WorkDate == attendanceDate)
                .Select(a => new
                {
                    Id = a.Id,
                    EmployeeId = a.EmployeeId,
                    EmployeeName = a.Employee?.EmployeeName ?? "Không rõ",
                    ShiftType = a.Shift?.ShiftType ?? "",
                    Status = a.Status ?? "",
                    CheckIn = a.CheckIn.HasValue ? a.CheckIn.Value.ToString("HH:mm") : "",
                    CheckOut = a.CheckOut.HasValue ? a.CheckOut.Value.ToString("HH:mm") : "",
                    WorkDate = a.Shift?.WorkDate.ToString("dd/MM/yyyy") ?? "",
                    Note = a.Note ?? "Không phép"
                })
                .ToList();

            // Reset DataSource trước khi gán lại
            dgvAttendance.DataSource = null;
            dgvAttendance.DataSource = attendances;
            ApplyRowColors();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceByAttendanceDate();
            dateTimePicker4.Value = dateTimePicker3.Value;
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            LoadEmployeeByShiftDate();
            dateTimePicker3.Value = dateTimePicker4.Value;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LoadEmployeeByShiftDate()
        {
            DateOnly shiftDate = DateOnly.FromDateTime(dateTimePicker4.Value);

            // Lọc nhân viên theo ca làm trong ngày shiftDate
            var shiftAssignments = bLL_ShiftAssignment.GetAll()
                .Where(sa => sa.Shift != null
                          && sa.Employee != null
                            //&& sa.Shift.WorkDate.Day == shiftDate.Day
                            //&& sa.Shift.WorkDate.Month == shiftDate.Month
                            //&& sa.Shift.WorkDate.Year == shiftDate.Year)
                            && sa.Shift.WorkDate == shiftDate)
                .ToList();

            if (shiftAssignments.Count == 0)
            {
                dgvEmployee.DataSource = null;
                return;
            }

            var employees = shiftAssignments
                .Select(sa => new
                {
                    ID = sa.Employee.Id,
                    Name = sa.Employee.EmployeeName,
                    Role = sa.Employee.Role ?? "Không rõ",
                    SalaryPerHour = sa.Employee.SalaryPerHour,
                    Phone = sa.Employee.Phone ?? "Không có",
                    StartDate = sa.Shift.WorkDate.ToString("dd/MM/yyyy"),
                    ShiftType = sa.Shift.ShiftType
                })
                .ToList();

            dgvEmployee.AutoGenerateColumns = true;
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.DataSource = employees;
            dgvEmployee.Visible = true;
            dgvEmployee.Update();
            dgvEmployee.Refresh();
        }

        private void LoadAttendanceByAttendanceDate()
        {


            DateOnly attendanceDate = DateOnly.FromDateTime(dateTimePicker3.Value);
            var attendances = bLL_Attendance.GetAll()
                .Where(a => a.Shift != null && a.Shift.WorkDate == attendanceDate)
                .Select(a => new
                {
                    Id = a.Id,
                    EmployeeId = a.EmployeeId,
                    EmployeeName = a.Employee?.EmployeeName ?? "Không rõ",
                    ShiftType = a.Shift?.ShiftType ?? "",
                    Status = a.Status ?? "",
                    CheckIn = a.CheckIn.HasValue ? a.CheckIn.Value.ToString("HH:mm") : "",
                    CheckOut = a.CheckOut.HasValue ? a.CheckOut.Value.ToString("HH:mm") : "", // ẨN GIỜ RA
                    WorkDate = a.Shift?.WorkDate.ToString("dd/MM/yyyy") ?? "",
                    Note = a.Note ?? "Không phép"
                })
                .ToList();

            dgvAttendance.DataSource = attendances;
            ApplyRowColors();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên trong bảng điểm danh.", "Cảnh báo");
                    return;
                }

                var attendance = bLL_Attendance.GetAll()
                    .FirstOrDefault(a => a.Id == txtId.Text);

                // Nếu chưa có bản ghi → tạo mới
                if (attendance == null)
                {
                    if (!TryCreateNewAttendanceForCheckout(out attendance)) return;
                }

                // Lấy giờ từ form
                DateTime checkInTime = DateOnly.FromDateTime(dateTimePicker3.Value)
                    .ToDateTime(TimeOnly.FromDateTime(dtCheckIn.Value));
                DateTime checkOutTime = DateOnly.FromDateTime(dateTimePicker3.Value)
                    .ToDateTime(TimeOnly.FromDateTime(dtCheckOut.Value));

                if (checkOutTime <= checkInTime)
                {
                    MessageBox.Show("Giờ ra phải lớn hơn giờ vào!", "Cảnh báo");
                    return;
                }

                // Tính trạng thái
                var shiftAssign = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(sa => sa.EmployeeId == txtEmployeeId.Text && sa.ShiftId == attendance.ShiftId);
                if (shiftAssign == null)
                {
                    MessageBox.Show("Không tìm thấy ca làm.", "Lỗi");
                    return;
                }

                TimeSpan shiftStart = shiftAssign.Shift.StartTime.ToTimeSpan();
                TimeSpan shiftEnd = shiftAssign.Shift.EndTime.ToTimeSpan();
                bool late = checkInTime.TimeOfDay > shiftStart.Add(TimeSpan.FromMinutes(15));
                bool early = checkOutTime.TimeOfDay < shiftEnd.Subtract(TimeSpan.FromMinutes(15));
                string status = "Đúng giờ";
                if (late && early) status = "Đi muộn và Về sớm";
                else if (late) status = "Đi muộn";
                else if (early) status = "Về sớm";

                TimeSpan worked = checkOutTime - checkInTime;
                double shiftHours = (shiftEnd - shiftStart).TotalHours;
                decimal overtime = worked.TotalHours > shiftHours ? (decimal)(worked.TotalHours - shiftHours) : 0;

                // Cập nhật
                attendance.CheckIn = checkInTime;
                attendance.CheckOut = checkOutTime;
                attendance.Status = status;
                attendance.OvertimeHours = overtime;
                attendance.Method = "Thủ công";
                attendance.Note = txtNote.Text;

                if (attendance.Id == null) // mới tạo
                    bLL_Attendance.Add(attendance);
                else
                    bLL_Attendance.Update(attendance);

                MessageBox.Show($"Check Out thành công!\nTrạng thái: {status}\nOT: {overtime:F1}h", "Thành công");
                LoadAttendanceByAttendanceDate();
                LoadEmployeeByShiftDate();
                ApplyRowColors();
                //UpdateCheckInOutControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi");
            }
        }

        //cập nhập trạng thái check in check out
        private void UpdateCheckInOutControls()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                dtCheckIn.Enabled = dtCheckOut.Enabled = false;
                return;
            }

            var attendance = bLL_Attendance.GetAll()
                .FirstOrDefault(a => a.Id == txtId.Text);

            // Nếu chưa có bản ghi → cho phép nhập cả vào + ra
            if (attendance == null)
            {
                dtCheckIn.Enabled = true;
                dtCheckOut.Enabled = true;
                return;
            }

            // CHỈ KHÓA KHI ĐÃ CHECK OUT
            if (attendance.CheckOut.HasValue)
            {
                dtCheckIn.Enabled = dtCheckOut.Enabled = false;
            }
            else
            {
                dtCheckIn.Enabled = true;
                dtCheckOut.Enabled = true;
            }
        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dgvAttendance.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells["Status"].Value?.ToString()?.Trim() ?? "";

                if (status.Contains("Vắng")) row.DefaultCellStyle.BackColor = Color.LightCoral;
                else if (status.Contains("muộn") && status.Contains("sớm")) row.DefaultCellStyle.BackColor = Color.Orange;
                else if (status.Contains("muộn")) row.DefaultCellStyle.BackColor = Color.Salmon;
                else if (status.Contains("sớm")) row.DefaultCellStyle.BackColor = Color.Khaki;
                else if (status.Contains("Đúng giờ")) row.DefaultCellStyle.BackColor = Color.LightGreen;
                else row.DefaultCellStyle.BackColor = Color.White;
            }
        }
        private bool TryCreateNewAttendanceForCheckout(out Attendance attendance)
        {
            attendance = null;
            string employeeId = txtEmployeeId.Text;
            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Không xác định nhân viên.", "Lỗi");
                return false;
            }

            DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker3.Value);
            var shiftAssign = bLL_ShiftAssignment.GetAll()
                .FirstOrDefault(sa => sa.EmployeeId == employeeId && sa.Shift.WorkDate == selectedDate);
            if (shiftAssign == null)
            {
                MessageBox.Show("Nhân viên không có ca làm trong ngày này.", "Lỗi");
                return false;
            }

            var emp = bLL_Employee.GetById(employeeId);
            if (emp == null || string.IsNullOrEmpty(emp.BranchId)) return false;

            attendance = new Attendance
            {
                Id = bLL_Attendance.GenerateId(),
                EmployeeId = employeeId,
                ShiftId = shiftAssign.ShiftId,
                BranchId = emp.BranchId,
                Status = "Đúng giờ", // sẽ cập nhật sau
                Method = "Thủ công",
                Note = txtNote.Text,
                OvertimeHours = 0
            };

            txtId.Text = attendance.Id; // cập nhật form
            return true;
        }
    }
}
