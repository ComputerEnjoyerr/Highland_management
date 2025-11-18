using BLL;
using Castle.Core;
using DAL;
using DTO;
using OfficeOpenXml;
using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = OfficeOpenXml.LicenseContext;


namespace GUI
{
    public partial class frmFinancial : Form
    {
        public frmFinancial()
        {
            InitializeComponent();


        }
        private readonly BLL_Financial bLL_Financial = new();
        private readonly BLL_Branch bLL_Branch = new();
        private readonly BLL_Bill bLL_Bill = new();
        private readonly BLL_BillInfo bLL_BillInfo = new();
        private readonly BLL_Employee bLL_Employee = new();
        private readonly BLL_Product bLL_Product = new();
        private readonly BLL_Ingredient bLL_Ingredient = new();
        private readonly BLL_Customer bLL_Customer = new();
        private readonly BLL_Attendance bLL_Attendance = new();
        private readonly BLL_StockReceipt bLL_StockReceipt = new();

        private bool daLuuThangNay = false;
        private bool cheDoSua = false;
        private bool isUpdating = false;
        private bool allowEmpty = false;

        // Lọc tháng và năm được chọn
        public int SelectedMonth => cbMonth.SelectedIndex >= 0 ? cbMonth.SelectedIndex + 1 : DateTime.Now.Month;
        public int SelectedYear => int.TryParse(cbYear.Text, out int y) ? y : DateTime.Now.Year;
        //private ScottPlot.WinForms.FormsPlot formsPlot2;

        private void frmFinancial_Load(object sender, EventArgs e)
        {
            // Tháng: 1 đến 12
            for (int i = 1; i <= 12; i++)
                cbMonth.Items.Add(i);
            cbMonth.SelectedIndex = DateTime.Now.Month - 1;

            // Năm: 2020 → hiện tại
            for (int i = 2020; i <= DateTime.Now.Year; i++)
                cbYear.Items.Add(i);
            cbYear.SelectedIndex = cbYear.Items.Count - 1;


            LoadDataBill();
            LoadDataEmployee();
            LoadDataIngredient();
            LoadChiPhiCoDinh();

            // GẮN KeyPress CHO 3 Ô
            txtDienNuoc.KeyPress += RichTextBox_KeyPress;
            txtMatBang.KeyPress += RichTextBox_KeyPress;
            txtChiPhiKhac.KeyPress += RichTextBox_KeyPress;

            // Gắn TextChanged (vẫn cần)
            txtDienNuoc.TextChanged += CostInput_TextChanged;
            txtMatBang.TextChanged += CostInput_TextChanged;
            txtChiPhiKhac.TextChanged += CostInput_TextChanged;

            // Khởi tạo
            FormatRichTextBox(txtDienNuoc, 0);
            FormatRichTextBox(txtMatBang, 0);
            FormatRichTextBox(txtChiPhiKhac, 0);

            CapNhatLoiNhuan();
            // Căn giữa tiêu đề RichTextBox
            CenterRichTextBox(txtDoanhThu);
            CenterRichTextBox(txtLuongNV);
            CenterRichTextBox(txtLoiNhuan);
            CenterRichTextBox(txtMatBang);
            CenterRichTextBox(txtTienNguyenLieu);
            CenterRichTextBox(txtDienNuoc);
            CenterRichTextBox(txtChiPhiKhac);

            DrawFinancialPieChart();
            UpdateButtonStates();

            //// Thêm sự kiện khi thay đổi tháng/năm
            cbMonth.SelectedIndexChanged += (s, ev) => ReloadAll();
            cbYear.SelectedIndexChanged += (s, ev) => ReloadAll();

        }
        private void LoadChiPhiCoDinh()
        {
            var fin = bLL_Financial.GetByMonthYear(SelectedMonth, SelectedYear);
            daLuuThangNay = (fin != null);
            decimal dienNuoc = 0, matBang = 0, chiPhiKhac = 0;

            if (fin != null)
            {
                isUpdating = true;

                // Sử dụng giá trị từ database, nếu null thì dùng 0
                decimal dienNuocValue = (fin.ElectricityCost ?? 0) + (fin.WaterCost ?? 0);
                decimal matBangValue = fin.RentCost ?? 0;
                decimal chiPhiKhacValue = fin.OtherCost ?? 0;

                FormatRichTextBox(txtDienNuoc, dienNuocValue);
                FormatRichTextBox(txtMatBang, matBangValue);
                FormatRichTextBox(txtChiPhiKhac, chiPhiKhacValue);

                isUpdating = false;

                // Cập nhật lại lợi nhuận và biểu đồ
               
                CapNhatLoiNhuan();
                DrawFinancialPieChart();
                UpdateButtonStates();
            }
            else
            {
                // Nếu chưa có dữ liệu, set về 0
                isUpdating = true;
                FormatRichTextBox(txtDienNuoc, 0);
                FormatRichTextBox(txtMatBang, 0);
                FormatRichTextBox(txtChiPhiKhac, 0);
                isUpdating = false;
            }

            UpdateButtonStates();
        }

        private void UpdateButtonStates()
        {
            btnLuuChiPhi.Enabled = !daLuuThangNay || cheDoSua;
            btnSuaChiPhi.Enabled = daLuuThangNay && !cheDoSua;

            // Cho phép/nhập liệu khi chưa lưu hoặc đang ở chế độ sửa
            bool allowEdit = !daLuuThangNay || cheDoSua;
            txtDienNuoc.ReadOnly = !allowEdit;
            txtMatBang.ReadOnly = !allowEdit;
            txtChiPhiKhac.ReadOnly = !allowEdit;

            // Cập nhật text nút
            btnLuuChiPhi.Text = cheDoSua ? "Cập nhật" : "Lưu chi phí";
        }

        private void ReloadAll()
        {
            LoadDataBill();
            LoadDataEmployee();
            LoadDataIngredient();
            LoadChiPhiCoDinh();
            cheDoSua = false;
            UpdateButtonStates();
        }

        private void LoadDataBill()
        {

            var data = bLL_Bill.GetAll()
                .Where(b => b.CreateDate?.Month == SelectedMonth && b.CreateDate?.Year == SelectedYear)
        .Select(b => new
        {
            b.Id,
            b.CreateDate,
            CustomerName = b.CustomerId != null ? bLL_Customer.GetById(b.CustomerId)?.CustomerName : "Khách lẻ",
            b.TotalPrice,
            EmployeeName = bLL_Employee.GetById(b.EmployeeId)?.EmployeeName
        })
        .OrderByDescending(b => b.CreateDate)
        .ToList();

            dataGridView1.DataSource = data;
            //txtDoanhThu.Text = $"{data.Sum(x => x.TotalPrice):N0} vnd";

            decimal totalRevenue = data.Sum(x => x.TotalPrice);
            txtDoanhThu.Text = $"{totalRevenue:N0} vnd";
            FormatRichTextBox(txtDoanhThu, data.Sum(x => x.TotalPrice));
            CapNhatLoiNhuan();

            DrawFinancialPieChart();


        }

        private void LoadDataIngredient()
        {
            // Bảo vệ ComboBox
            if (cbMonth.SelectedIndex < 0 || string.IsNullOrEmpty(cbYear.Text))
                return;

            int selectedMonth = cbMonth.SelectedIndex + 1;
            int selectedYear = int.Parse(cbYear.Text);

            var receipts = bLL_StockReceipt.GetAll()
                .Where(s =>
                    s.ReceiptDate.Month == selectedMonth &&
                    s.ReceiptDate.Year == selectedYear &&
                    s.Ingredient != null)
                .ToList();

            // TÍNH TỔNG TIỀN NGUYÊN LIỆU
            decimal totalCost = receipts.Sum(s => s.Quantity * s.UnitPrice);

            var data = bLL_StockReceipt.GetAll()
         .Where(s =>
             s.ReceiptDate.Month == selectedMonth &&   // DateOnly → có .Month, .Year
             s.ReceiptDate.Year == selectedYear &&     // KHÔNG CẦN .Value
             s.Ingredient != null)
         .GroupBy(s => s.IngredientId)
         .Select(g => new
         {
             IngredientId = g.Key,
             IngredientName = g.First().Ingredient?.IngredientName ?? "Không xác định",
             TotalQuantity = g.Sum(x => x.Quantity),
             UnitPrice = g.First().UnitPrice,
             ReceiptDate = g.First().ReceiptDate
             //TotalValue = g.Sum(x => x.Quantity * x.UnitPrice)
         })
         .ToList();

            dataGridView2.DataSource = data;
            txtTienNguyenLieu.Text = $"{totalCost:N0} vnd";
            FormatRichTextBox(txtTienNguyenLieu, totalCost);
            CapNhatLoiNhuan();

            DrawFinancialPieChart();
        }

        private void LoadDataEmployee()
        {
            if (cbMonth.SelectedIndex < 0 || string.IsNullOrEmpty(cbYear.Text))
                return;

            int month = cbMonth.SelectedIndex + 1;
            int year = int.Parse(cbYear.Text);

            var attendances = bLL_Attendance.GetAll()
                .Where(a =>
                    a.CheckIn.HasValue &&
                    a.CheckOut.HasValue &&
                    a.Employee != null &&
                    a.CheckIn.Value.Month == month &&
                    a.CheckIn.Value.Year == year)
                .ToList();

            decimal totalSalary = 0;
            var data = new List<object>();

            var grouped = attendances.GroupBy(a => a.EmployeeId);
            foreach (var g in grouped)
            {
                var emp = g.First().Employee!;
                double hours = g.Sum(a =>
                    (a.CheckOut.Value - a.CheckIn.Value).TotalHours +
                    (double)(a.OvertimeHours ?? 0)
                );
                decimal salary = (decimal)hours * (emp.SalaryPerHour);
                totalSalary += salary;

                data.Add(new
                {
                    Mã = emp.Id,
                    EmployeeName = emp.EmployeeName,
                    Gender = emp.Gender,
                    Role = emp.Role,
                    Phone = emp.Phone,
                    SalaryPerHour = emp.SalaryPerHour,
                    TotalHour = Math.Round(hours, 2),
                    TotalSalary = Math.Round(salary, 0)
                });
            }

            // Gán dữ liệu grid
            dataGridView3.DataSource = data;
            txtLuongNV.Text = $"{totalSalary:N0}vnd";
            FormatRichTextBox(txtLuongNV, totalSalary);
            CapNhatLoiNhuan();

            DrawFinancialPieChart();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            LoadDataBill();
            LoadDataEmployee();
            LoadDataIngredient();
            DrawFinancialPieChart();
            LoadChiPhiCoDinh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cbYear.SelectedIndex = cbYear.Items.Count - 1;

            LoadDataBill();
            LoadDataEmployee();
            LoadDataIngredient();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        //Hàm căn giữa RichTextBox
        private void CenterRichTextBox(RichTextBox rtb)
        {
            string text = rtb.Text;
            rtb.Clear();
            rtb.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            rtb.AppendText(text);
        }

        private void CostInput_TextChanged(object sender, EventArgs e)
        {
            var rtb = sender as RichTextBox;
            if (rtb == null || isUpdating) return;
            isUpdating = true;
            try
            {
                int oldCaretOffset = rtb.Text.Length - rtb.SelectionStart;
                string digits = new string(rtb.Text.Where(char.IsDigit).ToArray());

                decimal value = 0;
                if (decimal.TryParse(digits, out decimal parsed))
                    value = parsed;

                FormatRichTextBox(rtb, value);
                rtb.SelectionStart = Math.Max(0, rtb.Text.Length - oldCaretOffset);
            }
            finally
            {
                isUpdating = false;
            }
            CapNhatLoiNhuan();
            DrawFinancialPieChart();
            if (daLuuThangNay && !cheDoSua)
            {
                cheDoSua = true;
                UpdateButtonStates();
            }

        }

        private void CapNhatLoiNhuan()
        {
            if (isUpdating) return;
            isUpdating = true;
            try
            {
                decimal doanhThu = LaySo(txtDoanhThu);
                decimal luong = LaySo(txtLuongNV);
                decimal nguyenLieu = LaySo(txtTienNguyenLieu);
                decimal dienNuoc = LaySo(txtDienNuoc);
                decimal matBang = LaySo(txtMatBang);
                decimal chiPhiKhac = LaySo(txtChiPhiKhac);
                decimal loiNhuan = doanhThu - luong - nguyenLieu - dienNuoc - matBang - chiPhiKhac;

                txtLoiNhuan.Clear();
                txtLoiNhuan.SelectionFont = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
                txtLoiNhuan.AppendText(loiNhuan.ToString("N0") + "vnd");
                CenterRichTextBox(txtLoiNhuan);

                txtLoiNhuan.SelectAll();
                txtLoiNhuan.SelectionColor = loiNhuan >= 0
                    ? System.Drawing.Color.Black
                    : System.Drawing.Color.Red;
                txtLoiNhuan.DeselectAll();
            }
            finally
            {
                isUpdating = false;
            }
        }
        private decimal LaySo(RichTextBox rtb)
        {
            string so = "";
            foreach (char c in rtb.Text)
                if (char.IsDigit(c)) so += c;
            decimal.TryParse(so, out decimal kq);
            return kq;
        }

        private void FormatRichTextBox(RichTextBox rtb, decimal value)
        {
            rtb.Clear();
            rtb.SelectionFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            rtb.SelectionColor = System.Drawing.Color.Black;
            rtb.SelectionAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            rtb.AppendText(value.ToString("N0") + " vnd");
        }

        private void RichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var rtb = sender as RichTextBox;
            if (rtb == null) return;

            // Cho phép Backspace, Delete, số
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || char.IsDigit(e.KeyChar))
            {
                allowEmpty = true;
                return;
            }

            // Chặn ký tự không phải số
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow?.Cells["Id"].Value is string billId)
            {
                var bill = bLL_Bill.GetById(billId);
                if (bill != null)
                {
                    var frm = new frmBillDetail(bill);
                    frm.ShowDialog();
                }
            }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView2.Rows[e.RowIndex];
                if (row.Cells["IngredientId"].Value is string ingredientId)
                {
                    int selectedMonth = SelectedMonth; // Lấy từ thuộc tính hiện tại
                    int selectedYear = SelectedYear;   // Lấy từ thuộc tính hiện tại
                    var frm = new frmIngredientDetail(ingredientId, selectedMonth, selectedYear);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy ID nguyên liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //In file Excel
        private void ExportBillDataToExcel()
        {

            // Cấu hình EPPlus để bỏ qua thông báo bản quyền
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            using (var package = new ExcelPackage())
            {
                // Sheet 1: Doanh Thu
                var worksheetDoanhThu = package.Workbook.Worksheets.Add($"DoanhThu_{SelectedMonth}_{SelectedYear}");
                // Tiêu đề cột Doanh Thu
                worksheetDoanhThu.Cells[1, 1].Value = "ID";
                worksheetDoanhThu.Cells[1, 2].Value = "Ngày Tạo";
                worksheetDoanhThu.Cells[1, 3].Value = "Tên Khách Hàng";
                worksheetDoanhThu.Cells[1, 4].Value = "Tổng Giá";
                worksheetDoanhThu.Cells[1, 5].Value = "Tên Nhân Viên";
                // Lấy dữ liệu Doanh Thu
                var billData = bLL_Bill.GetAll()
                    .Where(b => b.CreateDate?.Month == SelectedMonth && b.CreateDate?.Year == SelectedYear)
                    .Select(b => new
                    {
                        b.Id,
                        CreateDate = b.CreateDate?.ToString("dd/MM/yyyy"),
                        CustomerName = b.CustomerId != null ? bLL_Customer.GetById(b.CustomerId)?.CustomerName : "Khách lẻ",
                        TotalPrice = (decimal?)b.TotalPrice ?? 0m,
                        EmployeeName = bLL_Employee.GetById(b.EmployeeId)?.EmployeeName
                    })
                    .OrderByDescending(b => b.CreateDate)
                    .ToList();
                // Đổ dữ liệu Doanh Thu
                int rowDoanhThu = 2;
                foreach (var item in billData)
                {
                    worksheetDoanhThu.Cells[rowDoanhThu, 1].Value = item.Id;
                    worksheetDoanhThu.Cells[rowDoanhThu, 2].Value = item.CreateDate;
                    worksheetDoanhThu.Cells[rowDoanhThu, 3].Value = item.CustomerName;
                    worksheetDoanhThu.Cells[rowDoanhThu, 4].Value = item.TotalPrice;
                    worksheetDoanhThu.Cells[rowDoanhThu, 5].Value = item.EmployeeName;
                    rowDoanhThu++;
                }
                // Định dạng Doanh Thu
                worksheetDoanhThu.Cells[1, 1, rowDoanhThu - 1, 5].AutoFitColumns();
                worksheetDoanhThu.Cells[1, 1, 1, 5].Style.Font.Bold = true;
                worksheetDoanhThu.Cells[1, 1, rowDoanhThu - 1, 5].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                // Sheet 2: Nguyên Liệu
                var worksheetNguyenLieu = package.Workbook.Worksheets.Add($"NguyenLieu_{SelectedMonth}_{SelectedYear}");
                // Tiêu đề cột Nguyên Liệu
                worksheetNguyenLieu.Cells[1, 1].Value = "ID Nguyên Liệu";
                worksheetNguyenLieu.Cells[1, 2].Value = "Tên Nguyên Liệu";
                worksheetNguyenLieu.Cells[1, 3].Value = "Tổng Số Lượng";
                worksheetNguyenLieu.Cells[1, 4].Value = "Đơn Giá";
                worksheetNguyenLieu.Cells[1, 5].Value = "Ngày Nhận";
                // Lấy dữ liệu Nguyên Liệu
                int selectedMonth = cbMonth.SelectedIndex + 1;
                int selectedYear = int.Parse(cbYear.Text);
                var ingredientData = bLL_StockReceipt.GetAll()
                    .Where(s => s.ReceiptDate.Month == selectedMonth &&
                               s.ReceiptDate.Year == selectedYear &&
                               s.Ingredient != null)
                    .GroupBy(s => s.IngredientId)
                    .Select(g => new
                    {
                        IngredientId = g.Key,
                        IngredientName = g.First().Ingredient?.IngredientName ?? "Không xác định",
                        TotalQuantity = g.Sum(x => x.Quantity),
                        UnitPrice = g.First().UnitPrice,
                        ReceiptDate = g.First().ReceiptDate.ToString("dd/MM/yyyy")
                    })
                    .ToList();
                // Đổ dữ liệu Nguyên Liệu
                int rowNguyenLieu = 2;
                foreach (var item in ingredientData)
                {
                    worksheetNguyenLieu.Cells[rowNguyenLieu, 1].Value = item.IngredientId;
                    worksheetNguyenLieu.Cells[rowNguyenLieu, 2].Value = item.IngredientName;
                    worksheetNguyenLieu.Cells[rowNguyenLieu, 3].Value = item.TotalQuantity;
                    worksheetNguyenLieu.Cells[rowNguyenLieu, 4].Value = item.UnitPrice;
                    worksheetNguyenLieu.Cells[rowNguyenLieu, 5].Value = item.ReceiptDate;
                    rowNguyenLieu++;
                }
                // Định dạng Nguyên Liệu
                worksheetNguyenLieu.Cells[1, 1, rowNguyenLieu - 1, 5].AutoFitColumns();
                worksheetNguyenLieu.Cells[1, 1, 1, 5].Style.Font.Bold = true;
                worksheetNguyenLieu.Cells[1, 1, rowNguyenLieu - 1, 5].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                // Sheet 3: Nhân Viên
                var worksheetNhanVien = package.Workbook.Worksheets.Add($"NhanVien_{SelectedMonth}_{SelectedYear}");
                // Tiêu đề cột Nhân Viên
                worksheetNhanVien.Cells[1, 1].Value = "Mã";
                worksheetNhanVien.Cells[1, 2].Value = "Tên Nhân Viên";
                worksheetNhanVien.Cells[1, 3].Value = "Giới Tính";
                worksheetNhanVien.Cells[1, 4].Value = "Chức Vụ";
                worksheetNhanVien.Cells[1, 5].Value = "Số Điện Thoại";
                worksheetNhanVien.Cells[1, 6].Value = "Lương/Giờ";
                worksheetNhanVien.Cells[1, 7].Value = "Tổng Giờ";
                worksheetNhanVien.Cells[1, 8].Value = "Tổng Lương";
                // Lấy dữ liệu Nhân Viên
                var employeeData = bLL_Attendance.GetAll()
                    .Where(a => a.CheckIn.HasValue &&
                               a.CheckOut.HasValue &&
                               a.Employee != null &&
                               a.CheckIn.Value.Month == selectedMonth &&
                               a.CheckIn.Value.Year == selectedYear)
                    .GroupBy(a => a.EmployeeId)
                    .Select(g => new
                    {
                        EmployeeId = g.Key,
                        EmployeeName = g.First().Employee?.EmployeeName,
                        Gender = g.First().Employee?.Gender,
                        Role = g.First().Employee?.Role,
                        Phone = g.First().Employee?.Phone,
                        SalaryPerHour = g.First().Employee?.SalaryPerHour ?? 0m,
                        TotalHours = g.Sum(a => (a.CheckOut.Value - a.CheckIn.Value).TotalHours + (double)(a.OvertimeHours ?? 0)),
                        TotalSalary = g.Sum(a => (decimal)((a.CheckOut.Value - a.CheckIn.Value).TotalHours + (double)(a.OvertimeHours ?? 0)) * (g.First().Employee?.SalaryPerHour ?? 0m))
                    })
                    .ToList();
                // Đổ dữ liệu Nhân Viên
                int rowNhanVien = 2;
                foreach (var item in employeeData)
                {
                    worksheetNhanVien.Cells[rowNhanVien, 1].Value = item.EmployeeId;
                    worksheetNhanVien.Cells[rowNhanVien, 2].Value = item.EmployeeName;
                    worksheetNhanVien.Cells[rowNhanVien, 3].Value = item.Gender;
                    worksheetNhanVien.Cells[rowNhanVien, 4].Value = item.Role;
                    worksheetNhanVien.Cells[rowNhanVien, 5].Value = item.Phone;
                    worksheetNhanVien.Cells[rowNhanVien, 6].Value = item.SalaryPerHour;
                    worksheetNhanVien.Cells[rowNhanVien, 7].Value = Math.Round(item.TotalHours, 2);
                    worksheetNhanVien.Cells[rowNhanVien, 8].Value = item.TotalSalary;
                    rowNhanVien++;
                }
                // Định dạng Nhân Viên
                worksheetNhanVien.Cells[1, 1, rowNhanVien - 1, 8].AutoFitColumns();
                worksheetNhanVien.Cells[1, 1, 1, 8].Style.Font.Bold = true;
                worksheetNhanVien.Cells[1, 1, rowNhanVien - 1, 8].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);

                // Lưu file
                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    FileName = $"BaoCaoTaiChinh_{SelectedMonth}_{SelectedYear}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, package.GetAsByteArray());
                    MessageBox.Show("Xuất file Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportBillDataToExcel();
        }
        private void DrawFinancialPieChart()
        {
            decimal doanhThu = LaySo(txtDoanhThu);
            decimal luongNV = LaySo(txtLuongNV);
            decimal nguyenLieu = LaySo(txtTienNguyenLieu);
            decimal dienNuoc = LaySo(txtDienNuoc);
            decimal matBang = LaySo(txtMatBang);
            decimal chiPhiKhac = LaySo(txtChiPhiKhac);
            decimal loiNhuan = doanhThu - luongNV - nguyenLieu - dienNuoc - matBang - chiPhiKhac;

            var items = new List<(string label, decimal value, Color color)>
    {
        ("Doanh thu",       doanhThu,     Color.FromArgb(0, 180, 0)),
        ("Lương nhân viên", luongNV,      Color.FromArgb(220, 53, 69)),
        ("Nguyên liệu",     nguyenLieu,   Color.FromArgb(255, 140, 0)),
        ("Điện nước",       dienNuoc,     Color.FromArgb(30, 144, 255)),
        ("Mặt bằng",        matBang,      Color.FromArgb(255, 215, 0)),
        ("Chi phí khác",    chiPhiKhac,   Color.FromArgb(128, 128, 128)),
        (loiNhuan >= 0 ? "Lợi nhuận" : "Lỗ", Math.Abs(loiNhuan),
         loiNhuan >= 0 ? Color.FromArgb(0, 123, 255) : Color.FromArgb(220, 53, 69))
    };

            items = items.Where(x => x.value > 0).ToList();
            decimal total = items.Sum(x => x.value);

            // Tạo Bitmap và vẽ trực tiếp (không dùng Clone trong using)
            Bitmap bmp = new Bitmap(picChart.Width, picChart.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

                if (total == 0)
                {
                    using (Font f = new Font("Segoe UI", 18, FontStyle.Bold))
                        g.DrawString("Chưa có dữ liệu tài chính", f, Brushes.Gray,
                            picChart.Width / 2, picChart.Height / 2,
                            new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    picChart.Image = bmp;
                    return;
                }

                float startAngle = 0;
                int centerX = picChart.Width / 2;
                int centerY = picChart.Height / 2 - 20;
                int radius = Math.Min(picChart.Width - 100, picChart.Height - 150) / 2;

                // Vẽ từng lát
                for (int i = 0; i < items.Count; i++)
                {
                    float sweepAngle = (float)(items[i].value / total * 360);
                    using (SolidBrush brush = new SolidBrush(items[i].color))
                        g.FillPie(brush, centerX - radius, centerY - radius, radius * 2, radius * 2, startAngle, sweepAngle);

                    // Nhãn + tiền + phần trăm
                    float midAngle = startAngle + sweepAngle / 2;
                    double rad = midAngle * Math.PI / 180;
                    int labelX = centerX + (int)(radius * 0.55 * Math.Cos(rad));
                    int labelY = centerY + (int)(radius * 0.55 * Math.Sin(rad));

                    string text = $"{items[i].label}\n{items[i].value:N0}₫\n{(items[i].value / total * 100):F1}%";
                    using (Font f = new Font("Segoe UI", 8.5f, FontStyle.Bold))
                    using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
                        g.DrawString(text, f, Brushes.White, labelX, labelY, sf);

                    startAngle += sweepAngle;
                }

                // Tiêu đề
                using (Font titleFont = new Font("Segoe UI", 16, FontStyle.Bold))
                using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Center })
                    g.DrawString($"Cơ cấu tài chính tháng {SelectedMonth:D2}/{SelectedYear}", titleFont, Brushes.Black, picChart.Width / 2, 30, sf);

                // Legend
                int legendY = centerY + radius + 40;
                for (int i = 0; i < items.Count; i++)
                {
                    g.FillRectangle(new SolidBrush(items[i].color), 100, legendY + i * 28, 20, 20);
                    g.DrawRectangle(Pens.Black, 100, legendY + i * 28, 20, 20);
                    g.DrawString($"{items[i].label}: {items[i].value:N0}₫ ({(items[i].value / total * 100):F1}%)",
                        new Font("Segoe UI", 10), Brushes.Black, 130, legendY + i * 28 + 2);
                }
            }

            // Gán ảnh (chỉ gán 1 lần ở ngoài using)
            picChart.Image = bmp;
        }

        private void picChart_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuChiPhi_Click(object sender, EventArgs e)
        {
            try
            {
                var fin = new Financial
                {
                    BranchId = bLL_Branch.GetAll().FirstOrDefault()?.Id,
                    ReportMonth = SelectedMonth,
                    ReportYear = SelectedYear,
                    ElectricityCost = LaySo(txtDienNuoc),
                    WaterCost = 0,
                    RentCost = LaySo(txtMatBang),
                    OtherCost = LaySo(txtChiPhiKhac)
                };

                bLL_Financial.Update(fin);  // ← void, không cần kiểm tra true/false

                MessageBox.Show("Lưu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                daLuuThangNay = true;
                cheDoSua = false;
                LoadChiPhiCoDinh(); // sẽ đọc lại từ DB → luôn luôn đúng
                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaChiPhi_Click(object sender, EventArgs e)
        {
            cheDoSua = true;
            UpdateButtonStates();

            MessageBox.Show("Bạn đang ở chế độ sửa. Hãy nhập các chi phí mới và bấm Cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
