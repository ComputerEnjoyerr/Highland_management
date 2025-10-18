using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class PromotionVoucher
{
    public string PromotionId { get; set; } = null!;

    public string CustomerId { get; set; } = null!;

    public DateOnly? UsedDate { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
