using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_WorkSchedule
    {
        private readonly HighlandsContext _context = new();

        public List<WorkSchedule> GetAll()
        {
            return _context.WorkSchedules
                .Include(wS => wS.Branch)
                .Include(wS => wS.WorkShifts)
                .ToList();
        }

        public void Add(WorkSchedule workSchedule)
        {
            _context.WorkSchedules.Add(workSchedule);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var workSchedule = _context.WorkSchedules.FirstOrDefault(wS => wS.Id == id);
            if (workSchedule != null)
            {
                _context.WorkSchedules.Remove(workSchedule);
                _context.SaveChanges();
            }
        }

        public void Update(WorkSchedule workSchedule)
        {
            var oldWorkSchedule = _context.WorkSchedules.FirstOrDefault(wS => wS.Id == workSchedule.Id);
            if (oldWorkSchedule != null)
            {
                oldWorkSchedule.BranchId = workSchedule.BranchId;
                oldWorkSchedule.WeekStart = workSchedule.WeekStart;
                oldWorkSchedule.WeekEnd = workSchedule.WeekEnd;
                oldWorkSchedule.CreatedBy = workSchedule.CreatedBy;
                oldWorkSchedule.WeekEnd = workSchedule.WeekEnd;
                _context.SaveChanges();
            }
        }

        public WorkSchedule? GetById(string id)
        {
            return _context.WorkSchedules
                .Include(wS => wS.Branch)
                .Include(wS => wS.WorkShifts)
            .FirstOrDefault(wS => wS.Id == id);
        }

        // Lấy lịch làm việc theo chi nhánh và tuần
        public WorkSchedule? GetByBranchAndWeek(string branchId, DateOnly weekStart, DateOnly weekEnd)
        {
            return _context.WorkSchedules
                .Include(wS => wS.Branch)
                .Include(wS => wS.WorkShifts)
                .FirstOrDefault(wS => wS.BranchId == branchId &&
                                wS.WeekStart == weekStart &&
                                wS.WeekEnd == weekEnd);
        }
    }
}
