using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace DTO;

public partial class Supplier
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;
    [Phone(ErrorMessage = "Số điện thoại phải phù hợp!")]
    [StringLength(11, MinimumLength = 8, ErrorMessage ="Số điện thoại phải từ 8 đến 11 ký tự")]
    public string Phone { get; set; } = null!;

    [Required (ErrorMessage = "Địa chỉ không được để trống")]
    public string? AddressId { get; set; }
    [EmailAddress(ErrorMessage = "Email không hợp lệ")]

    public string Email { get; set; } = null!;

    public virtual Address? Address { get; set; }

}
