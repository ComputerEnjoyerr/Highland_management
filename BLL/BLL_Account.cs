using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Account
    {
        private readonly DAL_Account dAL_Account = new();

        // Lưu thông tin tài khoản hiện tại sau khi đăng nhập thành công
        public static Account? CurrentUser { get; private set; }

        // Hàm lấy nhân viên hiện tại từ tài khoản đăng nhập
        public Employee GetCurrentEmployee()
        {
            if (CurrentUser == null)
                throw new Exception("Chưa đăng nhập.");

            BLL_Employee bllEmployee = new BLL_Employee();
            var emp = bllEmployee.GetById(CurrentUser.EmployeeId);

            if (emp == null)
                throw new Exception("Không tìm thấy thông tin nhân viên của tài khoản.");

            return emp;
        }

        // Hàm lấy chi nhánh hiện tại từ nhân viên đăng nhập
        public string GetCurrentBranchId()
        {
            var emp = GetCurrentEmployee();

            if (string.IsNullOrEmpty(emp.BranchId))
                throw new Exception("Nhân viên không thuộc chi nhánh nào!");

            return emp.BranchId;
        }


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

            if (a.Password.Length > 50)
                return (false, "Mật khẩu không được vượt quá 50 ký tự");

            // Regex kiểm tra mật khẩu mạnh
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+\-=\[\]{}|;':"",.<>/?]).+$");
            if (!regex.IsMatch(a.Password))
                return (false, "Mật khẩu phải có chữ hoa, chữ thường, số và ký tự đặc biệt");

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

        // Hàm tạo id tài khoản mới
        public string GenerateNewAccountId()
        {
            string prefix = "AC";
            string datePart = DateTime.Now.ToString("ddMMyyyy"); // ddMMyyyy
            string todayPrefix = prefix + datePart;

            var allAccounts = dAL_Account.GetAll();

            // Lọc các account cùng ngày
            var todayAccounts = allAccounts
                .Where(a => !string.IsNullOrEmpty(a.Id) && a.Id.StartsWith(todayPrefix))
                .ToList();

            int nextNumber = 1;
            if (todayAccounts.Count > 0)
            {
                // Lấy số thứ tự lớn nhất trong các ID cùng ngày
                nextNumber = todayAccounts
                    .Select(a => int.Parse(a.Id.Substring(todayPrefix.Length))) // lấy phần số cuối
                    .Max() + 1;
            }

            string newId = todayPrefix + nextNumber.ToString("D3"); // 3 số, điền 0 nếu thiếu
            return newId;
        }

    }
}
