using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill
    {
        private string _id, _branchId, _employeeId, _customerId;
        private int _tableId, _status;
        private DateTime _createdDate;

        public Bill(string id, string branchId, string employeeId, string customerId, int tableId, int status, DateTime createdDate)
        {
            Id = id;
            BranchId = branchId;
            EmployeeId = employeeId;
            CustomerId = customerId;
            TableId = tableId;
            Status = status;
            CreatedDate = createdDate;
        }

        public string Id { get => _id; set => _id = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string CustomerId { get => _customerId; set => _customerId = value; }
        public int TableId { get => _tableId; set => _tableId = value; }
        public int Status { get => _status; set => _status = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
    }
}
