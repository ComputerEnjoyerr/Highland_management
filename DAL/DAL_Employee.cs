using DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
                .Include(e => e.ShiftAssignments)
                .ThenInclude(s => s.Shift)
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

        // Hàm in report chi nhánh
        public DataTable GetEmployeeByFilter(string? accountId)
        {
            var sql = @"
            SELECT 
                E.Id AS EmployeeId,
                E.EmployeeName,
                E.CitizenId,
                E.Phone,
                E.Gender,
                E.DateOfBirth,
                E.Role,
                E.HireDate,
                E.CurrentStatus,

                A.Name AS AddressName,
                W.WardName,
                P.ProvinceName,

                B.Id AS BranchId,
                B.BranchName,
                BA.Name AS BranchAddressName,
                BW.WardName AS BranchWard,
                BP.ProvinceName AS BranchProvince

            FROM EMPLOYEE E
            JOIN EMPLOYEE ER ON ER.BranchId = E.BranchId
            JOIN ACCOUNT ACC ON ACC.EmployeeId = ER.Id 
                            AND ACC.Id = @AccountId

            LEFT JOIN ADDRESS A ON A.Id = E.AddressId
            LEFT JOIN WARD W ON W.Id = A.WardId
            LEFT JOIN PROVINCE P ON P.Id = W.ProvinceId

            JOIN BRANCH B ON B.Id = E.BranchId
            LEFT JOIN ADDRESS BA ON BA.Id = B.AddressId
            LEFT JOIN WARD BW ON BW.Id = BA.WardId
            LEFT JOIN PROVINCE BP ON BP.Id = BW.ProvinceId

            WHERE 
                E.Id <> 'EM_ADMIN';";

            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = sql;

                // Thêm tham số vào lệnh
                cmd.Parameters.Add(new SqlParameter("@AccountId",
                    string.IsNullOrEmpty(accountId) ? DBNull.Value : accountId));

                // Mở kết nối
                _context.Database.OpenConnection();

                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }
    }
}
