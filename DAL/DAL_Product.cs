using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Product
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<Product> GetAll()
        {
            return _context.Products
                .Include(p => p.Category)
                .ToList();
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public Product? GetById(string id)
        {
            return _context.Products
                .Include(p => p.Category)
                .FirstOrDefault(p => p.Id == id);
        }

        public void Update(Product product)
        {
            var oldProduct = _context.Products.FirstOrDefault(p => p.Id == product.Id);
            if (oldProduct != null)
            {
                oldProduct.ProductName = product.ProductName;
                oldProduct.Price = product.Price;
                oldProduct.Image = product.Image;
                oldProduct.CategoryId = product.CategoryId;
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
