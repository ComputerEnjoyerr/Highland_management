using System;
using System.Collections.Generic;
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
}
