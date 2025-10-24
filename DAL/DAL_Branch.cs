using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Branch
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

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
    }
}
