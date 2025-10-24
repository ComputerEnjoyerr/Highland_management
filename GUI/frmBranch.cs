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
    public partial class frmBranch : Form
    {
        private readonly BLL_Branch bLL_Branch = new BLL_Branch();
        private readonly BLL_Address bLL_Address = new BLL_Address();
        private readonly BLL_Province bLL_Province = new BLL_Province();
        private readonly BLL_Ward bLL_Ward = new BLL_Ward();

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
                        Address = b.Address != null ? b.Address.Address1 : "Lỗi hiển thị",
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
                Address = b.Address != null ? b.Address.Address1 : "Lỗi hiển thị",
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
        }

        private void LoadWard(string provinceId)
        {
            var wards = bLL_Ward.GetWardByProvinceId(provinceId);
            cboWard.DataSource = wards;
            cboWard.DisplayMember = "WardName";
            cboWard.ValueMember = "Id";
            cboWard.SelectedIndex = -1;
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
                    Address1 = txtAddress.Text,
                };
                bLL_Address.Add(address);

                string branchId = bLL_Branch.GenerateBranchId(provinceId);
                txtBId.Text = branchId;
                var branch = new Branch
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
                var existingPhone = bLL_Branch.GetBranchByPhone(txtPhone.Text, txtBId.Text);
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

                string id = txtBId.Text.Trim(); // Lấy ID Branch cần update
                var branch = bLL_Branch.GetAll().FirstOrDefault(b => b.Id == id);
                if (branch != null)
                {
                    // Update thông tin Address
                    if (branch.Address != null)
                    {
                        branch.Address.Address1 = txtAddress.Text;
                        branch.Address.WardId = cboWard.SelectedValue.ToString();
                    }
                    else
                    {
                        // Nếu chưa có Address, tạo mới
                        var address = new Address
                        {
                            Id = bLL_Address.GetAllAddresses().Count + 1.ToString(),
                            Address1 = txtAddress.Text,
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
            }
        }
    }
}
