using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI
{
    public partial class frmTable : Form
    {
        private readonly BLL_Table bLL_Table = new BLL_Table();
        private List<Product> productList = new List<Product>();
        private readonly Account _currentUser;
        public frmTable(Account currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;

            LoadTable(branchId);
            LoadCapacity();
            LoadStatus();
        }

        // Hàm load danh sách bàn
        private void LoadTable(string branchId, string? keyword = null)
        {
            dgvTable.MultiSelect = false;
            dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTable.ReadOnly = true;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var filteredList = bLL_Table.GetByBranch(branchId)
                    .Where(t => t.TableName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                t.Capacity.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                t.Id.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .Select(t => new
                    {
                        t.Id,
                        t.TableName,
                        t.Capacity,
                        t.Status,
                        BranchName = t.Branch.BranchName
                    }).ToList();
                dgvTable.DataSource = filteredList;
                return;
            }

            var tableList = bLL_Table.GetByBranch(branchId)
                .Select(t => new
                {
                    t.Id,
                    t.TableName,
                    t.Capacity,
                    t.Status,
                    BranchName = t.Branch.BranchName
                }).ToList();
            dgvTable.DataSource = tableList;
        }

        // Hàm load sức chứa
        public int LoadCapacity()
        {
            cboCapacity.Items.Clear();

            for (int i = 4; i <= 30; i += 2)
            {
                cboCapacity.Items.Add(i);
            }

            cboCapacity.SelectedIndex = 0;
            return Convert.ToInt32(cboCapacity.SelectedItem);
        }

        // Hàm load trạng thái
        public int LoadStatus()
        {
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Trống");
            cboStatus.Items.Add("Đã đặt");
            cboStatus.SelectedIndex = 0;

            return cboStatus.SelectedIndex;
        }

        // Hàm dọn dẹp dữ liệu
        public void ClearData()
        {
            txtId.Clear();
            txtTableName.Clear();
            cboCapacity.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTableName.Text))
            {
                MessageBox.Show("Thông tin bàn không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
