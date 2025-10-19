using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Recipe
    {
        private readonly HighlandsDatabaseVer2Context _context = new();
        public List<Recipe> GetAll()
        {
            return _context.Recipes.ToList();
        }
    }
}
