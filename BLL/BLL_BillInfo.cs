using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_BillInfo
    {
        private readonly DAL_BillInfo dAL_BillInfo = new();

        public List<Billinfo> GetAll()
        {
            return dAL_BillInfo.GetAll();
        }

        public List<Billinfo> GetByBillId(string billId)
        {
            return dAL_BillInfo.GetByBillId(billId);
        }

        public void Add(Billinfo billinfo)
        {
            dAL_BillInfo.Add(billinfo);
        }

        public void Delete(int id)
        {
            dAL_BillInfo.Delete(id);
        }

        public void Update(Billinfo billinfo)
        {
            dAL_BillInfo.Update(billinfo);
        }
    }
}
