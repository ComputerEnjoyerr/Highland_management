using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Branch
    {
        private readonly DAL_Branch dAL_Branch = new();
        BLL_Employee bLL_Employee = new BLL_Employee();
        BLL_Province bLL_Province = new BLL_Province();
        BLL_Ward bLL_Ward = new BLL_Ward();

        public List<Branch> GetAll() { return dAL_Branch.GetAll(); }

        public Branch GetById(string id)
        {
            var branch = dAL_Branch.GetById(id);
            if (branch == null)
            {
                return new Branch();
            }
            return branch;
        }

        public void Add(Branch branch)
        {
            ValidateBranch(branch);

            if (!ValidateInput(branch).IsValid)
                throw new Exception($"{ValidateInput(branch).Message}");

            dAL_Branch.Add(branch);
        }

        public void Update(Branch branch)
        {
            // Kiểm tra nếu có chi nhánh khác dùng cùng số điện thoại
            var allBranches = dAL_Branch.GetAll();
            if (allBranches.Any(b => b.Phone == branch.Phone && b.Id != branch.Id))
                throw new Exception("Số điện thoại này đã được chi nhánh khác sử dụng!");
            if (string.IsNullOrWhiteSpace(branch.Id))
                throw new Exception("Thiếu ID chi nhánh khi cập nhật.");
            if (string.IsNullOrWhiteSpace(branch.BranchName))
                throw new Exception("Tên chi nhánh không được để trống.");

            if (!ValidateInput(branch).IsValid)
                throw new Exception($"{ValidateInput(branch).Message}");

            dAL_Branch.Update(branch);
        }

        public void Delete(string id)
        {
            // Kiểm tra xem còn nhân viên trong chi nhánh không
            var employees = bLL_Employee.GetEmployeesByBranchId(id);
            if (employees != null && employees.Count > 0)
                throw new Exception("Không thể xóa chi nhánh vì vẫn còn nhân viên đang làm việc.");

            // Nếu không có nhân viên thì xóa chi nhánh
            dAL_Branch.Delete(id);
        }

        //Hàm kiểm tra hợp lệ của chi nhánh
        private void ValidateBranch(Branch branch)
        {
            // Kiểm tra tên chi nhánh
            if (string.IsNullOrWhiteSpace(branch.BranchName))
                throw new Exception("Tên chi nhánh không được để trống.");
            if (dAL_Branch.IsBranchNameExists(branch.BranchName))
                throw new Exception("Tên chi nhánh đã tồn tại.");
            if (branch.BranchName.Length > 80)
                throw new Exception("Tên chi nhánh không được vượt quá 80 ký tự.");

            // Kiểm tra địa chỉ
            if (string.IsNullOrWhiteSpace(branch.AddressId))
                throw new Exception("Chi nhánh phải có mã địa chỉ hợp lệ.");

            // Kiểm tra giờ mở cửa - đóng cửa
            if (branch.OpenTime == branch.CloseTime)
                throw new Exception("Giờ mở cửa và giờ đóng cửa không được trùng nhau.");
            if (branch.OpenTime >= branch.CloseTime)
                throw new Exception("Giờ đóng cửa phải sau giờ mở cửa.");

            // Kiểm tra trạng thái
            if (string.IsNullOrWhiteSpace(branch.Status))
                throw new Exception("Trạng thái chi nhánh không được để trống.");
        }
        public void Remove(Branch branch) { dAL_Branch.Delete(branch.Id); }

        // Hàm tao mã chi nhánh tự động
        public string GenerateBranchId(string provinceId)
        {
            string codeName = bLL_Province.GetAllProvinces()
                .FirstOrDefault(p => p.Id == provinceId)?.CodeName ?? "XX";
            string timesTamp = DateTime.Now.ToString("mmss");
            string ranDomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
            string branchId = $"{codeName}{timesTamp}{ranDomString}";
            return branchId.Length > 10 ? branchId.Substring(0, 10) : branchId;
        }

        // Hàm kt tên chi nhánh đã tồn tại hay chưa
        public bool IsBranchNameExists(string branchName)
        {
            return dAL_Branch.IsBranchNameExists(branchName);
        }

        // Hàm kt trùng số điện thoại chi nhánh
        public Branch GetBranchByPhone(string phone, string id = null)
        {
            var existing = dAL_Branch.GetById(id);
            var existingPhone = dAL_Branch.GetAll()
                .FirstOrDefault(b => b.Phone == phone);
            if (existingPhone == null)
            {
                return null;
            }
            if (existing != null)
            {
                return null;
            }
            return existingPhone;
        }

        private (bool IsValid, string Message) ValidateInput(Branch b)
        {
            if (!ValidationData.IsValidName(b.BranchName))
                return (false, "Tên chi nhánh không hợp lệ.");

            if (!ValidationData.IsValidPhone(b.Phone))
                return (false, "Số điện thoại không hợp lệ.");

            if (!ValidationData.IsValidAddress(b.AddressId))
                return (false, "Địa chỉ chi nhánh không hợp lệ.");

            if (!ValidationData.IsValidTimeRange(b.OpenTime?.ToTimeSpan() ?? TimeSpan.Zero, b.CloseTime?.ToTimeSpan() ?? TimeSpan.Zero))
                return (false, "Khoảng thời gian mở - đóng cửa không hợp lệ.");

            return (true, "Dữ liệu hợp lệ.");
        }

        // Hàm in repport chi nhánh
        public DataTable GetBranchByFilter(string? provinceName, string? wardName)
        {
            return dAL_Branch.GetBranchByFilter(provinceName, wardName);
        }
    }
}
