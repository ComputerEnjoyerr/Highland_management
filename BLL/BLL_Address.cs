using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Address
    {
        DAL_Address dAL_Address = new DAL_Address();
        BLL_Province bLL_Province = new BLL_Province();
        public List<DTO.Address> GetAllAddresses()
        {
            return dAL_Address.GetAllAddresses();
        }
        
        public void Add(DTO.Address address)
        {
            dAL_Address.Add(address);
        }

        public void Update(DTO.Address address)
        {
            dAL_Address.Update(address);
        }

        public void Remove(string id)
        {
            dAL_Address.Remove(id);
        }

        public string GenerateAddressId(string provinceId)
        {
            string prefix = "AD";
            string daysTamp = DateTime.Now.ToString("yyMMdd");
            string codeName = bLL_Province.GetAllProvinces()
                .FirstOrDefault(p => p.Id == provinceId)?.CodeName ?? "XX";
            //string numberPath = GetNextNumber().ToString("D3");
            string timesTamp = DateTime.Now.ToString("HHmmss");
            string ranDomString = Guid.NewGuid().ToString("N").Substring(0, 2).ToUpper();

            string addressId = $"{prefix}{daysTamp}{codeName}{timesTamp}{ranDomString}";
            return addressId.Length > 20 ? addressId.Substring(0, 20) : addressId;
        }
    }
}
