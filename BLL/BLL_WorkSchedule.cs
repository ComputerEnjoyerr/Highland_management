using DAL;
using DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_WorkSchedule
    {
        private readonly DAL_WorkSchedule dAL_WorkSchedule = new DAL_WorkSchedule();

        public List<WorkSchedule> GetAll() { return dAL_WorkSchedule.GetAll(); }
        public WorkSchedule? GetById(string id)
        {
            return dAL_WorkSchedule.GetById(id);
        }
        public void Add(WorkSchedule workSchedule)
        {
            dAL_WorkSchedule.Add(workSchedule);
        }
        public void Update(WorkSchedule workSchedule)
        {
            if (string.IsNullOrWhiteSpace(workSchedule.Id))
                throw new Exception("Thiếu ID chấm công khi cập nhật.");
            dAL_WorkSchedule.Update(workSchedule);
        }
        public void Delete(string id)
        {
            dAL_WorkSchedule.Delete(id);
        }

        // Lấy lịch làm việc theo chi nhánh và tuần
        public WorkSchedule? GetByBranchAndWeek(string branchId, DateOnly weekStart, DateOnly weekEnd)
        {
            return dAL_WorkSchedule.GetByBranchAndWeek(branchId, weekStart, weekEnd);
        }

        // Hàm tạo mã tự động
        public string GenerateScheduleId()
        {
            string prefix = "WS" + DateTime.Now.ToString("yyMM");

            var all = dAL_WorkSchedule.GetAll()
                .Where(s => s.Id.StartsWith(prefix))
                .OrderByDescending(s => s.Id)
                .ToList();

            int nextNumber = 1;
            if (all.Any())
            {
                string lastId = all.First().Id;
                if (int.TryParse(lastId.Substring(6, 4), out int current))
                    nextNumber = current + 1;
            }

            return $"{prefix}{nextNumber:D4}";
        }

        public DataTable GetScheduleByDate(DateTime selectedDate)
        {
            return dAL_WorkSchedule.GetScheduleByDate(selectedDate);
        }
    }
}
