using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Product
{
    public string Id { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public string? Image { get; set; }

    public string? CategoryId { get; set; }

    public virtual ICollection<Billinfo> Billinfos { get; set; } = new List<Billinfo>();

    public virtual Category? Category { get; set; }

    public virtual ICollection<PromotionProduct> PromotionProducts { get; set; } = new List<PromotionProduct>();

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product
    {
        private string _id, _name, _image, _categoryId;
        private decimal _price;

        public Product(string id, string name, string image, string categoryId, decimal price)
        {
            Id = id;
            Name = name;
            Image = image;
            CategoryId = categoryId;
            Price = price;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Image { get => _image; set => _image = value; }
        public string CategoryId { get => _categoryId; set => _categoryId = value; }
        public decimal Price { get => _price; set => _price = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
