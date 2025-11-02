using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Account
    {
        private readonly DAL_Account dAL_Account = new();
        
        public List<Account> GetAll()
        {
            var accounts = dAL_Account.GetAll();
            if (accounts == null || accounts.First() == null)
                throw new Exception($"Không có tài khoản nào trong CSDL");
            return accounts;
            
        }

        public Account GetById(string id)
        {
            return dAL_Account.GetById(id);
        }

        private (bool IsValid, string Message) ValidateInput(Account a)
        {
            if (!ValidationData.IsNotEmpty(a.AccountName))
                return (false, "Tên tài khoản không được bỏ trống");

            if (!ValidationData.IsNotEmpty(a.Password))
                return (false, "Mật khẩu không được bỏ trống");

            return (true, "Dữ liệu hợp lệ.");
        }

        public void Add(Account account)
        {
            if (!ValidateInput(account).IsValid)
                throw new Exception($"{ValidateInput(account).Message}");

            dAL_Account.Add(account);
        }

        public void Update(Account account)
        {
            if (string.IsNullOrEmpty(account.Id))
                throw new Exception("Thiếu Id, không thể cập nhật");

            if (!ValidateInput(account).IsValid)
                throw new Exception($"{ValidateInput(account).Message}");

            dAL_Account.Update(account);
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Thiếu Id, không thể xóa");

            dAL_Account.Remove(id);
        }
    }
}
