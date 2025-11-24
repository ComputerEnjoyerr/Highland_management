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
    public partial class frmCustomerList : Form
    {
        public Customer SelectedCustomer = new Customer();
        private BLL_Customer bLL_Customer = new BLL_Customer();
        private List<Customer> customers = new List<Customer>();
        private Customer unknowCustomer = new Customer
        {
            Id = "UKNOWNGUEST-001",
            CustomerName = "Khách vãng lai",
            Phone = "0901234567",
            Email = "unknown@example.com",
            Gender = "Nam",
            DateOfBirth = DateOnly.FromDateTime(DateTime.UtcNow),
            Point = 0,
            Drips = 0,
            Tier = "Member"
        };
        public frmCustomerList()
        {
            InitializeComponent();
        }
        private void LoadCustomer(string keyword = "")
        {
            // Hiển thị các btn Khách hàng
            var filteredList = bLL_Customer.GetAll()
                .Where(c => c.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            c.Tier != null && c.Tier.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            c.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                            c.Email.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            customers = filteredList;

            var displayList = customers
                .Select(c => new
                {
                    //c.Id,
                    c.CustomerName,
                    c.Phone,
                    c.Email,
                    c.Point,
                    c.Drips,
                    c.Tier,
                }).ToList();

            dgvCustomer.DataSource = displayList;
        }
        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            dgvCustomer.MultiSelect = false;
            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomer.ReadOnly = true;

            LoadCustomer();
        }

        private void dgvCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < customers.Count)
            {
                SelectedCustomer = customers[e.RowIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private CancellationTokenSource _cts = new();
        private async void txtFindCustomer_TextChanged(object sender, EventArgs e)
        {
            string input = txtFindCustomer.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadCustomer(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                // Nếu chưa có khách hàng nào được chọn thì chọn khách vãng lai
                if (customers.FirstOrDefault(c => c.Id == unknowCustomer.Id) == null)
                {
                    bLL_Customer.Add(unknowCustomer);
                    SelectedCustomer = unknowCustomer;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                } else
                {
                    var existingCustomer = bLL_Customer.GetById(unknowCustomer.Id);
                    if (existingCustomer != null)
                    {
                        SelectedCustomer = existingCustomer;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Chọn khách vãng lai thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }
    }
}
