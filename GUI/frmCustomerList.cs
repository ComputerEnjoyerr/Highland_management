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
        private BLL_Customer BLL_Customer = new BLL_Customer();
        private List<Customer> customers = new List<Customer>();

        public frmCustomerList()
        {
            InitializeComponent();
        }
        private void LoadCustomer(string keyword = "")
        {
            // Hiển thị các btn Khách hàng
            var filteredList = BLL_Customer.GetAll()
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
    }
}
