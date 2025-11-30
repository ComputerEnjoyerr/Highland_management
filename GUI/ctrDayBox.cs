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
    public partial class ctrDayBox : UserControl
    {
        public string DayText { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }

        public FlowLayoutPanel CaContainer { get; private set; }

        public ctrDayBox(string day, int dayNum, int month, int year)
        {
            InitializeComponent();

            CaContainer.Dock = DockStyle.Fill;
            CaContainer.FlowDirection = FlowDirection.TopDown;
            CaContainer.WrapContents = false;
            CaContainer.AutoScroll = true;
            CaContainer.Padding = new Padding(5, 2, 5, 2);
            CaContainer.AutoSize = false;

            // Hiển thị tiêu đề ngày
            lbDay.Text = day;
            DayText = dayNum.ToString(); 
            Month = month;
            Year = year;

            // Đăng ký sự kiện click
            lbDay.Click += panel1_Click;
        }

        public event EventHandler ButtonClicked;

        private void panel1_Click(object sender, EventArgs e)
        {
            ButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}