using System;
using System.Collections.Generic;

namespace DTO;

public partial class BranchEmployee
{
    public string EmployeeId { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
}
