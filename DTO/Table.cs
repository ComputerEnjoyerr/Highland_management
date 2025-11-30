using System;
using System.Collections.Generic;

namespace DTO;

public partial class Table
{
    public int Id { get; set; }

    public string? TableName { get; set; }

    public string BranchId { get; set; } = null!;

    public int? Capacity { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual Branch Branch { get; set; } = null!;
}
