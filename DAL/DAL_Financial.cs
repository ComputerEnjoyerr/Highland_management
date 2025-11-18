using DocumentFormat.OpenXml.InkML;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Financial
    {
        private readonly HighlandsContext _context = new();

        public List<Financial> GetALl()
        {
            return _context.Financials
                .Include(f => f.Branch)
                .ToList();
        }
        public Financial? GetByMonthYear(int month, int year)
        {
            return _context.Financials
        .AsNoTracking() // Thêm dòng này → không cache
        .FirstOrDefault(f => f.ReportMonth == month && f.ReportYear == year);
        }

        
        public void Update(Financial f)
        {
            var existing = _context.Financials
                .FirstOrDefault(x => x.ReportMonth == f.ReportMonth && x.ReportYear == f.ReportYear);

            if (existing != null)
            {
                // UPDATE – chỉ cập nhật những field được phép
                existing.ElectricityCost = f.ElectricityCost;
                existing.WaterCost = f.WaterCost;
                existing.RentCost = f.RentCost;
                existing.OtherCost = f.OtherCost;
            }
            else
            {
                // INSERT
                if (string.IsNullOrEmpty(f.ReportId))
                    f.ReportId = $"RP{f.ReportYear % 100:D2}{f.ReportMonth:D2}{DateTime.Now:HHmmss}";

                f.CreatedAt = DateTime.Now;
                _context.Financials.Add(f);
            }

            _context.SaveChanges();
        }
        
    }
}

