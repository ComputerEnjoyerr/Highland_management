using System;
using System.Collections.Generic;


namespace DTO;

public partial class Inventory
{
    public string BranchId { get; set; } = null!;

    public string IngredientId { get; set; } = null!;

    public decimal? CurrentQuantity { get; set; }

    public int? UnitId { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
}
