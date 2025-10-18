using System;
using System.Collections.Generic;


namespace DTO;

public partial class Product
{
    public string Id { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Image { get; set; }

    public string? CategoryId { get; set; }

    public virtual ICollection<Billinfo> Billinfos { get; set; } = new List<Billinfo>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<PromotionProduct> PromotionProducts { get; set; } = new List<PromotionProduct>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
}
