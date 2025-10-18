using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Category
{
    public string Id { get; set; } = null!;

    public string? Name { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<PromotionProgram> PromotionPrograms { get; set; } = new List<PromotionProgram>();
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Category
    {
        private string _id, _name;

        public Category(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
