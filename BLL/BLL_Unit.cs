using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Unit
    {
        private readonly DAL_Unit dAL_Unit = new();

        public List<Unit> GetAll() { return dAL_Unit.GetAll(); }
        public void Add(Unit unit) { dAL_Unit.Add(unit); }
        public void Remove(int id) { dAL_Unit.Delete(id); }
        public void Update(Unit unit) { dAL_Unit.Update(unit); }
    }
}
