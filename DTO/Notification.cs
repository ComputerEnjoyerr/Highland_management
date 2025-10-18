using System;
using System.Collections.Generic;
<<<<<<< HEAD

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

    public bool? IsRead { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Employee? Employee { get; set; }
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Notification
    {
        private string _id, _title, _message, _type, _targerRole, _branchId, _employeeId;
        private bool _isRead;
        private DateTime _createdDate;

        public Notification(string id, string title, string message, string type, string targerRole, string branchId, string employeeId, bool isRead, DateTime createdDate)
        {
            Id = id;
            Title = title;
            Message = message;
            Type = type;
            TargerRole = targerRole;
            BranchId = branchId;
            EmployeeId = employeeId;
            IsRead = isRead;
            CreatedDate = createdDate;
        }

        public string Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Message { get => _message; set => _message = value; }
        public string Type { get => _type; set => _type = value; }
        public string TargerRole { get => _targerRole; set => _targerRole = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public bool IsRead { get => _isRead; set => _isRead = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
