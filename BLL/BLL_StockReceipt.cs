using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_StockReceipt
    {
        private readonly DAL_StockReceipt dAL_StockReceipt = new();

        public List<StockReceipt> GetAll() => dAL_StockReceipt.GetAll();

        private (bool IsValid, string Message) ValidateInput(StockReceipt s)
        {
            if (!ValidationData.IsNotEmpty(s.SupplierId))
                return (false, "Nhà cung cấp không được bỏ trống");

            if (!ValidationData.IsNotEmpty(s.CreatedBy))
                return (false, "Người tạo phiếu không được bỏ trống");

            if (!ValidationData.IsValidDecimal(s.TotalPrice))
                return (false, "Không tính được tổng tiền hợp lệ");

            if (!ValidationData.IsValidInt(s.Quantity))
                return (false, "Số lượng không hợp lệ");

            return (true, "Dữ liệu hợp lệ.");
        }

        public void Add(StockReceipt stock)
        {
            if (!ValidateInput(stock).IsValid)
                throw new Exception($"{ValidateInput(stock).Message}");
            dAL_StockReceipt.Add(stock);
        }

        public void Update(StockReceipt stock)
        {
            if (string.IsNullOrEmpty(stock.Id))
                throw new Exception("Thiếu Id phiếu nhập, không thể cập nhật");
            if (!ValidateInput(stock).IsValid)
                throw new Exception($"{ValidateInput(stock).Message}");
            dAL_StockReceipt.Update(stock);
        }

        public void Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Thiếu Id phiếu nhập, không thể xóa");
            dAL_StockReceipt.Delete(id);
        }
    }
}
