using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Table
    {
        private readonly HighlandsContext context = new();

        public List<Table> GetByBranch(string branchId)
        {
            return context.Tables
                .Where(t =>  t.BranchId == branchId)
                .Include(t => t.Branch)
                .ToList();
        }

        public void Add(Table table)
        {
            context.Tables.Add(table);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var table = context.Tables.FirstOrDefault(t => t.Id == id);
            if (table != null)
            {
                context.Tables.Remove(table);
                context.SaveChanges();
            }
        }

        public void Update(Table table)
        {
            var existingTable = context.Tables.FirstOrDefault(t => t.Id == table.Id);
            if (existingTable != null)
            {
                existingTable.TableName = table.TableName;
                existingTable.BranchId = table.BranchId;
                existingTable.Capacity = table.Capacity;
                existingTable.Status = table.Status;
                context.SaveChanges();
            }
        }
    }
}
