using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Employee
    {
        private readonly HighlandsContext _context = new();

        public List<Employee> GetAll()
        {
            return _context.Employees
                .Include(e => e.Branch)
                .Include(e => e.Address)
                .ThenInclude(e => e.Ward)
                .ThenInclude(e => e.Province)
                .ToList();
        }

        public Employee? GetById(string id)
        {
            return _context.Employees
                .Include(e => e.Branch)
                .Include(e => e.Address)
                .ThenInclude(a => a.Ward)
                .ThenInclude(w => w.Province)
                .FirstOrDefault(e => e.Id == id);
        }

        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }   
        }

        public void Update(Employee employee)
        {
            var existing = _context.Employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existing != null)
            {
                existing.CitizenId = employee.CitizenId;
                existing.EmployeeName = employee.EmployeeName;
                existing.Phone = employee.Phone;
                existing.BranchId = employee.BranchId;
                existing.AddressId = employee.AddressId;
                existing.DateOfBirth = employee.DateOfBirth;
                existing.Gender = employee.Gender;
                existing.HireDate = employee.HireDate;
                existing.SalaryPerHour = employee.SalaryPerHour;
                existing.Role = employee.Role;
                existing.CurrentStatus = employee.CurrentStatus;
                _context.SaveChanges();
            }
        }

        // Hàm lấy danh sách nhân viên theo chi nhánh
        public List<Employee> GetByBranchId(string branchId)
        {
            return _context.Employees
                .Where(e => e.BranchId == branchId)
                .ToList();
        }

        // Hàm kiểm tra tên nhân viên đã tồn tại hay chưa
        public bool IsEmployeeNameExists(string employeeName)
        {
            return _context.Employees.Any(e => e.EmployeeName == employeeName);
        }
    }
}
