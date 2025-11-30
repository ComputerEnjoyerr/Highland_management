using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Ingredient
    {
        private readonly DAL_Ingredient dAL_Ingredient = new();

        public List<Ingredient> GetAll()
        {
            return dAL_Ingredient.GetAll();
        }

        public Ingredient GetById(string id) { return  dAL_Ingredient.GetById(id); }

        public void Add(Ingredient ingredient)
        {
            dAL_Ingredient.Add(ingredient);
        }

        public void Update(Ingredient ingredient)
        {
            dAL_Ingredient.Update(ingredient);
        }

        public void Delete(string id)
        {
            dAL_Ingredient.Delete(id);
        }
    }
}
