using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DTO;

public partial class SupplierIngredient
{
    public string SupplierId { get; set; }

    public string IngredientId { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? StandardUnitId { get; set; }

    public int? ExpiryDay { get; set; }

    public virtual Ingredient? Ingredient { get; set; }

    public virtual Unit? StandardUnit { get; set; }

    public virtual Supplier? Supplier { get; set; }

}
