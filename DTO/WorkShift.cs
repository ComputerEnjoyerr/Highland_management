using System;
using System.Collections.Generic;
<<<<<<< HEAD

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
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkShift
    {
        private string _id, _scheduleId, _shiftType;
        private DateTime _workDate, _startTime, _endTime;

        public WorkShift() { }
        public WorkShift(string id, string scheduleId, string shiftType, DateTime workDate, DateTime startTime, DateTime endTime)
        {
            Id = id;
            ScheduleId = scheduleId;
            ShiftType = shiftType;
            WorkDate = workDate;
            StartTime = startTime;
            EndTime = endTime;
        }

        public string Id { get => _id; set => _id = value; }
        public string ScheduleId { get => _scheduleId; set => _scheduleId = value; }
        public string ShiftType { get => _shiftType; set => _shiftType = value; }
        public DateTime WorkDate { get => _workDate; set => _workDate = value; }
        public DateTime StartTime { get => _startTime; set => _startTime = value; }
        public DateTime EndTime { get => _endTime; set => _endTime = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
