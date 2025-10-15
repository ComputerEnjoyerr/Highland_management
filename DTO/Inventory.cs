using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Inventory
    {
        private string _branchId, _ingredientId;
        private decimal _currentQuantity;
        private int _unitId;

        public Inventory(string branchId, string ingredientId, decimal currentQuantity, int unitId)
        {
            BranchId = branchId;
            IngredientId = ingredientId;
            CurrentQuantity = currentQuantity;
            UnitId = unitId;
        }

        public string BranchId { get => _branchId; set => _branchId = value; }
        public string IngredientId { get => _ingredientId; set => _ingredientId = value; }
        public decimal CurrentQuantity { get => _currentQuantity; set => _currentQuantity = value; }
        public int UnitId { get => _unitId; set => _unitId = value; }
    }
}
