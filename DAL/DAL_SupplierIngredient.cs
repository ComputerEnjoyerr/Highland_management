using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SupplierIngredient
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<SupplierIngredient> GetAll()
        {
            return _context.SupplierIngredients
                .Include(i =>  i.Ingredient)
                .Include(s => s.Supplier)
                .Include(u => u.StandardUnit)
                .ToList();
        }

        public void Add(SupplierIngredient supplierIngredient)
        {
            _context.Add(supplierIngredient);
            _context.SaveChanges();
        }

        public void Update(SupplierIngredient supplierIngredient)
        {
            var existing = _context.SupplierIngredients.FirstOrDefault(si => si.SupplierId == supplierIngredient.SupplierId && si.IngredientId == supplierIngredient.IngredientId);
            if (existing != null)
            {
                existing.StandardUnitId = supplierIngredient.StandardUnitId;
                existing.UnitPrice = supplierIngredient.UnitPrice;
                existing.ExpiryDay = supplierIngredient.ExpiryDay;
                _context.SaveChanges();
            }
        }

        public void Delete(string supplierId, string ingredientId)
        {
            var supplierIngredient = _context.SupplierIngredients.FirstOrDefault(si => si.SupplierId == supplierId && si.IngredientId == ingredientId);
            if (supplierIngredient != null)
            {
                _context.Remove(supplierIngredient);
                _context.SaveChanges();
            }
        }
    }
}
