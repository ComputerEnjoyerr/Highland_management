using System;
using System.Collections.Generic;

namespace DTO;

public partial class Customer
{
    public string Id { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public decimal? Point { get; set; }

    public int? Drips { get; set; }

    public string? Tier { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<PromotionVoucher> PromotionVouchers { get; set; } = new List<PromotionVoucher>();

}
