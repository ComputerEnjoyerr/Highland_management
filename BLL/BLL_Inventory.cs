using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Inventory
    {
        private readonly DAL_Inventory dAL_Inventory = new();

        private (bool IsValid, string Message) ValidateInput(Inventory inv)
        {
            if (!ValidationData.IsNotEmpty(inv.BranchId))
                return (false, "Chi nhánh không được bỏ trống");
            if (!ValidationData.IsNotEmpty(inv.IngredientId))
                return (false, "Nguyên liệu không được bỏ trống");
            if (!ValidationData.IsValidDecimal(inv.CurrentQuantity))
                return (false, "Số lượng hiện tại không hợp lệ");
            if (!ValidationData.IsValidInt(inv.UnitId))
                return (false, "Đơn vị tính không hợp lệ");
            return (true, "Dữ liệu hợp lệ.");
        }

        public void Add(Inventory newInventoryItem)
        {
            if (!ValidateInput(newInventoryItem).IsValid)
                throw new Exception($"{ValidateInput(newInventoryItem).Message}");
            dAL_Inventory.Add(newInventoryItem);
        }

        public List<Inventory> GetAllByBranch(string branchId)
        {
            return dAL_Inventory.GetAllByBranch(branchId);
        }

        public void Update(Inventory inventoryItem)
        {
            if (string.IsNullOrEmpty(inventoryItem.BranchId) || string.IsNullOrEmpty(inventoryItem.IngredientId))
                throw new Exception("Thiếu Id kho hoặc nguyên liệu, không thể cập nhật");
            if (!ValidateInput(inventoryItem).IsValid)
                throw new Exception($"{ValidateInput(inventoryItem).Message}");
            dAL_Inventory.Update(inventoryItem);
        }

        public List<Inventory> GetLowStockItems(string branchId)
        {
            // Giả sử ngưỡng tồn kho thấp là 10 đơn vị
            decimal lowStockThreshold = 10m;
            return dAL_Inventory.GetAllByBranch(branchId)
                .Where(inv => inv.CurrentQuantity < lowStockThreshold)
                .ToList();
        }
    }
}
