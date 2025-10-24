using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PromotionVoucher
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<Promotion> GetAllPromotionVoucher()
        {
            return _context.Promotions
                .Where(p => p.PromotionType == "Voucher")
                .Include(p => p.PromotionVouchers)             
                .ThenInclude(pv => pv.Customer)
                .ToList();
        }

        public PromotionVoucher? GetPromotionVoucherById(string promotionId, string customerId)
        {
            return _context.PromotionVouchers
                .FirstOrDefault(pv => pv.PromotionId == promotionId && pv.CustomerId == customerId);
        }
        public void Add(PromotionVoucher promotionVoucher)
        {
            _context.PromotionVouchers.Add(promotionVoucher);
            _context.SaveChanges();
        }

        public void Update(PromotionVoucher promotionVoucher)
        {
            var existingPromotionVoucher = _context.PromotionVouchers
                .FirstOrDefault(pv => pv.PromotionId == promotionVoucher.PromotionId
                && pv.CustomerId == promotionVoucher.CustomerId);
            if (existingPromotionVoucher != null)
            {
                
                //existingPromotionVoucher.CustomerId = promotionVoucher.CustomerId;
                existingPromotionVoucher.UsedDate = promotionVoucher.UsedDate;              
                _context.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Phiếu Voucher không tồn tại!", "Thông báo");
            }
        }

        public void Delete(string id)
        {
            var promotionVoucher = _context.PromotionVouchers.FirstOrDefault(pv => pv.PromotionId == id.Trim());
            
            if (promotionVoucher != null)
            {
                _context.PromotionVouchers.Remove(promotionVoucher);
                _context.SaveChanges();
            }
        }
    }
}
