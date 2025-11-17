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
    public partial class frmEmployee : Form
    {
        private readonly BLL_Employee bLL_Employee = new BLL_Employee();
        private readonly BLL_Account bLL_Account = new BLL_Account();
        private readonly BLL_Address bLL_Address = new BLL_Address();
        private readonly BLL_Ward bLL_Ward = new BLL_Ward();
        private readonly BLL_Province bLL_Province = new BLL_Province();
        private readonly BLL_Branch bLL_Branch = new BLL_Branch();

        private readonly Account _currentUser;
        public frmEmployee(Account currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        // Hàm load dữ liệu nhân viên lên DataGridView
        public void LoadEmployeeData(string branchId, string? keyword = null)
        {
            dgvEmployee.MultiSelect = false;
            dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployee.ReadOnly = true;

            var allEmployees = bLL_Employee.GetAll()
            .Where(e => e.Id != "EM_ADMIN" && e.BranchId == branchId && e.Role != "Quản lý");
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var filteredList = allEmployees
                    .Where(e => e.EmployeeName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                e.Id.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                e.CurrentStatus.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                e.Role.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                e.Gender.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                e.SalaryPerHour.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                e.CitizenId.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(e => new
                    {
                        e.Id,
                        e.CitizenId,
                        e.EmployeeName,
                        e.Gender,
                        e.DateOfBirth,
                        e.Role,
                        Address = e.Address != null ? e.Address.Name : "Lỗi hiển thị",
                        Province = e.Address?.Ward?.Province != null ? e.Address.Ward.Province.ProvinceName : "Lỗi hiển thị",
                        Ward = e.Address?.Ward != null ? e.Address.Ward.WardName : "Lỗi hiển thị",
                        e.SalaryPerHour,
                        e.Phone,
                        e.CurrentStatus
                    }).ToList();
                dgvEmployee.DataSource = filteredList;
                return;
            }

            var displayList = allEmployees.Select(e => new
            {
                e.Id,
                e.CitizenId,
                e.EmployeeName,
                e.Gender,
                e.DateOfBirth,
                e.Role,
                Address = e.Address != null ? e.Address.Name : "Lỗi hiển thị",
                Province = e.Address?.Ward?.Province != null ? e.Address.Ward.Province.ProvinceName : "Lỗi hiển thị",
                Ward = e.Address?.Ward != null ? e.Address.Ward.WardName : "Lỗi hiển thị",
                e.SalaryPerHour,
                e.Phone,
                e.CurrentStatus
            }).ToList();
            dgvEmployee.DataSource = displayList;
        }

        // Hàm dọn dẹp dữ liệu
        public void ClearData()
        {
            txtId.Clear();
            txtName.Clear();
            txtCitizenId.Clear();
            cboRole.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Today.AddYears(-16); // Mặc định 16 tuổi
            txtAddress.Clear();
            cboProvince.SelectedIndex = -1;
            cboWard.SelectedIndex = -1;
            txtSalary.Clear();
            txtPhone.Clear();
            cboGender.SelectedIndex = -1;
        }

        private void LoadWard(string provinceId)
        {
            var wards = bLL_Ward.GetWardByProvinceId(provinceId);
            cboWard.DataSource = wards;
            cboWard.DisplayMember = "WardName";
            cboWard.ValueMember = "Id";
            cboWard.SelectedIndex = -1;
        }

        private void LoadProvince()
        {
            var provinces = bLL_Province.GetAllProvinces();
            cboProvince.DataSource = provinces;
            cboProvince.DisplayMember = "ProvinceName";
            cboProvince.ValueMember = "Id";
            cboProvince.SelectedIndex = -1;
        }

        // Hàm load giới tính nhân viên
        private void LoadGender()
        {
            cboGender.Items.Clear();
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.Items.Add("Khác");
            cboGender.SelectedIndex = 0;
        }

        // Hàm load vai trò nhân viên
        private void LoadRole()
        {
            cboRole.Items.Clear();
            cboRole.Items.Add("Nhân viên");
            cboRole.Items.Add("Thời vụ");
            cboRole.Items.Add("Quản lý");
            cboRole.SelectedIndex = 0;
        }

        // Hàm load trạng thái nhân viên
        private void LoadEmployeeStatus()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Đang làm việc");
            cboStatus.Items.Add("Đã nghỉ");
            cboStatus.SelectedIndex = 0;
        }

        // Hàm lấy địa chỉ
        private void UpdateAddressFromCombos(ComboBox cboProvince, ComboBox cboWard, TextBox txtAddress)
        {
            if (cboProvince.SelectedItem == null || cboWard.SelectedItem == null)
                return; // Không làm gì nếu chưa chọn đủ

            var province = (Province)cboProvince.SelectedItem;
            var ward = (Ward)cboWard.SelectedItem;

            string provinceName = province.ProvinceName;
            string wardName = ward.WardName;

            string currentText = txtAddress.Text.Trim();

            // Nếu textbox đang rỗng hoặc chưa chứa thông tin tỉnh/phường thì cập nhật
            if (string.IsNullOrWhiteSpace(currentText) ||
                !currentText.Contains(wardName) || !currentText.Contains(provinceName))
            {
                // Giữ lại phần tên đường nếu người dùng đã nhập
                string streetName = "";

                if (currentText.Contains(",")) // Nếu người dùng nhập trước đó, tách phần đầu
                    streetName = currentText.Split(',')[0].Trim();

                if (!string.IsNullOrEmpty(streetName))
                    txtAddress.Text = $"{streetName}, {wardName}, {provinceName}";
                else
                    txtAddress.Text = $"{wardName}, {provinceName}";
            }
        }
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;

            LoadEmployeeData(branchId);
            LoadProvince();
            LoadGender();
            LoadRole();
            LoadEmployeeStatus();
            LoadAccountData(branchId);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvince.SelectedIndex != -1 || cboProvince.SelectedValue != null)
            {
                string? provinceId = cboProvince.SelectedValue?.ToString();

                LoadWard(provinceId);
            }

            // Cập nhật địa chỉ hiển thị
            UpdateAddressFromCombos(cboProvince, cboWard, txtAddress);
        }

        private void cboWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cập nhật địa chỉ hiển thị
            UpdateAddressFromCombos(cboProvince, cboWard, txtAddress);
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy ID của nhân viên
            var employeeId = dgvEmployee.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            // Gọi lại tầng nghiệp vụ (BLL) để lấy thông tin đầy đủ
            var employee = bLL_Employee.GetById(employeeId);
            if (employee == null) return;

            // Gán dữ liệu cho các TextBox, ComboBox, DateTimePicker
            txtId.Text = employee.Id;
            txtCitizenId.Text = employee.CitizenId;
            txtName.Text = employee.EmployeeName;
            txtPhone.Text = employee.Phone;
            txtAddress.Text = employee.Address?.Name ?? "";
            txtSalary.Text = employee.SalaryPerHour.ToString();

            cboRole.SelectedIndex = cboRole.FindStringExact(employee.Role);
            cboProvince.SelectedIndex = cboProvince.FindStringExact(employee.Address?.Ward?.Province?.ProvinceName ?? "");
            cboWard.SelectedIndex = cboWard.FindStringExact(employee.Address?.Ward?.WardName ?? "");
            cboGender.SelectedIndex = cboGender.FindStringExact(employee.Gender ?? "");
            dtpDateOfBirth.Value = employee.DateOfBirth != default
            ? employee.DateOfBirth.ToDateTime(TimeOnly.MinValue)
            : DateTime.Now;
            cboStatus.SelectedIndex = cboStatus.FindStringExact(employee.CurrentStatus);
        }

        // Xử lý sự kiện khi rời khỏi ô nhập tên
        private void txtName_Leave(object sender, EventArgs e)
        {
            // Nếu người dùng không nhập tên => báo lỗi
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtName.Focus(); // Trả con trỏ về ô nhập
                return;
            }

            // Kiểm tra độ dài Name
            string name = txtName.Text.Trim();
            if (name.Length > 30)
            {
                MessageBox.Show("Tên nhân viên không được vượt quá 30 ký tự!",
                                "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Clear();
                txtName.Focus();
                return;
            }

            // Kiểm tra trùng tên (trừ chính nhân viên đang chỉnh sửa)
            var existingEmployee = bLL_Employee.GetAll()
                .FirstOrDefault(e => e.EmployeeName.Equals(name, StringComparison.OrdinalIgnoreCase)
                                  && e.BranchId == txtId.Text
                                  && e.Id != txtId.Text);

            if (existingEmployee != null)
            {
                MessageBox.Show("Tên nhân viên này đã tồn tại trong chi nhánh này!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtName.Clear();
                txtName.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Clear();
                txtName.Focus();
                return;
            }

            // Nếu hợp lệ -> chỉ tạo mã nếu chưa có
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                txtId.Text = bLL_Employee.GenerateEmployeeId();
            }
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
                LoadEmployeeData(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) ||
            string.IsNullOrEmpty(txtPhone.Text) ||
            string.IsNullOrEmpty(txtAddress.Text) ||
            string.IsNullOrEmpty(txtCitizenId.Text) ||
            string.IsNullOrEmpty(txtSalary.Text))
            {
                MessageBox.Show("Thông tin nhân viên không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var existingPhone = bLL_Employee.GetEmployeeByPhone(txtPhone.Text);
            if (existingPhone != null)
            {
                MessageBox.Show("Số điện thoại đã trùng với nhân viên khác", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtPhone.Clear();
                txtPhone.Focus();
                return;
            }
            if (cboProvince.SelectedValue == null)
            {
                MessageBox.Show("Tỉnh/Thành phố không được để trống", "Thông báo");
                cboProvince.Focus();
                return;
            }
            if (cboWard.SelectedValue == null)
            {
                MessageBox.Show("Phường/Xã phố không được để trống", "Thông báo");
                cboWard.Focus();
                return;
            }

            // Lấy BranchId của tài khoản hiện tại
            string branchId;
            try
            {
                branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                return;
            }

            // Kiểm tra trùng tên trong chi nhánh
            bool nameExists = bLL_Employee.GetAll()
                .Any(e => e.EmployeeName.Equals(txtName.Text.Trim(), StringComparison.OrdinalIgnoreCase)
                       && e.BranchId == branchId);

            if (nameExists)
            {
                MessageBox.Show("Tên nhân viên đã tồn tại trong chi nhánh!", "Cảnh báo");
                return;
            }

            try
            {
                var address = new Address
                {
                    Id = bLL_Address.GenerateAddressId(cboProvince.SelectedValue.ToString()),
                    WardId = cboWard.SelectedValue.ToString(),
                    Name = txtAddress.Text,
                };
                bLL_Address.Add(address);

                string employeeId = bLL_Employee.GenerateEmployeeId();
                txtId.Text = employeeId;
                var employee = new Employee
                {
                    Id = employeeId,
                    CitizenId = txtCitizenId.Text,
                    EmployeeName = txtName.Text,
                    Phone = txtPhone.Text,
                    AddressId = address.Id,
                    HireDate = DateOnly.FromDateTime(DateTime.Today),
                    DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value),
                    Gender = cboGender.SelectedItem?.ToString(),
                    SalaryPerHour = decimal.Parse(txtSalary.Text),
                    Role = cboRole.SelectedItem?.ToString(),
                    CurrentStatus = cboStatus.SelectedItem?.ToString(),
                    BranchId = branchId
                };
                bLL_Employee.Add(employee);
                MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo");
                ClearData();
                LoadEmployeeData(branchId);
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm nhân viên thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;

            try
            {
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtPhone.Text) ||
                    string.IsNullOrEmpty(txtAddress.Text) ||
                    string.IsNullOrEmpty(txtCitizenId.Text) ||
                    string.IsNullOrEmpty(txtSalary.Text))
                {
                    MessageBox.Show("Thông tin nhân viên không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cboProvince.SelectedValue == null)
                {
                    MessageBox.Show("Tỉnh/Thành phố không được để trống", "Thông báo");
                    cboProvince.Focus();
                    return;
                }
                if (cboWard.SelectedValue == null)
                {
                    MessageBox.Show("Phường/Xã phố không được để trống", "Thông báo");
                    cboWard.Focus();
                    return;
                }

                string id = txtId.Text.Trim(); // Lấy ID Employee cần update
                var employee = bLL_Employee.GetAll().FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    // Update thông tin Address
                    if (employee.Address != null)
                    {
                        employee.Address.Name = txtAddress.Text;
                        employee.Address.WardId = cboWard.SelectedValue.ToString();
                    }
                    else
                    {
                        // Nếu chưa có Address, tạo mới
                        var address = new Address
                        {
                            Id = bLL_Address.GetAllAddresses().Count + 1.ToString(),
                            Name = txtAddress.Text,
                            WardId = cboWard.SelectedValue.ToString()
                        };
                        bLL_Address.Add(employee.Address);
                        employee.AddressId = address.Id;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để cập nhật địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                employee.EmployeeName = txtName.Text;
                employee.CitizenId = txtCitizenId.Text;
                employee.Phone = txtPhone.Text;
                employee.HireDate = DateOnly.FromDateTime(DateTime.Today);
                employee.DateOfBirth = DateOnly.FromDateTime(dtpDateOfBirth.Value);
                employee.Gender = cboGender?.SelectedItem?.ToString();
                employee.SalaryPerHour = decimal.Parse(txtSalary.Text);
                employee.Role = cboRole?.SelectedItem?.ToString();
                employee.CurrentStatus = cboStatus?.SelectedItem?.ToString();

                bLL_Employee.Update(employee);
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");

                LoadEmployeeData(branchId);
                ClearData();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật nhân viên thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;
            try
            {
                string id = txtId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để xóa.", "Thông báo");
                    return;
                }
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", id, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bLL_Employee.Delete(id);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    LoadEmployeeData(branchId);
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa nhân viên thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        // ----------------------- Tạo tài khoản ------------------------

        // Hàm load tài khoản
        public void LoadAccountData(string branchId, string? keyword = null)
        {
            dgvAccount.MultiSelect = false;
            dgvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAccount.ReadOnly = true;

            var allAccounts = bLL_Account.GetAll()
            .Where(a => a.Id != "AC_ADMIN" && a.Employee != null
            && a.Employee.BranchId == branchId && a.Employee.Role != "Quản lý");
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var filteredList = allAccounts
                    .Where(a => (a.AccountName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                 a.Id.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase)) &&
                                 a.Employee.BranchId == branchId)
                    .Select(a => new
                    {
                        a.Id,
                        a.AccountName,
                        a.Password,
                        EmployeeName = a.EmployeeId != null ? a.Employee.EmployeeName : "Lỗi hiển thị",
                        a.CreateDate
                    }).ToList();
                dgvAccount.DataSource = filteredList;
                return;
            }

            var displayList = allAccounts
                .Where(a => a.Employee != null && a.Employee.BranchId == branchId)
                .Select(a => new
                {
                    a.Id,
                    a.AccountName,
                    a.Password,
                    EmployeeName = a.EmployeeId != null ? a.Employee.EmployeeName : "Lỗi hiển thị",
                    a.CreateDate
                }).ToList();

            dgvAccount.DataSource = displayList;
        }

        // Hàm dọn dẹp dữ liệu
        public void ClearAccountData()
        {
            txtAId.Clear();
            txtAName.Clear();
            txtAccountId.Clear();
            txtAccount.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
        }

        private void dgvEmployee_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy ID của nhân viên
            var employeeId = dgvEmployee.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            // Gọi lại tầng nghiệp vụ (BLL) để lấy thông tin đầy đủ
            var employee = bLL_Employee.GetById(employeeId);
            if (employee == null) return;

            // Gán dữ liệu cho các TextBox
            txtAId.Text = employee.Id;
            txtAName.Text = employee.EmployeeName;
            tctEmployeeAccount.SelectedIndex = 1;
            tctEmployeeAccount.Focus();
            txtAccount.Clear();
            txtAccountId.Clear();
            txtPassword.Clear();
            txtRePassword.Clear();
        }

        private void btnResetA_Click(object sender, EventArgs e)
        {
            ClearAccountData();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy ID của tài khoản
            var AccountId = dgvAccount.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            // Gọi lại tầng nghiệp vụ (BLL) để lấy thông tin đầy đủ
            var account = bLL_Account.GetById(AccountId);
            if (account == null) return;

            // Gán dữ liệu cho các TextBox
            txtAId.Text = account.EmployeeId;
            txtAName.Text = account.Employee.EmployeeName;
            txtAccountId.Text = account.Id;
            txtAccount.Text = account.AccountName;
            txtPassword.Text = account.Password;
            txtRePassword.Text = account.Password;
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            // Nếu người dùng không nhập tài khoản => báo lỗi
            if (string.IsNullOrWhiteSpace(txtAccount.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtName.Focus(); // Trả con trỏ về ô nhập
                return;
            }

            // Kiểm tra độ dài Account
            string account = txtAccount.Text.Trim();
            if (account.Length > 50)
            {
                MessageBox.Show("Tên tài khoản không được vượt quá 50 ký tự!",
                                "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAccount.Clear();
                txtAccount.Focus();
                return;
            }

            // Kiểm tra trùng tên tài khoản(trừ chính nhân viên đang chỉnh sửa)
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;
            var existingAccount = bLL_Account.GetAll()
                .FirstOrDefault(a => a.AccountName.Equals(account, StringComparison.OrdinalIgnoreCase)
                                  && a.Employee.BranchId == branchId
                                  && a.Id != txtAccountId.Text);

            if (existingAccount != null)
            {
                MessageBox.Show("Tên tài khoản này đã tồn tại trong chi nhánh này!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtAccount.Clear();
                txtAccount.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(account))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Clear();
                txtName.Focus();
                return;
            }

            // Nếu hợp lệ -> chỉ tạo mã nếu chưa có
            if (string.IsNullOrWhiteSpace(txtAccountId.Text))
            {
                txtAccountId.Text = bLL_Account.GenerateNewAccountId();
            }
        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            string confirm = txtRePassword.Text.Trim();
            string employeeId = txtAId.Text.Trim();
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;

            // Kiểm tra đã chọn nhân viên
            if (string.IsNullOrEmpty(employeeId))
            {
                MessageBox.Show("Vui lòng chọn nhân viên trước khi tạo tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAId.Focus();
                return;
            }

            // Kiểm tra chức vụ
            var employee = bLL_Employee.GetById(employeeId);
            if (employee.Role != null && employee.Role.Equals("Thời vụ", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Không thể tạo tài khoản cho nhân viên có chức vụ 'Thời vụ'!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Kiểm tra nhân viên đã có tài khoản chưa
            var existingAccount = bLL_Account.GetAll().FirstOrDefault(a => a.EmployeeId == employeeId);
            if (existingAccount != null)
            {
                MessageBox.Show("Nhân viên này đã có tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mật khẩu trùng nhau
            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu nhập lại không giống mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRePassword.Clear();
                txtRePassword.Focus();
                return;
            }

            try
            {
                var account = new Account
                {
                    Id = txtAccountId.Text,
                    AccountName = txtAccount.Text.Trim(),
                    Password = password,
                    EmployeeId = employeeId,
                    CreateDate = DateOnly.FromDateTime(DateTime.Today)
                };
                bLL_Account.Add(account);
                MessageBox.Show("Đã tạo tài khoản thành công", "Thông báo");
                ClearAccountData();
                LoadAccountData(branchId);
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm tài khoản thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnDeleteA_Click(object sender, EventArgs e)
        {
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;
            try
            {
                string id = txtAccountId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xóa.", "Thông báo");
                    return;
                }
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa tài khoản này không?", id, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bLL_Account.Delete(id);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    ClearAccountData();
                    LoadAccountData(branchId);
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa tài khoản thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnSaveA_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            string confirm = txtRePassword.Text.Trim();
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;

            if (string.IsNullOrWhiteSpace(txtAccountId.Text))
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần cập nhật từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật tài khoản này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;

            // Kiểm tra mật khẩu trùng nhau
            if (password != confirm)
            {
                MessageBox.Show("Mật khẩu nhập lại không giống mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRePassword.Clear();
                txtRePassword.Focus();
                return;
            }

            try
            {
                string id = txtAccountId.Text.Trim(); // Lấy ID Account cần update
                var account = bLL_Account.GetAll().FirstOrDefault(a => a.Id == id);


                account.AccountName = txtAccount.Text;
                account.Password = password;
                account.CreateDate = DateOnly.FromDateTime(DateTime.Today);

                bLL_Account.Update(account);
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");

                ClearAccountData();
                LoadAccountData(branchId);
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật tài khoản thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private async void txtFindA_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindA.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadEmployeeData(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }
    }
}
