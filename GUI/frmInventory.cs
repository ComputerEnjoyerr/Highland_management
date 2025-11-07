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
    public partial class frmInventory : Form
    {
        private BLL_StockReceipt bLL_StockReceipt = new();
        private BLL_Inventory bLL_Inventory = new();
        private BLL_SupplierIngredient bLL_SupplierIngredient = new();
        private BLL_Ingredient bLL_Ingredient = new();
        private BLL_Unit bLL_Unit = new();

        private Employee selectedEmployee;
        private SupplierIngredient selectedSupplierIngredient;
        private StockReceipt selectedStockReceipt;
        private List<StockReceipt> currentStockList;
        private List<SupplierIngredient> supplierIngredientList;
        private List<Inventory> inventoryList;
        public frmInventory(Employee em)
        {
            InitializeComponent();
            selectedEmployee = em;
        }

        private void LoadInventory()
        {
            inventoryList = bLL_Inventory.GetAllByBranch(selectedEmployee.BranchId);
            var displayList = inventoryList.Select(i =>
            {
                var stockReceipts = bLL_StockReceipt.GetAll()
                    .Where(s => s.BranchId == selectedEmployee.BranchId &&
                                s.IngredientId == i.IngredientId &&
                                s.Status == 1).ToList();
                var latestReceipt = stockReceipts
                    .OrderByDescending(s => s.ReceiptDate)
                    .FirstOrDefault();
                return new
                {
                    Ingredient = i.Ingredient != null ? i.Ingredient.IngredientName : "Lỗi hiển thị",
                    CurrentQuantity = i.CurrentQuantity.ToString("0.###"),
                    Unit = i.Unit != null ? i.Unit.UnitName : "Lỗi hiển thị",
                    Supplier = latestReceipt != null && latestReceipt.Supplier != null ? latestReceipt.Supplier.Name : "Chưa có",
                    LatestExpiryDate = latestReceipt != null ? latestReceipt.ExpiryDate.ToString("dd/MM/yyyy") : "Chưa có",
                };
            }).ToList();
            dgvInventory.DataSource = displayList;
        }

        private void LoadUnit()
        {
            var unitList = bLL_Unit.GetAll();
            cboUnit1.DataSource = unitList;
            cboUnit1.DisplayMember = "UnitName";
            cboUnit1.ValueMember = "Id";

            cboUnit2.DataSource = unitList;
            cboUnit2.DisplayMember = "UnitName";
            cboUnit2.ValueMember = "Id";
        }

        private void FindStockByDate(DateOnly date = default)
        {
            currentStockList = bLL_StockReceipt.GetAll()
                .Where(s => s.BranchId == selectedEmployee.BranchId &&
                            s.Status == 1)
                .OrderByDescending(s => s.ReceiptDate)
                .ToList();
            if (date == default)
            {
                var displayList1 = currentStockList.Select(s => new
                {
                    //s.Id,
                    Ingredient = s.Ingredient != null ? s.Ingredient.IngredientName : "Lỗi hiển thị",
                    Supplier = s.Supplier != null ? s.Supplier.Name : "Lỗi hiển thị",
                    s.UnitPrice,
                    Unit = s.PurchasedUnit != null ? s.PurchasedUnit.UnitName : "Lỗi hiển thị",
                    s.Quantity,
                    s.ExpiryDate,
                    s.ReceiptDate,
                })
                .ToList();
                dgvStockHistory.DataSource = displayList1;
                return;
            }
            var filteredList = currentStockList
                .Where(s => s.ReceiptDate == date)
                .ToList();
            var displayList = filteredList.Select(s => new
            {
                //s.Id,
                Ingredient = s.Ingredient != null ? s.Ingredient.IngredientName : "Lỗi hiển thị",
                Supplier = s.Supplier != null ? s.Supplier.Name : "Lỗi hiển thị",
                s.UnitPrice,
                Unit = s.PurchasedUnit != null ? s.PurchasedUnit.UnitName : "Lỗi hiển thị",
                s.Quantity,
                //CreatedBy = s.CreatedByNavigation != null ? s.CreatedByNavigation.EmployeeName : "Lỗi hiển thị",
                s.ExpiryDate,
            }).ToList();
            dgvStockHistory.DataSource = displayList;
        }

        private void LoadStock()
        {

            currentStockList = bLL_StockReceipt.GetAll()
                .Where(s => s.BranchId == selectedEmployee.BranchId &&
                            s.Status == 0).ToList();
            var displayList = currentStockList.Select(s => new
            {
                //s.Id,
                Ingredient = s.Ingredient != null ? s.Ingredient.IngredientName : "Lỗi hiển thị",
                Supplier = s.Supplier != null ? s.Supplier.Name : "Lỗi hiển thị",
                s.UnitPrice,
                Unit = s.PurchasedUnit != null ? s.PurchasedUnit.UnitName : "Lỗi hiển thị",
                s.Quantity,
                //CreatedBy = s.CreatedByNavigation != null ? s.CreatedByNavigation.EmployeeName : "Lỗi hiển thị",
                s.ExpiryDate,
            }).ToList();

            foreach (var item in displayList)
            {
                if (item.ExpiryDate < DateOnly.FromDateTime(DateTime.Now))
                {
                    MessageBox.Show($"Nguyên liệu {item.Ingredient} từ nhà cung cấp {item.Supplier} đã hết hạn sử dụng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            dgvStockReceipt.DataSource = displayList;
        }

        private void LoadSupplierIngredient(string keyword = "")
        {
            var filteredList = bLL_SupplierIngredient.GetAll()
                .Where(i => i.Ingredient != null &&
                            i.Ingredient.IngredientName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            i.Supplier != null &&
                            i.Supplier.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            supplierIngredientList = filteredList;

            var displayList = supplierIngredientList.Select(i => new
            {
                Supplier = i.Supplier != null ? i.Supplier.Name : "Lỗi hiển thị",
                Ingredient = i.Ingredient != null ? i.Ingredient.IngredientName : "Lỗi hiển thị",
                UnitPrice = i.UnitPrice.ToString("C0"),
                StandardUnit = i.StandardUnit != null ? i.StandardUnit.UnitName : "Lỗi hiển thị",
                i.ProducedDate,
            }).ToList();
            dgvSupplierIngredient.DataSource = displayList;
        }

        private void CalculateTotalPrice() // Tính tổng giá tiền dựa trên số lượng và giá đơn vị
        {
            if (selectedSupplierIngredient != null)
            {
                decimal quantity = nmrQty.Value;
                decimal unitPrice = selectedSupplierIngredient.UnitPrice;
                decimal totalPrice = quantity * unitPrice;
                txtPrice.Text = totalPrice.ToString("C0");
            }
            if (selectedStockReceipt != null)
            {
                decimal quantity = nmrQty.Value;
                decimal unitPrice = selectedStockReceipt.UnitPrice;
                decimal totalPrice = quantity * unitPrice;
                txtPrice.Text = totalPrice.ToString("C0");
            }
        }

        private void CalculateFinalPrice()
        {
            // Tính tổng giá tiền dựa trên số lượng và giá đơn vị của danh sách phiếu nhập

            decimal finalPrice = 0;
            foreach (var stock in currentStockList)
            {
                //MessageBox.Show($"Cộng thêm : {stock.TotalPrice}");
                finalPrice += stock.TotalPrice;
            }
            // Hiển thị tổng giá tiền
            txtFinalPrice.Text = finalPrice.ToString("C0");
        }

        private void RefreshInput1()
        {
            // Đặt lại null cho các biến được chọn
            selectedStockReceipt = null;
            selectedSupplierIngredient = null;
            txtStockId.Clear();
            txtIngreId1.Clear();
            txtIngreName1.Clear();
            txtSupplierName1.Clear();
            txtExpiryDay.Clear();
            txtPrice.Clear();
            txtProducedDate.Clear();
            txtExpiryDate.Clear();
            nmrQty.Value = 1;
            cboUnit1.SelectedIndex = 0;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStockReceiptInfo fr = new frmStockReceiptInfo();
            fr.ShowDialog();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgvSupplierIngredient.MultiSelect = false;
            dgvSupplierIngredient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupplierIngredient.ReadOnly = true;
            dgvSupplierIngredient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvStockReceipt.MultiSelect = false;
            dgvStockReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockReceipt.ReadOnly = true;
            dgvStockReceipt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvInventory.MultiSelect = false;
            dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventory.ReadOnly = true;
            dgvInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvStockHistory.MultiSelect = false;
            dgvStockHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockHistory.ReadOnly = true;
            dgvStockHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            cboUnit1.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnit2.DropDownStyle = ComboBoxStyle.DropDownList;

            nmrQty.Maximum = decimal.MaxValue;
            nmrQty.Value = 1;
            nmrQty.Minimum = 1;

            LoadStock();
            LoadUnit();
            LoadSupplierIngredient();
            CalculateFinalPrice();
            LoadInventory();
            FindStockByDate();
        }

        private void dgvSupplierIngredient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < supplierIngredientList.Count)
            {
                var selectedRow = supplierIngredientList[e.RowIndex];
                txtStockId.Text = "";
                selectedStockReceipt = null;
                if (selectedRow != null)
                {
                    selectedSupplierIngredient = selectedRow;
                    txtIngreId1.Text = selectedRow.IngredientId;
                    txtIngreName1.Text = selectedRow.Ingredient != null ? selectedRow.Ingredient.IngredientName : "";
                    txtSupplierName1.Text = selectedRow.Supplier != null ? selectedRow.Supplier.Name : "";
                    txtExpiryDay.Text = selectedRow.ExpiryDay.ToString();
                    txtPrice.Text = selectedRow.UnitPrice.ToString("C0");
                    txtProducedDate.Text = selectedRow.ProducedDate != null ? selectedRow.ProducedDate.Value.ToString("dd/MM/yyyy") : "";
                    txtExpiryDate.Text = selectedRow.ProducedDate != null ? selectedRow.ProducedDate.Value.AddDays(selectedRow.ExpiryDay ?? 0).ToString("dd/MM/yyyy") : "";
                    var unit = selectedRow.StandardUnit != null ? selectedRow.StandardUnit.UnitName : "";
                    cboUnit1.SelectedIndex = cboUnit1.FindStringExact(unit);
                    CalculateTotalPrice();
                }
            }
        }

        private void nmrQty_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void btnAddIngreToStock_Click(object sender, EventArgs e)
        {
            if (selectedSupplierIngredient == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu từ danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (selectedEmployee == null)
            {
                MessageBox.Show("Không tìm thấy thông tin nhân viên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(cboUnit1.SelectedValue.ToString(), out int purchasedUnitId))
            {
                MessageBox.Show("Vui lòng chọn đơn vị hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int quantity = (int)nmrQty.Value;
                decimal unitPrice = selectedSupplierIngredient.UnitPrice;
                decimal totalPrice = quantity * unitPrice;

                // Thêm nguyên liệu vào kho
                var stockItem = new StockReceipt
                {
                    Id = bLL_StockReceipt.GenerateNewId(),
                    BranchId = selectedEmployee.BranchId,
                    IngredientId = selectedSupplierIngredient.IngredientId,
                    SupplierId = selectedSupplierIngredient.SupplierId,
                    CreatedBy = selectedEmployee.Id,
                    PurchasedUnitId = purchasedUnitId,
                    UnitPrice = unitPrice,
                    Quantity = quantity,
                    TotalPrice = totalPrice,
                    ReceiptDate = DateOnly.FromDateTime(DateTime.Now),
                    // Ngày hết hạn bằng ngày sản xuất + số ngày hạn sử dụng + 1
                    ExpiryDate = selectedSupplierIngredient.ProducedDate != null ?
                                 selectedSupplierIngredient.ProducedDate.Value.AddDays(selectedSupplierIngredient.ExpiryDay ?? 0) :
                                 DateOnly.FromDateTime(DateTime.Now),
                    Status = 0,
                };
                bLL_StockReceipt.Add(stockItem);
                LoadStock();
                RefreshInput1();
                CalculateFinalPrice();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm công thức thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void dgvStockReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < currentStockList.Count)
            {
                var selectedRow = currentStockList[e.RowIndex];
                selectedSupplierIngredient = null;
                if (selectedRow != null)
                {
                    selectedStockReceipt = selectedRow;
                    txtStockId.Text = selectedRow.Id;
                    txtIngreId1.Text = selectedRow.IngredientId;
                    txtIngreName1.Text = selectedRow.Ingredient != null ? selectedRow.Ingredient.IngredientName : "";
                    txtSupplierName1.Text = selectedRow.Supplier != null ? selectedRow.Supplier.Name : "";
                    txtExpiryDate.Text = selectedRow.ExpiryDate.ToString("dd/MM/yyyy");
                    nmrQty.Value = selectedRow.Quantity;
                    txtPrice.Text = selectedRow.TotalPrice.ToString("C0");
                    //// Số ngày hạn sử dụng tính bằng ngày hết hạn - ngày nhập + 1
                    //txtExpiryDay.Text = (selectedRow.ExpiryDate.ToDateTime(new TimeOnly()) - selectedRow.ReceiptDate.ToDateTime(new TimeOnly()).AddDays(-1)).Days.ToString();
                    //// Ngày sản xuất tính bằng ngày hết hạn - số ngày hạn sử dụng
                    //txtProducedDate.Text = selectedRow.ExpiryDate.ToDateTime(new TimeOnly()).AddDays( - int.Parse(txtExpiryDay.Text)).ToString("dd/MM/yyyy");
                    var unit = selectedRow.PurchasedUnit != null ? selectedRow.PurchasedUnit.UnitName : "";
                    cboUnit1.SelectedIndex = cboUnit1.FindStringExact(unit);

                    CalculateTotalPrice();
                }
            }
        }

        private void btnUpdateIngreToStock_Click(object sender, EventArgs e)
        {
            if (selectedStockReceipt == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu từ danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn lưu thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                int quantity = (int)nmrQty.Value;
                decimal unitPrice = selectedStockReceipt.UnitPrice;
                decimal totalPrice = quantity * unitPrice;

                selectedStockReceipt.Quantity = quantity;
                selectedStockReceipt.TotalPrice = totalPrice;

                bLL_StockReceipt.Update(selectedStockReceipt);
                LoadStock();
                RefreshInput1();
                CalculateFinalPrice();

            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm công thức thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            if (selectedStockReceipt == null)
            {
                MessageBox.Show("Vui lòng chọn nguyên liệu từ danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa nguyên liệu này khỏi phiếu nhập?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;
            try
            {
                bLL_StockReceipt.Delete(selectedStockReceipt.Id);
                LoadStock();
                RefreshInput1();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm công thức thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnCheckoutReceipt_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thanh toán phiếu nhập này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;

            try
            {
                // Cập nhật trạng thái của tất cả nguyên liệu trong phiếu nhập
                var stockReceiptsToCheckout = currentStockList
                    .Where(s => s.Status == 0 &&
                                s.BranchId == selectedEmployee.BranchId).ToList();
                foreach (var stockReceipt in stockReceiptsToCheckout)
                {
                    stockReceipt.Status = 1;
                    bLL_StockReceipt.Update(stockReceipt);

                    // Kiểm tra xem nguyên liệu đã tồn tại trong kho chưa
                    var inventoryItem = bLL_Inventory.GetAllByBranch(selectedEmployee.BranchId)
                        .FirstOrDefault(i => i.BranchId == selectedEmployee.BranchId &&
                                             i.IngredientId == stockReceipt.IngredientId);
                    // Nếu tồn tại thì cập nhật
                    if (inventoryItem != null)
                    {
                        inventoryItem.CurrentQuantity += stockReceipt.Quantity;
                        bLL_Inventory.Update(inventoryItem);
                    }
                    else // Nếu chưa tồn tại thì thêm mới
                    {
                        var newInventoryItem = new Inventory
                        {
                            BranchId = stockReceipt.BranchId,
                            IngredientId = stockReceipt.IngredientId,
                            UnitId = stockReceipt.PurchasedUnitId,
                            CurrentQuantity = stockReceipt.Quantity,
                        };
                        bLL_Inventory.Add(newInventoryItem);
                    }
                }
                LoadStock();
                RefreshInput1();
                LoadInventory();
                CalculateFinalPrice();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thanh toán phiếu nhập thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void dtpFindStockByDate_ValueChanged(object sender, EventArgs e)
        {
            // Lọc danh sách phiếu nhập theo ngày
            var selectedDate = DateOnly.FromDateTime(dtpFindStockByDate.Value.Date);
            FindStockByDate(selectedDate);
        }

        private void dgvInventory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < inventoryList.Count)
            {
                var selectedRow = inventoryList[e.RowIndex];
                if (selectedRow != null)
                {
                    txtIngreId2.Text = selectedRow.IngredientId;
                    txtIngreName2.Text = selectedRow.Ingredient != null ? selectedRow.Ingredient.IngredientName : "";
                    txtInvQty.Text = selectedRow.CurrentQuantity.ToString();
                    var unit = selectedRow.Unit != null ? selectedRow.Unit.UnitName : "";
                    cboUnit2.SelectedIndex = cboUnit2.FindStringExact(unit);
                    var stockReceipts = bLL_StockReceipt.GetAll()
                    .Where(s => s.BranchId == selectedEmployee.BranchId &&
                                s.IngredientId == selectedRow.IngredientId &&
                                s.Status == 1).ToList();
                    var latestReceipt = stockReceipts
                        .OrderByDescending(s => s.ReceiptDate)
                        .FirstOrDefault();
                    txtSupplierName2.Text = latestReceipt != null && latestReceipt.Supplier != null ? latestReceipt.Supplier.Name : "";
                    dtpExpiryDate.Text = latestReceipt != null ? latestReceipt.ExpiryDate.ToString("dd/MM/yyyy") : "";
                }
            }
        }
    }
}
