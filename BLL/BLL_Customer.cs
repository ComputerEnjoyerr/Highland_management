using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Customer
    {
        private readonly DAL_Customer dAL_Customer= new();

        public List<Customer> GetAll() { return dAL_Customer.GetAll(); }

        public Customer GetById(string id) { return dAL_Customer.GetById(id); }

        private (bool IsValid, string Message) ValidateInput(Customer c)
        {
            if (!ValidationData.IsValidName(c.CustomerName))
                return (false, "Tên khách hàng không hợp lệ.");

            if (!ValidationData.IsValidPhone(c.Phone))
                return (false, "Số điện thoại không hợp lệ.");

            if (!ValidationData.IsValidEmail(c.Email))
                return (false, "Email không hợp lệ");

            if (!ValidationData.IsValidGender(c.Gender))
                return (false, "Giới tính không hợp lệ");

            if (!ValidationData.IsValidDecimal(c.Point))
                return (false, "Số điểm không hợp lệ");

            if (!ValidationData.IsValidInt(c.Drips))
                return (false, "Điểm Drips không hợp lệ");

            return (true, "Dữ liệu hợp lệ.");
        }

        private bool IsDuplicatedPhone(string phone, string id = null)
        {
            var existingPhone = dAL_Customer.GetAll()
                .FirstOrDefault(c => c.Phone == phone);

            // Nếu chưa có ai dùng số này
            if (existingPhone == null)
                return false;

            // Nếu là khách đang chọn
            if (id != null && existingPhone.Id == id)
                return false;

            // Nếu có khách khác
            return true;
        }

        public void Add(Customer customer) 
        {
            if (!ValidateInput(customer).IsValid)
                throw new Exception($"{ValidateInput(customer).Message}");

            if (IsDuplicatedPhone(customer.Phone))
                throw new Exception("Số điện thoại này đã tồn tại");

            dAL_Customer.Add(customer); 
        }

        public void Update(Customer customer) 
        {
            if (string.IsNullOrWhiteSpace(customer.Id))
                throw new Exception("Thiếu Id khách hàng, không thể cập nhật");

            if (!ValidateInput(customer).IsValid)
                throw new Exception($"{ValidateInput(customer).Message}");

            if (IsDuplicatedPhone(customer.Phone, customer.Id))
                throw new Exception("Số điện thoại này đã tồn tại");

            dAL_Customer.Update(customer);
        }

        public void Delete(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                throw new Exception("Thiếu Id khách hàng, không thể cập nhật");

            dAL_Customer.Delete(id); 
        }

        public string GenerateId(string phone)
        {
            // Tự động tạo 4 kí tự random
            string randomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
            return $"CS{phone}{randomString}"; // In ra Id khách bằng sđt + 4 kí tự random
        }
    }
}
