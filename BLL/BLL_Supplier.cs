using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Supplier
    {
        public readonly DAL_Supplier dAL_Supplier = new();       
        BLL_Province bLL_Province = new BLL_Province();
        BLL_Ward bLL_Ward = new BLL_Ward();

        public List<DTO.Supplier> GetAllSuppliers()
        {
            return dAL_Supplier.GetAllSuppliers();
        }
        //Lấy số thứ tự tiếp theo
        private int GetNextNumber()
        {
            var allSuppliers = dAL_Supplier.GetAllSuppliers();
            return allSuppliers.Count;
        }

        //Tạo iDSupplier tự động
        public string GenerateSupplierId(string provinceId)
        {
            string prefix = "SP";
            string timesTamp = DateTime.Now.ToString("yyMMddHHmmss");
            string codeName = bLL_Province.GetAllProvinces()
                .FirstOrDefault(p => p.Id == provinceId)?.CodeName ?? "XX";
            //string numberPath = GetNextNumber().ToString("D3");
            string ranDomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();

            string supplierId = $"{prefix}{timesTamp}{codeName}{ranDomString}";
            return supplierId.Length > 20 ? supplierId.Substring(0, 20) : supplierId;
        }
       

        private string getWardName(string wardId)
        {
            var ward = bLL_Ward.GetWardById(wardId);
            return ward?.WardName ?? "Unknown";
        }

        public void Add(Supplier supplier)
        {
           if(string.IsNullOrEmpty(supplier.Id))
                throw new ArgumentException("Mã nhà cung cấp không được để trống!");
           if(string.IsNullOrEmpty(supplier.Name))
                throw new ArgumentException("Tên nhà cung cấp không được để trống!");
            if (string.IsNullOrEmpty(supplier.Phone))
                throw new ArgumentException("Số điện thoại nhà cung cấp không được để trống!");
            if (string.IsNullOrEmpty(supplier.Name))
                throw new ArgumentException("Email nhà cung cấp không được để trống!");

            dAL_Supplier.Add(supplier);
        }

        public void Update(DTO.Supplier supplier)
        {
            if (string.IsNullOrEmpty(supplier.Name))
                throw new ArgumentException("Tên nhà cung cấp không được để trống!");
            dAL_Supplier.Update(supplier);
        }

        public void Delete(string id)
        {
            dAL_Supplier.Delete(id); 
        }

        //
        //public void PrintAddressId(string addressId)
        //{
        //    var wardName = GenerateAddressId(addressId);
        //    Console.WriteLine($"Địa chỉ ID: {wardName}");
        //}

        //kiem tra so dien thoai va email bi trùng
        public Supplier GetEmailSupplier(string email,string id)
        {
            //kiểm tra email có bị trùng với ncc khác không
            var emailSupplier = dAL_Supplier.GetAllSuppliers().FirstOrDefault(s => s.Email == email && s.Id != id);
            //if (emailSupplier == null) return new Supplier();
            //return emailSupplier;

            return emailSupplier ?? new Supplier();
        }

        public Supplier getPhoneSupplier(string phone, string id)
        {
            //kiểm tra số điện thoại có bị trùng với ncc khác không
            var phoneSupplier = dAL_Supplier.GetAllSuppliers().FirstOrDefault(s => s.Phone == phone && s.Id != id);
            //if(phoneSupplier == null) return new Supplier();
            //return phoneSupplier;
            return phoneSupplier ?? new Supplier();
        }

        
    }
}
