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
    }
}
