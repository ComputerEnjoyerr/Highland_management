using System;
using System.Collections.Generic;


namespace DTO;

public partial class WorkShift
{
    public string Id { get; set; } = null!;

    public string? ScheduleId { get; set; }

    public DateOnly WorkDate { get; set; }

    public string? ShiftType { get; set; }

    public TimeOnly StartTime { get; set; }

    public TimeOnly EndTime { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual WorkSchedule? Schedule { get; set; }

    public virtual ICollection<ShiftAssignment> ShiftAssignments { get; set; } = new List<ShiftAssignment>();

}
