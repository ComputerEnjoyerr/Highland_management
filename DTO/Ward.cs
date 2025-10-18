using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Ward
{
    public string Id { get; set; } = null!;

    public string WardName { get; set; } = null!;

    public string? ProvinceId { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual Province? Province { get; set; }
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
