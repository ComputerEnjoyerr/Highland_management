using System;
using System.Collections.Generic;

namespace DTO;

public partial class Province
{
    public string Id { get; set; } = null!;

    public string ProvinceName { get; set; } = null!;

    public string CodeName { get; set; } = null!;

    public string? Type { get; set; }

    public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();
}
