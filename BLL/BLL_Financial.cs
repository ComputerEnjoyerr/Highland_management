using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Financial
    {
        private readonly DAL_Financial dAL_Financial = new();

        public List<Financial> GetAll()
        {
            return dAL_Financial.GetALl();
        }
        public Financial? GetByMonthYear(int month, int year)
        {
            return  dAL_Financial.GetByMonthYear(month, year);
        }
        

        
        public void Update(Financial financial)
        {
            dAL_Financial.Update(financial);
        }

    }
    
}
