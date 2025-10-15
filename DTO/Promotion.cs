using System;
using System.Collections.Generic;
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
}
