using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Address
    {
        private int _id, _idWard;
        private string _addressName;

        public Address(int id, string address, int idWard)
        {
            Id = id;
            WardId = idWard;
            AddressName = address;
        }

        public int Id { get => _id; set => _id = value; }
        public int WardId { get => _idWard; set => _idWard = value; }
        public string AddressName { get => _addressName; set => _addressName = value; }
    }
}
