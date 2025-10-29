using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Promotion
    {
        private readonly HighlandsContext _context = new();      

        public List<Promotion> GetAllPromotions()
        {
            return _context.Promotions.ToList();
        }

        public Promotion? GetPromotionById(string id)
        {
            return _context.Promotions.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Promotion promotion)
        {
            _context.Promotions.Add(promotion);
            _context.SaveChanges();
        }

        public void Remove(string id)
        {
            var existingPromotion = _context.Promotions.FirstOrDefault(p => p.Id == id);
            if (existingPromotion != null)
            {
                _context.Promotions.Remove(existingPromotion);
                _context.SaveChanges();
            }
        }
        public void Update(Promotion promotion)
        {
            var existingPromotion = _context.Promotions.FirstOrDefault(p => p.Id == promotion.Id);
            if (existingPromotion != null)
            {
                existingPromotion.PromotionName = promotion.PromotionName;
                existingPromotion.Description = promotion.Description;
                existingPromotion.DiscountType = promotion.DiscountType;

                existingPromotion.Value = promotion.Value;

                existingPromotion.RequiringPoint = promotion.RequiringPoint;
                existingPromotion.ExpiryDay = promotion.ExpiryDay;

                // Save changes
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Khuyến mãi không tồn tại!", "Thông báo");
            }
        }
    }
}
