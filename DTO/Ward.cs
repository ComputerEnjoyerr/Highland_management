using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Ward
    {
        private string _id, _name, _provinceId;

        public Ward() { }
        public Ward(string id, string name, string provinceId)
        {
            Id = id;
            Name = name;
            ProvinceId = provinceId;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string ProvinceId { get => _provinceId; set => _provinceId = value; }
    }
}
