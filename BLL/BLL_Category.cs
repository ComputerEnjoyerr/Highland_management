using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Category
    {
        private readonly DAL.DAL_Category _dalCategory = new();
        public List<DTO.Category> GetAll()
        {
            return _dalCategory.GetAll();
        }
        public DTO.Category? GetById(string id)
        {
            return _dalCategory.GetById(id);
        }
    }
}
