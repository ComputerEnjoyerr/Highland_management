using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Inventory
    {
        private readonly HighlandsContext context = new();

        public List<Inventory> GetAllByBranch(string branchId)
        {
            var invList = context.Inventories
                .Where(i =>  i.BranchId == branchId)
                .ToList();
            if (invList.Count > 0 )
            {
                return invList;
            }
            return new List<Inventory>();
        }
    }
}
