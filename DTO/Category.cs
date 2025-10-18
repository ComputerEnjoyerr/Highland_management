using System;
using System.Collections.Generic;


namespace DTO;

public partial class Category
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<PromotionProgram> PromotionPrograms { get; set; } = new List<PromotionProgram>();

}
