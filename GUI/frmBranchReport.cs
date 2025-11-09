using BLL;
using DAL;
using FastReport;
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
    public partial class frmBranchReport : Form
    {
        private readonly BLL_Address bLL_Address = new BLL_Address();
        private readonly BLL_Province bLL_Province = new BLL_Province();
        private readonly BLL_Ward bLL_Ward = new BLL_Ward();
        private readonly BLL_Branch bLL_Branch = new BLL_Branch();
        public frmBranchReport()
        {
            InitializeComponent();
        }

        private void frmBranchReport_Load(object sender, EventArgs e)
        {
            LoadProvince();
        }

        // Hàm nạp dữ liệu cho combobox Tỉnh/Thành phố
        private void LoadProvince()
        {
            var provinces = bLL_Province.GetAllProvinces();
            cboProvince.DataSource = provinces;
            cboProvince.DisplayMember = "ProvinceName";
            cboProvince.ValueMember = "Id";
            cboProvince.SelectedIndex = -1;
        }

        // Hàm nạp dữ liệu cho combobox Quận/Huyện
        private void LoadWard(string provinceId)
        {
            var wards = bLL_Ward.GetWardByProvinceId(provinceId);
            cboWard.DataSource = wards;
            cboWard.DisplayMember = "WardName";
            cboWard.ValueMember = "Id";
            cboWard.SelectedIndex = -1;
        }

        private void cboProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvince.SelectedIndex != -1)
            {
                string provinceId = cboProvince.SelectedValue.ToString();
                LoadWard(provinceId);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu lọc từ các ComboBox hoặc TextBox (tuỳ giao diện của bạn)
                string? provinceName = string.IsNullOrWhiteSpace(cboProvince.Text) ? null : cboProvince.Text;
                string? wardName = string.IsNullOrWhiteSpace(cboWard.Text) ? null : cboWard.Text;

                // Lấy dữ liệu từ BLL
                var branchTable = bLL_Branch.GetBranchByFilter(provinceName, wardName);
                branchTable.TableName = "BranchDetail";

                // Đường dẫn tới file báo cáo FastReport
                string reportPath = Path.Combine(Application.StartupPath, @"..\..\..\RPTBranchDetail.frx");
                Report report = new Report();

                report.Dictionary.Connections.Clear();
                report.Load(reportPath);

                // Gán dữ liệu cho báo cáo
                report.RegisterData(branchTable, "BranchDetail");

                // Gán tham số (nếu file report có sử dụng)
                report.SetParameterValue("ProvinceName", provinceName ?? "");
                report.SetParameterValue("WardName", wardName ?? "");

                // Kích hoạt nguồn dữ liệu
                report.GetDataSource("BranchDetail").Enabled = true;

                // Hiển thị báo cáo
                report.Show();
                cboProvince.SelectedIndex = -1;
                cboWard.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất báo cáo chi nhánh: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
