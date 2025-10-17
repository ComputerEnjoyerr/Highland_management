using System;
using System.Collections.Generic;
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
}
