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
    public partial class frmAdPromotion : Form
    {
        private readonly BLL_PromotionProgram bLL_PromotionProgram = new BLL_PromotionProgram();
        private readonly BLL_Promotion bLL_Promotion = new BLL_Promotion();

        public frmAdPromotion()
        {
            InitializeComponent();
        }

        // Hàm xóa dữ liệu trên form
        private void ClearData()
        {
            txtPPId.Clear();
            txtPPName.Clear();
            txtPPDescription.Clear();
            cboPPCategory.SelectedIndex = -1;
            cboPPDiscountType.SelectedIndex = -1;
            txtPPValue.Clear();
            txtPPMaxDiscount.Clear();
            dtpPPStartDate.Value = DateTime.Now;
            nmrPPExpiryDay.Text = "0";
            nmrPPRequiringPoint.Text = "0";
        }

        // Hàm tải dữ liệu lên
        public void LoadPromotionProgramData()
        {
            var promotionPrograms = bLL_PromotionProgram.GetAllPromotionPrograms()
                .Select(p => new
                {
                    p.Id,
                    p.PromotionName,
                    p.Description,
                    Category = p.PromotionProgram.Category.Name,
                    p.DiscountType,
                    p.Value,
                    p.MaxDiscount,
                    StartDate = p.PromotionProgram.StartDate,
                    EndDate = p.PromotionProgram.StartDate.HasValue
                    ? p.PromotionProgram.StartDate.Value.ToDateTime(TimeOnly.MinValue).AddDays(p.ExpiryDay ?? 0)
                    : (DateTime?)null,
                    p.ExpiryDay,
                    p.RequiringPoint
                });
            dgvPromotionProgram.DataSource = promotionPrograms;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPPName.Text) ||
                string.IsNullOrEmpty(txtPPDescription.Text) ||
                string.IsNullOrEmpty(txtPPValue.Text) ||
                string.IsNullOrEmpty(txtPPMaxDiscount.Text))
            {
                MessageBox.Show("Thông tin chương trình khuyến mãi không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboPPDiscountType.SelectedValue == null)
            {
                MessageBox.Show("Loại giảm giá không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cboPPCategory.SelectedValue == null)
            {
                MessageBox.Show("Danh mục sản phẩm không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void frmAdPromotion_Load(object sender, EventArgs e)
        {
            LoadPromotionProgramData();

            // Cấu hình DataGridView hiển thị cho đẹp
            dgvPromotionProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPromotionProgram.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPromotionProgram.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromotionProgram.MultiSelect = false;
            dgvPromotionProgram.ReadOnly = true;
            dgvPromotionProgram.AllowUserToAddRows = false;
            dgvPromotionProgram.AllowUserToDeleteRows = false;
            dgvPromotionProgram.AllowUserToResizeRows = false;
            dgvPromotionProgram.RowHeadersVisible = false;

            // Style cho bảng
            dgvPromotionProgram.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvPromotionProgram.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPromotionProgram.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvPromotionProgram.EnableHeadersVisualStyles = false;

            dgvPromotionProgram.DefaultCellStyle.BackColor = Color.White;
            dgvPromotionProgram.DefaultCellStyle.ForeColor = Color.Black;
            dgvPromotionProgram.DefaultCellStyle.SelectionBackColor = Color.MistyRose;
            dgvPromotionProgram.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvPromotionProgram.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            dgvPromotionProgram.GridColor = Color.LightGray;
            dgvPromotionProgram.BorderStyle = BorderStyle.None;
        }
    }
}
