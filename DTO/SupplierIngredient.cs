using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class SupplierIngredient
{
    public string? SupplierId { get; set; }

    public string? IngredientId { get; set; }

    public decimal? UnitPrice { get; set; }

    public int? StandardUnitId { get; set; }

    public int? ExpiryDay { get; set; }

    public virtual Ingredient? Ingredient { get; set; }

    public virtual Unit? StandardUnit { get; set; }

    public virtual Supplier? Supplier { get; set; }
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
