using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_StockReceipt
    {
        private readonly HighlandsContext context = new();

        public List<StockReceipt> GetAll()
        {
            return context.StockReceipts.ToList();
        }

        public void Add(StockReceipt stockReceipt)
        {
            context.StockReceipts.Add(stockReceipt);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var stockReceipt = context.StockReceipts.FirstOrDefault(b => b.Id == id);
            if (stockReceipt != null)
            {
                context.StockReceipts.Remove(stockReceipt);
                context.SaveChanges();
            }
        }

        public void Update(StockReceipt stockReceipt)
        {
            var existingStock = context.StockReceipts.FirstOrDefault(b => b.Id == stockReceipt.Id);
            if (existingStock != null)
            {
                existingStock.BranchId = stockReceipt.BranchId;
                existingStock.IngredientId = stockReceipt.IngredientId;
                existingStock.CreatedBy = stockReceipt.CreatedBy;
                existingStock.ExpiryDate = stockReceipt.ExpiryDate;
                existingStock.ReceiptDate = stockReceipt.ReceiptDate;
                existingStock.Status = stockReceipt.Status;
                existingStock.SupplierId = stockReceipt.SupplierId;
                existingStock.PurchasedUnit = stockReceipt.PurchasedUnit;
                existingStock.Quantity = stockReceipt.Quantity;
                existingStock.TotalPrice = stockReceipt.TotalPrice;
                existingStock.UnitPrice = stockReceipt.UnitPrice;
                context.SaveChanges();
            }
        }
    }
}
