using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class BranchEmployee
{
    public string EmployeeId { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
