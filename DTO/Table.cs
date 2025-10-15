using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Table
    {
        private int _id, _capacity;
        private string _name, _branchId;

        public Table() { }
        public Table(int id, int capacity, string name, string branchId)
        {
            Id = id;
            Capacity = capacity;
            Name = name;
            BranchId = branchId;
        }

        public int Id { get => _id; set => _id = value; }
        public int Capacity { get => _capacity; set => _capacity = value; }
        public string Name { get => _name; set => _name = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
    }
}
