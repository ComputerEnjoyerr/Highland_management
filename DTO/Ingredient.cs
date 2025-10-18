using System;
using System.Collections.Generic;

namespace DTO;

public partial class Ingredient
{
    public string Id { get; set; } = null!;

    public string IngredientName { get; set; } = null!;

    public virtual ICollection<Inventory> Inventories { get; set; } = new List<Inventory>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual ICollection<StockReceipt> StockReceipts { get; set; } = new List<StockReceipt>();

}
