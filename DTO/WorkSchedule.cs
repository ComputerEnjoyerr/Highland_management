using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkSchedule
    {
        private string _id, _branchId, _createdBy;
        private DateTime _weekStart, _weekEnd, _createdDate;

        public WorkSchedule() { }
        public WorkSchedule(string id, string branchId, string createdBy, DateTime weekStart, DateTime weekEnd, DateTime createdDate)
        {
            Id = id;
            BranchId = branchId;
            CreatedBy = createdBy;
            WeekStart = weekStart;
            WeekEnd = weekEnd;
            CreatedDate = createdDate;
        }

        public string Id { get => _id; set => _id = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public string CreatedBy { get => _createdBy; set => _createdBy = value; }
        public DateTime WeekStart { get => _weekStart; set => _weekStart = value; }
        public DateTime WeekEnd { get => _weekEnd; set => _weekEnd = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
    }
}
