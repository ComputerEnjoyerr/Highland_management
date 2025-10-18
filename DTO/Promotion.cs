using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Promotion
{
    public string Id { get; set; } = null!;

    public string? PromotionName { get; set; }

    public string? Description { get; set; }

    public string PromotionType { get; set; } = null!;

    public string DiscountType { get; set; } = null!;

    public decimal? Value { get; set; }

    public decimal? MaxDiscount { get; set; }

    public int? RequiringPoint { get; set; }

    public int? ExpiryDay { get; set; }

    public virtual ICollection<PromotionProduct> PromotionProducts { get; set; } = new List<PromotionProduct>();

    public virtual PromotionProgram? PromotionProgram { get; set; }

    public virtual ICollection<PromotionUsage> PromotionUsages { get; set; } = new List<PromotionUsage>();

    public virtual ICollection<PromotionVoucher> PromotionVouchers { get; set; } = new List<PromotionVoucher>();
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Promotion
    {
        private string _id, _name, _description, _promotionType, _discountType;
        private decimal _value, _maxDiscount;
        private int _requirePoint, _expiryDay;

        public Promotion() { }
        public Promotion(string id, string name, string description, string promotionType, string discountType, decimal value, decimal maxDiscount, int requirePoint, int expiryDay)
        {
            Id = id;
            Name = name;
            Description = description;
            PromotionType = promotionType;
            DiscountType = discountType;
            Value = value;
            MaxDiscount = maxDiscount;
            RequirePoint = requirePoint;
            ExpiryDay = expiryDay;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public string PromotionType { get => _promotionType; set => _promotionType = value; }
        public string DiscountType { get => _discountType; set => _discountType = value; }
        public decimal Value { get => _value; set => _value = value; }
        public decimal MaxDiscount { get => _maxDiscount; set => _maxDiscount = value; }
        public int RequirePoint { get => _requirePoint; set => _requirePoint = value; }
        public int ExpiryDay { get => _expiryDay; set => _expiryDay = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
