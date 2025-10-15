using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Province
    {
        private string _id, _name, _codeName;

        public Province() { }
        public Province(string id, string name, string codeName)
        {
            Id = id;
            Name = name;
            CodeName = codeName;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string CodeName { get => _codeName; set => _codeName = value; }
    }
}
