using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Branch
{
    public string Id { get; set; } = null!;

    public string BranchName { get; set; } = null!;

    public string? AddressId { get; set; }

    public string Phone { get; set; } = null!;

    public TimeOnly? OpenTime { get; set; }

    public TimeOnly? CloseTime { get; set; }

    public string? Status { get; set; }

    public virtual Address? Address { get; set; }

    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<BranchEmployee> BranchEmployees { get; set; } = new List<BranchEmployee>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Financial> Financials { get; set; } = new List<Financial>();

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<PromotionProduct> PromotionProducts { get; set; } = new List<PromotionProduct>();

    public virtual ICollection<StockReceipt> StockReceipts { get; set; } = new List<StockReceipt>();

    public virtual ICollection<Table> Tables { get; set; } = new List<Table>();

    public virtual ICollection<WorkSchedule> WorkSchedules { get; set; } = new List<WorkSchedule>();
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Branch
    {
        private string _id, _name, _addressId, _phone, _status;
        private DateTime _openTime, _closeTime;

        public Branch(string id, string name, string addressId, string phone, string status, DateTime openTime, DateTime closeTime)
        {
            Id = id;
            Name = name;
            AddressId = addressId;
            Phone = phone;
            Status = status;
            OpenTime = openTime;
            CloseTime = closeTime;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string AddressId { get => _addressId; set => _addressId = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime OpenTime { get => _openTime; set => _openTime = value; }
        public DateTime CloseTime { get => _closeTime; set => _closeTime = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
