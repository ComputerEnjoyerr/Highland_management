using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Ingredient
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<Ingredient> GetAll()
        {
            return _context.Ingredients
                .ToList();
        }

        public Ingredient GetById(string id)
        {
            var ingredient = _context.Ingredients.FirstOrDefault(i => i.Id == id);
            if (ingredient != null)
            {
                return ingredient;
            }
            return new Ingredient();
        }

        public void Add(Ingredient ingredient)
        {
            _context.Add(ingredient);
            _context.SaveChanges();
        }

        public void Update(Ingredient ingredient)
        {
            var existing = _context.Ingredients.FirstOrDefault(i => i.Id == ingredient.Id);
            if (existing != null)
            {
                existing.IngredientName = ingredient.IngredientName;
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var ingredient = _context.Ingredients.FirstOrDefault(i => i.Id == id);
            if (ingredient != null)
            {
                _context.Remove(ingredient);
                _context.SaveChanges();
            }
        }
    }
}
