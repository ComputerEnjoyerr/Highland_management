using System;
using System.Collections.Generic;

namespace DTO;

public partial class Address
{
    public string Id { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? WardId { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    public virtual Ward? Ward { get; set; }

}
