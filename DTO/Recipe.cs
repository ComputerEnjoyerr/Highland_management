using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Recipe
{
    public string Id { get; set; } = null!;

    public string IngredientId { get; set; } = null!;

    public string ProductId { get; set; } = null!;

    public decimal? Quantity { get; set; }

    public int RecipeUnitId { get; set; }

    public virtual Ingredient Ingredient { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual Unit RecipeUnit { get; set; } = null!;
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Recipe
    {
        private string _id, _ingredientId, _productId;
        private decimal _quantity;
        private int _recipeUnitId;

        public Recipe() { }
        public Recipe(string id, string ingredientId, string productId, decimal quantity, int recipeUnitId)
        {
            Id = id;
            IngredientId = ingredientId;
            ProductId = productId;
            Quantity = quantity;
            RecipeUnitId = recipeUnitId;
        }

        public string Id { get => _id; set => _id = value; }
        public string IngredientId { get => _ingredientId; set => _ingredientId = value; }
        public string ProductId { get => _productId; set => _productId = value; }
        public decimal Quantity { get => _quantity; set => _quantity = value; }
        public int RecipeUnitId { get => _recipeUnitId; set => _recipeUnitId = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
