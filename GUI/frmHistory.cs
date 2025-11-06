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
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }
        private readonly BLL_Bill bLL_Bill = new BLL_Bill();
        private readonly BLL_BillInfo bLL_BillInfo = new BLL_BillInfo();
        private readonly BLL_Customer bLL_Customer = new BLL_Customer();
        private readonly BLL_Employee bLL_Employee = new BLL_Employee();

        private Customer selectedCustomer; // Khách hàng đang chọn
        private Employee selectedEmployee; // Nhân viên đang chọn
        private void LoadHistoryBill()
        {
            var billList = bLL_Bill.GetAll();
            var historyData = billList.Select(bill => new
            {
                BillID = bill.Id,
                CustomerName = bill.CustomerId != null ? bLL_Customer.GetById(bill.CustomerId)?.CustomerName : "Khách lẻ",
                EmployeeName = bLL_Employee.GetById(bill.EmployeeId)?.EmployeeName,
                BillDate = bill.CreateDate,
                TotalPrice = bill.TotalPrice
            }).ToList();
            dgvHistoryBill.DataSource = historyData;
        }

        //load danh sách hóa đơn theo khách hàng
        private void LoadHistoryBillByCustomer(string customerId)
        {
            var billList = bLL_Bill.GetAll()
                                   .Where(b => b.CustomerId == customerId)
                                   .ToList();

            if (billList.Count == 0)
            {
                MessageBox.Show("Khách hàng này chưa có hóa đơn nào.");
                dgvHistoryBill.DataSource = null;
                return;
            }

            var historyData = billList.Select(bill => new
            {
                BillID = bill.Id,
                CustomerName = bLL_Customer.GetById(bill.CustomerId)?.CustomerName ?? "Khách lẻ",
                EmployeeName = bLL_Employee.GetById(bill.EmployeeId)?.EmployeeName,
                BillDate = bill.CreateDate,
                TotalPrice = bill.TotalPrice
            }).ToList();

            dgvHistoryBill.DataSource = historyData;
            dgvHistoryBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //frmCustomerList fr = new frmCustomerList();
            //fr.ShowDialog();
            using (frmCustomerList fr = new frmCustomerList())
            {
                if (fr.ShowDialog() == DialogResult.OK)
                {
                    selectedCustomer = fr.SelectedCustomer;

                    if (selectedCustomer != null)
                    {
                        txtFindCustomer.Text = selectedCustomer.CustomerName;

                        LoadHistoryBillByCustomer(selectedCustomer.Id);

                        FilterBills();
                    }
                }
            }
        }

        //load danh sách hóa đơn theo nhân viên
        private void LoadHistoryBillByEmployee(string employeeId)
        {
            var billList = bLL_Bill.GetAll()
                                   .Where(b => b.EmployeeId == employeeId)
                                   .ToList();

            if (billList.Count == 0)
            {
                MessageBox.Show("Nhân viên này chưa có hóa đơn nào.");
                dgvHistoryBill.DataSource = null;
                return;
            }

            var historyData = billList.Select(bill => new
            {
                BillID = bill.Id,
                CustomerName = bLL_Customer.GetById(bill.CustomerId)?.CustomerName ?? "Khách lẻ",
                EmployeeName = bLL_Employee.GetById(bill.EmployeeId)?.EmployeeName,
                BillDate = bill.CreateDate,
                TotalPrice = bill.TotalPrice
            }).ToList();

            dgvHistoryBill.DataSource = historyData;
            dgvHistoryBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        //chọn nhân viên va khach hang
        private void FilterBills()
        {
            var bills = bLL_Bill.GetAll();

            if (selectedCustomer != null)
                bills = bills.Where(b => b.CustomerId == selectedCustomer.Id).ToList();

            if (selectedEmployee != null)
                bills = bills.Where(b => b.EmployeeId == selectedEmployee.Id).ToList();

            var historyData = bills.Select(bill => new
            {
                BillID = bill.Id,
                CustomerName = bill.CustomerId != null ? bLL_Customer.GetById(bill.CustomerId)?.CustomerName : "Khách lẻ",
                EmployeeName = bLL_Employee.GetById(bill.EmployeeId)?.EmployeeName,
                BillDate = bill.CreateDate,
                TotalPrice = bill.TotalPrice
            }).ToList();

            dgvHistoryBill.DataSource = historyData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmCustomerList fr = new frmCustomerList();
            //fr.ShowDialog();
            using (frmEmployeeList frm = new frmEmployeeList())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    selectedEmployee = frm.SelectedEmployee;

                    if (selectedEmployee != null)
                    {
                        txtFindEmployee.Text = selectedEmployee.EmployeeName;

                        LoadHistoryBillByEmployee(selectedEmployee.Id);

                        FilterBills();
                    }
                }
            }
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            LoadHistoryBill();

            //Hiển thị định dạng giờ phút giây
            dtCreateTime.Format = DateTimePickerFormat.Custom;
            dtCreateTime.CustomFormat = "HH:mm:ss";
            dtCreateTime.ShowUpDown = true;

            dtCreateDate.Format = DateTimePickerFormat.Custom;
            dtCreateDate.CustomFormat = "dd/MM/yyyy";
            dtCreateDate.ShowUpDown = true;

            dgvHistoryBill.DoubleClick += dgvHistoryBill_DoubleClick;


        }

        private void frmHistory_DoubleClick(object sender, EventArgs e)
        {

        }

        private void LoadBillInfo(string billId)
        {
            var billInfoList = bLL_BillInfo.GetByBillId(billId);

            if (billInfoList == null || billInfoList.Count == 0)
            {
                MessageBox.Show($"Không có chi tiết hóa đơn {billId}");
                dgvBill.DataSource = null;
                return;
            }

            // ⚡ Dùng tên cột không có dấu + tránh null
            var billInfoData = billInfoList.Select(bi => new
            {
                ProductID = bi.ProductId,
                ProductName = bi.Product?.ProductName ?? "(Không có)",
                Quantity = bi.Quantity,
                Price = bi.Product?.Price ?? 0,
                Total = bi.Quantity * (bi.Product?.Price ?? 0)

            }).ToList();

            // ⚡ Reset binding an toàn
            dgvBill.DataSource = null;
            dgvBill.AutoGenerateColumns = true;
            dgvBill.DataSource = billInfoData;

            dgvBill.Refresh();
            dgvBill.Update();

            dgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBill.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // MessageBox.Show($"Hiển thị {dgvBill.Rows.Count} dòng trên DataGridView");
        }

        private void ShowTextBoxBill(string billId)
        {

            var bill = bLL_Bill.GetAll().FirstOrDefault(b => b.Id == billId);
            if (bill != null)
            {
                txtBillId.Text = bill.Id;
                txtEmployeeName.Text = bLL_Employee.GetById(bill.EmployeeId)?.EmployeeName;
                txtCustomerName.Text = bill.CustomerId != null ? bLL_Customer.GetById(bill.CustomerId)?.CustomerName : "Khách lẻ";
                txtTable.Text = bill.TableId.ToString();

                if (bill.CreateDate.HasValue)
                {
                    dtCreateDate.Value = bill.CreateDate.Value.Date; // chỉ phần ngày
                    dtCreateTime.Value = bill.CreateDate.Value;      // có cả giờ phút giây
                }
                else
                {
                    // Nếu hóa đơn chưa có ngày tạo, set mặc định là ngày hiện tại
                    dtCreateDate.Value = DateTime.Today;
                    dtCreateTime.Value = DateTime.Now;
                }
            }
        }

        private void dgvHistoryBill_DoubleClick(object sender, EventArgs e)
        {
            if (dgvHistoryBill.CurrentRow != null)
            {
                string selectedBillId = dgvHistoryBill.CurrentRow.Cells["BillID"].Value?.ToString();

                if (string.IsNullOrEmpty(selectedBillId))
                {
                    MessageBox.Show("Không lấy được mã hóa đơn!");
                    return;
                }
                LoadBillInfo(selectedBillId);

                ShowTextBoxBill(selectedBillId);
            }
        }

        private void dgvHistoryBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearFilters()
        {
            selectedCustomer = null;
            selectedEmployee = null;
            txtFindCustomer.Clear();
            txtFindEmployee.Clear();

            txtBillId.Clear();
            txtEmployeeName.Clear();
            txtCustomerName.Clear();
            txtTable.Clear();
            dtCreateDate.Value = DateTime.Today;
            dtCreateTime.Value = DateTime.Now;
            dgvBill.DataSource = null;

            LoadHistoryBill();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearFilters();
        }
    }
}
