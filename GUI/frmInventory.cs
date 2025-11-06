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

namespace GUI
{
    public partial class frmInventory : Form
    {
        private BLL_StockReceipt bLL_StockReceipt = new();
        private BLL_Inventory bLL_Inventory = new();
        private BLL_SupplierIngredient bLL_SupplierIngredient = new();
        private BLL_Ingredient bLL_Ingredient = new();

        private Employee selectedEmployee;
        private List<StockReceipt> currentStockList;
        private List<SupplierIngredient> supplierIngredientList;
        public frmInventory(Employee em)
        {
            InitializeComponent();
            selectedEmployee = em;
        }

        private void LoadStock()
        {
            currentStockList = bLL_StockReceipt.GetAll()
                .Where(s => s.BranchId == selectedEmployee.BranchId &&
                            s.Status == 0).ToList();
            var displayList = currentStockList.Select(s => new
            {
                s.Id,
                Ingredient = s.Ingredient != null ? s.Ingredient.IngredientName : "Lỗi hiển thị",
                Supplier = s.Supplier != null ? s.Supplier.Name : "Lỗi hiển thị",
                s.UnitPrice,
                PurchasedUnit = s.PurchasedUnit != null ? s.PurchasedUnit.UnitName : "Lỗi hiển thị",
                s.Quantity,
                CreatedBy = s.CreatedByNavigation != null ? s.CreatedByNavigation.EmployeeName : "Lỗi hiển thị"
            }).ToList();

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
                i.UnitPrice,
                StandardUnit = i.StandardUnit != null ? i.StandardUnit.UnitName : "Lỗi hiển thị",
                i.ProducedDate,
            }).ToList();
            dgvSupplierIngredient.DataSource = displayList;
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

            LoadStock();
            LoadSupplierIngredient();
        }
    }
}
