using BLL;
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
        public frmScheduleInfo(string day, string month, int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.day = day;

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
            cboShiftMorning.SelectedIndex = -1;
        }

        private void ClearDataAfternoon()
        {
            txtIdAfternoon.Clear();
            txtNameAfternoon.Clear();
            txtRoleAfternoon.Clear();
            txtAddressAfternoon.Clear();
            cboShiftAfternoon.SelectedIndex = -1;
        }

        private void ClearDataEvening()
        {
            txtIdEvening.Clear();
            txtNameEvening.Clear();
            txtRoleEvening.Clear();
            txtAddressEvening.Clear();
            cboShiftEvening.SelectedIndex = -1;
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

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var filteredList = bLL_Employee.GetAll()
                    .Where(e => e.EmployeeName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                e.Id.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(e => new
                    {
                        e.Id,
                        e.EmployeeName,
                        e.Phone,
                        e.CitizenId,
                        e.HireDate,
                        e.Role
                    }).ToList();
                dgvSchedule.DataSource = filteredList;
                return;
            }


            var employees = bLL_Employee.GetAll().Select(e => new
            {
                e.Id,
                e.EmployeeName,
                e.Phone,
                e.CitizenId,
                e.HireDate,
                e.Role
            }).ToList();
            dgvSchedule.DataSource = employees;
        }

        // Hàm load nhân viên theo ca làm việc
        public void LoadEmployeeByShift(string shift)
        {
            // Lấy danh sách phân công theo ngày + ca
            var assignments = bLL_ShiftAssignment.GetByDateAndShift(
                int.Parse(day), int.Parse(month), year, shift);

            // Tạo danh sách nhân viên hiển thị
            var employees = assignments
                .Where(a => a.Employee != null && a.Shift != null)
                .Select(a => new
                {
                    a.Employee.Id,
                    a.Employee.EmployeeName,
                    a.Employee.Phone,
                    a.Employee.Role,
                    a.Shift.ShiftType,
                    WorkDate = a.Shift.WorkDate.ToString("dd/MM/yyyy")
                })
                .ToList();

            // Gán vào DataGridView tương ứng theo ca
            switch (shift)
            {
                case "Sáng":
                    dgvShiftMorning.DataSource = employees;
                    break;
                case "Chiều":
                    dgvShiftAfternoon.DataSource = employees;
                    break;
                case "Tối":
                    dgvShiftEvening.DataSource = employees;
                    break;
            }

            // Tuỳ chọn: tự động điều chỉnh cột cho đẹp
            var dgv = shift switch
            {
                "Sáng" => dgvShiftMorning,
                "Chiều" => dgvShiftAfternoon,
                "Tối" => dgvShiftEvening,
                _ => null
            };

            if (dgv != null)
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.ReadOnly = true;
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void dvgSchedule_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmployeeSchedule fr = new frmEmployeeSchedule();
            fr.ShowDialog();
        }


        // -- Chức năng tìm kiếm nhân viên --

        //Biển theo dõi công tác nhập liệu
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

        private async void txtFindMorning_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindMorning.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadEmployeeByShift("Sáng");
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private async void txtFindAfternoon_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindAfternoon.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadEmployeeByShift("Sáng");
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private async void txtFindEvening_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindEvening.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadEmployeeByShift("Sáng");
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }
    }
}
