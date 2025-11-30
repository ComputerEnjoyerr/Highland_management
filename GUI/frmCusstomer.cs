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
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class frmCusstomer : Form
    {
        private readonly BLL_Customer bLL_Customer = new();
        private List<Customer> customerList = new();
        public frmCusstomer()
        {
            InitializeComponent();
        }

        private void LoadCustomer(string keyword = "")
        {
            // Lọc dữ liệu khách nếu có
            var filterdList = bLL_Customer.GetAll()
                .Where(c => c.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            c.Tier.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            customerList = filterdList; // Gán vào biến lưu trữ

            // Hiển thị ra dgv
            var displayList = customerList
                .Select(c => new
                {
                    c.Id,
                    c.CustomerName,
                    c.Phone,
                    c.Email,
                    c.Drips,
                    c.Tier,
                    c.Gender,
                    c.DateOfBirth
                }).ToList();
            dgvCustomer.DataSource = displayList;
        }

        private void RefreshInput()
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            nmrDrips.Value = 0;
            nmrPoint.Value = 0;
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
                var customer = new Customer
                {
                    Id = bLL_Customer.GenerateId(txtPhone.Text),
                    CustomerName = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Point = nmrPoint.Value,
                    Drips = (int)nmrDrips.Value,
                    Gender = cboGender.SelectedItem.ToString(),
                    DateOfBirth = DateOnly.FromDateTime(dtpDOB.Value),
                    Tier = cboTier.SelectedItem.ToString()
                };
                if (!ValidateInput(customer)) return;
                bLL_Customer.Add(customer);
                LoadCustomer();
                RefreshInput();
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
            LoadCustomer();

            // ===== Cài đặt trạng thái hiển thị =====

            dgvCustomer.MultiSelect = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ReadOnly = true;

            // cbo Hạng
            cboTier.Items.Add("Member");
            cboTier.Items.Add("Phin Bạc");
            cboTier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTier.SelectedIndex = 0;

            // cbo Giới tính
            cboGender.Items.Add("Nam");
            cboGender.Items.Add("Nữ");
            cboGender.Items.Add("Khác");
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.SelectedIndex = 0;

            // ========================================


        }

        private void cboTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTier.SelectedItem?.ToString() == "Phin Bạc")
                nmrPoint.Text = "700";
            else
                nmrPoint.Text = "0";
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customerList.Count)
            {
                var selectedRow = customerList[e.RowIndex];
                txtId.Text = selectedRow.Id;
                txtName.Text = selectedRow.CustomerName;
                txtPhone.Text = selectedRow.Phone;
                txtEmail.Text = selectedRow.Email;

                nmrDrips.Value = decimal.Parse(selectedRow.Drips.ToString());
                nmrPoint.Value = selectedRow.Point;

                var tier = selectedRow.Tier;
                cboTier.SelectedIndex = cboTier.FindStringExact(tier);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu khách hàng này không?\nNếu xóa khách hàng này sẽ biết mất hoàn toàn", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
            try
            {
                bLL_Customer.Delete(txtId.Text);
                LoadCustomer();
                RefreshInput();
            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa khách hàng thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật dữ liệu khách hàng này không?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
            try
            {
                var customer = new Customer
                {
                    Id = txtId.Text,
                    CustomerName = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Point = nmrPoint.Value,
                    Drips = (int)nmrDrips.Value,
                    Gender = cboGender.SelectedItem.ToString(),
                    DateOfBirth = DateOnly.FromDateTime(dtpDOB.Value),
                    Tier = cboTier.SelectedItem.ToString()
                };
                bLL_Customer.Update(customer);
                LoadCustomer();
                RefreshInput();

            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật khách hàng thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RefreshInput();
        }

        // Biến để theo dõi thao tác nhập liệu
        private CancellationTokenSource _cts = new();
        private async void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindCustomer.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadCustomer(txtFindCustomer.Text);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private void nmrPoint_ValueChanged(object sender, EventArgs e)
        {
            decimal value = nmrPoint.Value;
            if (value >= 700)
                cboTier.SelectedIndex = 1;
            else
                cboTier.SelectedIndex = 0;
        }
    }
}
