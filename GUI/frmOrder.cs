using BLL;
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
using System.Xml.Linq;

namespace GUI
{
    public partial class frmOrder : Form
    {
        private readonly BLL_Category bLL_Category = new();
        private readonly BLL_Product bLL_Product = new();
        private readonly BLL_Table bLL_Table = new();
        private readonly BLL_Customer bLL_Customer = new();
        private readonly BLL_Bill bLL_Bill = new();
        private readonly BLL_BillInfo bLL_BillInfo = new();
        private readonly BLL_Promotion bLL_Promotion = new();
        private readonly BLL_PromotionProgram bLL_PromotionProgram = new();
        private readonly BLL_PromotionVoucher bLL_PromotionVoucher = new();

        private Employee employee = new(); // Nhân viên đang đăng nhập
        private List<Table> tables = new(); // Danh sách bàn ăn của chi nhánh
        private Table selectedTable; // Bàn ăn hiện tại đang chọn
        private Product selectedProduct; // Sản phẩm đang chọn
        private Customer selectedCustomer; // Khách hàng đang chọn
        private Bill selectedBill; // Hóa đơn hiện tại
        private List<Billinfo> billInfoList = new(); // Danh sách chi tiết hóa đơn hiển thị
        private decimal totalPrice = 0; // Tổng tiền trước khuyến mãi
        public frmOrder(Employee em)
        {
            InitializeComponent();
            employee = em;
        }

        private void RefreshInput()
        {
            selectedProduct = null;
            txtProductName.Text = "";
            nmrProductQty.Value = 1;
        }

        private void ClearCustomer()
        {
            selectedCustomer = null;
            txtCustomer.Text = "";
            txtCustomer.Tag = null;
            txtCustomerDrips.Text = "";
            txtCustomerTier.Text = "";
            txtTotalPrice.Text = "0";
            txtDiscount.Text = "0";
            txtFinalPrice.Text = "0";
            totalPrice = 0;
        }

        private void LoadBillInfo()
        {
            // Hiển thị thông tin chi tiết hóa đơn cho bàn đã chọn
            if (selectedTable == null)
                return;
            selectedBill = bLL_Bill.GetAll().FirstOrDefault(b => b.TableId == selectedTable.Id && b.Status == 0);
            if (selectedBill == null)
            {
                // Bàn trống, không có hóa đơn
                if (dgvBillInfo.DataSource != null)
                    dgvBillInfo.DataSource = null;
                if (dgvBillInfoCheckout.DataSource != null)
                    dgvBillInfoCheckout.DataSource = null;
                btnChooseCustomer.Enabled = true; // Mở khóa nút chọn khách hàng khi bàn trống
                ClearCustomer();
                return;
            }
            // Lấy chi tiết hóa đơn
            var billInfos = bLL_BillInfo.GetByBillId(selectedBill.Id);
            billInfoList = billInfos;
            var displayList = billInfos.Select(bi =>
            {
                var product = bLL_Product.GetById(bi.ProductId);
                return new
                {
                    bi.ProductId,
                    product.ProductName,
                    product.Price,
                    bi.Quantity
                };
            }).ToList();
            // Gán khách hàng trong hóa đơn
            selectedCustomer = selectedBill.Customer;
            if (selectedCustomer != null)
            {
                txtCustomer.Text = selectedCustomer.CustomerName;
                txtCustomer.Tag = selectedCustomer;
                txtCustomerDrips.Text = selectedCustomer.Drips.ToString();
                txtCustomerTier.Text = selectedCustomer.Tier;
            }
            btnChooseCustomer.Enabled = false; // Khóa nút chọn khách hàng khi đã có khách
            dgvBillInfo.DataSource = displayList;
            dgvBillInfoCheckout.DataSource = displayList;
        }

        private void LoadBtnTable()
        {
            tables = bLL_Table.GetByBranch(employee.BranchId); // Lấy danh sách bàn ăn của chi nhánh
            flpBanAn.Controls.Clear();
            // Tạo nút cho từng bàn ăn
            foreach (var table in tables)
            {
                var status = "";
                var backColor = ColorTranslator.FromHtml("#F9F5EE");
                if (table.Status == 0)
                {
                    // Trống
                    status = "Trống";
                }
                else if (table.Status == 1)
                {
                    // Đã đặt
                    status = "Đã đặt";
                    backColor = ColorTranslator.FromHtml("#A8222B");
                }

                Button btn = new()
                {
                    Width = 160,
                    Height = 120,
                    BackColor = backColor,
                    Text = table.TableName + Environment.NewLine + status.ToUpper(),
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    Tag = table // Lưu thông tin bàn ăn vào thuộc tính Tag của nút
                };
                btn.Click += TableBtn_Click; // Gán sự kiện Click cho nút
                flpBanAn.Controls.Add(btn); // Thêm nút vào flpBanAn
            }
        }

        private void LoadCategory()
        {
            var categories = bLL_Category.GetAll();
            flpSideBar.Controls.Clear();
            foreach (var category in categories)
            {
                Panel container = new()
                {
                    Width = 176,
                    Height = 60,
                    Margin = new Padding(0, 0, 0, 1)
                };

                Button btn = new()
                {
                    Width = 201,
                    Height = 91,
                    Padding = new Padding(30, 0, 0, 0),
                    Location = new Point(-18, -16),
                    BackColor = ColorTranslator.FromHtml("#3B3030"),
                    ForeColor = ColorTranslator.FromHtml("#F9F5EE"),
                    Text = category.Name,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Tag = category // Lưu thông tin danh mục vào thuộc tính Tag của nút
                };
                container.Controls.Add(btn);
                btn.Click += CategoryBtn_Click; // Gán sự kiện Click cho nút
                flpSideBar.Controls.Add(container); // Thêm container vào flpSideBar
            }
        }

        private void LoadProduct(string categoryId = null)
        {
            // Lấy danh sách tất cả sản phẩm hoặc theo danh mục 
            var products = string.IsNullOrEmpty(categoryId) ?
                bLL_Product.GetAll() :
                bLL_Product.GetByCategory(categoryId);

            flpProducts.Controls.Clear();
            foreach (var product in products)
            {
                var image = new Bitmap(1, 1);
                if (!string.IsNullOrEmpty(product.Image))
                {
                    var imagePath = Path.Combine(Application.StartupPath, @"..\..\..\Images\Product", product.Image);
                    if (File.Exists(imagePath))
                    {
                        using (var img = Image.FromFile(imagePath))
                        {
                            image = new Bitmap(img);
                        }
                    }
                }
                else
                {
                    // Sử dụng hình ảnh mặc định nếu không có
                    var imagePath = Path.Combine(Application.StartupPath, @"..\..\..\Images\Product", "noImage.png");
                    if (File.Exists(imagePath))
                    {
                        using (var img = Image.FromFile(imagePath))
                        {
                            image = new Bitmap(img);
                        }
                    }
                }

                Panel pnl = new()
                {
                    Width = 150,
                    Height = 243,
                    BackColor = ColorTranslator.FromHtml("#F9F5EE"),
                    Text = product.ProductName + Environment.NewLine + product.Price.ToString("C0"),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Tag = product // Lưu thông tin sản phẩm vào thuộc tính Tag của nút
                };
                PictureBox pb = new()
                {
                    Width = 150,
                    Height = 150,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = image,
                    Location = new Point(0, 0),
                    Margin = new Padding(0),
                    Tag = product // Lưu thông tin sản phẩm vào thuộc tính Tag của nút
                };
                Label name = new()
                {
                    Text = product.ProductName,
                    Location = new Point(3, 160),
                    Width = 125,
                    Height = 47,
                    AllowDrop = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Tag = product // Lưu thông tin sản phẩm vào thuộc tính Tag của nút
                };
                Label price = new()
                {
                    Text = product.Price.ToString("C0"),
                    Location = new Point(3, 210),
                    ForeColor = ColorTranslator.FromHtml("#A8222B"),
                    Width = 150,
                    Height = 25,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Tag = product // Lưu thông tin sản phẩm vào thuộc tính Tag của nút
                };
                // Thêm các thông tin vào panel
                pnl.Controls.Add(pb);
                pnl.Controls.Add(name);
                pnl.Controls.Add(price);

                pb.Click += ProductPanel_Click;
                name.Click += ProductPanel_Click;
                price.Click += ProductPanel_Click;
                pnl.Click += ProductPanel_Click;
                flpProducts.Controls.Add(pnl); // Thêm nút vào flpProducts
            }
        }

        private void CalculateTotalPrice()
        {
            if (selectedBill == null)
                return;

            // Lấy danh sách chi tiết hóa đơn
            var billInfos = bLL_BillInfo.GetByBillId(selectedBill.Id);
            if (billInfos == null || !billInfos.Any())
            {
                txtTotalPrice.Text = txtDiscount.Text = txtFinalPrice.Text = "0";
                return;
            }

            // Tính tổng tiền trước khuyến mãi
            var productIds = billInfos.Select(bi => bi.ProductId).ToList();
            var products = bLL_Product.GetAll()
                                      .Where(p => productIds.Contains(p.Id))
                                      .ToDictionary(p => p.Id, p => p);

            decimal total = 0;
            foreach (var bi in billInfos)
            {
                if (products.TryGetValue(bi.ProductId, out var product))
                    total += product.Price * bi.Quantity;
            }

            // Tính khuyến mãi (nếu có)
            decimal discount = 0;
            var promoPrograms = bLL_PromotionProgram.GetAllPromotionPrograms();

            if (promoPrograms != null && promoPrograms.Any())
            {
                foreach (var promo in promoPrograms)
                {
                    if (promo == null) continue;

                    if (promo.DiscountType == "Phần trăm")
                    {
                        decimal percent = promo.Value;
                        discount += total * (percent / 100);
                    }
                    else if (promo.DiscountType == "Tiền")
                    {
                        discount += promo.Value;
                    } // Chưa xét mua 1 tặng 1
                }
            }

            decimal dripDiscount = 0;
            if (selectedCustomer != null)
            {
                int drips = selectedCustomer.Drips; // hoặc Points, tùy tên thuộc tính

                if (drips >= 70)
                    dripDiscount = 20000;
                else if (drips >= 35)
                    dripDiscount = 10000;
                else if (drips >= 20)
                    dripDiscount = 5000;
            }

            decimal totalDiscount = discount + dripDiscount;

            // Giới hạn giảm giá không vượt quá tổng tiền
            if (totalDiscount > total)
                totalDiscount = total;

            // Tính tổng tiền sau khuyến mãi
            totalPrice = total - totalDiscount;

            txtTotalPrice.Text = total.ToString("C0");
            txtDiscount.Text = totalDiscount.ToString("C0");
            txtFinalPrice.Text = totalPrice.ToString("C0");
        }


        private void CategoryBtn_Click(object? sender, EventArgs e)
        {
            var category = (Category)((Button)sender).Tag;
            if (category == null)
                return;
            LoadProduct(category.Id);
        }

        private void ProductPanel_Click(object? sender, EventArgs e)
        {
            var product = (Product)((Control)sender).Tag;
            if (product == null)
                return;
            selectedProduct = product;
            txtProductName.Text = selectedProduct.ProductName;
            nmrProductQty.Value = 1;
        }

        private void TableBtn_Click(object? sender, EventArgs e)
        {
            var table = (Table)((Button)sender).Tag;
            if (table == null)
                return;
            selectedTable = table;
            tabMain.SelectedTab = tpOrder;
            lbTableName.Text = selectedTable.TableName;
            LoadBillInfo();
            CalculateTotalPrice();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            dgvBillInfo.MultiSelect = false;
            dgvBillInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillInfo.ReadOnly = true;

            dgvBillInfoCheckout.MultiSelect = false;
            dgvBillInfoCheckout.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBillInfoCheckout.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBillInfoCheckout.ReadOnly = true;

            LoadBtnTable();
            LoadCategory();
            LoadProduct();
            LoadBillInfo();
            RefreshInput();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            using (frmCustomerList fr = new frmCustomerList())
            {
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    selectedCustomer = fr.SelectedCustomer;
                    if (selectedCustomer != null)
                    {
                        txtCustomer.Text = selectedCustomer.CustomerName;
                        txtCustomer.Tag = selectedCustomer;
                        txtCustomerDrips.Text = selectedCustomer.Drips.ToString();
                        txtCustomerTier.Text = selectedCustomer.Tier;
                    }
                }
                fr.Dispose();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi đặt món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedCustomer == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nmrProductQty.Value <= 0)
            {
                MessageBox.Show("Số lượng món phải lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedTable == null)
            {
                MessageBox.Show("Vui lòng chọn bàn trước khi đặt món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var billId = bLL_Bill.GenerateBillId();
                var currentBill = bLL_Bill.GetAll().FirstOrDefault(b => b.TableId == selectedTable.Id && b.Status == 0);
                if (selectedTable.Status == 0) // Tạo hóa đơn mới nếu bàn trống
                {
                    Bill newBill = new()
                    {
                        Id = billId,
                        BranchId = employee.BranchId,
                        CreateDate = DateTime.Now,
                        CustomerId = selectedCustomer.Id,
                        EmployeeId = employee.Id,
                        TableId = selectedTable.Id,
                        TotalPrice = 0, 
                        Status = 0
                    };
                    bLL_Bill.Add(newBill);
                    // Cập nhật trạng thái bàn
                    selectedTable.Status = 1;
                    bLL_Table.Update(selectedTable);

                }
                else if (selectedTable.Status == 1) // Nếu đã có hóa đơn thì ko cần tạo
                {
                    if (currentBill == null)
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn hợp lệ cho bàn này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    billId = currentBill.Id;
                }

                // Kiểm tra sản phẩm đã có trong hóa đơn chưa
                var existingBillInfo = bLL_BillInfo.GetAll().FirstOrDefault(bi => bi.BillId == billId && bi.ProductId == selectedProduct.Id);
                if (existingBillInfo == null) // Nếu chưa có thì tạo billInfo mới
                {
                    Billinfo billinfo = new()
                    {
                        BillId = billId,
                        ProductId = selectedProduct.Id,
                        Quantity = (int)nmrProductQty.Value
                    };
                    bLL_BillInfo.Add(billinfo);
                }
                else // Nếu đã có sản phẩm thì cộng thêm số lượng
                {
                    existingBillInfo.Quantity += (int)nmrProductQty.Value;
                    bLL_BillInfo.Update(existingBillInfo);
                }

                LoadBillInfo();
                LoadBtnTable();
                RefreshInput();
                CalculateTotalPrice();
            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa khách hàng thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void dgvBillInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < billInfoList.Count)
            {
                var selectedRow = billInfoList[e.RowIndex];
                if (selectedRow.Product != null && selectedRow.Bill != null)
                {
                    selectedProduct = selectedRow.Product;
                    selectedBill = selectedRow.Bill;
                    txtProductName.Text = selectedProduct.ProductName;
                    nmrProductQty.Value = selectedRow.Quantity;
                }
            }
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (dgvBillInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedBill == null || selectedProduct == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn hoặc sản phẩm hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa món ăn/thức uống này khỏi hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                // Xóa sản phẩm khỏi hóa đơn
                var billInfo = bLL_BillInfo.GetAll()
                    .FirstOrDefault(bi => bi.BillId == selectedBill.Id && bi.ProductId == selectedProduct.Id);
                if (billInfo != null)
                {
                    bLL_BillInfo.Delete(billInfo.Id);
                    LoadBillInfo();
                    LoadBtnTable();
                    RefreshInput();
                    CalculateTotalPrice();
                }
            }
        }
        // Thanh toán hóa đơn
        private void btnCheckBill_Click(object sender, EventArgs e)
        {
            if (selectedBill == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Cập nhật trạng thái hóa đơn
                selectedBill.Status = 1; // Đã thanh toán
                selectedBill.CreateDate = DateTime.Now;
                selectedBill.TotalPrice = totalPrice;
                bLL_Bill.Update(selectedBill);
                // Cập nhật trạng thái bàn
                selectedTable.Status = 0; // Trống
                bLL_Table.Update(selectedTable);
                MessageBox.Show($"Thanh toán hóa đơn thành công\nThành tiền: {totalPrice}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBillInfo();
                LoadBtnTable();
                RefreshInput();
                ClearCustomer();
                
            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thanh toán hóa đơn thất bại.\nChi tiết lỗi: " + inner);

            }
        }
    }
}
