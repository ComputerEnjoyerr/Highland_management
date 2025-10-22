using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Recipe
    {
        private readonly DAL_Recipe dAL_Recipe = new();
        public List<Recipe> GetAll()
        {
            return dAL_Recipe.GetAll();
        }

        public void Add(Recipe recipe) { dAL_Recipe.Add(recipe); }
        public void Delete(string id) { dAL_Recipe.Delete(id); }
        public void Update(Recipe recipe) { dAL_Recipe.Update(recipe); }
        public string GenerateId() { return dAL_Recipe.GenerateId(); }
    }
}
