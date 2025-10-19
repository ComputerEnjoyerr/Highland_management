using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Ward
    {
        public readonly DAL_Ward dAL_Ward = new();

        public List<DTO.Ward> GetWardByProvinceId(string provinceId)
        {
            return dAL_Ward.GetWardByProvinceId(provinceId);
        }

        public DTO.Ward? GetWardById(string wardId)
        {
            return dAL_Ward.GetWardById(wardId);
        }


    }
}
