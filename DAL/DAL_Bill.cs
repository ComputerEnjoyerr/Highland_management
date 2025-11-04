using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Bill
    {
        private readonly HighlandsContext context = new();

        public List<Bill> GetAll()
        {
            return context.Bills
                .Include(b => b.Branch)
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .ToList();
        }

        public void Add(Bill bill)
        {
            context.Bills.Add(bill);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var bill = context.Bills.FirstOrDefault(b => b.Id == id);
            if (bill != null)
            {
                context.Bills.Remove(bill);
                context.SaveChanges();
            }
        }

        public void Update(Bill bill)
        {
            var existingBill = context.Bills.FirstOrDefault(b => b.Id == bill.Id);
            if (existingBill != null)
            {
                existingBill.BranchId = bill.BranchId;
                existingBill.EmployeeId = bill.EmployeeId;
                existingBill.CustomerId = bill.CustomerId;
                existingBill.CreateDate = bill.CreateDate;
                existingBill.Status = bill.Status;
                context.SaveChanges();
            }
        }
    }
}
