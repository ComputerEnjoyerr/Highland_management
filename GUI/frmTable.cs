using BLL;
using DAL;
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
        private List<Table> tableList = new List<Table>();
        private readonly Account _currentUser;
        public frmTable(Account currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadCapacity();
            LoadStatus();
        }

        // Hàm load danh sách bàn
        private void LoadTable(string? keyword = "")
        {
            dgvTable.MultiSelect = false;
            dgvTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTable.ReadOnly = true;

            string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;

            var filteredList = bLL_Table.GetByBranch(branchId)
            .Where(t => t.TableName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        t.Capacity.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                        t.Id.ToString().Contains(keyword, StringComparison.OrdinalIgnoreCase))
            .ToList();

            tableList = filteredList;

            // Trích dữ liệu cần thiết
            var displayLists = tableList.Select(t => new
            {
                t.Id,
                t.TableName,
                Status = t.Status == 0 ? "Trống" : "Đang được đặt",
                t.Capacity
            }).ToList();
            dgvTable.DataSource = displayLists;
            return;
        }

        // Hàm load sức chứa
        public int LoadCapacity()
        {
            cboCapacity.Items.Clear();

            for (int i = 2; i <= 30; i += 2)
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
            try
            {
                string branchId = new BLL_Employee().GetById(_currentUser.EmployeeId).BranchId;
                Table table = new Table
                {
                    TableName = txtTableName.Text,
                    Capacity = Convert.ToInt32(cboCapacity.SelectedItem),
                    Status = cboStatus.SelectedIndex,
                    BranchId = branchId
                };
                bLL_Table.Add(table);
                LoadTable();
                ClearData();
                MessageBox.Show("Thêm bàn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("Vui lòng chọn bàn cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Xác nhận xóa
                DialogResult rs = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa bàn này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (rs == DialogResult.Yes)
                {
                    bLL_Table.Remove(id);
                    MessageBox.Show("Đã xóa thành công", "Thông báo");
                    LoadTable();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa bàn thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTableName.Text))
                {
                    MessageBox.Show("Thông tin bàn không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var table = bLL_Table.GetById(Convert.ToInt32(txtId.Text));

                table.TableName = txtTableName.Text;
                table.Capacity = Convert.ToInt32(cboCapacity.SelectedItem);
                table.Status = cboStatus.SelectedIndex;

                bLL_Table.Update(table);
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");

                LoadTable();
                ClearData();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật bàn thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Lấy ID bàn từ lưới
            if (!int.TryParse(dgvTable.Rows[e.RowIndex].Cells["Id"].Value.ToString(), out int tableId))
                return;

            // Lấy dữ liệu chi tiết từ BLL
            var table = bLL_Table.GetById(tableId);
            if (table == null) return;

            // Đổ dữ liệu vào controls
            txtId.Text = table.Id.ToString();
            txtTableName.Text = table.TableName;

            // --- Gán CAPACITY (kiểu INT) ---
            for (int i = 0; i < cboCapacity.Items.Count; i++)
            {
                if ((int)cboCapacity.Items[i] == table.Capacity)
                {
                    cboCapacity.SelectedIndex = i;
                    break;
                }
            }

            // Status đang lưu dưới dạng số: 0 = Trống, 1 = Đã đặt
            if (table.Status == 0) cboStatus.SelectedIndex = 0;
            else if (table.Status == 1) cboStatus.SelectedIndex = 1;
        }

        // Biển theo dõi công tác nhập liệu
        private CancellationTokenSource _cts = new();
        private async void txtFind_TextChanged(object sender, EventArgs e)
        {
            string input = txtFind.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadTable(keyword: input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }
        }
    }
}
