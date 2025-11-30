    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Address
    {
        private readonly HighlandsContext _context = new();

        public List<Address> GetAllAddresses()
        {
            return _context.Addresses.ToList();
        }

        public Address? GetAddressById(string id)
        {
            return _context.Addresses.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
        }

        public void Remove(string id)
        {
            var address = _context.Addresses.FirstOrDefault(a => a.Id == id.Trim());
            if (address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
            }
        }

        public void Update(Address address)
        {
            var oldAddress = _context.Addresses.FirstOrDefault(a => a.Id == address.Id);
            if (oldAddress != null)
            {
                oldAddress.Name = address.Name;
                oldAddress.WardId = address.WardId;
                _context.SaveChanges();
            }
        }
    }
}
