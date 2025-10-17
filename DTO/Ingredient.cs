using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ingredient
    {
        private string _id, _name;

        public Ingredient(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
