using BLL;
using DTO;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.Devices;
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
        private readonly BLL_Ingredient bLL_Ingredient = new();
        private readonly BLL_SupplierIngredient bLL_SupplierIngredient = new();
        private readonly BLL_Unit bLL_unit = new();

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

        private void LoadDgvIngredient(string keyword = null)
        {
            if (!string.IsNullOrWhiteSpace(keyword))
            {

                var filteredList = bLL_SupplierIngredient.GetAll()
                    .Where(si => si.Supplier != null && si.Supplier.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                 si.Supplier != null && si.Supplier.Id.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                 si.Ingredient != null && si.Ingredient.IngredientName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(si => new
                    {
                        si.IngredientId,
                        IngredientName = si.Ingredient != null ? si.Ingredient.IngredientName : "Lỗi hiển thị",
                        SupplierName = si.Supplier != null ? si.Supplier.Name : "Lỗi hiển thị",
                        StandardUnit = si.StandardUnit != null ? si.StandardUnit.UnitName : "Lỗi hiển thị",
                        si.UnitPrice,
                        si.ExpiryDay
                    }).ToList();
                dgvIngredient.DataSource = filteredList;
                return;
            }

            var displayList = bLL_SupplierIngredient.GetAll().Select(si => new
            {
                si.IngredientId,
                IngredientName = si.Ingredient != null ? si.Ingredient.IngredientName : "Lỗi hiển thị",
                SupplierName = si.Supplier != null ? si.Supplier.Name : "Lỗi hiển thị",
                StandardUnit = si.StandardUnit != null ? si.StandardUnit.UnitName : "Lỗi hiển thị",
                si.UnitPrice,
                si.ExpiryDay
            }).ToList();
            dgvIngredient.DataSource = displayList;

        }

        private void LoadCboSupplier()
        {
            var suppliers = bLL_Supplier.GetAllSuppliers();
            cboSupplier.DataSource = suppliers;
            cboSupplier.DisplayMember = "Name";
            cboSupplier.ValueMember = "Id";
            cboSupplier.SelectedIndex = 0;
        }

        private void LoadCboUnit()
        {
            var units = bLL_unit.GetAll();
            cboUnit.DataSource = units;
            cboUnit.DisplayMember = "UnitName";
            cboUnit.ValueMember = "Id";
            cboUnit.SelectedIndex = 0;
        }

        private void LoadCboIngredient()
        {
            var ingredient = bLL_Ingredient.GetAll();
            cboIngredientName.DataSource = ingredient;
            cboIngredientName.DisplayMember = "IngredientName";
            cboIngredientName.ValueMember = "Id";
        }

        private void RefreshDgvIngredient()
        {
            txtIngredientId.Clear();
            txtIngredientPrice.Clear();
            cboIngredientName.SelectedIndex = -1;
            cboSupplier.SelectedIndex = -1;
            cboUnit.SelectedIndex = -1;
            nmrExpieryDay.Text = "0";
            LoadDgvIngredient();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvIngredient.MultiSelect = false;
            dgvIngredient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredient.ReadOnly = true;
            dgvIngredient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoaddgvSupplier();
            LoadProvince();
            LoadDgvIngredient();
            LoadCboSupplier();
            LoadCboUnit();
            LoadCboIngredient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtSupplierName.Text) ||
                string.IsNullOrEmpty(txtPhone.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Thông tin nhà cung cấp không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!decimal.TryParse(txtPhone.Text, out decimal phoneNum))
            {
                MessageBox.Show("Số điện thoại phải là ký tự số!");
                return;

            }
            var exitingEmail = bLL_Supplier.GetEmailSupplier(txtEmail.Text, txtSupplierID.Text);
            var exitingPhone = bLL_Supplier.getPhoneSupplier(txtPhone.Text, txtSupplierID.Text);
            
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
           
            if (txtSupplierName.Text.Length > 100)
            {
                MessageBox.Show("Tên nhà cung cấp không được vượt quá 100 ký tự", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtSupplierName.Text) ||
               string.IsNullOrEmpty(txtPhone.Text) ||
               string.IsNullOrEmpty(txtEmail.Text) ||
               string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để cập nhật!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPhone.Text, out decimal phoneNum))
            {
                MessageBox.Show("Số điện thoại phải là ký tự số!");
                return;

            }
            var exitingEmail = bLL_Supplier.GetEmailSupplier(txtEmail.Text, txtSupplierID.Text);
            var exitingPhone = bLL_Supplier.getPhoneSupplier(txtPhone.Text, txtSupplierID.Text);
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
            if (string.IsNullOrEmpty(txtSupplierName.Text) ||
              string.IsNullOrEmpty(txtPhone.Text) ||
              string.IsNullOrEmpty(txtEmail.Text) ||
              string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
            cboSupplier.SelectedIndex = -1;
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

                var supplierName = selectedRow.Cells["Name"].Value.ToString();
                cboSupplier.SelectedIndex = cboSupplier.FindStringExact(supplierName);
                LoadDgvIngredient(txtSupplierName.Text);
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

        private async void txtFindIngredient_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindIngredient.Text;

            //Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                //chờ 0,5s sau khi người dùng ngừng nhập
                await Task.Delay(500, _cts.Token);
                LoadDgvIngredient(input);
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

        private void dgvIngredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvIngredient.Rows[e.RowIndex];
                txtIngredientId.Text = selectedRow.Cells["IngredientId"].Value.ToString();
                txtIngredientPrice.Text = selectedRow.Cells["UnitPrice"].Value.ToString();

                var ingredientName = selectedRow.Cells["IngredientName"].Value.ToString();
                cboIngredientName.SelectedIndex = cboIngredientName.FindStringExact(ingredientName);

                nmrExpieryDay.Text = selectedRow.Cells["ExpiryDay"].Value.ToString();

                var supplierName = selectedRow.Cells["SupplierName"].Value.ToString();
                cboSupplier.SelectedIndex = cboSupplier.FindStringExact(supplierName);

                var unit = selectedRow.Cells["StandardUnit"].Value.ToString();
                cboUnit.SelectedIndex = cboUnit.FindStringExact(unit);
            }
        }

        private void btnAddIng_Click(object sender, EventArgs e)
        {
            if (cboIngredientName.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng đơn vị tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (!decimal.TryParse(txtIngredientPrice.Text, out var price))
                {
                    MessageBox.Show("Số tiền không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Kiểm tra giá tiền nhỏ hơn 0
                if(price < 0)
                {
                    MessageBox.Show("Giá tiền không được là số âm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                

                if (!int.TryParse(cboUnit.SelectedValue.ToString(), out var unit))
                {
                    MessageBox.Show("Đơn vị tính không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(nmrExpieryDay.Value.ToString(), out var exp))
                {
                    MessageBox.Show("Hạn sử dụng không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (exp <= -1)
                {
                    {
                        MessageBox.Show("Hạn sử dụng không được là số âm", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                var supIngre = new SupplierIngredient
                {
                    IngredientId = cboIngredientName.SelectedValue.ToString(),
                    SupplierId = cboSupplier.SelectedValue.ToString(),
                    UnitPrice = price,
                    StandardUnitId = unit,
                    ExpiryDay = exp,

                };
                bLL_SupplierIngredient.Add(supIngre);
                LoadDgvIngredient(txtSupplierName.Text);
                RefreshDgvIngredient();

            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm nguyên liệu của nhà cung cấp thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void cboIngredientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIngredientName.SelectedIndex >= 0)
            {
                txtIngredientId.Text = cboIngredientName.SelectedValue.ToString();
            }
        }

        private void btnClearIng_Click(object sender, EventArgs e)
        {
            RefreshDgvIngredient();
        }

        private void btnUpdateIng_Click(object sender, EventArgs e)
        {
            if (cboIngredientName.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboUnit.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng đơn vị tính", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật dữ liệu nguyên liệu của nhà cung cấp này không?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
            try
            {
                if (!decimal.TryParse(txtIngredientPrice.Text, out var price))
                {
                    MessageBox.Show("Số tiền không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(cboUnit.SelectedValue.ToString(), out var unit))
                {
                    MessageBox.Show("Đơn vị tính không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(nmrExpieryDay.Text, out var exp))
                {
                    MessageBox.Show("Hạn sử dụng không hợp lệ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (exp <= 0)
                {
                    MessageBox.Show("Hạn sử dụng không được bằng hoặc nhỏ hơn 0", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var supIngre = new SupplierIngredient
                {
                    IngredientId = txtIngredientId.Text,
                    SupplierId = txtSupplierID.Text,
                    UnitPrice = price,
                    StandardUnitId = unit,
                    ExpiryDay = exp,

                };
                bLL_SupplierIngredient.Update(supIngre);
                LoadDgvIngredient(txtSupplierName.Text);
                RefreshDgvIngredient();

            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật nguyên liệu của nhà cung cấp thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnDeleteIng_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu nguyên liệu của nhà cung cấp này không?\nNếu xóa nguyên liệu của nhà cung cấp này sẽ biết mất hoàn toàn", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
        }

        private void cboSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSupplier.SelectedIndex >= 0)
            {
                txtSupplierID.Text = cboSupplier.SelectedValue.ToString();
                LoadDgvIngredient(txtSupplierID.Text);  
            }
        }


    }
}
