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
        public Notification GetByType(string type)
        {
            return _dalNotification.GetByType(type);
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

        public string GenerateNotificationId(string type)
        {
            // Id được tạo ra từ ngày hiện tại + số ngẫu nhiên 4 chữ số
            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string randomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
            string typePart = type.ToUpper().Substring(0, 3);
            return $"NT{typePart}{datePart}{randomString}";
        }
    }
}
