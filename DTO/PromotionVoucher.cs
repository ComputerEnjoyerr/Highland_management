using System;
using System.Collections.Generic;


namespace DTO;

public partial class PromotionVoucher
{
    public string PromotionId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public DateOnly? UsedDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;

}
