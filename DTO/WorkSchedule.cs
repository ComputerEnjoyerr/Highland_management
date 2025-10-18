using System;
using System.Collections.Generic;
<<<<<<< HEAD

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
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
