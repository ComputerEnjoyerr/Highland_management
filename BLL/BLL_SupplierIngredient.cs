using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_SupplierIngredient
    {
        private readonly DAL_SupplierIngredient dAL_SupplierIngredient = new();

        public List<SupplierIngredient> GetAll()
        {
            return dAL_SupplierIngredient.GetAll();
        }

        public void Add(SupplierIngredient supplierIngredient)
        {
            dAL_SupplierIngredient.Add(supplierIngredient);
        }


        public void Update(SupplierIngredient supplierIngredient)
        {
            dAL_SupplierIngredient.Update(supplierIngredient);
        }

        public void Delete(string supplierId, string ingredientId)
        {
            dAL_SupplierIngredient.Delete(supplierId, ingredientId);
        }
    }
}
