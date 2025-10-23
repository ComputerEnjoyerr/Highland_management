using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PromotionProgram
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<Promotion> GetAllPromotionPrograms()
        {
            return _context.Promotions
                .Include(p => p.PromotionProgram)
                .ThenInclude(pp => pp.Category)
                .ToList();
        }

        public void Add(PromotionProgram promotionProgram)
        {
            _context.PromotionPrograms.Add(promotionProgram);
            _context.SaveChanges();
        }

        public void Update(PromotionProgram promotionProgram)
        {
            var oldPromotionProgram = _context.PromotionPrograms.FirstOrDefault(pp => pp.PromotionId == promotionProgram.PromotionId);
            if (oldPromotionProgram != null)
            {
                oldPromotionProgram.Promotion.PromotionName = promotionProgram.Promotion.PromotionName;
                oldPromotionProgram.Promotion.Description = promotionProgram.Promotion.Description;
                oldPromotionProgram.Promotion.DiscountType = promotionProgram.Promotion.DiscountType;
                oldPromotionProgram.Promotion.Value = promotionProgram.Promotion.Value;
                oldPromotionProgram.StartDate = promotionProgram.StartDate;
                oldPromotionProgram.Promotion.RequiringPoint = promotionProgram.Promotion.RequiringPoint;
                oldPromotionProgram.Promotion.ExpiryDay = promotionProgram.Promotion.ExpiryDay;
                oldPromotionProgram.Category.Name = promotionProgram.Category.Name;
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var promotionProgram = _context.PromotionPrograms.FirstOrDefault(pp => pp.PromotionId == id.Trim());
            if (promotionProgram != null)
            {
                _context.PromotionPrograms.Remove(promotionProgram);
                _context.SaveChanges();
            }
        }
    }
}
