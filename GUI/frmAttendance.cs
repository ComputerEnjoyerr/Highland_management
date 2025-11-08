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


            // Cấu hình dgvAttendance
            dgvAttendance.AutoGenerateColumns = true;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.MultiSelect = false;
            dgvAttendance.ReadOnly = true;
            dgvAttendance.AllowUserToAddRows = false;
            dgvAttendance.RowHeadersVisible = true;

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
                if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần Check In.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker3.Value);
                var shiftAssign = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(sa => sa.EmployeeId == txtEmployeeId.Text && sa.Shift != null && sa.Shift.WorkDate == selectedDate);

                if (shiftAssign == null)
                {
                    MessageBox.Show("Nhân viên này hôm nay không có ca làm.", "Thông báo");
                    return;
                }

                var existing = bLL_Attendance.GetAll()
                    .FirstOrDefault(a => a.EmployeeId == txtEmployeeId.Text && a.ShiftId == shiftAssign.ShiftId);

                if (existing != null && existing.CheckIn.HasValue)
                {
                    MessageBox.Show("Nhân viên này đã Check In rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DateTime selectedCheckInTime = dateTimePicker3.Value.Date + dtCheckIn.Value.TimeOfDay;
                TimeOnly checkInOnly = TimeOnly.FromDateTime(selectedCheckInTime);
                TimeOnly startTime = shiftAssign.Shift.StartTime;


                var employee = bLL_Employee.GetById(txtEmployeeId.Text);
                if (string.IsNullOrEmpty(employee?.BranchId))
                {
                    MessageBox.Show("Nhân viên không thuộc chi nhánh nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (existing == null)
                {
                    var attendance = new Attendance
                    {
                        Id = bLL_Attendance.GenerateId(),
                        EmployeeId = txtEmployeeId.Text,
                        ShiftId = shiftAssign.ShiftId,
                        BranchId = employee.BranchId,
                        CheckIn = selectedCheckInTime,
                        CheckOut = null,
                        Status = "Đang làm việc",
                        Method = "Thủ công",
                        Note = txtNote.Text
                    };
                    bLL_Attendance.Add(attendance);
                }
                else
                {
                    existing.CheckIn = selectedCheckInTime;
                    existing.Status = "";
                    existing.Note = txtNote.Text;
                    bLL_Attendance.Update(existing);
                }

                MessageBox.Show($"Check In thành công lúc {checkInOnly:HH:mm}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // CẬP NHẬT LẠI TRẠNG THÁI CONTROL
                UpdateCheckInOutControls();
                LoadAttendanceByAttendanceDate();
            }
            catch (Exception ex)
            {
                string inner = ex.InnerException?.Message ?? "Không có";
                MessageBox.Show($"Lỗi: {ex.Message}\nChi tiết: {inner}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần đánh vắng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker3.Value);
                var shiftAssign = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(sa => sa.EmployeeId == txtEmployeeId.Text
                                       && sa.Shift != null
                                       && sa.Shift.WorkDate == selectedDate);

                if (shiftAssign == null)
                {
                    MessageBox.Show("Nhân viên này hôm nay không có lịch làm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingAttendance = bLL_Attendance.GetAll()
                    .FirstOrDefault(a => a.EmployeeId == txtEmployeeId.Text && a.ShiftId == shiftAssign.ShiftId);

                // NẾU ĐÃ CÓ BẢN GHI → KIỂM TRA TRẠNG THÁI
                if (existingAttendance != null)
                {
                    if (existingAttendance.CheckIn.HasValue || existingAttendance.CheckOut.HasValue)
                    {
                        MessageBox.Show("Nhân viên này đã điểm danh — không thể đánh vắng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    // Nếu đã có bản ghi nhưng chưa Check In → cho phép đánh vắng (trường hợp hiếm)
                }

                var employee = bLL_Employee.GetById(txtEmployeeId.Text);
                if (string.IsNullOrEmpty(employee?.BranchId))
                {
                    MessageBox.Show("Nhân viên không thuộc chi nhánh nào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // TẠO HOẶC CẬP NHẬT BẢN GHI "VẮNG MẶT"
                Attendance attendance;
                if (existingAttendance == null)
                {
                    attendance = new Attendance
                    {
                        Id = bLL_Attendance.GenerateId(),
                        EmployeeId = txtEmployeeId.Text,
                        ShiftId = shiftAssign.ShiftId,
                        BranchId = employee.BranchId,
                        CheckIn = null,
                        CheckOut = null,
                        Status = "Vắng mặt",
                        Method = "Thủ công",
                        Note = txtNote.Text ?? "Không phép"
                    };
                    bLL_Attendance.Add(attendance);
                }
                else
                {
                    existingAttendance.Status = "Vắng mặt";
                    existingAttendance.Note = txtNote.Text ?? "Không phép";
                    bLL_Attendance.Update(existingAttendance);
                    attendance = existingAttendance;
                }

                MessageBox.Show($"Đã đánh vắng nhân viên {employee.EmployeeName} thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // CẬP NHẬT GIAO DIỆN
                UpdateCheckInOutControls();
                LoadAttendanceByAttendanceDate();
                LoadAttendanceForEmployee(txtEmployeeId.Text); // Cập nhật chi tiết
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đánh vắng: " + (ex.InnerException?.Message ?? ex.Message), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cbStatus.Text = row.Cells["Status"].Value?.ToString() ?? "";

            // === SỬA TẠI ĐÂY: KIỂM TRA null TRƯỚC KHI GÁN ===
            string checkInStr = row.Cells["CheckIn"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(checkInStr) && DateTime.TryParse(checkInStr, out DateTime checkIn))
            {
                dtCheckIn.Value = checkIn;
            }
            else
            {
                // Nếu null hoặc rỗng → gợi ý giờ ca làm
                DateOnly workDate = DateOnly.FromDateTime(dateTimePicker3.Value);
                var shift = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(sa => sa.EmployeeId == txtEmployeeId.Text && sa.Shift?.WorkDate == workDate);
                dtCheckIn.Value = shift != null
                    ? workDate.ToDateTime(shift.Shift.StartTime)
                    : DateTime.Now;
            }

            string checkOutStr = row.Cells["CheckOut"].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(checkOutStr) && DateTime.TryParse(checkOutStr, out DateTime checkOut))
            {
                dtCheckOut.Value = checkOut;
            }
            else
            {
                dtCheckOut.Value = DateTime.Now;
            }

            var employee = bLL_Employee.GetById(txtEmployeeId.Text);
            if (employee != null)
            {
                txtRole.Text = employee.Role ?? "";
                txtSalaryPerHour.Text = employee.SalaryPerHour.ToString();
                txtPhone.Text = employee.Phone ?? "";
            }
            txtNote.Text = row.Cells["Note"].Value?.ToString() ?? "Không phép";

            // BẮT BUỘC GỌI HÀM NÀY
            UpdateCheckInOutControls();

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
            UpdateCheckInOutControls();

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
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần Check Out.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateOnly selectedDate = DateOnly.FromDateTime(dateTimePicker3.Value);
                var shiftAssign = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(sa => sa.EmployeeId == txtEmployeeId.Text
                                       && sa.Shift != null
                                       && sa.Shift.WorkDate == selectedDate);

                if (shiftAssign == null)
                {
                    MessageBox.Show("Không tìm thấy ca làm việc hôm nay.", "Thông báo");
                    return;
                }

                var attendance = bLL_Attendance.GetAll()
                    .FirstOrDefault(a => a.EmployeeId == txtEmployeeId.Text && a.ShiftId == shiftAssign.ShiftId);

                if (attendance == null || !attendance.CheckIn.HasValue)
                {
                    MessageBox.Show("Nhân viên chưa Check In!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (attendance.CheckOut.HasValue)
                {
                    MessageBox.Show("Nhân viên đã Check Out rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // LẤY GIỜ CHECK IN & CHECK OUT
                DateTime checkInTime = attendance.CheckIn.Value;
                DateTime checkOutTime = dateTimePicker3.Value.Date + dtCheckOut.Value.TimeOfDay;

                // TÍNH GIỜ CA LÀM
                TimeSpan shiftStart = shiftAssign.Shift.StartTime.ToTimeSpan();
                TimeSpan shiftEnd = shiftAssign.Shift.EndTime.ToTimeSpan();
                TimeSpan checkInActual = checkInTime.TimeOfDay;
                TimeSpan checkOutActual = checkOutTime.TimeOfDay;

                // XÁC ĐỊNH ĐI TRỄ
                bool late = checkInActual > shiftStart.Add(TimeSpan.FromMinutes(15));

                // XÁC ĐỊNH VỀ SỚM
                bool early = checkOutActual < shiftEnd;

                // XÁC ĐỊNH TRẠNG THÁI
                string status;
                if (late && early)
                    status = "Đi muộn và Về sớm";
                else if (late)
                    status = "Đi muộn";
                else if (early)
                    status = "Về sớm";
                else
                    status = "Đúng giờ";

                // TÍNH GIỜ LÀM THỰC TẾ
                TimeSpan worked = checkOutTime - checkInTime;
                double workedHours = worked.TotalHours;

                // TÍNH GIỜ CA CHUẨN
                TimeSpan shiftDuration = shiftEnd - shiftStart;
                double shiftHours = shiftDuration.TotalHours;

                // TÍNH OT
                decimal overtime = 0;
                if (workedHours > shiftHours)
                {
                    overtime = (decimal)(workedHours - shiftHours);
                    //status += "";
                }

                // CẬP NHẬT ATTENDANCE
                attendance.CheckOut = checkOutTime;
                attendance.Status = status;
                attendance.OvertimeHours = overtime;
                attendance.Method = "Thủ công";
                attendance.Note = txtNote.Text;

                bLL_Attendance.Update(attendance);

                // HIỂN THỊ KẾT QUẢ
                MessageBox.Show(
                    $"Check Out thành công!\n" +
                    $"Check In: {checkInTime:HH:mm} | Check Out: {checkOutTime:HH:mm}\n" +
                    $"Giờ làm: {workedHours:F1}h | OT: {overtime:F1}h\n" +
                    $"Trạng thái: {status}",
                    "Check Out",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // CẬP NHẬT GIAO DIỆN
                UpdateCheckInOutControls();
                LoadAttendanceByAttendanceDate();
            }
            catch (Exception ex)
            {
                string inner = ex.InnerException?.Message ?? "Không có";
                MessageBox.Show($"Lỗi Check Out:\n{ex.Message}\nChi tiết: {inner}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //cập nhập trạng thái check in check out
        private void UpdateCheckInOutControls()
        {
            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
            {
                dtCheckIn.Enabled = false;
                dtCheckOut.Enabled = false;
                return;
            }

            DateOnly workDate = DateOnly.FromDateTime(dateTimePicker3.Value);
            var shiftAssign = bLL_ShiftAssignment.GetAll()
                .FirstOrDefault(sa => sa.EmployeeId == txtEmployeeId.Text
                                   && sa.Shift != null
                                   && sa.Shift.WorkDate == workDate);

            if (shiftAssign == null)
            {
                dtCheckIn.Enabled = false;
                dtCheckOut.Enabled = false;
                return;
            }

            var attendance = bLL_Attendance.GetAll()
                .FirstOrDefault(a => a.EmployeeId == txtEmployeeId.Text && a.ShiftId == shiftAssign.ShiftId);

            if (attendance == null)
            {
                // Chưa điểm danh
                dtCheckIn.Enabled = true;
                dtCheckOut.Enabled = false;
                dtCheckIn.Value = workDate.ToDateTime(shiftAssign.Shift.StartTime);
                dtCheckOut.Value = workDate.ToDateTime(shiftAssign.Shift.EndTime);
            }
            else if (attendance.CheckIn.HasValue && !attendance.CheckOut.HasValue)
            {
                // Đã Check In, chưa Check Out
                dtCheckIn.Enabled = false;
                dtCheckOut.Enabled = true;
                dtCheckIn.Value = attendance.CheckIn.Value; // AN TOÀN
                dtCheckOut.Value = DateTime.Now;
            }
            else if (!attendance.CheckIn.HasValue)
            {
                // Đánh vắng (CheckIn = null)
                dtCheckIn.Enabled = false;
                dtCheckOut.Enabled = false;
                dtCheckIn.Value = workDate.ToDateTime(shiftAssign.Shift.StartTime); // Gợi ý giờ ca
                dtCheckOut.Value = workDate.ToDateTime(shiftAssign.Shift.EndTime);
            }
            else
            {
                // Đã Check Out
                dtCheckIn.Enabled = false;
                dtCheckOut.Enabled = false;
                dtCheckIn.Value = attendance.CheckIn.Value;
                dtCheckOut.Value = attendance.CheckOut.Value;
            }
        }

        private void dtCheckIn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
