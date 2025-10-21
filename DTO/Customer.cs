using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTO;

public partial class Customer
{
    [MaxLength(12)]
    public string Id { get; set; } = null!;
    [Required(ErrorMessage = "Vui lòng nhập tên khách hàng"), MaxLength(30, ErrorMessage = "Tên khách hàng vượt quá 30 kí tự")]
    public string CustomerName { get; set; } = null!;

    [EmailAddress(ErrorMessage = "Email không hợp lệ")]
    public string Email { get; set; } = null!;

    [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
    [StringLength(11, MinimumLength = 8, ErrorMessage = "Số điện thoại phải từ 8 hoặc 11 kí tự")]
    public string Phone { get; set; } = null!;

    public decimal Point { get; set; } = 0;

    public int Drips { get; set; } = 0;

    public string Tier { get; set; } = "Member";

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<PromotionVoucher> PromotionVouchers { get; set; } = new List<PromotionVoucher>();

}
