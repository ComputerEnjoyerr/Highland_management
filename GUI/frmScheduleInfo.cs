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
    public partial class frmScheduleInfo : Form
    {
        private string month, day;
        private int year;
        public frmScheduleInfo(string day, string month, int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.day = day;

        }

        private void frmScheduleInfo_Load(object sender, EventArgs e)
        {
            this.Text = "Ca làm việc | Ngày " + this.day + " tháng " + this.month + " năm " + this.year;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView4_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmEmployeeSchedule fr = new frmEmployeeSchedule();
            fr.ShowDialog();
        }
    }
}
