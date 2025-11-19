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
    public partial class frmIngredientDetail : Form
    {
        private readonly BLL_StockReceipt bLL_StockReceipt = new();
        private readonly BLL_Ingredient bLL_Ingredient = new();
        private readonly BLL_Supplier bLL_Supplier = new();
        private string ingredientId;
        private int selectedMonth;
        private int selectedYear;
        public frmIngredientDetail(string ingredientId, int selectedMonth, int selectedYear)
        {
            InitializeComponent();
            this.ingredientId = ingredientId;
            this.selectedMonth = selectedMonth;
            this.selectedYear = selectedYear;
        }

        private void LoadDataIngredientDetail()
        {
            if (string.IsNullOrEmpty(ingredientId)) return;

            var ingredient = bLL_Ingredient.GetById(ingredientId);
            if (ingredient == null)
            {
                lbTen.Text = "Không xác định";
                lbTongNhap.Text = "0 kg";
                lbDonGia.Text = "0 vnd/kg";
                lbTongTien.Text = "0 vnd";
                richTextBox1.Text = "Không có lịch sử";               
                return;
            }

            lbTen.Text = ingredient.IngredientName ?? "Không xác định";

            var receipts = bLL_StockReceipt.GetAll()
                .Where(r => r.IngredientId == ingredientId &&
                           r.ReceiptDate.Month == selectedMonth &&
                           r.ReceiptDate.Year == selectedYear)
                .ToList();

            if (receipts.Any())
            {
                decimal tongNhap = receipts.Sum(r => r.Quantity);
                lbTongNhap.Text = $"{tongNhap} kg";

                decimal donGiaTrungBinh = receipts.Average(r => r.UnitPrice);
                lbDonGia.Text = $"{donGiaTrungBinh:N0} vnd/kg";

                decimal tongTien = receipts.Sum(r => r.Quantity * r.UnitPrice);
                lbTongTien.Text = $"{tongTien:N0} vnd";

                // Xây dựng lịch sử nhập hàng
                var lichSu = receipts.Select(r => $"{r.ReceiptDate:dd/MM}: {r.Quantity}kg - {r.UnitPrice:N0} vnd/kg - {r.Quantity * r.UnitPrice:N0} vnd")
                                   .Aggregate((a, b) => a + Environment.NewLine + b);
                richTextBox1.Text = string.IsNullOrEmpty(lichSu) ? "Không có lịch sử" : lichSu;
            }
            else
            {
                lbTongNhap.Text = "0 kg";
                lbDonGia.Text = "0 vnd/kg";
                lbTongTien.Text = "0 vnd";
            }
        }

        private void LoadSupplierDetail()
        {
            if (string.IsNullOrEmpty(ingredientId)) return;

            // Lấy danh sách phiếu nhập kho cho ingredientId và tháng/năm hiện tại
            var receipts = bLL_StockReceipt.GetAll()
                .Where(r => r.IngredientId == ingredientId &&
                           r.ReceiptDate.Month == selectedMonth &&
                           r.ReceiptDate.Year == selectedYear)
                .ToList();

            if (!receipts.Any())
            {
                dataGridView1.DataSource = null; // Xóa dữ liệu nếu không có phiếu nhập
                return;
            }

            // Lấy danh sách SupplierId từ các phiếu nhập
            var supplierIds = receipts.Select(r => r.SupplierId).Distinct().ToList();

            // Lấy thông tin nhà cung cấp dựa trên SupplierId
            var suppliers = bLL_Supplier.GetAllSuppliers()
                .Where(s => supplierIds.Contains(s.Id))
                .Select(s => new
                {
                    s.Id,
                    s.Name,
                    s.Phone,
                    s.Email,
                    Address = s.Address != null ? s.Address.Name : "Không có địa chỉ",
                    Ward = s.Address?.Ward != null ? s.Address.Ward.WardName : "Không xác định",
                    Province = s.Address?.Ward?.Province != null ? s.Address.Ward.Province.ProvinceName : "Không xác định"
                })
                .ToList();

            dataGridView1.DataSource = suppliers;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmIngredientDetail_Load(object sender, EventArgs e)
        {
            LoadDataIngredientDetail();
            LoadSupplierDetail();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
