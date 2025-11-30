using BLL;
using DTO;
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
        private Employee employee = new(); // Nhân viên/Quản lý đăng nhập vào tài khoản
        private readonly BLL_WorkShift bLL_WorkShift = new BLL_WorkShift();
        private readonly BLL_ShiftAssignment bLL_ShiftAssignment = new BLL_ShiftAssignment();

        public frmSchedule(Employee em)
        {
            InitializeComponent();
            this.employee = em;
        }
        public int weekNumber, year;

        private void showWeek(int weekNumber, int year)
        {
            flpSchedule.Controls.Clear();

            DateTime startOfWeek = FirstDateOfWeek(year, weekNumber);
            DateOnly start = DateOnly.FromDateTime(startOfWeek);
            DateOnly end = start.AddDays(6);

            lbMonthDisplay.Text = $"Tuần {weekNumber} - Năm {year}";

            var shifts = bLL_WorkShift.GetShiftsByWeek(start, end, employee.BranchId);

            for (int i = 0; i < 7; i++)
            {
                DateOnly day = start.AddDays(i);

                string dayOfWeekName = day.ToDateTime(new TimeOnly())
                                       .ToString("dddd", new CultureInfo("vi-VN"));

                ctrDayBox dayBox = new(
                    dayOfWeekName + " " + day.ToString("dd/MM"),
                    day.Day,
                    day.Month,
                    day.Year
                );

                // Đăng ký sự kiện nút bấm
                dayBox.ButtonClicked += ctrDayBox_ButtonClicked;

                flpSchedule.Controls.Add(dayBox);

                LoadShiftIntoDayBox(dayBox, shifts, day);
            }
        }

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            year = DateTime.Now.Year;
            weekNumber = GetWeekNumber(DateTime.Now);

            showWeek(weekNumber, year);
        }


        private void LoadShiftIntoDayBox(ctrDayBox dayBox, List<WorkShift> shifts, DateOnly date)
        {
            if (dayBox.CaContainer != null)
            {
                dayBox.CaContainer.Controls.Clear();
            }

            string[] shiftTypes = { "Sáng", "Chiều", "Tối" };

            foreach (var type in shiftTypes)
            {
                // Dùng FlowLayoutPanel thay vì Panel
                FlowLayoutPanel pnlShift = new FlowLayoutPanel();
                pnlShift.Width = dayBox.CaContainer.Width - 20;
                pnlShift.AutoSize = true;
                pnlShift.FlowDirection = FlowDirection.TopDown;
                pnlShift.WrapContents = false;
                pnlShift.Padding = new Padding(5, 0, 5, 8);

                // Header ca làm
                Label lblHeader = new Label();
                lblHeader.Text = type + ":";
                lblHeader.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                lblHeader.AutoSize = true;
                lblHeader.Margin = new Padding(0, 0, 0, 2);
                pnlShift.Controls.Add(lblHeader);

                // Tìm ca làm
                var shift = shifts.FirstOrDefault(s =>
                    s.WorkDate == date && s.ShiftType == type
                );

                if (shift == null)
                {
                    Label lbl = new Label()
                    {
                        Text = "   - Chưa tạo ca",
                        AutoSize = true,
                        ForeColor = Color.Gray,
                        Font = new Font("Segoe UI", 8.5F),
                        Margin = new Padding(0, 0, 0, 2)
                    };
                    pnlShift.Controls.Add(lbl);
                }
                else
                {
                    var empList = bLL_ShiftAssignment.GetEmployeesByShift(shift.Id);

                    if (empList.Count == 0)
                    {
                        Label lbl = new Label()
                        {
                            Text = "   - Chưa phân nhân viên",
                            AutoSize = true,
                            ForeColor = Color.DarkOrange,
                            Font = new Font("Segoe UI", 8.5F),
                            Margin = new Padding(0, 0, 0, 2)
                        };
                        pnlShift.Controls.Add(lbl);
                    }
                    else
                    {
                        foreach (var emp in empList)
                        {
                            Label lbl = new Label()
                            {
                                Text = "   • " + emp.EmployeeName,
                                AutoSize = true,
                                Font = new Font("Segoe UI", 8.5F),
                                Margin = new Padding(0, 0, 0, 2),
                                MaximumSize = new Size(pnlShift.Width - 25, 0)
                            };
                            pnlShift.Controls.Add(lbl);
                        }
                    }
                }

                dayBox.CaContainer.Controls.Add(pnlShift);
            }
        }

        private int GetWeekNumber(DateTime date)
        {
            var calendar = CultureInfo.InvariantCulture.Calendar;
            return calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFullWeek, DayOfWeek.Monday);
        }

        private DateTime FirstDateOfWeek(int year, int weekNumber)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Monday - jan1.DayOfWeek;
            DateTime firstMonday = jan1.AddDays(daysOffset);
            return firstMonday.AddDays((weekNumber - 1) * 7);
        }

        private void ctrDayBox_ButtonClicked(object sender, EventArgs e)
        {
            var dayBox = sender as ctrDayBox;

            if (dayBox != null && !string.IsNullOrEmpty(dayBox.DayText))
            {
                frmScheduleInfo fr = new frmScheduleInfo(
                    employee,
                    dayBox.DayText,
                    dayBox.Month.ToString("##"),
                    dayBox.Year,
                    onUpdated: () => showWeek(weekNumber, year)
                );
                fr.ShowDialog();
            }
        }

        private void pbPrev_Click(object sender, EventArgs e)
        {
            weekNumber--;
            if (weekNumber < 1)
            {
                year--;
                weekNumber = 52;
            }

            showWeek(weekNumber, year);
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            weekNumber++;
            if (weekNumber > 52)
            {
                weekNumber = 1;
                year++;
            }

            showWeek(weekNumber, year);
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            frmScheduleReport fr = new frmScheduleReport();
            fr.ShowDialog();
        }
    }
}
