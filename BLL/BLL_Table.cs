using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Table
    {
        private readonly DAL_Table dAL_Table = new();

        public List<Table> GetByBranch(string branchId)
        {
            return dAL_Table.GetByBranch(branchId);
        }

        public void Add(Table table)
        {
            // Kiểm tra tên bàn rỗng
            if (string.IsNullOrWhiteSpace(table.TableName))
                throw new Exception("Tên bàn không được để trống!");

            // Kiểm tra độ dài (tối đa 10 ký tự)
            if (table.TableName.Length > 10)
                throw new Exception("Tên bàn tối đa 10 ký tự!");

            // Kiểm tra sức chứa
            if (table.Capacity <= 0)
                throw new Exception("Sức chứa của bàn phải lớn hơn 0!");

            // Kiểm tra status
            if (table.Status != 0 && table.Status != 1)
                throw new Exception("Trạng thái bàn không hợp lệ!");

            // Kiểm tra chi nhánh tồn tại
            if (!dAL_Table.CheckBranchExists(table.BranchId))
                throw new Exception("Chi nhánh không tồn tại!");

            // Kiểm tra trùng tên trong cùng chi nhánh
            if (dAL_Table.IsTableNameExists(table.BranchId, table.TableName))
                throw new Exception("Tên bàn đã tồn tại trong chi nhánh này!");
            dAL_Table.Add(table);
        }

        public void Update(Table table)
        {
            dAL_Table.Update(table);
        }

        public void Remove(int id)
        {
            // Kiểm tra bàn có tồn tại không
            var table = dAL_Table.GetById(id);
            if (table == null)
                throw new Exception("Bàn không tồn tại!");

            // Không cho xóa nếu bàn đang được đặt
            if (table.Status == 1)
                throw new Exception("Bàn đang được sử dụng, không thể xóa!");

            // Kiểm tra liên kết với BILL
            if (dAL_Table.IsTableUsedInBill(id))
                throw new Exception("Bàn đã được sử dụng trong hóa đơn, không thể xóa!");
            dAL_Table.Remove(id);
        }

        public Table? GetById(int id)
        {
            return dAL_Table.GetById(id);
        }
    }
}
