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
            .Include(sA => sA.Shift)
            .Include(sA => sA.Employee)
            .ToList();
        }

        public ShiftAssignment? GetById(string id)
        {
            return _context.ShiftAssignments
            .Include(sA => sA.Shift)
            .Include(sA => sA.Employee)
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
                .ThenInclude(s => s.WorkSchedule)
                .Where(sA =>
                    sA.Shift != null &&
                    sA.Shift.WorkDate.Day == day &&
                    sA.Shift.WorkDate.Month == month &&
                    sA.Shift.WorkDate.Year == year &&
                    sA.Shift.ShiftType == shift &&
                    sA.Shift.WorkSchedule != null)
                .ToList();
        }

        // Hàm lấy lịch sử phân công ca làm việc của nhân viên theo ID nhân viên
        public List<ShiftAssignment> GetByEmployeeId(string employeeId)
        {
            return _context.ShiftAssignments
                .Include(sA => sA.Employee)
                .Include(sa => sa.Shift)
                    .ThenInclude(s => s.WorkSchedule)
                        .ThenInclude(ws => ws.Branch)
                .Where(sa => sa.EmployeeId == employeeId)
                .OrderBy(sa => sa.Shift.WorkDate)
                .ThenBy(sa => sa.Shift.ShiftType)
                .ToList();
        }

        public List<ShiftAssignment> GetShiftAssignmentsForToday()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);

            return _context.ShiftAssignments
                .Include(sa => sa.Employee)
                .Include(sa => sa.Shift)
                .ThenInclude(s => s.WorkSchedule)
                .Where(sa => sa.Shift.WorkDate >= today && sa.Shift.WorkDate < today.AddDays(1))
                .ToList();
        }
    }
}
