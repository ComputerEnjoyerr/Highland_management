using System;
using System.Collections.Generic;


namespace DTO;

public partial class PromotionProduct
{
    public string PromotionId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;

}
