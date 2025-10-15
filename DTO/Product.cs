using System;
using System.Collections.Generic;
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
}
