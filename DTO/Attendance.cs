using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Attendance
    {
        private string _id, _employeeId, shiftId, _branchId, _status, _method, _approvedBy, _note;
        private DateTime _checkIn, _checkOut;

        public Attendance(string id, string employeeId, string shiftId, string branchId, string status, string method, string approvedBy, string note, DateTime checkIn, DateTime checkOut)
        {
            Id = id;
            EmployeeId = employeeId;
            ShiftId = shiftId;
            BranchId = branchId;
            Status = status;
            Method = method;
            ApprovedBy = approvedBy;
            Note = note;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public string Id { get => _id; set => _id = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string ShiftId { get => shiftId; set => shiftId = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public string Status { get => _status; set => _status = value; }
        public string Method { get => _method; set => _method = value; }
        public string ApprovedBy { get => _approvedBy; set => _approvedBy = value; }
        public string Note { get => _note; set => _note = value; }
        public DateTime CheckIn { get => _checkIn; set => _checkIn = value; }
        public DateTime CheckOut { get => _checkOut; set => _checkOut = value; }
    }
}
