using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using FastReport;
using FastReport.Utils;

namespace GUI
{
    public partial class frmScheduleReport : Form
    {
        private readonly BLL_WorkSchedule bLL_WorkSchedule = new BLL_WorkSchedule();
        public frmScheduleReport()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateTime = dtpScheduleReport.Value;
                var scheduleTable = bLL_WorkSchedule.GetScheduleByDate(dateTime);
                scheduleTable.TableName = "ScheduleDetail";

                // Load report
                string reportPath = Path.Combine(Application.StartupPath, @"..\..\..\RPTScheduleDetail.frx");
                Report report = new Report();

                report.Dictionary.Connections.Clear();

                report.Load(reportPath);
                // Đặt tham số
                report.RegisterData(scheduleTable, "ScheduleDetail");
                // Truyền dữ liệu
                report.SetParameterValue("SelectedDate", dateTime);
                // Kích hoạt nguồn dữ liệu
                report.GetDataSource("ScheduleDetail").Enabled = true;
                // Hiển thị báo cáo
                report.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
