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
        private readonly HighlandsDatabaseVer2Context _context = new();

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

        public void Remove(Promotion promotion)
        {
            var existingPromotion = _context.Promotions.FirstOrDefault(p => p.Id == promotion.Id);
            if (existingPromotion != null)
            {
                _context.Promotions.Remove(existingPromotion);
                _context.SaveChanges();
            }
        }
    }
}
