using System;
using System.Collections.Generic;

namespace DTO;

public partial class SupplierIngredient
{
    public string SupplierId { get; set; } = null!;

    public string IngredientId { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public int? StandardUnitId { get; set; }

    public DateOnly? ProducedDate { get; set; }

    public int? ExpiryDay { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Unit? StandardUnit { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;
}
