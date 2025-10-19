using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Province
    {
        public readonly DAL_Province dAL_Province = new();

        public List<DTO.Province> GetAllProvinces()
        {
            return dAL_Province.GetAllProvinces();
        }
        public DTO.Province? GetProvinceById(string id)
        {
            return dAL_Province.GetProvinceById(id);
        }

        //Lấy codeName
        //private string GetProvinceCodeName(string provinceId)
        //{
        //    var province = dAL_Province.GetProvinceById(provinceId);
        //    return province?.CodeName ?? "XX";
        //}
    }
}
