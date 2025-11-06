using DAL;
using DTO;

namespace BLL
{
    public class BLL_Product
    {
        private readonly DAL_Product dAL_Product = new();

        public List<Product> GetAll() { return dAL_Product.GetAll(); }

        public Product GetById(string id)
        {
            var product = dAL_Product.GetById(id);
            if (product == null)
            {
                return new Product();
            }
            return product;
        }

        private (bool IsValid, string Message) ValidateInput(Product p)
        {
            if (!ValidationData.IsNotEmpty(p.ProductName))
                return (false, "Tên sản phẩm không được bỏ trống");

            //if (!ValidationData.IsValidName(p.ProductName))
            //    return (false, "Tên sản phẩm không hợp lệ");

            if (!ValidationData.IsValidStatus(p.Status))
                return (false, "Trạng thái sản phẩm không hợp lệ");

            if (!ValidationData.IsValidDecimal(p.Price, max: 9999999999))
                return (false, "Số tiền không hợp lệ");

            return (true, "Dữ liệu hợp lệ.");
        }

        private bool IsDuplicatedName(string name, string id = null)
        {
            var existing = dAL_Product.GetAll()
                .FirstOrDefault(p => p.ProductName == name);

            if (existing == null)
                return false; // tức ko có tên nào trùng

            if (id != null && existing.Id == id)
                return false;

            return true;
        }


        public void Add(Product product)
        {
            if (IsDuplicatedName(product.ProductName))
                throw new Exception("Tên sản phẩm này đã tồn tại");

            if (!ValidateInput(product).IsValid)
                throw new Exception($"{ValidateInput(product).Message}");

            dAL_Product.Add(product);
        }

        public void Update(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Id))
                throw new Exception("Thiếu Id sản phẩm, không thể cập nhật");

            if (IsDuplicatedName(product.ProductName, product.Id))
                throw new Exception("Tên sản phẩm này đã tồn tại");

            if (!ValidateInput(product).IsValid)
                throw new Exception($"{ValidateInput(product).Message}");

            dAL_Product.Update(product);
        }

        public void Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new Exception("Thiếu Id sản phẩm, không thể xóa");
            dAL_Product.Delete(id); 
        }

        public List<Product> GetByCategory(string id)
        {
            return dAL_Product.GetAll().Where(p => p.CategoryId == id).ToList();
        }
    }
}
