using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PromotionVoucher
    {
        private string _promotionId, _customerId;
        private DateTime _usedDate;

        public PromotionVoucher() { }
        public PromotionVoucher(string promotionId, string customerId, DateTime usedDate)
        {
            PromotionId = promotionId;
            CustomerId = customerId;
            UsedDate = usedDate;
        }

        public string PromotionId { get => _promotionId; set => _promotionId = value; }
        public string CustomerId { get => _customerId; set => _customerId = value; }
        public DateTime UsedDate { get => _usedDate; set => _usedDate = value; }
    }
}
