using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PromotionProgram
    {
        private string _promotionId, _categoryId;
        private DateTime _startDate, _endDate;

        public PromotionProgram() { }
        public PromotionProgram(string promotionId, string categoryId, DateTime startDate, DateTime endDate)
        {
            PromotionId = promotionId;
            CategoryId = categoryId;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string PromotionId { get => _promotionId; set => _promotionId = value; }
        public string CategoryId { get => _categoryId; set => _categoryId = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
    }
}
