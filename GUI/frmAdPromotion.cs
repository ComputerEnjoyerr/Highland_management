using BLL;
using DAL;
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
        private readonly BLL_Category bLL_Category = new BLL_Category();
        private readonly BLL_PromotionVoucher bLL_PromotionVoucher = new BLL_PromotionVoucher();

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

        // Hàm khởi tạo ComboBox
        private void InitializeComboBoxes()
        {
            // Khởi tạo ComboBox cho Loại giảm giá
            var discountTypes = new List<string> { "Phần trăm", "Tiền", "Mua x tặng y" };
            cboPPDiscountType.DataSource = discountTypes;
            // Khởi tạo ComboBox cho Danh mục sản phẩm
            var categories = bLL_Category.GetAll();
            cboPPCategory.DataSource = categories;
            cboPPCategory.DisplayMember = "Name";
            cboPPCategory.ValueMember = "Id";
            //Khởi tạo Combobox cho Loại giảm giá Voucher
            cbVoucherDiscountType.DataSource = discountTypes;
        }

        // Hàm tải dữ liệu lên
        public void LoadPromotionProgramData(string keyword = null)
        {
            dgvPromotionProgram.MultiSelect = false;
            dgvPromotionProgram.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPromotionProgram.ReadOnly = true;
            dgvPromotionProgram.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!string.IsNullOrWhiteSpace(keyword))
            {

                var filteredList = bLL_PromotionProgram.GetAllPromotionPrograms()
                    .Where(p => p.PromotionProgram != null && p.PromotionProgram.PromotionId.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                 p.PromotionProgram.Promotion != null && p.PromotionProgram.Promotion.PromotionName.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                .Select(p => new
                {
                    p.Id,
                    p.PromotionName,
                    p.Description,
                    Category = p.PromotionProgram != null && p.PromotionProgram.Category != null
                     ? p.PromotionProgram.Category.Name
                     : "(Không có danh mục)",
                    p.DiscountType,
                    p.Value,
                    p.MaxDiscount,
                    StartDate = p.PromotionProgram.StartDate,
                    EndDate = p.PromotionProgram.StartDate.HasValue
                    ? p.PromotionProgram.StartDate.Value.ToDateTime(TimeOnly.MinValue).AddDays(p.ExpiryDay ?? 0)
                    : (DateTime?)null,
                    p.ExpiryDay,
                    p.RequiringPoint
                }).ToList();
                dgvPromotionProgram.DataSource = filteredList;
                return;
            }

            var promotionPrograms = bLL_PromotionProgram.GetAllPromotionPrograms()
                .Select(p => new
                {
                    p.Id,
                    p.PromotionName,
                    p.Description,
                    //Category = p.PromotionProgram.Category.Name,
                    Category = p.PromotionProgram != null && p.PromotionProgram.Category != null
                                ? p.PromotionProgram.Category.Name
                                : "(Không có danh mục)",
                    p.DiscountType,
                    p.Value,
                    p.MaxDiscount,
                    StartDate = p.PromotionProgram.StartDate,
                    EndDate = p.PromotionProgram.StartDate.HasValue
                    ? p.PromotionProgram.StartDate.Value.ToDateTime(TimeOnly.MinValue).AddDays(p.ExpiryDay ?? 0)
                    : (DateTime?)null,
                    p.ExpiryDay,
                    p.RequiringPoint
                }).ToList();
            dgvPromotionProgram.DataSource = promotionPrograms;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtPPName.Text) ||
            string.IsNullOrEmpty(txtPPDescription.Text) ||
            string.IsNullOrEmpty(txtPPValue.Text) ||
            string.IsNullOrEmpty(txtPPMaxDiscount.Text))
            {
                MessageBox.Show("Thông tin chương trình khuyến mãi không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal value;
            if (!decimal.TryParse(txtPPValue.Text, out value))
            {
                MessageBox.Show("Giá trị giảm giá không hợp lệ (phải là số > 0)!", "Thông báo");
                txtPPValue.Clear();
                txtPPValue.Focus();
                return; // Dừng lại, không tiếp tục tạo promotion
            }

            decimal maxDiscount;
            if (!decimal.TryParse(txtPPMaxDiscount.Text, out maxDiscount))
            {
                MessageBox.Show("Giá trị giảm giá tối đa không hợp lệ (phải là số > 0)!", "Lỗi");
                txtPPMaxDiscount.Clear();
                txtPPMaxDiscount.Focus();
                return; // Dừng lại, không tiếp tục tạo promotion
            }

            if (cboPPDiscountType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại giảm giá!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPPDiscountType.Focus();
                return;
            }
            if (cboPPCategory.SelectedValue == null)
            {
                MessageBox.Show("Danh mục sản phẩm không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPPCategory.Focus();
                return;
            }
            if (!int.TryParse(nmrPPRequiringPoint.Text, out int requiringPoint) || requiringPoint < 0)
            {
                MessageBox.Show("Điểm yêu cầu phải là số >= 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmrPPRequiringPoint.Focus();
                return;
            }
            if (!int.TryParse(nmrPPExpiryDay.Text, out int expiryDate) || expiryDate < 0)
            {
                MessageBox.Show("Ngày hết hạn phải là số >= 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmrPPExpiryDay.Focus();
                return;
            }
            if (dtpPPStartDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày bắt đầu không thể nhỏ hơn hôm nay!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpPPStartDate.Focus();
                return;
            }
            try
            {
                string promotionId = bLL_PromotionProgram.GeneratePromotionProgramId("");
                string categoryId = cboPPCategory.SelectedValue.ToString();

                var promotion = new Promotion
                {
                    Id = promotionId,
                    PromotionName = txtPPName.Text,
                    Description = txtPPDescription.Text,
                    PromotionType = "Chương trình khuyến mãi",
                    DiscountType = cboPPDiscountType.SelectedItem.ToString(),
                    Value = value,
                    MaxDiscount = maxDiscount,
                    RequiringPoint = (int)nmrPPRequiringPoint.Value,
                    ExpiryDay = (int)nmrPPExpiryDay.Value
                };
                bLL_Promotion.Add(promotion);

                txtPPId.Text = promotionId;
                var add = new PromotionProgram
                {
                    PromotionId = promotionId,
                    CategoryId = categoryId,
                    StartDate = DateOnly.FromDateTime(dtpPPStartDate.Value)
                };
                bLL_PromotionProgram.Add(add);
                MessageBox.Show("Đã thêm chương trình khuyến mãi thành công", "Thông báo");
                LoadPromotionProgramData();
                ClearData();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm chương trình khuyến mãi thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void frmAdPromotion_Load(object sender, EventArgs e)
        {
            LoadPromotionProgramData();
            LoadDataVoucher();

            InitializeComboBoxes();

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

        private void dgvPromotionProgram_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvPromotionProgram.Rows[e.RowIndex];
                txtPPId.Text = selectedRow.Cells["Id"].Value.ToString();
                txtPPName.Text = selectedRow.Cells["PromotionName"].Value.ToString();
                txtPPDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                var categoryName = selectedRow.Cells["Category"].Value.ToString();
                cboPPCategory.SelectedIndex = cboPPCategory.FindStringExact(categoryName);
                var discountType = selectedRow.Cells["DiscountType"].Value.ToString();
                cboPPDiscountType.SelectedIndex = cboPPDiscountType.FindStringExact(discountType);
                txtPPValue.Text = selectedRow.Cells["Value"].Value.ToString();
                txtPPMaxDiscount.Text = selectedRow.Cells["MaxDiscount"].Value.ToString();
                if (DateTime.TryParse(selectedRow.Cells["StartDate"].Value.ToString(), out DateTime startDate))
                {
                    dtpPPStartDate.Value = startDate;
                }
                nmrPPExpiryDay.Value = Convert.ToDecimal(selectedRow.Cells["ExpiryDay"].Value);
                nmrPPRequiringPoint.Value = Convert.ToDecimal(selectedRow.Cells["RequiringPoint"].Value);
            }
        }

        private void txtPPName_Leave(object sender, EventArgs e)
        {
            // Nếu người dùng không nhập tên => báo lỗi
            if (string.IsNullOrWhiteSpace(txtPPName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên chương trình khuyến mãi!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                txtPPName.Focus(); // Trả con trỏ về ô nhập
                return;
            }

            // Kiểm tra độ dài Name
            string name = txtPPName.Text.Trim();
            if (name.Length > 100)
            {
                MessageBox.Show("Tên chương trình không được vượt quá 100 ký tự!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPPName.Clear();
                txtPPName.Focus();
                return;
            }

            // Kiểm tra trùng tên
            if (bLL_PromotionProgram.CheckPromotionProgramNameExists(name))
            {
                MessageBox.Show("Tên chương trình khuyến mãi này đã tồn tại!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPName.Clear();
                txtPPName.Focus();
                return;
            }

            // Tự động tạo ID
            if (string.IsNullOrWhiteSpace(txtPPId.Text))
            {
                txtPPId.Text = bLL_PromotionProgram.GeneratePromotionProgramId(txtPPName.Text);
                // Kiểm tra ID có trùng không
                while (bLL_PromotionProgram.CheckPromotionProgramIdExists(txtPPId.Text))
                {
                    // Nếu trùng → sinh lại ID mới
                    txtPPId.Text = bLL_PromotionProgram.GeneratePromotionProgramId(name);
                }
            }
        }

        private void txtPPDescription_TextChanged(object sender, EventArgs e)
        {
            string description = txtPPDescription.Text.Trim();
            if (description.Length > 200)
            {
                MessageBox.Show("Mô tả không được vượt quá 200 ký tự!",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPPDescription.Clear();
                txtPPDescription.Focus();
                return;
            }
        }

        // Biến để theo dõi thao tác nhập liệu
        private CancellationTokenSource _cts = new();
        private async void txtPPSearch_TextChanged(object sender, EventArgs e)
        {
            string input = txtPPSearch.Text;

            // Hủy thao tác trước đó nếu người dùng vẫn đang nhập
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                // Chờ 0,5s giây sau khi người dùng dừng nhập rồi mới thực hiện tìm kiếm
                await Task.Delay(500, _cts.Token);
                LoadPromotionProgramData(input);
            }
            catch (TaskCanceledException)
            {
                // Người dùng vẫn đang nhập, bỏ qua
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtPPId.Text.Trim();
                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("Vui lòng chọn chương trình khuyến mãi để xóa", "Thông báo");
                    return;
                }
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa chương trình khuến mãi này không?", id, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bLL_PromotionProgram.Delete(id);
                    bLL_Promotion.Remove(id);
                    MessageBox.Show("Đã xóa chương trình khuyến mãi thành công", "Thông báo");
                    LoadPromotionProgramData();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa chương trình khuyến mãi thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPPId.Text))
            {
                MessageBox.Show("Vui lòng chọn chương trình khuyến mãi cần cập nhật từ bảng.", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn cập nhật chương trình khuyến mãi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.No == rs)
                return;

            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtPPName.Text) ||
            string.IsNullOrEmpty(txtPPDescription.Text) ||
            string.IsNullOrEmpty(txtPPValue.Text) ||
            string.IsNullOrEmpty(txtPPMaxDiscount.Text))
            {
                MessageBox.Show("Thông tin chương trình khuyến mãi không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal value;
            if (!decimal.TryParse(txtPPValue.Text, out value))
            {
                MessageBox.Show("Giá trị giảm giá không hợp lệ (phải là số > 0)!", "Thông báo");
                txtPPValue.Clear();
                txtPPValue.Focus();
                return; // Dừng lại, không tiếp tục tạo promotion
            }

            decimal maxDiscount;
            if (!decimal.TryParse(txtPPMaxDiscount.Text, out maxDiscount) || maxDiscount < 0)
            {
                MessageBox.Show("Giá trị giảm giá tối đa không hợp lệ (phải là số > 0)!", "Lỗi");
                txtPPMaxDiscount.Clear();
                txtPPMaxDiscount.Focus();
                return; // Dừng lại, không tiếp tục tạo promotion
            }

            if (cboPPDiscountType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại giảm giá!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPPDiscountType.Focus();
                return;
            }
            if (cboPPCategory.SelectedValue == null)
            {
                MessageBox.Show("Danh mục sản phẩm không được để trống!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboPPCategory.Focus();
                return;
            }
            int test;
            if (!int.TryParse(txtPPValue.Text, out test) || test < 0)
            {
                MessageBox.Show("Giá trị giảm giá phải là số >= 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPValue.Clear();
                txtPPValue.Focus();
                return;
            }
            if (!int.TryParse(nmrPPRequiringPoint.Text, out int requiringPoint) || requiringPoint < 0)
            {
                MessageBox.Show("Điểm yêu cầu phải là số >= 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmrPPRequiringPoint.Focus();
                return;
            }
            if (!int.TryParse(nmrPPExpiryDay.Text, out int expiryDate) || expiryDate < 0)
            {
                MessageBox.Show("Ngày hết hạn phải là số >= 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nmrPPExpiryDay.Focus();
                return;
            }
            try
            {
                string id = txtPPId.Text.Trim(); // Lấy ID PromotionProgram cần update
                var promotion = bLL_PromotionProgram.GetAllPromotionPrograms().FirstOrDefault(p => p.Id == id);

                if (promotion == null)
                {
                    MessageBox.Show("Không tìm thấy chương trình khuyến mãi để cập nhật!", "Thông báo");
                    return;
                }

                promotion.PromotionName = txtPPName.Text;
                promotion.Description = txtPPDescription.Text;
                promotion.DiscountType = cboPPDiscountType.SelectedItem.ToString();
                promotion.Value = decimal.Parse(txtPPValue.Text);
                promotion.MaxDiscount = decimal.Parse(txtPPMaxDiscount.Text);
                promotion.RequiringPoint = (int)nmrPPRequiringPoint.Value;
                promotion.ExpiryDay = (int)nmrPPExpiryDay.Value;
                // Update thông tin PromotionProgram
                var promotionProgram = new PromotionProgram
                {
                    PromotionId = id,
                    CategoryId = cboPPCategory.SelectedValue.ToString(),
                    StartDate = DateOnly.FromDateTime(dtpPPStartDate.Value)
                };

                bLL_PromotionProgram.Update(promotionProgram);
                bLL_Promotion.Update(promotion);

                MessageBox.Show("Đã cập nhật chương trình khuyến mãi thành công", "Thông báo");
                ClearData();
                LoadPromotionProgramData();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật chương trình khuyến mãi thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        //---------------------------------------------------------------------------------------------------------------------
        private void ClearDataVoucher()
        {
            txtVoucherID.Clear();
            txtVoucherName.Clear();
            txtVoucherDescription.Clear();
            cbVoucherDiscountType.SelectedIndex = -1;
            txtVoucherValue.Clear();
            txtVoucherMaxDiscount.Clear();
            numVoucherExpiryday.TabIndex = 0;

        }

        private void btnClearVoucher_Click(object sender, EventArgs e)
        {
            ClearDataVoucher();

        }

        private void LoadDataVoucher(string keyword = null)
        {
            dgvDataVoucher.MultiSelect = false;
            dgvDataVoucher.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataVoucher.ReadOnly = true;

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var list = bLL_Promotion.GetAllPromotions()
                    .Where(pr => pr.PromotionType == "Voucher" &&
                                (pr.Id.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                                 pr.PromotionName.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
                    .Select(pr => new
                    {
                        pr.Id,
                        pr.PromotionName,
                        pr.Description,
                        pr.DiscountType,
                        pr.Value,
                        pr.MaxDiscount,
                        pr.ExpiryDay

                    }).ToList();
                dgvDataVoucher.DataSource = list;
                return;
            }
            var voucherList = bLL_PromotionVoucher.GetAllPromotionVouchers()
                .Select(pr => new
                {
                    pr.Id,
                    pr.PromotionName,
                    pr.Description,
                    pr.DiscountType,
                    pr.Value,
                    pr.MaxDiscount,
                    pr.ExpiryDay
                }).ToList();
            dgvDataVoucher.DataSource = voucherList;

        }

        private void dgvDataVoucher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvDataVoucher.Rows[e.RowIndex];
                txtVoucherID.Text = selectedRow.Cells["Id"].Value.ToString();
                txtVoucherName.Text = selectedRow.Cells["PromotionName"].Value.ToString();
                txtVoucherDescription.Text = selectedRow.Cells["Description"].Value.ToString();
                var discountType = selectedRow.Cells["DiscountType"].Value.ToString();
                cbVoucherDiscountType.SelectedIndex = cbVoucherDiscountType.FindStringExact(discountType);
                txtVoucherValue.Text = selectedRow.Cells["Value"].Value.ToString();
                txtVoucherMaxDiscount.Text = selectedRow.Cells["MaxDiscount"].Value.ToString();
                numVoucherExpiryday.Value = Convert.ToDecimal(selectedRow.Cells["ExpiryDay"].Value);

            }
        }

        private void btnDeleteVoucher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVoucherID.Text))
            {
                MessageBox.Show("Vui lòng chọn thông tin Voucher để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string voucherId = txtVoucherID.Text.Trim();
                if (string.IsNullOrEmpty(voucherId))
                {
                    MessageBox.Show("Vui lòng chọn voucher để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult rs = MessageBox.Show("Bạn có muốn xóa voucher này không?", voucherId, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    bLL_PromotionVoucher.DeleteProVoucher(voucherId);
                    bLL_Promotion.Remove(voucherId);
                    MessageBox.Show("Đã xóa voucher thành công", "Thông báo");
                    LoadDataVoucher();
                    ClearDataVoucher();
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Xóa voucher thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtVoucherName.Text) || string.IsNullOrEmpty(txtVoucherDescription.Text)
                || string.IsNullOrEmpty(txtVoucherValue.Text) || string.IsNullOrEmpty(txtVoucherMaxDiscount.Text))
            {
                MessageBox.Show("Thông tin Voucher không được để trống", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbVoucherDiscountType.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại giảm giá!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbVoucherDiscountType.Focus();
                return;
            }
            if (txtVoucherName.Text.Length > 20)
            {
                MessageBox.Show("Mã Voucher không được quá 20 ký tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal valueVoucher;
            if (!decimal.TryParse(txtVoucherValue.Text, out valueVoucher) || valueVoucher <0)
            {
                MessageBox.Show("Giá trị giảm giá Voucher không được nhỏ hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);              
                return; // Dừng lại, không tiếp tục tạo promotion
            }

            decimal maxDiscountVoucher;
            if(!decimal.TryParse(txtVoucherMaxDiscount.Text, out maxDiscountVoucher) || maxDiscountVoucher < 0)
            {
                MessageBox.Show("Giá trị giảm giá tối đa Voucher không được nhỏ hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtVoucherDescription.Text.Length > 100)
            {
                MessageBox.Show("Mô tả không được quá 100 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string discountType = cbVoucherDiscountType.SelectedItem.ToString() ?? "";
                string voucherId = bLL_PromotionVoucher.GenerateProVoucherId(discountType);
                var voucher = new Promotion
                {
                    Id = voucherId,
                    PromotionName = txtVoucherName.Text,
                    Description = txtVoucherDescription.Text,
                    PromotionType = "Voucher",
                    DiscountType = cbVoucherDiscountType.SelectedItem.ToString(),
                    Value = valueVoucher,
                    MaxDiscount = maxDiscountVoucher,
                    ExpiryDay = (int)numVoucherExpiryday.Value
                };
                bLL_Promotion.Add(voucher);
                MessageBox.Show("Đã thêm voucher thành công", "Thông báo");
                LoadDataVoucher();
                ClearDataVoucher();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Thêm voucher thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }

        private void btnUpdateVoucher_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVoucherID.Text))
            {
                MessageBox.Show("Vui lòng chọn Voucher để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal valueVoucher;
            if (!decimal.TryParse(txtVoucherValue.Text, out valueVoucher) || valueVoucher < 0)
            {
                MessageBox.Show("Giá trị giảm giá Voucher không được nhỏ hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal maxDiscountVoucher;
            if (!decimal.TryParse(txtVoucherMaxDiscount.Text, out maxDiscountVoucher) || maxDiscountVoucher <0)
            {
                MessageBox.Show("Giá trị giảm giá tối đa Voucher không được nhỏ hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string id = txtVoucherID.Text.Trim(); // Lấy ID Voucher cần update
                var voucher = bLL_PromotionVoucher.GetAllPromotionVouchers().FirstOrDefault(p => p.Id == id);
                if (voucher == null)
                {
                    MessageBox.Show("Không tìm thấy voucher để cập nhật!", "Thông báo");
                    return;
                }
                voucher.PromotionName = txtVoucherName.Text;
                voucher.Description = txtVoucherDescription.Text;
                voucher.DiscountType = cbVoucherDiscountType.SelectedItem.ToString();
                voucher.Value = decimal.Parse(txtVoucherValue.Text);
                voucher.MaxDiscount = decimal.Parse(txtVoucherMaxDiscount.Text);
                voucher.ExpiryDay = (int)numVoucherExpiryday.Value;
                DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật thông tin Voucher không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (rs == DialogResult.OK)
                {
                    bLL_Promotion.Update(voucher);
                    MessageBox.Show("Đã cập nhật voucher thành công", "Thông báo");
                    ClearDataVoucher();
                    LoadDataVoucher();
                }
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.InnerException?.Message ?? ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show("Cập nhật chương trình khuyến mãi thất bại.\nChi tiết lỗi: " + inner, "Thông báo");
            }
        }
        private CancellationTokenSource _ctsVoucher = new();
        private async void textBox2_TextChanged(object sender, EventArgs e)
        {
            string input = textBox2.Text;

            _ctsVoucher.Cancel();
            _ctsVoucher = new CancellationTokenSource();

            try
            {
                await Task.Delay(500, _ctsVoucher.Token);
                LoadDataVoucher(input);
            }
            catch(TaskCanceledException)
            {

            }
        }
    }
}
