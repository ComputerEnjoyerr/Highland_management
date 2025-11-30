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
    public partial class frmEmployeeList : Form
    {

        public Employee SelectedEmployee = new Employee();
        private readonly BLL_Employee bLL_Employee = new BLL_Employee();
        private List<Employee> employees = new List<Employee>();
        private CancellationTokenSource _cts = new();
        public frmEmployeeList()
        {
            InitializeComponent();
        }

        private void LoadEmployee(string keyword = "")
        {
            var filteredList = bLL_Employee.GetAll()
                .Where(emp =>
                    emp.EmployeeName.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                    emp.Phone.Contains(keyword, StringComparison.OrdinalIgnoreCase)||
                    emp.Gender.Contains(keyword,StringComparison.OrdinalIgnoreCase))
                .ToList();

            employees = filteredList;

            var displayList = employees.Select(emp => new
            {
                emp.EmployeeName,
                emp.CitizenId,
                emp.Gender,
                emp.Phone,
                emp.Role,
                emp.SalaryPerHour
            }).ToList();

            dataGridView1.DataSource = displayList;
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            try
            {
                await Task.Delay(500, _cts.Token); // debounce 0.5s
                LoadEmployee(input);
            }
            catch (TaskCanceledException)
            {
                // người dùng vẫn đang gõ, bỏ qua
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < employees.Count)
            {
                SelectedEmployee = employees[e.RowIndex];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;

            LoadEmployee();
        }
    }
}
