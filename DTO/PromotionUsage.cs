using System;
using System.Collections.Generic;


namespace DTO;

public partial class PromotionUsage
{
    public string PromotionId { get; set; } = null!;

    public string BillId { get; set; } = null!;

    public DateOnly? UsedDate { get; set; }

    public decimal? DiscountAmount { get; set; }

    public virtual Bill Bill { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;

}
