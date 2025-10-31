using BLL;
using DTO;
using FastReport;
using FastReport.Preview;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class frmProduct : Form
    {
        private readonly BLL_Product bLL_Product = new();
        private readonly BLL_Recipe bLL_Recipe = new();
        private readonly BLL_Category bLL_Category = new();
        private readonly BLL_Ingredient bLL_Ingredient = new();
        private readonly BLL_SupplierIngredient bLL_SupplierIngredient = new();
        private readonly BLL_Unit bLL_Unit = new();
        private string selectedImagePath = null;   
        private string selectedImageName = null;   

        private List<Product> productList = new List<Product>();

        public frmProduct()
        {
            InitializeComponent();
        }

        private void LoaddgvProduct(string keyword = "")
        {
            // Lọc dữ liệu từ keyword
            var filteredList = bLL_Product.GetAll()
                .Where(p => p.ProductName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            p.Category != null && p.Category.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            p.Price.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            productList = filteredList; // Gán danh sách vào biến

            // Trích dữ liệu cần thiết
            var displayList = productList.Select(p => new
            {
                p.Id,
                p.ProductName,
                p.Price,
                p.Status,
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

        private void LoaddgvRecipe(string productId)
        {
            var product = bLL_Product.GetById(productId);
            if (product != null)
            {
                var filteredList = bLL_Recipe.GetAll()
                    .Where(r => r.ProductId == productId)
                    .Select(r => new
                    {
                        r.Id,
                        r.IngredientId,
                        Ingredient = r.Ingredient != null ? r.Ingredient.IngredientName : "Lỗi hiển thị",
                        r.Quantity,
                        RecipeUnit = r.RecipeUnit != null ? r.RecipeUnit.UnitName : "Lỗi hiển thị"
                    }).ToList();
                dgvRecipe1.DataSource = filteredList;
                dgvRecipe2.DataSource = filteredList;
                return;
            }
            var displayList = bLL_Recipe.GetAll()
                .Select(r => new
                {
                    r.Id,
                    r.IngredientId,
                    Ingredient = r.Ingredient != null ? r.Ingredient.IngredientName : "Lỗi hiển thị",
                    r.Quantity,
                    RecipeUnit = r.RecipeUnit != null ? r.RecipeUnit.UnitName : "Lỗi hiển thị"
                }).ToList();
            dgvRecipe1.DataSource = displayList;
            dgvRecipe2.DataSource = displayList;
        }


        private void LoadCboCategory()
        {
            var categories = bLL_Category.GetAll();
            cboCategory.DataSource = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";

        }

        private void LoadCboUnit()
        {
            var units = bLL_Unit.GetAll();
            cboIngredientUnit.DataSource = units;
            cboIngredientUnit.DisplayMember = "UnitName";
            cboIngredientUnit.ValueMember = "Id";

        }

        private void LoadCboProduct()
        {
            var products = bLL_Product.GetAll();
            cboProductName.DataSource = products;
            cboProductName.DisplayMember = "ProductName";
            cboProductName.ValueMember = "Id";

        }

        private void RefreshProduct()
        {
            txtProductId1.Clear();
            txtProductName1.Clear();
            txtPrice.Clear();
            cboCategory.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            txtProductName1.Focus();
            pbImage.Image = null;
            selectedImageName = null;
            selectedImagePath = null;
            LoadCboProduct();
        }
        private void RefreshRecipe()
        {
            txtRecipeId.Clear();
            txtIngredientId.Clear();
            txtIngredientName.Clear();
            txtIngredientQty.Clear();
            cboIngredientUnit.SelectedIndex = 0;
            txtIngredientQty.Focus();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

            // Tải dữ liệu về các control
            LoaddgvProduct();
            LoaddgvSupplierIngredient();
            LoadCboCategory();
            LoadCboUnit();
            LoadCboProduct();

            // ===== Cài đặt trạng thái hiển thị =====

            dgvProduct.MultiSelect = false;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.ReadOnly = true;
            dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRecipe1.MultiSelect = false;
            dgvRecipe1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipe1.ReadOnly = true;
            dgvRecipe1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvRecipe2.MultiSelect = false;
            dgvRecipe2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipe2.ReadOnly = true;
            dgvRecipe2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            pbImage.SizeMode = PictureBoxSizeMode.Zoom;

            // cbo loại sản phẩm
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.SelectedIndex = 0;

            // cbo đơn vị tính nguyên liệu
            cboIngredientUnit.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIngredientUnit.SelectedIndex = 0;

            // cbo sản phẩm
            cboProductName.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductName.SelectedIndex = -1;

            // cbo trạng thái sản phẩm
            cboStatus.Items.Add("Đang bán");
            cboStatus.Items.Add("Ngừng bán");
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.SelectedIndex = 0;

            // ========================================
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra giá tiền có phải là decimal
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Vui lòng nhập giá bán và giờ làm thêm hợp lệ.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                DateTime dateTime = DateTime.Now;
                // Tạo product mới để thêm vào
                Product product = new Product
                {
                    Id = $"PD{dateTime:yyMMddHHmmss}",
                    ProductName = txtProductName1.Text,
                    CategoryId = cboCategory.SelectedValue.ToString(),
                    // Image,
                    Status = cboStatus.SelectedItem.ToString(),
                    Price = price
                };
                // Lưu ảnh vào product và thư mục
                if (!SaveImageToFile(product))
                    return;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
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
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                // Kiểm tra số tiền có phải là decimal
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Vui lòng nhập giá bán hợp lệ.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                // Tạo product mới để sửa
                var product = new Product
                {
                    Id = txtProductId1.Text,
                    ProductName = txtProductName1.Text,
                    CategoryId = cboCategory.SelectedValue.ToString(),
                    Status = cboStatus.SelectedItem.ToString(),
                    // Image = ?,
                    Price = price
                };
                if (!SaveImageToFile(product))
                    return;

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
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < productList.Count)
            {
                var selectedRow = productList[e.RowIndex];

                txtProductId1.Text = selectedRow.Id;
                txtProductName1.Text = selectedRow.ProductName;
                txtPrice.Text = selectedRow.Price.ToString();
                var categoryName = selectedRow.Category?.Name;
                cboCategory.SelectedIndex = cboCategory.FindStringExact(categoryName);
                var status = selectedRow.Status;
                cboStatus.SelectedIndex = cboStatus.FindStringExact(status);

                // Hiển thị chi tiết công thức
                LoaddgvRecipe(txtProductId1.Text);
                // Hiển thị ảnh sản phẩm
                var product = bLL_Product.GetById(txtProductId1.Text);
                if (product != null)
                    DisplayImage(product);
            }
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                tcMain.SelectTab("tpRecipe");

                var selectedRow = dgvProduct.Rows[e.RowIndex];
                txtProductId2.Text = selectedRow.Cells["Id"].Value.ToString();
                var productName = selectedRow.Cells["ProductName"].Value.ToString();
                cboProductName.SelectedIndex = cboProductName.FindStringExact(productName);

                // Hiển thị chi tiết công thức
                LoaddgvRecipe(txtProductId1.Text);
            }
        }

        private async void txtFindIngredient_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindIngredient.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoaddgvSupplierIngredient(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private void cboProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductName.SelectedIndex != -1)
            {
                if (cboProductName.SelectedValue == null)
                    return;
                txtProductId2.Text = cboProductName.SelectedValue.ToString();

            }
            else
            {
                txtProductId2.Clear();
            }
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            if (txtProductId2.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn sản phẩm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (txtIngredientId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (txtIngredientQty.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập số lượng", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(txtIngredientQty.Text, out decimal quantity))
                {
                    MessageBox.Show("Giá tiền không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboIngredientUnit.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn đơn vị tính", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboIngredientUnit.SelectedValue == null)
                {
                    MessageBox.Show("Không thể lưu dữ liệu Đơn vị tính", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                var recipe = new Recipe
                {
                    Id = bLL_Recipe.GenerateId(),
                    IngredientId = txtIngredientId.Text,
                    ProductId = txtProductId2.Text,
                    Quantity = quantity,
                    RecipeUnitId = (int)cboIngredientUnit.SelectedValue
                };
                bLL_Recipe.Add(recipe);
                LoaddgvRecipe(txtProductId2.Text);
                RefreshRecipe();

            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm công thức thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void dgvRecipe2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var selectedRow = dgvRecipe2.Rows[e.RowIndex];
                txtRecipeId.Text = selectedRow.Cells["Id"].Value.ToString();

                var unit = selectedRow.Cells["RecipeUnit"].Value.ToString();
                cboIngredientUnit.SelectedIndex = cboIngredientUnit.FindStringExact(unit);

                txtIngredientQty.Text = selectedRow.Cells["Quantity"].Value.ToString();

                var ingredientId = selectedRow.Cells["IngredientId"].Value.ToString();
                if (ingredientId == null) return;

                txtIngredientId.Text = ingredientId;
                var ingredient = bLL_Ingredient.GetById(ingredientId);
                txtIngredientName.Text = ingredient.IngredientName;
            }
        }

        private void txtProductId2_TextChanged(object sender, EventArgs e)
        {

            if (txtProductId2.Text.IsNullOrEmpty())
                return;
            LoaddgvRecipe(txtProductId2.Text);
        }

        private void btnDeleteRecipe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecipeId.Text))
            {
                MessageBox.Show("Vui lòng chọn công thức cần xóa từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu công thức này không?\nNếu xóa công thức này sẽ biết mất hoàn toàn", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
            try
            {
                bLL_Recipe.Delete(txtRecipeId.Text);
                LoaddgvRecipe(txtProductId2.Text);
                RefreshRecipe();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa công thức thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnUpdateRecipe_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRecipeId.Text))
            {
                MessageBox.Show("Vui lòng chọn công thức cần cập nhật từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtProductId2.Text))
            {
                MessageBox.Show("Không thể tìm thấy sản phẩm có công thức này.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtIngredientId.Text))
            {
                MessageBox.Show("Không thể tìm thấy nguyên liệu thuộc công thức này.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật dữ liệu công thức này không?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
            try
            {
                if (txtIngredientQty.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập số lượng", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (!decimal.TryParse(txtIngredientQty.Text, out decimal quantity))
                {
                    MessageBox.Show("Giá tiền không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboIngredientUnit.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn đơn vị tính", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboIngredientUnit.SelectedValue == null)
                {
                    MessageBox.Show("Không thể lưu dữ liệu Đơn vị tính", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                var recipe = new Recipe
                {
                    Id = txtRecipeId.Text,
                    IngredientId = txtIngredientId.Text,
                    ProductId = txtProductId2.Text,
                    Quantity = quantity,
                    RecipeUnitId = (int)cboIngredientUnit.SelectedValue
                };
                bLL_Recipe.Update(recipe);
                LoaddgvRecipe(txtProductId2.Text);
                RefreshRecipe();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật công thức thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnClearRecipe_Click(object sender, EventArgs e)
        {
            RefreshRecipe();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            string path = Path.Combine(Application.StartupPath, @"..\..\..\RPTProductDetail.frx");
            report.Load(path);
            report.Show();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn ảnh sản phẩm";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu thông tin file được chọn
                    selectedImagePath = openFileDialog.FileName;
                    selectedImageName = Path.GetFileName(selectedImagePath);

                    // Hiển thị ảnh trong pbImage 
                    using (var img = Image.FromFile(selectedImagePath))
                    {
                        pbImage.Image = new Bitmap(img);
                    }
                }
            }
        }

        private bool SaveImageToFile(Product product)
        {
            try
            {
                // Đường dẫn cố định tới thư mục ảnh trong project GUI
                string imageFolder = Path.Combine(Application.StartupPath, @"..\..\..\Images\Product");

                // Tạo thư mục nếu chưa có hoặc bị xóa
                if (!Directory.Exists(imageFolder))
                    Directory.CreateDirectory(imageFolder);

                if (string.IsNullOrEmpty(selectedImagePath))
                {
                    product.Image = null;
                    return true;
                }

                // Tạo đường dẫn đích
                string destinationPath = Path.Combine(imageFolder, selectedImageName);

                // Lệnh tự động tạo tên mới nếu trùng tên
                if (File.Exists(destinationPath))
                {
                    string fileNameWithoutExt = Path.GetFileNameWithoutExtension(selectedImageName);
                    string extension = Path.GetExtension(selectedImageName);
                    string newName = $"{ fileNameWithoutExt}_{DateTime.Now:yyyyMMddHHmmss}{extension}";
                    destinationPath = Path.Combine(imageFolder, newName);
                    selectedImageName = newName;
                }

                // Sao chép file vào thư mục Image
                File.Copy(selectedImagePath, destinationPath, true);

                // Gán tên file vào product
                product.Image = selectedImageName;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void DisplayImage(Product product)
        {
            pbImage.Image = null;

            if (!string.IsNullOrEmpty(product.Image))
            {
                // Tìm file ảnh trùng tên với product.Image
                string imagePath = Path.Combine(Application.StartupPath, @"..\..\..\Images\Product", product.Image);
                if (File.Exists(imagePath))
                {
                    using (var img = Image.FromFile(imagePath))
                    {
                        pbImage.Image = new Bitmap(img);
                    }
                }
            }
        }
    }
}
