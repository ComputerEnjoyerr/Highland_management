using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Province
    {
        private readonly HighlandsContext _context = new();

        public List<Province> GetAllProvinces()
        {
            return _context.Provinces.ToList();
        }
        public Province? GetProvinceById(string id)
        {
            return _context.Provinces.FirstOrDefault(p => p.Id == id);
        }
    }
}
