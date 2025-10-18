using System;
using System.Collections.Generic;

namespace DTO;

public partial class Attendance
{
    public string Id { get; set; } = null!;

    public string? EmployeeId { get; set; }

    public string? ShiftId { get; set; }

    public string? BranchId { get; set; }

    public DateTime? CheckIn { get; set; }

    public DateTime? CheckOut { get; set; }

    public string? Status { get; set; }

    public string? Method { get; set; }

    public string? ApprovedBy { get; set; }

    public string? Note { get; set; }

    public virtual Employee? ApprovedByNavigation { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual WorkShift? Shift { get; set; }
}
