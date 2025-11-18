using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Notification
    {
        private readonly HighlandsContext _context = new();

        public List<Notification> GetAll()
        {
            return _context.Notifications
                .Include(n => n.Branch)
                .Include(n => n.Employee)
                .ToList();
        }

        public Notification GetById(string id)
        {
            return _context.Notifications
                .Include(n => n.Branch)
                .Include(n => n.Employee)
                .FirstOrDefault(n => n.Id == id);
        }

        public Notification GetByName(string name)
        {
            return _context.Notifications
                .Include(n => n.Branch)
                .Include(n => n.Employee)
                .FirstOrDefault(n => n.Title == name);
        }

        public List<Notification> GetByEmployeeId(string employeeId)
        {
            return _context.Notifications
                .Include(n => n.Branch)
                .Include(n => n.Employee)
                .Where(n => n.EmployeeId == employeeId)
                .ToList();
        }

        public void Add(Notification notification)
        {
            _context.Notifications.Add(notification);
            _context.SaveChanges();
        }

        public void Remove(string id)
        {
            var notification = GetById(id);
            if (notification != null)
            {
                _context.Notifications.Remove(notification);
                _context.SaveChanges();
            }
        }

        public void Update(Notification notification)
        {
            var existing = GetById(notification.Id);
            if (existing != null)
            {
                existing.Title = notification.Title;
                existing.Message = notification.Message;
                existing.Type = notification.Type;
                existing.TargetRole = notification.TargetRole;
                existing.BranchId = notification.BranchId;
                existing.EmployeeId = notification.EmployeeId;
                existing.IsRead = notification.IsRead;
                existing.CreatedAt = notification.CreatedAt;
                _context.SaveChanges();
            }
        }


    }
}
