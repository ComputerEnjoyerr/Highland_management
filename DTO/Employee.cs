using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Employee
{
    public string Id { get; set; } = null!;

    public string EmployeeName { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public string? AddressId { get; set; }

    public string Phone { get; set; } = null!;

    public DateOnly? HireDate { get; set; }

    public decimal SalaryPerHour { get; set; }

    public string? Role { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Attendance> AttendanceApprovedByNavigations { get; set; } = new List<Attendance>();

    public virtual ICollection<Attendance> AttendanceEmployees { get; set; } = new List<Attendance>();

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Branch Branch { get; set; } = null!;

    public virtual ICollection<BranchEmployee> BranchEmployees { get; set; } = new List<BranchEmployee>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<ShiftAssignment> ShiftAssignments { get; set; } = new List<ShiftAssignment>();

    public virtual ICollection<WorkSchedule> WorkSchedules { get; set; } = new List<WorkSchedule>();
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        private string _id, _name, _branchId, _addressId, _phone, _role;
        private DateTime _hiredDate;
        private decimal _salaryPerHour;

        public Employee(string id, string name, string branchId, string addressId, string phone, string role, DateTime hiredDate, decimal salaryPerHour)
        {
            Id = id;
            Name = name;
            BranchId = branchId;
            AddressId = addressId;
            Phone = phone;
            Role = role;
            HiredDate = hiredDate;
            SalaryPerHour = salaryPerHour;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public string AddressId { get => _addressId; set => _addressId = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Role { get => _role; set => _role = value; }
        public DateTime HiredDate { get => _hiredDate; set => _hiredDate = value; }
        public decimal SalaryPerHour { get => _salaryPerHour; set => _salaryPerHour = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
