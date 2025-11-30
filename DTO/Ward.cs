using System;
using System.Collections.Generic;

namespace DTO;

public partial class Ward
{
    public string Id { get; set; } = null!;

    public string WardName { get; set; } = null!;

    public string? ProvinceId { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Province? Province { get; set; }
}
