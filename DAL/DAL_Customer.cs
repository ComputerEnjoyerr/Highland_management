using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Customer
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<Customer> GetAll()
        {
            return _context.Customers
                .ToList();
        }

        public Customer GetById(string id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);  
            if (customer == null) return new Customer();
            return customer;
        }

        public void Add(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void Update(Customer customer)
        {
            var existing = _context.Customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existing != null)
            {
                existing.CustomerName = customer.CustomerName;
                existing.Phone = customer.Phone; 
                existing.Email = customer.Email;
                existing.Point = customer.Point;
                existing.Drips = customer.Drips;
                existing.Tier = customer.Tier;
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
            if (customer != null)
            {
                _context.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
