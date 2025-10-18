using System;
using System.Collections.Generic;


namespace DTO;

public partial class PromotionProgram
{
    public string PromotionId { get; set; } = null!;

    public string? CategoryId { get; set; }

    public DateOnly? StartDate { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Promotion Promotion { get; set; } = null!;

}
