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
            .Where(p => p.PromotionType == "Chương trình khuyến mãi")
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

                oldPromotionProgram.StartDate = promotionProgram.StartDate;
                oldPromotionProgram.CategoryId = promotionProgram.CategoryId;
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

        // Hàm kiểm tra id
        public bool CheckPromotionProgramIdExists(string id)
        {
            return _context.PromotionPrograms.Any(p => p.PromotionId == id);
        }

        // Hàm kiểm tra tên
        public bool CheckPromotionProgramNameExists(string name)
        {
            return _context.Promotions.Any(p => p.PromotionName == name);
        }
}}
