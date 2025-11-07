using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_WorkShift
    {
        private readonly HighlandsContext _context = new();

        public List<WorkShift> GetAll()
        {
            return _context.WorkShifts
                .Include(wS => wS.WorkSchedule)
                .ToList();
        }

        public void Add(WorkShift workShift)
        {
            _context.WorkShifts.Add(workShift);
            _context.SaveChanges();
        }

        public void Delete(WorkShift workShift)
        {
            var existingWorkShift = _context.WorkShifts.FirstOrDefault(wS => wS.Id == workShift.Id);
            if (existingWorkShift != null)
            {
                _context.WorkShifts.Remove(existingWorkShift);
                _context.SaveChanges();
            }
        }

        public void Update(WorkShift workShift)
        {
            var oldWorkShift = _context.WorkShifts.FirstOrDefault(wS => wS.Id == workShift.Id);
            if (oldWorkShift != null)
            {
                oldWorkShift.ScheduleId = workShift.ScheduleId;
                oldWorkShift.WorkDate = workShift.WorkDate;
                oldWorkShift.ShiftType = workShift.ShiftType;
                _context.SaveChanges();
            }
        }

        public WorkShift? GetById(string id)
        {
            return _context.WorkShifts
                .Include(wS => wS.WorkSchedule)
            .FirstOrDefault(wS => wS.Id == id);
        }

        // Lấy ca làm việc theo ngày và ca
        public WorkShift? GetShiftByDateAndType(DateOnly workDate, string shiftType, string branchId)
        {
            return _context.WorkShifts
                .Include(ws => ws.WorkSchedule)
                .AsEnumerable()
                .FirstOrDefault(ws =>
                    ws.WorkDate == workDate &&
                    ws.ShiftType == shiftType &&
                    ws.WorkSchedule != null &&
                    ws.WorkSchedule.BranchId == branchId);
        }
    }
}
