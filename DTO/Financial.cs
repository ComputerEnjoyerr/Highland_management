using System;
using System.Collections.Generic;

namespace DTO;

public partial class Financial
{
    public string ReportId { get; set; } = null!;

    public string? BranchId { get; set; }

    public int ReportMonth { get; set; }

    public int ReportYear { get; set; }

    public decimal? TotalRevenue { get; set; }

    public decimal? IngredientCost { get; set; }

    public decimal? SalaryCost { get; set; }

    public decimal? ElectricityCost { get; set; }

    public decimal? WaterCost { get; set; }

    public decimal? RentCost { get; set; }

    public decimal? OtherCost { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Branch? Branch { get; set; }
}
