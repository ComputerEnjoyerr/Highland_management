using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Bill
    {
        private readonly DAL_Bill dAL_Bill = new();
        public List<Bill> GetAll()
        {
            return dAL_Bill.GetAll();
        }
        public void Add(Bill bill)
        {
            dAL_Bill.Add(bill);
        }
        public void Delete(string id)
        {
            dAL_Bill.Delete(id);
        }
        public void Update(Bill bill)
        {
            dAL_Bill.Update(bill);
        }

        public string GenerateBillId()
        {
            // Id được tạo ra từ ngày hiện tại + số ngẫu nhiên 4 chữ số
            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string randomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
            return $"BILL{datePart}{randomString}";

        }

        public DataTable GetBillHeader(string billId)
        {
            try
            {
                var headerTable = dAL_Bill.GetBillHeader(billId);
                if (headerTable == null || headerTable.Rows.Count == 0)
                {
                    throw new Exception("Không tìm thấy thông tin header cho BillId: " + billId);
                }
                return headerTable;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin header cho BillId {billId}: {ex.Message}", ex);
            }
        }

        public DataTable GetBillDetail(string billId)
        {
            try
            {
                var detailTable = dAL_Bill.GetBillDetail(billId);
                if (detailTable == null || detailTable.Rows.Count == 0)
                {
                    throw new Exception("Không tìm thấy thông tin chi tiết cho BillId: " + billId);
                }
                return detailTable;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin chi tiết cho BillId {billId}: {ex.Message}", ex);
            }
        }

        public DataSet GetBillForPrint(string billId)
        {
            return dAL_Bill.GetBillForPrint(billId);
        }
    }
}
