using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Supplier
    {
        private string _id, _name, _phone, _addressId, _email;

        public Supplier() { }
        public Supplier(string id, string name, string phone, string addressId, string email)
        {
            Id = id;
            Name = name;
            Phone = phone;
            AddressId = addressId;
            Email = email;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string AddressId { get => _addressId; set => _addressId = value; }
        public string Email { get => _email; set => _email = value; }
    }
}
