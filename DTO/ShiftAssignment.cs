using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ShiftAssignment
    {
        private string _id, _shiftId, _employeeid, _note;

        public ShiftAssignment() { }
        public ShiftAssignment(string id, string shiftId, string employeeid, string note)
        {
            Id = id;
            ShiftId = shiftId;
            Employeeid = employeeid;
            Note = note;
        }

        public string Id { get => _id; set => _id = value; }
        public string ShiftId { get => _shiftId; set => _shiftId = value; }
        public string Employeeid { get => _employeeid; set => _employeeid = value; }
        public string Note { get => _note; set => _note = value; }
    }
}
