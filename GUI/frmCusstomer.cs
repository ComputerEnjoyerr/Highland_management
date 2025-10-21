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
    public partial class frmCusstomer : Form
    {
        private readonly BLL_Customer bLL_Customer = new();

        public frmCusstomer()
        {
            InitializeComponent();
        }

        private void LoadProduct()
        {
            dgvCustomer.MultiSelect = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ReadOnly = true;
            var displayList = bLL_Customer.GetAll()
                .Select(c => new
                {
                    c.Id,
                    c.CustomerName,
                    c.Point,
                    c.Drips,
                    c.Tier,
                    c.Phone,
                    c.Email,
                }).ToList();
            dgvCustomer.DataSource = displayList;
        }

        private void LoadCboTier()
        {
            cboTier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTier.Items.Add("Member");
            cboTier.Items.Add("Phin Bạc");
            cboTier.SelectedIndex = 0;
        }

        public bool ValidateInput(Customer customer)
        {
            var context = new ValidationContext(customer);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(customer, context, results);
            if (!isValid)
            {
                MessageBox.Show(results.First().ErrorMessage, "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtPoint.Text, out var point))
                {
                    MessageBox.Show("Điểm không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (!int.TryParse(txtPoint.Text, out var drips))
                {
                    MessageBox.Show("Drips không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboTier.SelectedIndex == -1)
                {
                    MessageBox.Show("Không thể tìm thấy thông tin hạng", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                var customer = new Customer
                {
                    // Id = 
                    CustomerName = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Point = point,
                    Drips = drips,
                    Tier = cboTier.SelectedItem.ToString()
                };
                if (!ValidateInput(customer)) return;
                bLL_Customer.Add(customer);
                LoadProduct();

            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm khách hàng thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void frmCusstomer_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCboTier();
            txtPoint.Text = "0";
            txtDrips.Text = "0";
        }

        private void cboTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTier.SelectedItem?.ToString() == "Phin Bạc")
            {
                txtPoint.Text = "700";
            }
        }
    }
}
