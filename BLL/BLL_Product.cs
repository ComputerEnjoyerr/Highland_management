using DAL;
using DTO;

namespace BLL
{
    public class BLL_Product
    {
        private readonly DAL_Product dAL_Product = new();

        public List<Product> GetAll() { return dAL_Product.GetAll(); }

        public void Add(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new Exception("Tên sản phẩm không được để trống.");

            if (product.Price <= 0)
                throw new Exception("Giá sản phẩm phải lớn hơn 0.");
            dAL_Product.Add(product);
        }

        public void Update(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.Id))
                throw new Exception("Thiếu ID sản phẩm khi cập nhật.");

            if (string.IsNullOrWhiteSpace(product.ProductName))
                throw new Exception("Tên sản phẩm không được để trống.");

            if (product.Price <= 0)
                throw new Exception("Giá sản phẩm phải lớn hơn 0.");

            dAL_Product.Update(product);
        }

        public void Delete(string id) { dAL_Product.Delete(id); }
    }
}
