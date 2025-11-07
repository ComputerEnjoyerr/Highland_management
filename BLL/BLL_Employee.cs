using DAL;
using DTO;
using Microsoft.EntityFrameworkCore;
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
        private readonly DAL_ShiftAssignment dAL_ShiftAssignment = new();
        private readonly DAL_Account dAL_Account = new();
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
            if (!ValidateInput(employee).IsValid)
                throw new Exception($"{ValidateInput(employee).Message}");
            dAL_Employee.Add(employee);
        }

        public void Delete(string id)
        {
            // Kiểm tra xem nhân viên này có đang được phân ca làm việc hay không
            var hasShift = dAL_ShiftAssignment
                .GetAll()
                .Any(sa => sa.EmployeeId == id);

            if (hasShift)
                throw new Exception("Không thể xóa nhân viên đang đăng ký lịch làm việc!");

            // Kiểm tra nhân viên có tài khoản đăng nhập
            bool hasAccount = dAL_Account.GetAll().Any(a => a.EmployeeId == id);
            if (hasAccount)
                throw new Exception("Không thể xóa nhân viên đang có tài khoản hệ thống (Admin, Nhân viên hoặc Quản lý)!");

            // Nếu không có lịch làm việc -> cho phép xóa
            var emp = dAL_Employee.GetById(id);
            if (emp == null)
                throw new Exception("Không tìm thấy nhân viên cần xóa!");

            dAL_Employee.Delete(id);
        }

        public void Update(Employee employee)
        {
            if (!ValidateInput(employee).IsValid)
                throw new Exception($"{ValidateInput(employee).Message}");

            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(employee.EmployeeName))
                throw new Exception("Tên nhân viên không được để trống.");
            if (employee.EmployeeName.Length > 30)
                throw new Exception("Tên nhân viên không được vượt quá 30 ký tự.");

            // Kiểm tra lương
            if (employee.SalaryPerHour < 0)
                throw new Exception("Lương nhân viên không được âm.");
            if (!decimal.TryParse(employee.SalaryPerHour.ToString(), out _))
                throw new Exception("Lương phải là số hợp lệ.");

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(employee.Phone))
                throw new Exception("Số điện thoại không được để trống.");
            if (employee.Phone.Length > 15)
                throw new Exception("Số điện thoại không được vượt quá 15 ký tự.");
            var allEmployee = dAL_Employee.GetAll();
            if (allEmployee.Any(e => e.Phone == employee.Phone && e.Id != employee.Id))
                throw new Exception("Số điện thoại này đã được nhân viên khác sử dụng!");
            dAL_Employee.Update(employee);
        }

        // Hàm lấy danh sách nhân viên theo chi nhánh
        public List<Employee> GetEmployeesByBranchId(string branchId)
        {
            var employees = dAL_Employee.GetAll().Where(e => e.BranchId == branchId).ToList();
            if (employees == null)
            {
                return new List<Employee>();
            }
            return employees;
        }

        // Hàm xét dữ liệu nhân viên có hợp lệ hay không
        private void ValidateEmployee(Employee employee)
        {
            // Kiểm tra tên nhân viên
            if (string.IsNullOrWhiteSpace(employee.EmployeeName))
                throw new Exception("Tên nhân viên không được để trống.");
            //if (dAL_Employee.IsEmployeeNameExists(employee.EmployeeName))
            //    throw new Exception("Tên nhân viên đã tồn tại.");
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
            if (!decimal.TryParse(employee.SalaryPerHour.ToString(), out _))
                throw new Exception("Lương phải là số hợp lệ.");

            // Kiểm tra số điện thoại
            if (string.IsNullOrWhiteSpace(employee.Phone))
                throw new Exception("Số điện thoại không được để trống.");
            if (employee.Phone.Length > 15)
                throw new Exception("Số điện thoại không được vượt quá 15 ký tự.");
            var allEmployee = dAL_Employee.GetAll();
            if (allEmployee.Any(e => e.Phone == employee.Phone && e.Id != employee.Id))
                throw new Exception("Số điện thoại này đã được nhân viên khác sử dụng!");

            // Kiểm tra CMND/CCCD
            if (string.IsNullOrWhiteSpace(employee.CitizenId))
                throw new Exception("Căn cước công dân không được để trống.");
            if (employee.CitizenId.Length > 20)
                throw new Exception("Căn cước công dân không được vượt quá 20 ký tự.");
            var allEmployees = dAL_Employee.GetAll();
            if (allEmployees.Any(e => e.CitizenId == employee.CitizenId && e.Id != employee.Id))
                throw new Exception("Căn cước công dân này đã được nhân viên khác sử dụng!");
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

        // Hàm kiểm tra trùng lặp tên nhân viên
        public bool IsEmployeeNameExists(string employeeName)
        {
            return dAL_Employee.IsEmployeeNameExists(employeeName);
        }

        // Hàm kt trùng số điện thoại chi nhánh
        public Employee GetEmployeeByPhone(string phone, string id = null)
        {
            var existing = dAL_Employee.GetById(id);
            var existingPhone = dAL_Employee.GetAll()
                .FirstOrDefault(e => e.Phone == phone);
            if (existingPhone == null)
            {
                return null;
            }
            if (existing != null)
            {
                return null;
            }
            return existingPhone;
        }

        private (bool IsValid, string Message) ValidateInput(Employee e)
        {
            if (!ValidationData.IsValidName(e.EmployeeName))
                return (false, "Tên nhân viên không hợp lệ.");

            if (!ValidationData.IsValidCitizenId(e.CitizenId))
                return (false, "Căn cước công dân của nhân viên không hợp lệ.");

            if (!ValidationData.IsValidPhone(e.Phone))
                return (false, "Số điện thoại không hợp lệ.");

            if (!ValidationData.IsValidAddress(e.AddressId))
                return (false, "Địa chỉ nhân viên không hợp lệ.");

            if (!ValidationData.IsValidGender(e.Gender))
                return (false, "Giới tính không hợp lệ");

            if (!ValidationData.IsValidDateOfBirth(e.DateOfBirth))
                return (false, "Ngày sinh không hợp lệ.");

            if (!ValidationData.IsValidRole(e.Role))
                return (false, "Chức vụ không hợp lệ.");

            if (!ValidationData.IsValidDecimal(e.SalaryPerHour))
                return (false, "Lương nhân viên không hợp lệ.");

            if (!ValidationData.IsValidStatus(e.CurrentStatus))
                return (false, "Trạng thái nhân viên không hợp lệ.");

            return (true, "Dữ liệu hợp lệ.");
        }
    }
}
