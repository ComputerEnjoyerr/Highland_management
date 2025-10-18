using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class PromotionProduct
{
    public string PromotionId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public string BranchId { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual Promotion Promotion { get; set; } = null!;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PromotionProduct
    {
        private string _promotionId, _productId, _branchId;
        private DateTime _startDate, _endDate;

        public PromotionProduct() { }
        public PromotionProduct(string promotionId, string productId, string branchId, DateTime startDate, DateTime endDate)
        {
            PromotionId = promotionId;
            ProductId = productId;
            BranchId = branchId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string PromotionId { get => _promotionId; set => _promotionId = value; }
        public string ProductId { get => _productId; set => _productId = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
