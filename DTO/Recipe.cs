using System;
using System.Collections.Generic;

namespace DTO;

public partial class Recipe
{
    public string Id { get; set; } = null!;

    public string IngredientId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public int RecipeUnitId { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual Unit RecipeUnit { get; set; } = null!;

}
