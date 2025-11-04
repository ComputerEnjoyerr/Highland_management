using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Table
    {
        private readonly DAL_Table dAL_Table = new();

        public List<Table> GetByBranch(string branchId)
        {
            return dAL_Table.GetByBranch(branchId);
        }

        public void Update(Table table)
        {
            dAL_Table.Update(table);
        }
    }
}
