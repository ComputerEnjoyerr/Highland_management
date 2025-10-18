using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class PromotionUsage
{
    public string PromotionId { get; set; } = null!;

    public string BillId { get; set; } = null!;

    public DateOnly? UsedDate { get; set; }

    public decimal? DiscountAmount { get; set; }

    public virtual Bill Bill { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
