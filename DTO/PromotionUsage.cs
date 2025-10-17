using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PromotionUsage
    {
        private string _promotionId, _billId;
        private DateTime _usedAt;
        private decimal _discountAmount;

        public PromotionUsage() { }
        public PromotionUsage(string promotionId, string billId, DateTime usedAt, decimal discountAmount)
        {
            PromotionId = promotionId;
            BillId = billId;
            UsedAt = usedAt;
            DiscountAmount = discountAmount;
        }

        public string PromotionId { get => _promotionId; set => _promotionId = value; }
        public string BillId { get => _billId; set => _billId = value; }
        public DateTime UsedAt { get => _usedAt; set => _usedAt = value; }
        public decimal DiscountAmount { get => _discountAmount; set => _discountAmount = value; }
    }
}
