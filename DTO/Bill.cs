using System;
using System.Collections.Generic;

namespace DTO;

public partial class Bill
{
    public string Id { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public int TableId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Billinfo> Billinfos { get; set; } = new List<Billinfo>();

    public virtual Branch Branch { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<PromotionUsage> PromotionUsages { get; set; } = new List<PromotionUsage>();

    public virtual Table Table { get; set; } = null!;
}
