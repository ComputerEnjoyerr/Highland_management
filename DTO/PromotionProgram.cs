using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class PromotionProgram
{
    public string PromotionId { get; set; } = null!;

    public string? CategoryId { get; set; }

    public DateOnly? StartDate { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Promotion Promotion { get; set; } = null!;
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
