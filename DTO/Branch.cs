using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Branch
    {
        private string _id, _name, _addressId, _phone, _status;
        private DateTime _openTime, _closeTime;

        public Branch(string id, string name, string addressId, string phone, string status, DateTime openTime, DateTime closeTime)
        {
            Id = id;
            Name = name;
            AddressId = addressId;
            Phone = phone;
            Status = status;
            OpenTime = openTime;
            CloseTime = closeTime;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string AddressId { get => _addressId; set => _addressId = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Status { get => _status; set => _status = value; }
        public DateTime OpenTime { get => _openTime; set => _openTime = value; }
        public DateTime CloseTime { get => _closeTime; set => _closeTime = value; }
    }
}
