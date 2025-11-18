using System;
using System.Collections.Generic;

namespace DTO;

public partial class Notification
{
    public string Id { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? TargetRole { get; set; }

    public string? BranchId { get; set; }

    public string? EmployeeId { get; set; }

    public bool IsRead { get; set; } = false;

    public DateTime? CreatedAt { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Employee? Employee { get; set; }
}
