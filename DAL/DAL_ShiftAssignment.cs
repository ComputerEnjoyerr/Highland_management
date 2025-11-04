using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_ShiftAssignment
    {
        private readonly HighlandsContext _context = new();

        public List<ShiftAssignment> GetAll()
        {
            return _context.ShiftAssignments
                .Include(sA => sA.Employee)
                .Include(sA => sA.Shift)
                .ToList();
        }

        public ShiftAssignment? GetById(string id)
        {
            return _context.ShiftAssignments
            .Include(sA => sA.Employee)
            .Include(sA => sA.Shift)
            .FirstOrDefault(sA => sA.Id == id);
        }

        public void Add(ShiftAssignment shiftAssignment)
        {
            _context.ShiftAssignments.Add(shiftAssignment);
            _context.SaveChanges();
        }

        public void Delete(ShiftAssignment shiftAssignment)
        {
            var existingShiftAssignment = _context.ShiftAssignments.FirstOrDefault(sA => sA.Id == shiftAssignment.Id);
            if (existingShiftAssignment != null)
            {
                _context.ShiftAssignments.Remove(existingShiftAssignment);
                _context.SaveChanges();
            }
        }

        public void Update(ShiftAssignment shiftAssignment)
        {
            var oldShiftAssignment = _context.ShiftAssignments.FirstOrDefault(sA => sA.Id == shiftAssignment.Id);
            if (oldShiftAssignment != null)
            {
                oldShiftAssignment.EmployeeId = shiftAssignment.EmployeeId;
                oldShiftAssignment.ShiftId = shiftAssignment.ShiftId;
                oldShiftAssignment.Note = shiftAssignment.Note;
                _context.SaveChanges();
            }
        }

        // Lấy ca làm việc theo ngày và ca
        public List<ShiftAssignment> GetByDateAndShift(int day, int month, int year, string shift)
        {
            return _context.ShiftAssignments
                .Include(sA => sA.Employee)
                .Include(sA => sA.Shift)
                .Where(sA =>
                    sA.Shift != null &&
                    sA.Shift.WorkDate.Day == day &&
                    sA.Shift.WorkDate.Month == month &&
                    sA.Shift.WorkDate.Year == year &&
                    sA.Shift.ShiftType == shift)
                .ToList();
        }
    }
}
