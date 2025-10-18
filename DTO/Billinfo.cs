using System;
using System.Collections.Generic;

namespace DTO;

public partial class Billinfo
{
    public int Id { get; set; }

    public string ProductId { get; set; } = null!;

    public string BillId { get; set; } = null!;

    public int Quantity { get; set; }

    public virtual Bill Bill { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
