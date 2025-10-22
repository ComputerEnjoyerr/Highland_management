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

namespace GUI
{
    public partial class frmCusstomer : Form
    {
        private readonly BLL_Customer bLL_Customer = new();

        public frmCusstomer()
        {
            InitializeComponent();
        }

        private void LoadProduct(string keyword = null)
        {
            dgvCustomer.MultiSelect = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ReadOnly = true;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var filterdList = bLL_Customer.GetAll()
                    .Where(c => c.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                c.Tier.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
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
                dgvCustomer.DataSource = filterdList;
                return;
            }

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
                if (txtName.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập họ tên", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPhone.Text.Length < 8)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                var existingPhone = bLL_Customer.GetByPhone(txtPhone.Text);
                if (existingPhone != null)
                {
                    MessageBox.Show("Số điện thoại đã trùng với 1 khách hàng khác", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (txtEmail.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập Email", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (nmrDrips.Value <= -1)
                {
                    MessageBox.Show("Drips không được là số âm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (nmrPoint.Value <= -1)
                {
                    MessageBox.Show("Điểm không được là số âm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboTier.SelectedIndex == -1)
                {
                    MessageBox.Show("Không thể tìm thấy thông tin hạng", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                var customer = new Customer
                {
                    Id = bLL_Customer.GenerateId(txtPhone.Text),
                    CustomerName = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Point = nmrPoint.Value,
                    Drips = (int)nmrDrips.Value,
                    Tier = cboTier.SelectedItem.ToString()
                };
                if (!ValidateInput(customer)) return;
                bLL_Customer.Add(customer);
                LoadProduct();
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
            LoadProduct();
            LoadCboTier();
        }

        private void cboTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTier.SelectedItem?.ToString() == "Phin Bạc")
            {
                nmrPoint.Text = "700";
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvCustomer.Rows[e.RowIndex];
                txtId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtName.Text = selectedRow.Cells["CustomerName"].Value.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
                txtEmail.Text = selectedRow.Cells["Email"].Value.ToString();

                nmrDrips.Value = decimal.Parse(selectedRow.Cells["Drips"].Value.ToString());
                nmrPoint.Value = decimal.Parse(selectedRow.Cells["Point"].Value.ToString());

                var tier = selectedRow.Cells["Tier"].Value.ToString();
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
                LoadProduct();
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
            if (txtId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật dữ liệu khách hàng này không?", "Lưu ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == rs)
                return;
            try
            {
                if (txtName.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập họ tên", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (txtPhone.Text.Length < 8)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                var existingPhone = bLL_Customer.GetByPhone(txtPhone.Text, txtId.Text);
                if (existingPhone != null)
                {
                    MessageBox.Show("Số điện thoại đã trùng với 1 khách hàng khác", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (txtEmail.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Vui lòng nhập Email", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (nmrDrips.Value <= -1)
                {
                    MessageBox.Show("Drips không được là số âm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (nmrPoint.Value <= -1)
                {
                    MessageBox.Show("Điểm không được là số âm", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                if (cboTier.SelectedIndex == -1)
                {
                    MessageBox.Show("Không thể tìm thấy thông tin hạng", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }

                var customer = new Customer
                {
                    Id = txtId.Text,
                    CustomerName = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    Point = nmrPoint.Value,
                    Drips = (int)nmrDrips.Value,
                    Tier = cboTier.SelectedItem.ToString()
                };
                bLL_Customer.Update(customer);
                LoadProduct();
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
                LoadProduct(txtFindCustomer.Text);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }
    }
}
