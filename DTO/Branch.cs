using System;
using System.Collections.Generic;
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

}
