using System;
using System.Collections.Generic;


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

}
