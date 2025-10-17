using System;
using System.Collections.Generic;
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
}
