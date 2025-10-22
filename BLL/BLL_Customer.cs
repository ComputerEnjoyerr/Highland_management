using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Customer
    {
        private readonly DAL_Customer dAL_Customer= new();

        public List<Customer> GetAll() { return dAL_Customer.GetAll(); }

        public Customer GetById(string id) { return dAL_Customer.GetById(id); }

        public void Add(Customer customer) { dAL_Customer.Add(customer); }

        public void Update(Customer customer) {dAL_Customer.Update(customer); }

        public void Delete(string id) { dAL_Customer.Delete(id); }

        public Customer GetByPhone(string phone, string id = null)
        {
            var existing = dAL_Customer.GetById(id);
            var existingPhone = dAL_Customer.GetAll()
                .FirstOrDefault(c => c.Phone == phone);
            if (existingPhone == null)
            {
                return null;
            }
            if (existing != null)
                return null;
            return existingPhone;
        }

        public string GenerateId(string phone)
        {
            return $"C{phone}";
        }
    }
}
