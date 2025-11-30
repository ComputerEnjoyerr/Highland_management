using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Category
    {
        private readonly HighlandsContext _context = new();

        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }

        public Category? GetById(string id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }

        public void Add(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }
    }
}
