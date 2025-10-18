using System;
using System.Collections.Generic;


namespace DTO;

public partial class Supplier
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? AddressId { get; set; }

    public string Email { get; set; } = null!;

    public virtual Address? Address { get; set; }

}
