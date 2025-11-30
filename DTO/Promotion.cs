using System;
using System.Collections.Generic;

namespace DTO;

public partial class Promotion
{
    public string Id { get; set; } = null!;

    public string? PromotionName { get; set; }

    public string? Description { get; set; }

    public string PromotionType { get; set; } = null!;

    public string DiscountType { get; set; } = null!;

    public decimal Value { get; set; }

    public decimal? MaxDiscount { get; set; }

    public int? RequiringPoint { get; set; }

    public int? ExpiryDay { get; set; }

    public virtual ICollection<PromotionProduct> PromotionProducts { get; set; } = new List<PromotionProduct>();

    public virtual PromotionProgram? PromotionProgram { get; set; }

    public virtual ICollection<PromotionUsage> PromotionUsages { get; set; } = new List<PromotionUsage>();

    public virtual ICollection<PromotionVoucher> PromotionVouchers { get; set; } = new List<PromotionVoucher>();
}
