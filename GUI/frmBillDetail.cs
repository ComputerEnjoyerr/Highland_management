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
    public partial class frmBillDetail : Form
    {

        private readonly BLL_Bill bLL_Bill = new();
        private readonly BLL_BillInfo bLL_BillInfo = new();
        private readonly BLL_Product bLL_Product = new();
        private readonly BLL_Customer bLL_Customer = new();
        private readonly BLL_Employee bLL_Employee = new();

        private Bill currentBill;

        public frmBillDetail(Bill bill)
        {
            InitializeComponent();
            currentBill = bill;

        }
        private void LoadDataBillDetail()
        {
            if (currentBill == null) return;
            lbMaHoaDon.Text = currentBill.Id;
            lbThoiGian.Text = currentBill.CreateDate?.ToString("dd/MM/yyyy HH:mm") ?? "";
            string khachHang = currentBill.CustomerId != null ? bLL_Customer.GetById(currentBill.CustomerId).CustomerName : "Khách lẻ";
            lbKhachHang.Text = khachHang;
            string nhanVien = bLL_Employee.GetById(currentBill.EmployeeId).EmployeeName;
            lbNhanVien.Text = nhanVien;
            lbTongtien.Text = string.Format("{0:N0} VND", currentBill.TotalPrice);

            var billInfos = bLL_BillInfo.GetAll().Where(bi => bi.BillId == currentBill.Id).ToList();
            decimal tongGia = billInfos.Sum(bi => bi.Quantity * bi.Product.Price);
            lbTongGia.Text = string.Format("{0:N0} VND", tongGia);

            // Tính Giảm giá
            decimal giamGia = tongGia - currentBill.TotalPrice;
            lbGiamGia.Text = string.Format("{0:N0} VND", giamGia >= 0 ? giamGia : 0);
        }

        private void LoadProductsInBill(string billId)
        {
            var billInfoList = bLL_BillInfo.GetByBillId(billId);
            var billInfoData = billInfoList.Select(bi => new
            {
                ProductID = bi.ProductId,
                ProductName = bi.Product?.ProductName ?? "(Không có)",
                Quantity = bi.Quantity,
                Price = bi.Product?.Price ?? 0,
                Total = bi.Quantity * (bi.Product?.Price ?? 0)

            }).ToList();
            dataGridView1.DataSource = billInfoData;
        }
        private void frmBillDetail_Load(object sender, EventArgs e)
        {
            LoadDataBillDetail();
            LoadProductsInBill(currentBill.Id);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
