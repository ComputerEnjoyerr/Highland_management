using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Attendance
    {
        private readonly HighlandsContext _context = new();

        public List<Attendance> GetAll()
        {
            return _context.Attendances
                .Include(a => a.Employee)
                .Include(a => a.Branch)
                .Include(a => a.Shift)
                .ToList();
        }

        public void Add(Attendance attendance)
        {
            _context.Attendances.Add(attendance);
            _context.SaveChanges();
        }

        public void Update(Attendance attendance)
        {
            var oldAttendance = _context.Attendances.FirstOrDefault(a => a.Id == attendance.Id);
            if (oldAttendance != null)
            {
                oldAttendance.EmployeeId = attendance.EmployeeId;
                oldAttendance.ShiftId = attendance.ShiftId;
                oldAttendance.BranchId = attendance.BranchId;
                oldAttendance.CheckIn = attendance.CheckIn;
                oldAttendance.CheckOut = attendance.CheckOut;
                oldAttendance.OvertimeHours = attendance.OvertimeHours;
                oldAttendance.Status = attendance.Status;
                oldAttendance.Method = attendance.Method;
                oldAttendance.ApprovedBy = attendance.ApprovedBy;
                oldAttendance.Note = attendance.Note;
                _context.SaveChanges();
            }
        }

        public void Delete(string id)
        {
            var attendance = _context.Attendances.FirstOrDefault(a => a.Id == id);
            if (attendance != null)
            {
                _context.Attendances.Remove(attendance);
                _context.SaveChanges();
            }
        }

        public Attendance? GetById(string id)
        {
            return _context.Attendances
            .Include(A => A.Employee)
            .Include(a => a.Branch)
            .Include(a => a.Shift)
            .FirstOrDefault(a => a.Id == id);
        }
    } 
}
