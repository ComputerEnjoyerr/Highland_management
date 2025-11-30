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
    public partial class frmNotification : Form
    {
        private BLL_Notification bLL_Notification = new BLL_Notification();
        private BLL_Inventory bLL_Inventory = new BLL_Inventory();

        private Employee employee = new Employee();
        private List<Notification> notifications = new List<Notification>();
        private Notification currentNotification = null;
        public frmNotification(Employee em)
        {
            InitializeComponent();
            employee = em;
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtTitle.Clear();
            txtContent.Clear();
            dtpTime.Value = DateTime.Now;
            cboType.SelectedIndex = 0;
        }

        private void LoadNotification(string type = "")
        {
            var filteredNotifications = bLL_Notification.GetAll()
                .Where(n => n.Type.Contains(type, StringComparison.OrdinalIgnoreCase) && 
                            n.BranchId == employee.BranchId)
                .OrderByDescending(c => c.CreatedAt)
                .ToList();
            notifications = filteredNotifications;
            var displayList = filteredNotifications.Select(n => new
            {
                n.Id,
                n.Title,
                n.CreatedAt,
                n.Type,
                IsRead = (n.IsRead) ? "Đã đọc" : "Chưa đọc"
            })
            .ToList();

            dgvNotification.DataSource = displayList;
        }

        private void LoadTypeComboBox()
        {
            cboType.Items.Add("Nguyên liệu");
            cboType.Items.Add("Tồn kho");
            cboType.Items.Add("Khác");
            cboType.SelectedIndex = 0;

            cboFindByType.Items.Add("Nguyên liệu");
            cboFindByType.Items.Add("Tồn kho");
            cboFindByType.Items.Add("Khác");
        }

        private void frmNotification_Load(object sender, EventArgs e)
        {
            cboType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFindByType.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvNotification.MultiSelect = false;
            dgvNotification.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotification.ReadOnly = true;
            dgvNotification.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadTypeComboBox();
            LoadNotification();
        }

        private void btnIsRead_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin thông báo đã chọn
                var selectedNotification = currentNotification;
                if (selectedNotification != null)
                {
                    // Đánh dấu thông báo là đã đọc
                    bLL_Notification.UpdateReadStatus(selectedNotification.Id, true);
                    LoadNotification();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa khách hàng thất bại.\nChi tiết lỗi: " + inner);
            }
        }



        private void dgvNotification_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNotification.Rows.Count)
            {
                currentNotification = notifications[e.RowIndex];
                txtId.Text = currentNotification.Id.ToString();
                txtTitle.Text = currentNotification.Title;
                txtContent.Text = currentNotification.Message;
                var dateTime = currentNotification.CreatedAt;
                if (dateTime.HasValue)
                    dtpTime.Value = dateTime.Value;
                var type = currentNotification.Type;
                cboType.SelectedItem = cboType.Items.Cast<string>().FirstOrDefault(item => item.Equals(type, StringComparison.OrdinalIgnoreCase));
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xóa thông báo này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.No)
                return;
            try
            {
                if (currentNotification == null)
                {
                    MessageBox.Show("Không có thông báo nào được chọn.");
                    return;
                }

                bLL_Notification.Remove(currentNotification.Id);
                LoadNotification();
                
                currentNotification = null;
                ClearForm();

            }
            catch (Exception ex)
            {
                // Lấy chi tiết lỗi từ InnerException
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa khách hàng thất bại.\nChi tiết lỗi: " + inner);
            }
        }

        private void cboFindByType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFindByType.SelectedItem != null)
            {
                string selectedType = cboFindByType.SelectedItem.ToString();
                LoadNotification(selectedType);
            }
        }
    }
}
