using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Inventory
    {
        private readonly DAL_Inventory dAL_Inventory = new();

        public List<Inventory> GetAllByBranch(string branchId)
        {
            return dAL_Inventory.GetAllByBranch(branchId);
        }
    }
}
