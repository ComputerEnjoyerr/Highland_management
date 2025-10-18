using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Inventory
{
    public string BranchId { get; set; } = null!;

    public string IngredientId { get; set; } = null!;

    public decimal? CurrentQuantity { get; set; }

    public int? UnitId { get; set; }

    public virtual Branch Branch { get; set; } = null!;

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Unit? Unit { get; set; }
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
