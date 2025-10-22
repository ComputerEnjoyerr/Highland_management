using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }
        private readonly BLL_Supplier bLL_Supplier = new();
        private readonly BLL_Address bLL_Address = new();
        private readonly BLL_Province bLL_Province = new();
        private readonly BLL_Ward bLL_Ward = new();

        private void LoadProvince()
        {
            var provinces = bLL_Province.GetAllProvinces();
            cbProvince.DataSource = provinces;
            cbProvince.DisplayMember = "ProvinceName";
            cbProvince.ValueMember = "Id";
            cbProvince.SelectedIndex = -1;
        }

        private void LoadWard(string provinceId)
        {
            var wards = bLL_Ward.GetWardByProvinceId(provinceId);
            cbWard.DataSource = wards;
            cbWard.DisplayMember = "WardName";
            cbWard.ValueMember = "Id";
            cbWard.SelectedIndex = -1;
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoaddgvSupplier();
            LoadProvince();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {              
           
            if(string.IsNullOrEmpty(txtSupplierName.Text)||
                string.IsNullOrEmpty(txtPhone.Text)||
                string.IsNullOrEmpty(txtEmail.Text)||
                string.IsNullOrEmpty(txtAddress.Text)){
                MessageBox.Show("Thông tin nhà cung cấp không được để trống!","Thiếu thông tin",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (cbProvince.SelectedValue == null)
            {
                MessageBox.Show("Tỉnh/Thành phố không được để trống");
                return;
            }
            if (cbWard.SelectedValue == null)
            {
                MessageBox.Show("Phường/Xã phố không được để trống");
                return;
            }
            if(!decimal.TryParse(txtPhone.Text, out decimal phoneNum))
                {
                MessageBox.Show("Số điện thoại phải là ký tự số!");
                return;

            }
            var exitingEmail = bLL_Supplier.GetEmailSupplier(txtEmail.Text);
            var exitingPhone = bLL_Supplier.getPhoneSupplier(txtPhone.Text);
            if (exitingEmail != null && !string.IsNullOrEmpty(exitingEmail.Id))
            {
                MessageBox.Show("Email đã bị trùng với một nhà cung cấp khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (exitingPhone != null && !string.IsNullOrEmpty(exitingPhone.Id)) 
            {
                MessageBox.Show("Số điện thoại đã bị trùng với một nhà cung cấp khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string provinceId = cbProvince.SelectedValue.ToString();              
                string wardId = cbWard.SelectedValue.ToString();
                var address = new Address
                {
                    Id = bLL_Address.GenerateAddressId(cbProvince.SelectedValue.ToString()),
                    //ProvinceId = cbProvince.SelectedValue.ToString(),
                    WardId = cbWard.SelectedValue.ToString(),
                    Address1 = txtAddress.Text,
                };
                bLL_Address.Add(address);

                string supllierId = bLL_Supplier.GenerateSupplierId(provinceId);
                txtSupplierID.Text = supllierId;
                var add = new Supplier
                {
                    Id = supllierId,
                    Name = txtSupplierName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    AddressId = address.Id,

                };
                if (!ValidateSupplier(add))
                {
                    return;
                }
                bLL_Supplier.Add(add);
                MessageBox.Show("Đã thêm thành công");
                ClearInputFields();
                LoaddgvSupplier();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm nhà cung cấp thất bại.\nChi tiết lỗi: " + inner);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPhone.Text, out decimal phoneNum))
            {
                MessageBox.Show("Số điện thoại phải là ký tự số!");
                return;

            }
            var exitingEmail = bLL_Supplier.GetEmailSupplier(txtEmail.Text);
            var exitingPhone = bLL_Supplier.getPhoneSupplier(txtPhone.Text);
            if (exitingEmail != null && !string.IsNullOrEmpty(exitingEmail.Id))
            {
                MessageBox.Show("Email đã bị trùng với một nhà cung cấp khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (exitingPhone != null && !string.IsNullOrEmpty(exitingPhone.Id))
            {
                MessageBox.Show("Số điện thoại đã bị trùng với một nhà cung cấp khác", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string id = txtSupplierID.Text.Trim(); // Lấy ID Supplier cần update
                var supplier = bLL_Supplier.GetAllSuppliers().FirstOrDefault(s => s.Id == id);

                if (supplier == null)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp để cập nhật!");
                    return;
                }

                // Update thông tin Address
                if (supplier.Address != null)
                {
                    supplier.Address.Address1 = txtAddress.Text;
                    supplier.Address.WardId = cbWard.SelectedValue.ToString();
                }
                else
                {
                    // Nếu chưa có Address, tạo mới
                    var address = new Address
                    {
                        Id = bLL_Address.GetAllAddresses().Count + 1.ToString(),
                        Address1 = txtAddress.Text,
                        WardId = cbWard.SelectedValue.ToString()
                    };
                    bLL_Address.Add(supplier.Address);
                    supplier.AddressId = address.Id;
                }

                // Update thông tin Supplier
                supplier.Name = txtSupplierName.Text;
                supplier.Phone = txtPhone.Text;
                supplier.Email = txtEmail.Text;

                if (!ValidateSupplier(supplier))
                {
                    return;
                }
                bLL_Supplier.Update(supplier); // Lưu vào DB

                MessageBox.Show("Đã cập nhật thành công");
                ClearInputFields();
                LoaddgvSupplier();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật nhà cung cấp thất bại.\nChi tiết lỗi: " + inner);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtSupplierID.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa.");
                    return;
                }
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không?", id, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bLL_Supplier.Delete(id);
                    MessageBox.Show("Đã xóa thành công");
                    LoaddgvSupplier();
                    ClearInputFields();

                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa nhà cung cấp thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnHoanTac_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtSupplierID.Clear();
            txtSupplierName.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cbWard.SelectedIndex = -1;
            cbProvince.SelectedIndex = -1;
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvince.SelectedIndex != -1)
            {
                string provinceId = cbProvince.SelectedValue.ToString();
                string newSupplierId = bLL_Supplier.GenerateSupplierId(provinceId);
                txtSupplierID.Text = newSupplierId;
                LoadWard(cbProvince.SelectedValue.ToString());
            }
            else
            {
                txtSupplierID.Clear();
            }
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvSupplier.Rows[e.RowIndex];

                //txtSupplierID.Text = dgvSupplier.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtSupplierName.Text = selectedRow.Cells["Name"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value?.ToString();

                var provinceName = selectedRow.Cells["Province"].Value?.ToString();
                cbProvince.SelectedIndex = cbProvince.FindStringExact(provinceName);
                var wardName = selectedRow.Cells["Ward"].Value.ToString();
                cbWard.SelectedIndex = cbWard.FindStringExact(wardName);
                txtSupplierID.Text = selectedRow.Cells["Id"].Value.ToString();
            }
        }

        private void cbWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if (cbWard.SelectedIndex != -1 && cbWard.SelectedValue != null)
            //    {
            //        string wardId = cbWard.SelectedValue.ToString();
            //        txtSupplierID.Text = bLL_Supplier.GenerateSupplierId(wardId);
            //    }
        }

        private void LoaddgvSupplier(string keyword = null)
        {
            dgvSupplier.MultiSelect = false;
            dgvSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplier.ReadOnly = true;

            
            if (!string.IsNullOrEmpty(keyword))
            {
                var filterList = bLL_Supplier.GetAllSuppliers()
                    .Where(s => s.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) && s.Address != null)
                    //.ToList();
                    .Select(s => new
                    {
                        s.Id,
                        s.Name,
                        s.Phone,
                        s.Email,
                        Address = s.Address != null ? s.Address.Address1 : "null",
                        Ward = s.Address?.Ward != null ? s.Address.Ward.WardName : "Unknown",
                        Province = s.Address?.Ward?.Province != null ? s.Address.Ward.Province.ProvinceName : "Unknown",
                    }).ToList();

                dgvSupplier.DataSource = filterList;
                return;
            }
                        
            var displayList = bLL_Supplier.GetAllSuppliers().Select(s => new
            {
                s.Id,
                s.Name,
                s.Phone,
                s.Email,
                Address = s.Address != null ? s.Address.Address1 : "null",
                Ward = s.Address?.Ward != null ? s.Address.Ward.WardName : "Unknown",
                Province = s.Address?.Ward?.Province != null ? s.Address.Ward.Province.ProvinceName : "Unknown",
            }).ToList();

                dgvSupplier.DataSource = displayList;            
        }
        //Biển theo dõi công tác nhập liệu
        private CancellationTokenSource _cts = new();

        private async Task txtFindSupplier_TextChanged(object sender, EventArgs e)
        {
        }

        private async void txtFindSuppliers_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindSuppliers.Text;

            //Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                //chờ 0,5s sau khi người dùng ngừng nhập
                await Task.Delay(500, _cts.Token);
                LoaddgvSupplier(input);
            }
            catch (TaskCanceledException)
            {

            }
        }
        //Kiểm tra email hợp lệ
        private bool ValidateSupplier(Supplier supplier)
        {
            var context = new ValidationContext(supplier, null, null);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(supplier, context, results, true);

            if (!isValid)
            {
                //thông báo lỗi
                MessageBox.Show(results.First().ErrorMessage, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        } 

        
    }
}
