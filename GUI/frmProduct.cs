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
    public partial class frmProduct : Form
    {
        private readonly BLL_Product bLL_Product = new();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void LoadProduct()
        {
            var displayList = bLL_Product.GetAll().Select(p => new
            {
                p.Id,
                p.ProductName,
                p.Price,
                p.Image,
                CategoryName = p.Category != null ? p.Category.Name : "Không có danh mục"
            }).ToList();
            dgvProduct.DataSource = displayList;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    MessageBox.Show("Vui lòng nhập giá bán và giờ làm thêm hợp lệ.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtProductName1.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm");
                    return;
                }
                DateTime dateTime = DateTime.Now;
                Product product = new Product
                {
                    Id = $"PD{dateTime:yyMMddHHmmss}",
                    ProductName = txtProductName1.Text,
                    CategoryId = "CA001",
                    Price = price
                };
                bLL_Product.Add(product);
                LoadProduct();
            } catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm sản phẩm thất bại.\nChi tiết lỗi: " + inner);
            }
        }
    }
}
