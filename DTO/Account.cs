using System;
using System.Collections.Generic;

namespace DTO;

public partial class Account
{
    public string Id { get; set; } = null!;

    public string AccountName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string EmployeeId { get; set; } = null!;

    public DateOnly? CreateDate { get; set; }

    public virtual Employee Employee { get; set; } = null!;
}
