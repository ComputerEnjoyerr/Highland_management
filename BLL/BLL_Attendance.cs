using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Attendance
    {
        private readonly DAL_Attendance dAL_Attendance = new();
        public List<Attendance> GetAll() { return dAL_Attendance.GetAll(); }
        public Attendance? GetById(string id)
        {
            return dAL_Attendance.GetById(id);
        }
        public void Add(Attendance attendance)
        {
            dAL_Attendance.Add(attendance);
        }
        public void Update(Attendance attendance)
        {
            if (string.IsNullOrWhiteSpace(attendance.Id))
                throw new Exception("Thiếu ID chấm công khi cập nhật.");
            dAL_Attendance.Update(attendance);
        }
        public void Delete(string id)
        {
            dAL_Attendance.Delete(id);
        }

        public string GenerateId()
        {
            string prefix = "AT";
            string timeTamp = DateTime.Now.ToString("yyMMddHHmmss");
            string ranDomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();

            string attendanceId = $"{prefix}{timeTamp}{ranDomString}";
            return attendanceId.Length > 20 ? attendanceId.Substring(0, 20) : attendanceId;
        }
    }
}
