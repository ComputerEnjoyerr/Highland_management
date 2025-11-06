using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BillInfo
    {
        private readonly HighlandsContext context = new();

        public List<Billinfo> GetAll()
        {
            return context.Billinfos
                .Include(b => b.Bill)
                .Include(b => b.Product)
                .ToList();
        }
        public List<Billinfo> GetByBillId(string billId)
        {
            return context.Billinfos
                .Where(bi => bi.BillId == billId)
                .Include(b => b.Bill)
                .Include(b => b.Product)
                .ToList();
        }

        public void Add(Billinfo billinfo)
        {
            context.Billinfos.Add(billinfo);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var billinfo = context.Billinfos.FirstOrDefault(bi => bi.Id == id);
            if (billinfo != null)
            {
                context.Billinfos.Remove(billinfo);
                context.SaveChanges();
            }
        }

        public void Update(Billinfo billinfo)
        {
            var existingBillinfo = context.Billinfos.FirstOrDefault(bi => bi.Id == billinfo.Id);
            if (existingBillinfo != null)
            {
                existingBillinfo.BillId = billinfo.BillId;
                existingBillinfo.ProductId = billinfo.ProductId;
                existingBillinfo.Quantity = billinfo.Quantity;
                context.SaveChanges();
            }
        }
    }
}
