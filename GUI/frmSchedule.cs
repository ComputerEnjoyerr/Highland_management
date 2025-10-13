using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
        }
        public int month, year;

        private void showDay(int month, int year)
        {
            // Xóa lịch cũ
            flpSchedule.Controls.Clear();
            this.month = month;
            this.year = year;

            // Hiển thị tiêu đề tháng
            lbMonthDisplay.Text = $"Tháng {month}, năm {year}";

            // Ngày đầu tháng
            DateTime startOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);

            // Lấy thứ của ngày đầu tiên trong tháng (0 = Chủ nhật, 1 = Thứ 2,...)
            int dayOfWeek = (int)startOfMonth.DayOfWeek;

            // Nếu bạn muốn lịch bắt đầu từ Thứ Hai, đổi lại:
            if (dayOfWeek == 0)
                dayOfWeek = 7; // Chủ nhật thành 7

            // Tạo các ô trống trước ngày 1 (để căn đúng thứ)
            for (int i = 1; i < dayOfWeek; i++)
            {
                ctrDayBox blank = new ctrDayBox("", month, year);
                flpSchedule.Controls.Add(blank);
                blank.ButtonClicked += ctrDayBox_ButtonClicked;
            }

            // Tạo các ô ngày trong tháng
            for (int day = 1; day <= daysInMonth; day++)
            {
                ctrDayBox dayBox = new ctrDayBox(day.ToString(), month, year);
                flpSchedule.Controls.Add(dayBox);
                dayBox.ButtonClicked += ctrDayBox_ButtonClicked;
            }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            showDay(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void ctrDayBox_ButtonClicked(object sender, EventArgs e)
        {
            var dayBox = sender as ctrDayBox;
            if (dayBox != null && !string.IsNullOrEmpty(dayBox.DayText))
            {

                frmScheduleInfo fr = new frmScheduleInfo(dayBox.DayText, dayBox.Month.ToString("##"), dayBox.Year);
                fr.ShowDialog();
            }
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            this.month--;
            if (this.month < 1)
            {
                this.month = 12;
                this.year--;
            }
            showDay(this.month, this.year);
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            this.month++;
            if (this.month > 12)
            {
                this.month = 1;
                this.year++;
            }
            showDay(this.month, this.year);
        }
    }
}
