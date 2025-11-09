using DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Branch
    {
        private readonly HighlandsContext _context = new();

        public List<Branch> GetAll()
        {
            return _context.Branches
                .Include(b => b.Address)
                .ThenInclude(a => a.Ward)
                .ThenInclude(w => w.Province)
                .ToList();
        }

        public void Add(Branch branch)
        {
            _context.Branches.Add(branch);
            _context.SaveChanges();
        }

        public Branch? GetById(string id)
        {
            return _context.Branches
                .Include(p => p.Address)
                .FirstOrDefault(p => p.Id == id);
        }

        public void Update(Branch branch)
        {
            var existing = _context.Branches.FirstOrDefault(b => b.Id == branch.Id);
            if (existing != null)
            {
                existing.BranchName = branch.BranchName;
                existing.AddressId = branch.AddressId;
                existing.Phone = branch.Phone;
                existing.OpenTime = branch.OpenTime;
                existing.CloseTime = branch.CloseTime;
                existing.Status = branch.Status;
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var branch = _context.Branches.FirstOrDefault(b => b.Id == id);
            if (branch != null)
            {
                _context.Branches.Remove(branch);
                _context.SaveChanges();
            }
        }

        //Hàm kiểm tra tên chi nhánh đã tồn tại hay chưa
        public bool IsBranchNameExists(string branchName)
        {
            return _context.Branches.Any(b => b.BranchName == branchName);
        }

        //Hàm kiểm tra số điện thoại đã tồn tại hay chưa
        public bool IsPhoneExists(string phone)
        {
            return _context.Branches.Any(b => b.Phone == phone);
        }

        // Hàm in report chi nhánh
        public DataTable GetBranchByFilter(string? provinceName, string? wardName)
        {
            var sql = @"
            SELECT 
                B.Id AS BranchId,
                B.BranchName,
                B.Phone,
                B.OpenTime,
                B.CloseTime,
                B.Status,
                A.Name AS AddressName,
                W.WardName,
                P.ProvinceName,
                P.CodeName
            FROM BRANCH B
            JOIN ADDRESS A ON B.AddressId = A.Id
            JOIN WARD W ON A.WardId = W.Id
            JOIN PROVINCE P ON W.ProvinceId = P.Id
            WHERE
                (@ProvinceName IS NULL OR P.ProvinceName = @ProvinceName)
                AND (@WardName IS NULL OR W.WardName = @WardName)
            ORDER BY 
                P.ProvinceName, 
                W.WardName, 
                B.BranchName;";

            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = sql;

                // Thêm tham số vào lệnh
                cmd.Parameters.Add(new SqlParameter("@ProvinceName",
                    string.IsNullOrEmpty(provinceName) ? DBNull.Value : provinceName));
                cmd.Parameters.Add(new SqlParameter("@WardName",
                    string.IsNullOrEmpty(wardName) ? DBNull.Value : wardName));

                // Mở kết nối
                _context.Database.OpenConnection();

                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }
    }
}
