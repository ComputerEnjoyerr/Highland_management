using System;
using System.Collections.Generic;


namespace DTO;

public partial class WorkSchedule
{
    public string Id { get; set; } = null!;

    public string? BranchId { get; set; }

    public DateOnly WeekStart { get; set; }

    public DateOnly WeekEnd { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Employee? CreatedByNavigation { get; set; }

    public virtual ICollection<WorkShift> WorkShifts { get; set; } = new List<WorkShift>();

}
