using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Supplier
    {
        private readonly HighlandsDatabaseVer2Context _context = new();
        public List<Supplier> GetAllSuppliers()
        {
            return _context.Suppliers
                .Include(p => p.Address)
                .ThenInclude(a => a.Ward)
                .ThenInclude(w => w.Province)
                .ToList();
            
        }

        public Supplier? GetSupplierById(string id)
        {
            return _context.Suppliers.Include(p => p.Address).FirstOrDefault(s => s.Id == id);
        }

        public void Add(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void Update(Supplier supplier)
        {
            var oldSupplier = _context.Suppliers.FirstOrDefault(s => s.Id == supplier.Id);
            if(oldSupplier != null)
            {
                oldSupplier.Name = supplier.Name;
                oldSupplier.Phone = supplier.Phone;
                oldSupplier.AddressId = supplier.AddressId;
                oldSupplier.Email = supplier.Email;
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(s => s.Id == id.Trim());
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }

    }
}
