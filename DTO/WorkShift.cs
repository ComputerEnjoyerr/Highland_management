using System;
using System.Collections.Generic;
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
}
