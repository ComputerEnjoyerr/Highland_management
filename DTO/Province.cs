using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Province
{
    public string Id { get; set; } = null!;

    public string ProvinceName { get; set; } = null!;

    public string CodeName { get; set; } = null!;

    public string? Type { get; set; }

    public virtual ICollection<Ward> Wards { get; set; } = new List<Ward>();
=======
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
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
