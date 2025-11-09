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
    public partial class frmScheduleInfo : Form
    {
        private readonly BLL_ShiftAssignment bLL_ShiftAssignment = new BLL_ShiftAssignment();
        private readonly BLL_Employee bLL_Employee = new BLL_Employee();
        private readonly BLL_WorkShift bLL_WorkShift = new BLL_WorkShift();
        private readonly BLL_WorkSchedule bLL_WorkSchedule = new BLL_WorkSchedule();
        private string month, day;
        private int year;
        private Employee employee = new Employee();

        private List<Employee> employeeList = new List<Employee>();
        private List<ShiftAssignment> shiftAssignments = new List<ShiftAssignment>();
        private List<ShiftAssignment> shiftMorningList = new();
        private List<ShiftAssignment> shiftAfternoonList = new();
        private List<ShiftAssignment> shiftEveningList = new();

        public frmScheduleInfo(Employee employee, string day, string month, int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.day = day;
            this.employee = employee;
        }

        private void frmScheduleInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Ca làm việc | Ngày " + this.day + " tháng " + this.month + " năm " + this.year;
            LoadEmployees();
            LoadShift();
            LoadEmployeeByShift("Sáng");
            LoadEmployeeByShift("Chiều");
            LoadEmployeeByShift("Tối");
        }

        // Hàm dọn dẹp dữ liệu trên các toolbox
        private void ClearDataEmployee()
        {
            txtEmployeeId.Clear();
            txtEmployeeName.Clear();
            txtEmployeeRole.Clear();
            txtEmployeeAddress.Clear();
            cboEmployeeShift.SelectedIndex = -1;
        }

        private void ClearDataMorning()
        {
            txtIdMorning.Clear();
            txtNameMorning.Clear();
            txtRoleMorning.Clear();
            txtAddressMorning.Clear();
        }

        private void ClearDataAfternoon()
        {
            txtIdAfternoon.Clear();
            txtNameAfternoon.Clear();
            txtRoleAfternoon.Clear();
            txtAddressAfternoon.Clear();
        }

        private void ClearDataEvening()
        {
            txtIdEvening.Clear();
            txtNameEvening.Clear();
            txtRoleEvening.Clear();
            txtAddressEvening.Clear();
        }

        // Hàm load ca làm việc
        private void LoadShift()
        {
            cboEmployeeShift.Items.Clear();
            cboEmployeeShift.Items.Add("Sáng");
            cboEmployeeShift.Items.Add("Chiều");
            cboEmployeeShift.Items.Add("Tối");
            cboEmployeeShift.SelectedIndex = 0;

            cboShiftMorning.Items.Clear();
            cboShiftMorning.Items.Add("Sáng");
            cboShiftMorning.SelectedIndex = 0;

            cboShiftAfternoon.Items.Clear();
            cboShiftAfternoon.Items.Add("Chiều");
            cboShiftAfternoon.SelectedIndex = 0;

            cboShiftEvening.Items.Clear();
            cboShiftEvening.Items.Add("Tối");
            cboShiftEvening.SelectedIndex = 0;
        }


        // Hàm load dữ liệu nhân viên lên DataGridView
        private void LoadEmployees(string keyword = "")
        {
            dgvSchedule.MultiSelect = false;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.ReadOnly = true;

            // Lấy chi nhánh hiện tại của người đăng nhập
            var currentBranchId = employee.BranchId;

            // Lấy toàn bộ nhân viên thuộc chi nhánh đó
            var employeesQuery = bLL_Employee.GetAll()
                .Where(e => e.BranchId == currentBranchId &&
                            (e.Role == "Nhân viên" || e.Role == "Thời vụ"));

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                employeesQuery = employeesQuery.Where(e =>
                    e.EmployeeName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    e.Id.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase));
            }

            employeeList = employeesQuery.ToList();

            // Dựng danh sách hiển thị
            var employees = employeeList
                .Select(e => new
                {
                    e.Id,
                    e.EmployeeName,
                    e.Phone,
                    e.CitizenId,
                    e.HireDate,
                    e.Role
                })
                .ToList();

            dgvSchedule.DataSource = employees;
        }


        // Hàm load nhân viên theo ca làm việc (lọc theo chi nhánh và từ khóa tìm kiếm)
        public void LoadEmployeeByShift(string shift)
        {
            if (string.IsNullOrEmpty(shift))
            {
                MessageBox.Show("Ca làm việc không hợp lệ!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy từ khóa tìm kiếm tương ứng với từng ca
            string keyword = shift switch
            {
                "Sáng" => txtFindMorning.Text.Trim().ToLower(),
                "Chiều" => txtFindAfternoon.Text.Trim().ToLower(),
                "Tối" => txtFindEvening.Text.Trim().ToLower(),
                _ => ""
            };

            // Lấy danh sách phân công theo ngày + ca
            var assignments = bLL_ShiftAssignment.GetByDateAndShift(
                int.Parse(day), int.Parse(month), year, shift);

            // Lọc theo chi nhánh hiện tại
            var currentBranchId = employee.BranchId;
            var filteredAssignments = assignments
                .Where(a => a.Employee != null &&
                            a.Shift != null &&
                            a.Shift.WorkSchedule != null &&
                            a.Shift.WorkSchedule.BranchId == currentBranchId &&
                            (a.Employee.Role == "Nhân viên" || a.Employee.Role == "Thời vụ"))
                .ToList();

            // Lưu danh sách riêng cho từng ca
            switch (shift)
            {
                case "Sáng":
                    shiftMorningList = filteredAssignments;
                    break;
                case "Chiều":
                    shiftAfternoonList = filteredAssignments;
                    break;
                case "Tối":
                    shiftEveningList = filteredAssignments;
                    break;
            }


            // Nếu có từ khóa thì lọc thêm
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                filteredAssignments = filteredAssignments
                    .Where(a =>
                        a.Employee.Id.ToLower().Contains(keyword) ||
                        a.Employee.EmployeeName.ToLower().Contains(keyword) ||
                        (!string.IsNullOrEmpty(a.Note) && a.Note.ToLower().Contains(keyword)))
                    .ToList();
            }

            // Chuẩn bị dữ liệu hiển thị
            var data = filteredAssignments.Select(a => new
            {
                ID = a.Employee?.Id,
                Name = a.Employee?.EmployeeName,
                Phone = a.Employee?.Phone,
                Role = a.Employee?.Role,
                Note = string.IsNullOrEmpty(a.Note) ? "" : a.Note,
                WorkDate = a.Shift?.WorkDate.ToString("dd/MM/yyyy"),

                // thêm StartTime và EndTime
                StartTime = a.Shift?.StartTime.ToString("hh\\:mm tt"),
                EndTime = a.Shift?.EndTime.ToString("hh\\:mm tt")
            }).ToList();


            // Gán vào DataGridView tương ứng
            DataGridView? dgv = shift switch
            {
                "Sáng" => dgvShiftMorning,
                "Chiều" => dgvShiftAfternoon,
                "Tối" => dgvShiftEvening,
                _ => null
            };

            if (dgv == null) return;

            dgv.DataSource = data;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;

            // Nếu không có dữ liệu thì xóa hết hàng cũ
            if (data.Count == 0)
                dgv.DataSource = null;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần đăng kí từ bảng.", "Cảnh báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy thông tin nhân viên và ca làm việc
                string employeeId = txtEmployeeId.Text;
                string employeeName = txtEmployeeName.Text;
                string employeeRole = txtEmployeeRole.Text;
                string employeeAddress = txtEmployeeAddress.Text;
                string employeeShift = cboEmployeeShift.SelectedItem?.ToString() ?? "";
                string? note = txtNote.Text?.Trim();

                // Nếu có nhập thì kiểm tra độ dài
                if (!string.IsNullOrEmpty(note) && note.Length > 200)
                {
                    MessageBox.Show("Ghi chú không được vượt quá 200 ký tự!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Chuyển ngày, tháng, năm về kiểu DateOnly
                var selectedDate = new DateOnly(year, int.Parse(month), int.Parse(day));

                if (string.IsNullOrEmpty(cboEmployeeShift.Text))
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nhân viên đã đăng ký cùng ca trong cùng ngày chưa
                var existingAssignment = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(a =>
                        a.EmployeeId == employeeId &&
                        a.Shift != null &&
                        a.Shift.WorkDate == selectedDate &&
                        a.Shift.ShiftType == employeeShift);

                if (existingAssignment != null)
                {
                    MessageBox.Show(
                        $"Nhân viên {employeeName} đã đăng ký ca {existingAssignment?.Shift?.ShiftType} trong ngày {selectedDate:dd/MM/yyyy}.",
                        "Trùng ca làm việc",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                int offset = selectedDate.DayOfWeek == DayOfWeek.Sunday
                    ? -6 // Nếu là Chủ nhật thì lùi về Thứ 2 của tuần hiện tại
                    : DayOfWeek.Monday - selectedDate.DayOfWeek;

                // Tính ngày bắt đầu và kết thúc tuần (kiểu DateOnly)
                var weekStart = selectedDate.AddDays((int)offset);
                var weekEnd = weekStart.AddDays(6);

                // Lấy lịch làm việc trong tuần đó
                var workSchedule = bLL_WorkSchedule.GetByBranchAndWeek(employee.BranchId, weekStart, weekEnd);

                if (workSchedule == null)
                {
                    workSchedule = new WorkSchedule
                    {
                        Id = bLL_WorkSchedule.GenerateScheduleId(),
                        BranchId = employee.BranchId,
                        WeekStart = weekStart,
                        WeekEnd = weekEnd,
                        CreatedBy = employeeId,
                        CreatedAt = DateTime.Now
                    };
                    bLL_WorkSchedule.Add(workSchedule);
                }

                // Kiểm tra ca làm việc
                var workShift = bLL_WorkShift.GetShiftByDateAndType(selectedDate, employeeShift, employee.BranchId);

                if (workShift == null)
                {
                    // Xác định giờ theo loại ca
                    TimeSpan startTime, endTime;
                    switch (employeeShift)
                    {
                        case "Sáng":
                            startTime = new TimeSpan(6, 0, 0);
                            endTime = new TimeSpan(12, 0, 0);
                            break;
                        case "Chiều":
                            startTime = new TimeSpan(12, 0, 0);
                            endTime = new TimeSpan(18, 0, 0);
                            break;
                        case "Tối":
                            startTime = new TimeSpan(18, 0, 0);
                            endTime = new TimeSpan(23, 0, 0);
                            break;
                        default:
                            MessageBox.Show("Ca làm việc không hợp lệ!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    workShift = new WorkShift
                    {
                        Id = bLL_WorkShift.GenerateShiftId(),
                        ScheduleId = workSchedule.Id,
                        WorkDate = selectedDate,
                        ShiftType = employeeShift,
                        StartTime = TimeOnly.FromTimeSpan(startTime),
                        EndTime = TimeOnly.FromTimeSpan(endTime)
                    };
                    bLL_WorkShift.Add(workShift);
                }

                ShiftAssignment newAssignment = new ShiftAssignment
                {
                    Id = bLL_ShiftAssignment.GenerateShiftAssignmentId(),
                    EmployeeId = employeeId,
                    ShiftId = workShift.Id,
                    Note = string.IsNullOrEmpty(note) ? null : note
                };
                bLL_ShiftAssignment.Add(newAssignment);

                MessageBox.Show("Đăng ký ca làm việc thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Làm mới dữ liệu hiển thị
                LoadEmployeeByShift(employeeShift);
                ClearDataEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng ký: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dvgSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < employeeList.Count)
            {
                var selectedEmployee = employeeList[e.RowIndex];
                frmEmployeeSchedule frm = new frmEmployeeSchedule(selectedEmployee);
                frm.ShowDialog();
            }
        }


        // -- Chức năng tìm kiếm nhân viên --

        // Biển theo dõi công tác nhập liệu
        private CancellationTokenSource _cts = new();
        private async void txtEmployeeFind_TextChanged(object sender, EventArgs e)
        {
            string input = txtEmployeeFind.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadEmployees(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        // Hàm tìm kiếm
        private async Task SearchWithDelay(string shift)
        {
            _cts?.Cancel();
            _cts = new CancellationTokenSource();
            try
            {
                await Task.Delay(500, _cts.Token);
                LoadEmployeeByShift(shift);
            }
            catch (TaskCanceledException)
            {
                // Bỏ qua khi người dùng vẫn đang nhập
            }
        }

        private async void txtFindMorning_TextChanged(object sender, EventArgs e)
        {
            await SearchWithDelay("Sáng");
        }

        private async void txtFindAfternoon_TextChanged(object sender, EventArgs e)
        {
            await SearchWithDelay("Chiều");
        }

        private async void txtFindEvening_TextChanged(object sender, EventArgs e)
        {
            await SearchWithDelay("Tối");
        }

        private void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < employeeList.Count)
            {
                var selectedRow = employeeList[e.RowIndex];

                txtEmployeeId.Text = selectedRow.Id;
                txtEmployeeName.Text = selectedRow.EmployeeName;
                txtEmployeeRole.Text = selectedRow.Role;
                txtEmployeeAddress.Text = selectedRow.Address?.Name ?? "";
            }
        }

        private void dgvShiftMorning_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < shiftMorningList.Count)
            {
                var selectedRow = shiftMorningList[e.RowIndex];
                if (selectedRow?.Employee == null) return;

                txtIdMorning.Text = selectedRow.Employee.Id;
                txtNameMorning.Text = selectedRow.Employee.EmployeeName;
                txtRoleMorning.Text = selectedRow.Employee.Role;
                txtAddressMorning.Text = selectedRow.Employee.Address?.Name ?? "";
            }
        }


        private void dgvShiftAfternoon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < shiftAfternoonList.Count)
            {
                var selectedRow = shiftAfternoonList[e.RowIndex];
                if (selectedRow?.Employee == null) return;

                txtIdAfternoon.Text = selectedRow.Employee.Id;
                txtNameAfternoon.Text = selectedRow.Employee.EmployeeName;
                txtRoleAfternoon.Text = selectedRow.Employee.Role;
                txtAddressAfternoon.Text = selectedRow.Employee.Address?.Name ?? "";
            }
        }


        private void dgvShiftEvening_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < shiftEveningList.Count)
            {
                var selectedRow = shiftEveningList[e.RowIndex];
                if (selectedRow?.Employee == null) return;

                txtIdEvening.Text = selectedRow.Employee.Id;
                txtNameEvening.Text = selectedRow.Employee.EmployeeName;
                txtRoleEvening.Text = selectedRow.Employee.Role;
                txtAddressEvening.Text = selectedRow.Employee.Address?.Name ?? "";
            }
        }


        private void btnCancelMorning_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdMorning.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần hủy ca.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string employeeId = txtIdMorning.Text;
                string employeeName = txtNameMorning.Text;
                string employeeShift = cboShiftMorning.SelectedItem?.ToString() ?? "";

                // Kiểm tra xem đã chọn ca làm việc hay chưa
                if (string.IsNullOrEmpty(employeeShift))
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần hủy!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ngày hiện tại trên form
                var selectedDate = new DateOnly(year, int.Parse(month), int.Parse(day));

                // Tìm ca làm việc tương ứng
                var assignment = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(a =>
                        a.EmployeeId == employeeId &&
                        a.Shift != null &&
                        a.Shift.WorkDate == selectedDate &&
                        a.Shift.ShiftType == employeeShift);

                if (assignment == null)
                {
                    MessageBox.Show($"Nhân viên {employeeName} chưa đăng ký ca {employeeShift} trong ngày {selectedDate:dd/MM/yyyy}.",
                        "Không tìm thấy",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Xác nhận người dùng
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn hủy ca {employeeShift} của nhân viên {employeeName} trong ngày {selectedDate:dd/MM/yyyy} không?",
                    "Xác nhận hủy ca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Gọi BLL để xóa
                    bLL_ShiftAssignment.Delete(assignment);

                    MessageBox.Show("Đã hủy ca làm việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại danh sách nhân viên theo ca
                    LoadEmployeeByShift(employeeShift);
                    ClearDataMorning();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy ca: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelAfternoon_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdAfternoon.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần hủy ca.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string employeeId = txtIdAfternoon.Text;
                string employeeName = txtNameAfternoon.Text;
                string employeeShift = cboShiftAfternoon.SelectedItem?.ToString() ?? "";

                // Kiểm tra xem đã chọn ca làm việc hay chưa
                if (string.IsNullOrEmpty(employeeShift))
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần hủy!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ngày hiện tại trên form
                var selectedDate = new DateOnly(year, int.Parse(month), int.Parse(day));

                // Tìm ca làm việc tương ứng
                var assignment = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(a =>
                        a.EmployeeId == employeeId &&
                        a.Shift != null &&
                        a.Shift.WorkDate == selectedDate &&
                        a.Shift.ShiftType == employeeShift);

                if (assignment == null)
                {
                    MessageBox.Show($"Nhân viên {employeeName} chưa đăng ký ca {employeeShift} trong ngày {selectedDate:dd/MM/yyyy}.",
                        "Không tìm thấy",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Xác nhận người dùng
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn hủy ca {employeeShift} của nhân viên {employeeName} trong ngày {selectedDate:dd/MM/yyyy} không?",
                    "Xác nhận hủy ca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Gọi BLL để xóa
                    bLL_ShiftAssignment.Delete(assignment);

                    MessageBox.Show("Đã hủy ca làm việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại danh sách nhân viên theo ca
                    LoadEmployeeByShift(employeeShift);
                    ClearDataAfternoon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy ca: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelEvening_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEvening.Text))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần hủy ca.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string employeeId = txtIdEvening.Text;
                string employeeName = txtNameEvening.Text;
                string employeeShift = cboShiftEvening.SelectedItem?.ToString() ?? "";

                // Kiểm tra xem đã chọn ca làm việc hay chưa
                if (string.IsNullOrEmpty(employeeShift))
                {
                    MessageBox.Show("Vui lòng chọn ca làm việc cần hủy!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ngày hiện tại trên form
                var selectedDate = new DateOnly(year, int.Parse(month), int.Parse(day));

                // Tìm ca làm việc tương ứng
                var assignment = bLL_ShiftAssignment.GetAll()
                    .FirstOrDefault(a =>
                        a.EmployeeId == employeeId &&
                        a.Shift != null &&
                        a.Shift.WorkDate == selectedDate &&
                        a.Shift.ShiftType == employeeShift);

                if (assignment == null)
                {
                    MessageBox.Show($"Nhân viên {employeeName} chưa đăng ký ca {employeeShift} trong ngày {selectedDate:dd/MM/yyyy}.",
                        "Không tìm thấy",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Xác nhận người dùng
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn hủy ca {employeeShift} của nhân viên {employeeName} trong ngày {selectedDate:dd/MM/yyyy} không?",
                    "Xác nhận hủy ca",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // Gọi BLL để xóa
                    bLL_ShiftAssignment.Delete(assignment);

                    MessageBox.Show("Đã hủy ca làm việc thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cập nhật lại danh sách nhân viên theo ca
                    LoadEmployeeByShift(employeeShift);
                    ClearDataEvening();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hủy ca: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
