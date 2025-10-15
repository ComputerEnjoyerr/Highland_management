using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BranchEmployee
    {
        private string _employeeId, _branchId;
        private DateTime _startDate, _endDate;

        public BranchEmployee(string  employeeId, string branchId, DateTime startDate, DateTime endDate)
        {
            EmployeeId = employeeId;
            StartDate = startDate;
            EndDate = endDate;
            BranchId = branchId;
        }

        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
    }
}
