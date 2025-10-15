using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Employee
    {
        private string _id, _name, _branchId, _addressId, _phone, _role;
        private DateTime _hiredDate;
        private decimal _salaryPerHour;

        public Employee(string id, string name, string branchId, string addressId, string phone, string role, DateTime hiredDate, decimal salaryPerHour)
        {
            Id = id;
            Name = name;
            BranchId = branchId;
            AddressId = addressId;
            Phone = phone;
            Role = role;
            HiredDate = hiredDate;
            SalaryPerHour = salaryPerHour;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public string AddressId { get => _addressId; set => _addressId = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Role { get => _role; set => _role = value; }
        public DateTime HiredDate { get => _hiredDate; set => _hiredDate = value; }
        public decimal SalaryPerHour { get => _salaryPerHour; set => _salaryPerHour = value; }
    }
}
