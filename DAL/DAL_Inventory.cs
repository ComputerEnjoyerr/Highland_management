using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Inventory
    {
        private readonly HighlandsContext context = new();

        public void Add(Inventory newInventoryItem)
        {
            context.Inventories.Add(newInventoryItem);
            context.SaveChanges();
        }

        public List<Inventory> GetAllByBranch(string branchId)
        {
            var invList = context.Inventories
                .Where(i =>  i.BranchId == branchId)
                .Include(i => i.Ingredient)
                .Include(i => i.Unit)
                .ToList();
            if (invList.Count > 0 )
            {
                return invList;
            }
            return new List<Inventory>();
        }

        public void Update(Inventory inventoryItem)
        {
            if (inventoryItem == null) return;
            var existingInventory = context.Inventories
                .FirstOrDefault(i => i.BranchId == inventoryItem.BranchId && i.IngredientId == inventoryItem.IngredientId);
            if (existingInventory != null)
            {
                existingInventory.CurrentQuantity = inventoryItem.CurrentQuantity;
                existingInventory.UnitId = inventoryItem.UnitId;
                context.SaveChanges();
            }
        }
    }
}
