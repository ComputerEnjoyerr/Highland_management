using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Recipe
    {
        private readonly HighlandsContext _context = new();
        public List<Recipe> GetAll()
        {
            return _context.Recipes
                .Include(r => r.Product)
                .Include(r => r.Ingredient)
                .Include(r => r.RecipeUnit)
                .ToList();
        }

        public void Add(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.Id == id);
            if (recipe != null)
            {
                _context.Recipes.Remove(recipe);
                _context.SaveChanges();
            }
        }

        public void Update(Recipe recipe)
        {
            var existing = _context.Recipes.FirstOrDefault(r => r.Id == recipe.Id);
            if (existing != null)
            {
                existing.ProductId = recipe.ProductId;
                existing.IngredientId = recipe.IngredientId;
                existing.Quantity = recipe.Quantity;
                existing.RecipeUnitId = recipe.RecipeUnitId;
                _context.SaveChanges();
            }
        }

        public string GenerateId()
        {
            DateTime dateTime = DateTime.Now;
            return $"RC{dateTime:yyMMddHHmmss}";
        }
    }
}
