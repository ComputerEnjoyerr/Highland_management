using System;
using System.Collections.Generic;

namespace DTO;

public partial class StockReceipt
{
    public string Id { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public string IngredientId { get; set; } = null!;

    public string? SupplierId { get; set; }

    public string? CreatedBy { get; set; }

    public int PurchasedUnitId { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public int Status { get; set; } = 0;

    public decimal TotalPrice { get; set; }

    public DateOnly ReceiptDate { get; set; }

    public DateOnly ExpiryDate { get; set; }

    public virtual Branch? Branch { get; set; }

    public virtual Employee? CreatedByNavigation { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Unit? PurchasedUnit { get; set; }

    public virtual Supplier Supplier { get; set; } = null!;
}
