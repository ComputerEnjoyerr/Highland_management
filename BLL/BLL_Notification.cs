using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_Notification
    {
        private readonly DAL_Notification _dalNotification = new();
        public List<Notification> GetAll()
        {
            return _dalNotification.GetAll();
        }
        public Notification GetById(string id)
        {
            return _dalNotification.GetById(id);
        }
        public Notification GetByName(string name)
        {
            return _dalNotification.GetByName(name);
        }
        public List<Notification> GetByEmployeeId(string employeeId)
        {
            return _dalNotification.GetByEmployeeId(employeeId);
        }

        public void Add(Notification notification)
        {
            _dalNotification.Add(notification);
        }

        public void Remove(string id)
        {
            _dalNotification.Remove(id);
        }

        public void UpdateReadStatus(string id, bool isRead)
        {
            var notification = _dalNotification.GetById(id);
            if (notification != null)
            {
                notification.IsRead = isRead;
                // Assuming there's an Update method in DAL_Notification
                _dalNotification.Update(notification);
            }
        }
    }
}
