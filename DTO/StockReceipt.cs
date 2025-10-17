using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StockReceipt
    {
        private string _id, _branchId, _ingredientId;
        private int _purchaseUnitId, _quantity;
        private decimal _unitPrice, _totalPrice;
        private DateTime _receiptDate, _expiryDate;

        public StockReceipt() { }
        public StockReceipt(string id, string branchId, string ingredientId, int purchaseUnitId, int quantity, decimal unitPrice, decimal totalPrice, DateTime receiptDate, DateTime expiryDate)
        {
            Id = id;
            BranchId = branchId;
            IngredientId = ingredientId;
            PurchaseUnitId = purchaseUnitId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
            ReceiptDate = receiptDate;
            ExpiryDate = expiryDate;
        }

        public string Id { get => _id; set => _id = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public string IngredientId { get => _ingredientId; set => _ingredientId = value; }
        public int PurchaseUnitId { get => _purchaseUnitId; set => _purchaseUnitId = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }
        public decimal TotalPrice { get => _totalPrice; set => _totalPrice = value; }
        public DateTime ReceiptDate { get => _receiptDate; set => _receiptDate = value; }
        public DateTime ExpiryDate { get => _expiryDate; set => _expiryDate = value; }
    }
}
