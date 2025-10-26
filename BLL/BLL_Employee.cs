using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Employee
    {
        private readonly DAL_Employee dAL_Employee = new();
        public List<Employee> GetAll()
        {
            return dAL_Employee.GetAll();
        }
        public Employee? GetById(string id)
        {
            return dAL_Employee.GetById(id);
        }

        public void Add(Employee employee)
        {
            ValidateEmployee(employee);
            dAL_Employee.Add(employee);
        }

        public void Delete(string id)
        {
            dAL_Employee.Delete(id);
        }

        public void Update(Employee employee)
        {
            dAL_Employee.Update(employee);
        }

        // Hàm lấy danh sách nhân viên theo chi nhánh
        public List<Employee> GetEmployeesByBranchId(string branchId)
        {
            return dAL_Employee.GetAll().Where(e => e.BranchId == branchId).ToList();
        }

        // Hàm xét dữ liệu nhân viên có hợp lệ hay không
        private void ValidateEmployee(Employee employee)
        {
            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(employee.EmployeeName))
                throw new Exception("Tên nhân viên không được để trống.");
            if (dAL_Employee.IsEmployeeNameExists(employee.EmployeeName))
                throw new Exception("Tên nhân viên đã tồn tại.");
            if (employee.EmployeeName.Length > 30)
                throw new Exception("Tên nhân viên không được vượt quá 30 ký tự.");

            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(employee.AddressId))
                throw new Exception("Nhân viên phải có mã địa chỉ hợp lệ.");

            // Kiểm tra trạng thái
            if (string.IsNullOrWhiteSpace(employee.Role))
                throw new Exception("Chức vụ nhân viên không được để trống.");

            // Kiểm tra lương
            if (employee.SalaryPerHour < 0)
                throw new Exception("Lương nhân viên không được âm.");

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(employee.Phone))
                throw new Exception("Số điện thoại không được để trống.");
            if (employee.Phone.Length > 15)
                throw new Exception("Số điện thoại không được vượt quá 15 ký tự.");
            var allEmployee = dAL_Employee.GetAll();
            if (allEmployee.Any(e => e.Phone == employee.Phone && e.Id != employee.Id))
                throw new Exception("Số điện thoại này đã được nhân viên khác sử dụng!");
        }

        // Hàm tạo mã cho nhân viên mới (định dạng: NVyyMMxxxx)
        public string GenerateEmployeeId()
        {
            string prefix = "NV" + DateTime.Now.ToString("yyMM"); // Ví dụ: NV2510

            // Lấy danh sách nhân viên có Id bắt đầu bằng prefix
            var employeesThisMonth = dAL_Employee.GetAll()
                .Where(e => e.Id.StartsWith(prefix))
                .ToList();

            // Tìm số thứ tự lớn nhất trong tháng
            int nextNumber = 1;
            if (employeesThisMonth.Any())
            {
                string lastId = employeesThisMonth
                    .OrderByDescending(e => e.Id)
                    .First().Id;

                // Lấy 4 số cuối từ mã cuối cùng
                string numberPart = lastId.Substring(6, 4);
                if (int.TryParse(numberPart, out int currentNumber))
                {
                    nextNumber = currentNumber + 1;
                }
            }

            // Sinh mã mới
            string newId = $"{prefix}{nextNumber:D4}"; // Ví dụ: NV25100001
            return newId.Length > 10 ? newId.Substring(0, 10) : newId;
        }

    }
}
