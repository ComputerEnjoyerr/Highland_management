using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SupplierIngredient
    {
        private string _supplierId, _ingredientId;
        private decimal _unitPrice;
        private int _standardUnitId, _expiryDay;

        public SupplierIngredient() { }
        public SupplierIngredient(string supplierId, string ingredientId, decimal unitPrice, int standardUnitId, int expiryDay)
        {
            SupplierId = supplierId;
            IngredientId = ingredientId;
            UnitPrice = unitPrice;
            StandardUnitId = standardUnitId;
            ExpiryDay = expiryDay;
        }

        public string SupplierId { get => _supplierId; set => _supplierId = value; }
        public string IngredientId { get => _ingredientId; set => _ingredientId = value; }
        public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }
        public int StandardUnitId { get => _standardUnitId; set => _standardUnitId = value; }
        public int ExpiryDay { get => _expiryDay; set => _expiryDay = value; }
    }
}
