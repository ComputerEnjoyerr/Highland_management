using BLL;
using DTO;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class frmProduct : Form
    {
        private readonly BLL_Product bLL_Product = new();
        private readonly BLL_Category bLL_Category = new();
        private readonly BLL_Ingredient bLL_Ingredient = new();
        private readonly BLL_SupplierIngredient bLL_SupplierIngredient = new();
        private readonly BLL_Unit bLL_Unit = new();

        public frmProduct()
        {
            InitializeComponent();
        }

        private void LoaddgvProduct(string keyword = null)
        {
            dgvProduct.MultiSelect = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ReadOnly = true;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var filteredList = bLL_Product.GetAll()
                    .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                p.Category != null && p.Category.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                p.Price.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(p => new
                    {
                        p.Id,
                        p.ProductName,
                        p.Price,
                        p.Image,
                        CategoryName = p.Category != null ? p.Category.Name : "Lỗi hiển thị"
                    }).ToList();
                dgvProduct.DataSource = filteredList;
                return;
            }

            var displayList = bLL_Product.GetAll().Select(p => new
            {
                p.Id,
                p.ProductName,
                p.Price,
                p.Image,
                CategoryName = p.Category != null ? p.Category.Name : "Lỗi hiển thị"
            }).ToList();
            dgvProduct.DataSource = displayList;
        }

        private void LoaddgvSupplierIngredient(string keyword = null)
        {
            dgvIngredient.MultiSelect = false;
            dgvIngredient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIngredient.ReadOnly = true;

            if (!string.IsNullOrWhiteSpace(keyword))
            {

                var filteredList = bLL_SupplierIngredient.GetAll()
                    .Where(si => si.Supplier != null && si.Supplier.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                 si.Ingredient != null && si.Ingredient.IngredientName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(si => new
                    {
                        si.IngredientId,
                        IngredientName = si.Ingredient != null ? si.Ingredient.IngredientName : "Lỗi hiển thị",
                        SupplierName = si.Supplier != null ? si.Supplier.Name : "Lỗi hiển thị",
                        StandardUnit = si.StandardUnit != null ? si.StandardUnit.UnitName : "Lỗi hiển thị",
                        si.UnitPrice
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
                si.UnitPrice
            }).ToList();
            dgvIngredient.DataSource = displayList;
        }

        private void LoadCboCategory()
        {
            var categories = bLL_Category.GetAll();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.SelectedIndex = -1;
        }

        private void LoadCboUnit()
        {
            var units = bLL_Unit.GetAll();
            cboIngredientUnit.DataSource = units;
            cboIngredientUnit.DisplayMember = "UnitName";
            cboIngredientUnit.ValueMember = "Id";
            cboIngredientUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIngredientUnit.SelectedIndex = -1;
        }

        private void RefreshProduct()
        {
            txtProductId1.Clear();
            txtProductName1.Clear();
            txtPrice.Clear();
            cboCategory.SelectedIndex = -1;
            txtProductName1.Focus();
        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoaddgvProduct();
            LoaddgvSupplierIngredient();
            LoadCboCategory();
            LoadCboUnit();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Vui lòng nhập giá bán và giờ làm thêm hợp lệ.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPrice.Text.Trim().Length > 0)
                {
                    MessageBox.Show("Giá bán vượt mức cho phép (Tối đa 10 ký tự số)", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtProductName1.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (txtProductName1.Text.Length > 50)
                {
                    MessageBox.Show("Tên sản phẩm vượt mức cho phép (Tối đa 50 ký tự)", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                if (cboCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn danh mục sản phẩm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboCategory.SelectedValue == null)
                {
                    MessageBox.Show("Giá trị danh mục sản phẩm không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                DateTime dateTime = DateTime.Now;
                Product product = new Product
                {
                    Id = $"PD{dateTime:yyMMddHHmmss}",
                    ProductName = txtProductName1.Text,
                    CategoryId = cboCategory.SelectedValue.ToString(),
                    // Image = ?,
                    Price = price
                };
                bLL_Product.Add(product);
                LoaddgvProduct();
                RefreshProduct();
            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm sản phẩm thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProduct();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvProduct.Rows[e.RowIndex];
                txtProductId1.Text = selectedRow.Cells["Id"].Value.ToString();
                txtProductName1.Text = selectedRow.Cells["ProductName"].Value.ToString();
                txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
                var categoryName = selectedRow.Cells["CategoryName"].Value.ToString();
                cboCategory.SelectedIndex = cboCategory.FindStringExact(categoryName);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId1.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu sản phẩm này không?\nNếu xóa sản phẩm này sẽ biết mất hoàn toàn", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
            try
            {
                bLL_Product.Delete(txtProductId1.Text);
                LoaddgvProduct();
                RefreshProduct();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa sản phẩm thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductId1.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần cập nhật từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Vui lòng nhập giá bán hợp lệ.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                int priceLength = 10;
                if (txtPrice.Text.Trim().Length > priceLength)
                {
                    MessageBox.Show($"Giá bán vượt mức cho phép (Tối đa {priceLength} ký tự số)", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtProductName1.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn danh mục sản phẩm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboCategory.SelectedValue == null)
                {
                    MessageBox.Show("Giá trị danh mục sản phẩm không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                var product = new Product
                {
                    Id = txtProductId1.Text,
                    ProductName = txtProductName1.Text,
                    CategoryId = cboCategory.SelectedValue.ToString(),
                    // Image = ?,
                    Price = price
                };
                bLL_Product.Update(product);
                LoaddgvProduct();
                RefreshProduct();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật sản phẩm thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        // Biến để theo dõi thao tác nhập liệu
        private CancellationTokenSource _cts = new();
        private async void txtFindProduct_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindProduct.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 2 giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoaddgvProduct(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private void dgvIngredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvIngredient.Rows[e.RowIndex];
                txtIngredientId.Text = selectedRow.Cells["IngredientId"].Value.ToString();
                txtIngredientName.Text = selectedRow.Cells["IngredientName"].Value.ToString();
                var unitName = selectedRow.Cells["StandardUnit"].Value.ToString();
                cboIngredientUnit.SelectedIndex = cboIngredientUnit.FindStringExact(unitName);
            }
        }
    }
}
