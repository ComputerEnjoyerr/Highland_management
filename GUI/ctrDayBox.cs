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
        string day;
        public string DayText { get; private set; }
        public int Month {  get; private set; }
        public int Year { get; private set; }
        public ctrDayBox(string day, int month, int year)
        {
            InitializeComponent();
            this.day = day;
            lbDay.Text = day;
            DayText = day;
            cbSelect.Visible = false;
            Month = month;
            Year = year;
            
        }
        public event EventHandler ButtonClicked;
        private void ctrDayBox_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //if (!cbSelect.Checked)
            //{
            //    cbSelect.Checked = true;
            //    this.BackColor = Color.Orange;
            //}
            //else
            //{
            //    cbSelect.Checked = false;
            //    this.BackColor = Color.Gray;
            //}

            ButtonClicked?.Invoke(this, EventArgs.Empty); // Gán sự kiện click để dùng cho form chính

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
