using System;
using System.Collections.Generic;


namespace DTO;

public partial class ShiftAssignment
{
    public string Id { get; set; } = null!;

    public string? ShiftId { get; set; }

    public string? EmployeeId { get; set; }

    public string? Note { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual WorkShift? Shift { get; set; }

}
