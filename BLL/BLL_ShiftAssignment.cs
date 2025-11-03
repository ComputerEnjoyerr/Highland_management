using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ShiftAssignment
    {
        private readonly DAL_ShiftAssignment dAL_ShiftAssignment = new();

        public List<ShiftAssignment> GetAll() { return dAL_ShiftAssignment.GetAll(); }

        public ShiftAssignment GetById(string id)
        {
            var shiftAssignment = dAL_ShiftAssignment.GetById(id);
            if (shiftAssignment == null)
            {
                return new ShiftAssignment();
            }
            return shiftAssignment;
        }

        public void Add(ShiftAssignment shiftAssignment)
        {
            dAL_ShiftAssignment.Add(shiftAssignment);
        }

        public void Delete(ShiftAssignment shiftAssignment)
        {
            dAL_ShiftAssignment.Delete(shiftAssignment);
        }

        public void Update(ShiftAssignment shiftAssignment)
        {
            dAL_ShiftAssignment.Update(shiftAssignment);
        }
    }
}
