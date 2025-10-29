using BLL;
using DAL;
using DTO;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace GUI
{
    public partial class frmBranch : Form
    {
        private readonly BLL_Branch bLL_Branch = new BLL_Branch();
        private readonly BLL_Address bLL_Address = new BLL_Address();
        private readonly BLL_Province bLL_Province = new BLL_Province();
        private readonly BLL_Ward bLL_Ward = new BLL_Ward();
        private readonly BLL_Employee bLL_Employee = new BLL_Employee();

        public frmBranch()
        {
            InitializeComponent();
        }

        private void LoadBranches(string keyword = null)
        {
            dgvBranch.MultiSelect = false;
            dgvBranch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBranch.ReadOnly = true;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var filteredList = bLL_Branch.GetAll()
                    .Where(b => b.BranchName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                b.Id.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(b => new
                    {
                        b.Id,
                        b.BranchName,
                        //Address = b.Address != null ? b.Address.Address1 : "Lỗi hiển thị",
                        Address = b.Address != null ? b.Address.Name : "Lỗi hiển thị",
                        Province = b.Address.Ward.Province != null ? b.Address.Ward.Province.ProvinceName : "Lỗi hiển thị",
                        Ward = b.Address.Ward != null ? b.Address.Ward.WardName : "Lỗi hiển thị",
                        b.Phone,
                        b.OpenTime,
                        b.CloseTime,
                        b.Status,
                    }).ToList();
                dgvBranch.DataSource = filteredList;
                return;
            }

            var displayList = bLL_Branch.GetAll().Select(b => new
            {
                b.Id,
                b.BranchName,
                //Address = b.Address != null ? b.Address.Address1 : "Lỗi hiển thị",
                Address = b.Address != null ? b.Address.Name : "Lỗi hiển thị",
                Province = b.Address.Ward.Province != null ? b.Address.Ward.Province.ProvinceName : "Lỗi hiển thị",
                Ward = b.Address.Ward != null ? b.Address.Ward.WardName : "Lỗi hiển thị",
                b.Phone,
                b.OpenTime,
                b.CloseTime,
                b.Status,
            }).ToList();
            dgvBranch.DataSource = displayList;

            // Cấu hình DataGridView hiển thị cho đẹp
            dgvBranch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBranch.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBranch.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBranch.MultiSelect = false;
            dgvBranch.ReadOnly = true;
            dgvBranch.AllowUserToAddRows = false;
            dgvBranch.AllowUserToDeleteRows = false;
            dgvBranch.AllowUserToResizeRows = false;
            dgvBranch.RowHeadersVisible = false;

            // Style cho bảng
            dgvBranch.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvBranch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBranch.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBranch.EnableHeadersVisualStyles = false;

            dgvBranch.DefaultCellStyle.BackColor = Color.White;
            dgvBranch.DefaultCellStyle.ForeColor = Color.Black;
            dgvBranch.DefaultCellStyle.SelectionBackColor = Color.MistyRose;
            dgvBranch.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBranch.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvBranch.GridColor = Color.LightGray;
            dgvBranch.BorderStyle = BorderStyle.None;
        }

        private void LoadProvince()
        {
            var provinces = bLL_Province.GetAllProvinces();
            cboProvince.DataSource = provinces;
            cboProvince.DisplayMember = "ProvinceName";
            cboProvince.ValueMember = "Id";
            cboProvince.SelectedIndex = -1;

            // Load cho phần nhân viên chi nhánh
            cboEProvince.DataSource = provinces;
            cboEProvince.DisplayMember = "ProvinceName";
            cboEProvince.ValueMember = "Id";
            cboEProvince.SelectedIndex = -1;
        }

        private void LoadWard(string provinceId)
        {
            var wards = bLL_Ward.GetWardByProvinceId(provinceId);
            cboWard.DataSource = wards;
            cboWard.DisplayMember = "WardName";
            cboWard.ValueMember = "Id";
            cboWard.SelectedIndex = -1;

            // Load cho phần nhân viên chi nhánh
            cboEWard.DataSource = wards;
            cboEWard.DisplayMember = "WardName";
            cboEWard.ValueMember = "Id";
            cboEWard.SelectedIndex = -1;
        }

        private void LoadStatus()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Đang hoạt động");
            cboStatus.Items.Add("Đã đóng");
            cboStatus.Items.Add("Đóng vĩnh viễn");
            cboStatus.SelectedIndex = 0;
        }


        private void ClearData()
        {
            txtBId.Clear();
            txtBName.Clear();
            txtAddress.Clear();
            cboProvince.SelectedIndex = -1;
            cboWard.SelectedIndex = -1;
            txtPhone.Clear();
            dtpOpenTime.Value = DateTime.Today.AddHours(8); // Mặc định 8:00 AM
            dtpCloseTime.Value = DateTime.Today.AddHours(17); // Mặc định 5:00 PM
            cboStatus.SelectedIndex = -1;
        }

        private void frmBranch_Load(object sender, EventArgs e)
        {
            LoadBranches();
            LoadProvince();
            LoadStatus();
            LoadRole();
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvince.SelectedIndex != -1)
            {
                string provinceId = cboProvince.SelectedValue.ToString();

                // Chỉ sinh mã mới nếu txtBId đang trống (đang thêm mới)
                if (string.IsNullOrWhiteSpace(txtBId.Text))
                {
                    string newBranchId = bLL_Branch.GenerateBranchId(provinceId);
                    txtBId.Text = newBranchId;
                }

                LoadWard(provinceId);
            }
            else
            {
                txtBId.Clear();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();

            // Xóa danh sách nhân viên chi nhánh khi reset
            dgvBanchEmployee.ClearSelection();
            dgvBanchEmployee.DataSource = null;
        }

        //Biển theo dõi công tác nhập liệu
        private CancellationTokenSource _cts = new();
        private async void txtFindBranch_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindBranch.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadBranches(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBName.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Thông tin chi nhánh không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Phải gồm 10 chữ số và bắt đầu bằng 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Clear();
                txtPhone.Focus();
                return;
            }
            var existingPhone = bLL_Branch.GetBranchByPhone(txtPhone.Text);
            if (existingPhone != null)
            {
                MessageBox.Show("Số điện thoại đã trùng với chi nhánh khác", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
            if (bLL_Branch.IsBranchNameExists(txtBName.Text.Trim()))
            {
                MessageBox.Show("Tên chi nhánh đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string provinceId = cboProvince.SelectedValue.ToString();
                string wardId = cboWard.SelectedValue.ToString();
                var address = new Address
                {
                    Id = bLL_Address.GenerateAddressId(cboProvince.SelectedValue.ToString()),
                    WardId = cboWard.SelectedValue.ToString(),
                    //Address1 = txtAddress.Text,
                    Name = txtAddress.Text,
                };
                bLL_Address.Add(address);

                string branchId = bLL_Branch.GenerateBranchId(provinceId);
                txtBId.Text = branchId;
                var branch = new DTO.Branch
                {
                    Id = branchId,
                    BranchName = txtBName.Text,
                    Phone = txtPhone.Text,
                    AddressId = address.Id,
                    OpenTime = TimeOnly.FromDateTime(dtpOpenTime.Value),
                    CloseTime = TimeOnly.FromDateTime(dtpCloseTime.Value),
                    Status = cboStatus.SelectedItem.ToString()
                };
                bLL_Branch.Add(branch);
                MessageBox.Show("Đã thêm chi nhánh thành công", "Thông báo");
                ClearData();
                LoadBranches();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm chi nhánh thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtBId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn chi nhánh để xóa.", "Thông báo");
                    return;
                }
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa chi nhánh này không?", id, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bLL_Branch.Delete(id);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    LoadBranches();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa chi nhánh thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBId.Text))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh cần cập nhật từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật chi nhánh này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;

            try
            {
                if (string.IsNullOrEmpty(txtBName.Text) ||
                    string.IsNullOrEmpty(txtPhone.Text) ||
                    string.IsNullOrEmpty(txtAddress.Text))
                {
                    MessageBox.Show("Thông tin chi nhánh không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhone.Text, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Phải gồm 10 chữ số và bắt đầu bằng 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                string id = txtBId.Text.Trim(); // Lấy ID Branch cần update
                var branch = bLL_Branch.GetAll().FirstOrDefault(b => b.Id == id);
                if (branch != null)
                {
                    // Update thông tin Address
                    if (branch.Address != null)
                    {
                        //branch.Address.Address1 = txtAddress.Text;
                        branch.Address.Name = txtAddress.Text;
                        branch.Address.WardId = cboWard.SelectedValue.ToString();
                    }
                    else
                    {
                        // Nếu chưa có Address, tạo mới
                        var address = new Address
                        {
                            Id = bLL_Address.GetAllAddresses().Count + 1.ToString(),
                            //Address1 = txtAddress.Text,
                            Name = txtAddress.Text,
                            WardId = cboWard.SelectedValue.ToString()
                        };
                        bLL_Address.Add(branch.Address);
                        branch.AddressId = address.Id;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy chi nhánh để cập nhật địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                branch.BranchName = txtBName.Text;
                branch.Phone = txtPhone.Text;
                branch.OpenTime = TimeOnly.FromDateTime(dtpOpenTime.Value);
                branch.CloseTime = TimeOnly.FromDateTime(dtpCloseTime.Value);
                branch.Status = cboStatus.SelectedItem.ToString();

                bLL_Branch.Update(branch);
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");

                LoadBranches();
                ClearData();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật chi nhánh thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void dgvBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvBranch.Rows[e.RowIndex];

                txtBName.Text = selectedRow.Cells["BranchName"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                var province = selectedRow.Cells["Province"].Value.ToString();
                cboProvince.SelectedIndex = cboProvince.FindStringExact(province);
                var ward = selectedRow.Cells["Ward"].Value.ToString();
                cboWard.SelectedIndex = cboWard.FindStringExact(ward);
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                dtpOpenTime.Value = DateTime.Today.AddHours(((TimeOnly)selectedRow.Cells["OpenTime"].Value).Hour).AddMinutes(((TimeOnly)selectedRow.Cells["OpenTime"].Value).Minute);
                dtpCloseTime.Value = DateTime.Today.AddHours(((TimeOnly)selectedRow.Cells["CloseTime"].Value).Hour).AddMinutes(((TimeOnly)selectedRow.Cells["CloseTime"].Value).Minute);
                var status = selectedRow.Cells["Status"].Value.ToString();
                cboStatus.SelectedIndex = cboStatus.FindStringExact(status);
                txtBId.Text = selectedRow.Cells["Id"].Value.ToString();

                // Load nhân viên chi nhánh tương ứng
                string branchId = selectedRow.Cells["Id"].Value.ToString();
                LoadEmployees(branchId);
            }
        }

        // Hàm xử lý sự kiện khi form được đóng
        private void frmBranch_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cts?.Cancel(); // Hủy bỏ bất kỳ tác vụ nào đang chờ
        }

        // ----------------------- Nhân Viên Chi Nhánh ------------------------

        // Hàm reset dữ liệu nhân viên chi nhánh
        private void ClearEmployeeData()
        {
            txtEId.Clear();
            txtEName.Clear();
            txtEPhone.Clear();
            txtEAddress.Clear();
            cboEWard.SelectedIndex = -1;
            cboEProvince.SelectedIndex = -1;
            cboERole.SelectedIndex = -1;
            txtESalaryPerHour.Clear();
        }

        // Hàm load nhân viên chi nhánh
        private void LoadEmployees(string branchId, string keyword = "")
        {
            dgvBanchEmployee.MultiSelect = false;
            dgvBanchEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBanchEmployee.ReadOnly = true;

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
                        //Address = e.Address != null ? e.Address.Address1 : "Lỗi hiển thị",
                        Address = e.Address != null ? e.Address.Name : "Lỗi hiển thị",
                        Province = e.Address.Ward.Province != null ? e.Address.Ward.Province.ProvinceName : "Lỗi hiển thị",
                        Ward = e.Address.Ward != null ? e.Address.Ward.WardName : "Lỗi hiển thị",
                        e.HireDate,
                        e.SalaryPerHour,
                        e.Role
                    }).ToList();
                dgvBanchEmployee.DataSource = filteredList;
                return;
            }


            var employees = bLL_Employee.GetEmployeesByBranchId(branchId).Select(e => new
            {
                e.Id,
                e.EmployeeName,
                e.Phone,
                //Address = e.Address != null ? e.Address.Address1 : "Lỗi hiển thị",
                Address = e.Address != null ? e.Address.Name : "Lỗi hiển thị",
                Province = e.Address?.Ward?.Province != null ? e.Address.Ward.Province.ProvinceName : "Lỗi hiển thị",
                Ward = e.Address?.Ward != null ? e.Address.Ward.WardName : "Lỗi hiển thị",
                e.HireDate,
                e.SalaryPerHour,
                e.Role
            }).ToList();
            dgvBanchEmployee.DataSource = employees;

            // Cấu hình DataGridView hiển thị cho đẹp
            dgvBanchEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBanchEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvBanchEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBanchEmployee.MultiSelect = false;
            dgvBanchEmployee.ReadOnly = true;
            dgvBanchEmployee.AllowUserToAddRows = false;
            dgvBanchEmployee.AllowUserToDeleteRows = false;
            dgvBanchEmployee.AllowUserToResizeRows = false;
            dgvBanchEmployee.RowHeadersVisible = false;

            // Style cho bảng
            dgvBanchEmployee.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvBanchEmployee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBanchEmployee.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvBanchEmployee.EnableHeadersVisualStyles = false;

            dgvBanchEmployee.DefaultCellStyle.BackColor = Color.White;
            dgvBanchEmployee.DefaultCellStyle.ForeColor = Color.Black;
            dgvBanchEmployee.DefaultCellStyle.SelectionBackColor = Color.MistyRose;
            dgvBanchEmployee.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvBanchEmployee.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvBanchEmployee.GridColor = Color.LightGray;
            dgvBanchEmployee.BorderStyle = BorderStyle.None;
        }

        private void LoadRole()
        {
            cboERole.Items.Clear();
            cboERole.Items.Add("Nhân viên");
            cboERole.Items.Add("Thời vụ");
            cboERole.Items.Add("Quản lý");
            cboERole.SelectedIndex = 0;
        }

        private void btnEReset_Click(object sender, EventArgs e)
        {
            ClearEmployeeData();
        }


        private async void txtEFind_TextChanged(object sender, EventArgs e)
        {
            string input = txtEFind.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadBranches(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private void dgvBanchEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvBanchEmployee.Rows[e.RowIndex];

                txtEName.Text = selectedRow.Cells["EmployeeName"].Value.ToString();
                txtEPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                txtEAddress.Text = selectedRow.Cells["Address"].Value.ToString();
                var province = selectedRow.Cells["Province"].Value.ToString();
                cboEProvince.SelectedIndex = cboEProvince.FindStringExact(province);
                var ward = selectedRow.Cells["Ward"].Value.ToString();
                cboEWard.SelectedIndex = cboEWard.FindStringExact(ward);
                var role = selectedRow.Cells["Role"].Value.ToString();
                cboERole.SelectedIndex = cboERole.FindStringExact(role);
                txtESalaryPerHour.Text = selectedRow.Cells["SalaryPerHour"].Value.ToString();
                txtEId.Text = selectedRow.Cells["Id"].Value.ToString();
            }
        }

        private void txtEName_Leave(object sender, EventArgs e)
        {
            // Nếu người dùng không nhập tên => báo lỗi
            if (string.IsNullOrWhiteSpace(txtEName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtEName.Focus(); // Trả con trỏ về ô nhập
                return;
            }

            // Kiểm tra độ dài Name
            string name = txtEName.Text.Trim();
            if (name.Length > 30)
            {
                MessageBox.Show("Tên nhân viên không được vượt quá 30 ký tự!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEName.Clear();
                txtEName.Focus();
                return;
            }

            // Kiểm tra trùng tên
            if (bLL_Employee.IsEmployeeNameExists(name))
            {
                MessageBox.Show("Tên chương trình khuyến mãi này đã tồn tại!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEName.Clear();
                txtEName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!",
                    "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEName.Clear();
                txtEName.Focus();
                return;
            }

            // Nếu hợp lệ -> tạo mã mới
            txtEId.Text = bLL_Employee.GenerateEmployeeId();
        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEName.Text) ||
                string.IsNullOrEmpty(txtEPhone.Text) ||
                string.IsNullOrEmpty(txtEAddress.Text) ||
                string.IsNullOrEmpty(txtESalaryPerHour.Text))
            {
                MessageBox.Show("Thông tin nhân viên không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEPhone.Text, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Phải gồm 10 chữ số và bắt đầu bằng 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEPhone.Clear();
                txtEPhone.Focus();
                return;
            }
            var existingPhone = bLL_Employee.GetEmployeeByPhone(txtEPhone.Text);
            if (existingPhone != null)
            {
                MessageBox.Show("Số điện thoại đã trùng với nhân viên khác", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtEPhone.Clear();
                txtEPhone.Focus();
                return;
            }
            if (cboEProvince.SelectedValue == null)
            {
                MessageBox.Show("Tỉnh/Thành phố không được để trống", "Thông báo");
                cboEProvince.Focus();
                return;
            }
            if (cboEWard.SelectedValue == null)
            {
                MessageBox.Show("Phường/Xã phố không được để trống", "Thông báo");
                cboEWard.Focus();
                return;
            }
            if (bLL_Employee.IsEmployeeNameExists(txtEName.Text.Trim()))
            {
                MessageBox.Show("Tên nhân viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string branchId = txtBId.Text;
                string provinceId = cboEProvince.SelectedValue.ToString();
                string wardId = cboEWard.SelectedValue.ToString();
                var address = new Address
                {
                    Id = bLL_Address.GenerateAddressId(cboEProvince.SelectedValue.ToString()),
                    WardId = cboEWard.SelectedValue.ToString(),
                    Name = txtEAddress.Text,
                    //Address1 = txtEAddress.Text,
                };
                bLL_Address.Add(address);

                string employeeId = bLL_Employee.GenerateEmployeeId();
                txtEId.Text = employeeId;
                var employee = new Employee
                {
                    Id = employeeId,
                    EmployeeName = txtEName.Text,
                    Phone = txtEPhone.Text,
                    AddressId = address.Id,
                    HireDate = DateOnly.FromDateTime(DateTime.Today),
                    SalaryPerHour = decimal.Parse(txtESalaryPerHour.Text),
                    Role = cboERole.SelectedItem.ToString(),
                    BranchId = txtBId.Text
                };
                bLL_Employee.Add(employee);
                MessageBox.Show("Đã thêm nhân viên thành công", "Thông báo");
                ClearEmployeeData();
                LoadEmployees(branchId);
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm nhân viên thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnEDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtEId.Text.Trim();
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
                    ClearEmployeeData();
                    LoadEmployees(txtBId.Text);
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa nhân viên thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnESave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEId.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;

            try
            {
                if (string.IsNullOrEmpty(txtEName.Text) ||
                    string.IsNullOrEmpty(txtEPhone.Text) ||
                    string.IsNullOrEmpty(txtEAddress.Text) ||
                    string.IsNullOrEmpty(txtESalaryPerHour.Text))
                {
                    MessageBox.Show("Thông tin nhân viên không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEPhone.Text, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ! Phải gồm 10 chữ số và bắt đầu bằng 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEPhone.Clear();
                    txtEPhone.Focus();
                    return;
                }
                if (cboEProvince.SelectedValue == null)
                {
                    MessageBox.Show("Tỉnh/Thành phố không được để trống", "Thông báo");
                    cboEProvince.Focus();
                    return;
                }
                if (cboEWard.SelectedValue == null)
                {
                    MessageBox.Show("Phường/Xã phố không được để trống", "Thông báo");
                    cboEWard.Focus();
                    return;
                }

                string id = txtEId.Text.Trim(); // Lấy ID Employee cần update
                var employee = bLL_Employee.GetAll().FirstOrDefault(e => e.Id == id);
                if (employee != null)
                {
                    // Update thông tin Address
                    if (employee.Address != null)
                    {
                        employee.Address.Name = txtEAddress.Text;
                        //employee.Address.Address1 = txtEAddress.Text;
                        employee.Address.WardId = cboEWard.SelectedValue.ToString();
                    }
                    else
                    {
                        // Nếu chưa có Address, tạo mới
                        var address = new Address
                        {
                            Id = bLL_Address.GetAllAddresses().Count + 1.ToString(),
                            Name = txtEAddress.Text,
                            //Address1 = txtEAddress.Text,
                            WardId = cboEWard.SelectedValue.ToString()
                        };
                        bLL_Address.Add(employee.Address);
                        employee.AddressId = address.Id;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên để cập nhật địa chỉ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                employee.EmployeeName = txtEName.Text;
                employee.Phone = txtEPhone.Text;
                employee.HireDate = DateOnly.FromDateTime(DateTime.Today);
                employee.SalaryPerHour = decimal.Parse(txtESalaryPerHour.Text);
                employee.Role = cboERole.SelectedItem.ToString();
                employee.BranchId = txtBId.Text;

                bLL_Employee.Update(employee);
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");

                LoadEmployees(txtBId.Text);
                ClearEmployeeData();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật nhân viên thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }
    }
}
