using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_Ward
    {
        private readonly HighlandsDatabaseVer2Context _context = new();

        public List<Ward> GetAllWards()
        {
            return _context.Wards.ToList();
        }
        public Ward? GetWardById(string id)
        {
            return _context.Wards.FirstOrDefault(w => w.Id == id);
        }
        public List<Ward>? GetWardByProvinceId(string id)
        {
            return _context.Wards.Where(w => w.ProvinceId == id).ToList();
        }
    }
}
