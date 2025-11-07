using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_WorkShift
    {
        private readonly DAL_WorkShift dAL_WorkShift = new DAL_WorkShift();
        public List<WorkShift> GetAll() { return dAL_WorkShift.GetAll(); }
        public WorkShift? GetById(string id)
            {
            return dAL_WorkShift.GetById(id);
        }

        public void Add(WorkShift workShift)
        {
            dAL_WorkShift.Add(workShift);
        }

        public void Update(WorkShift workShift)
        {
            if (string.IsNullOrWhiteSpace(workShift.Id))
                throw new Exception("Thiếu ID ca làm việc khi cập nhật.");
            dAL_WorkShift.Update(workShift);
        }
        public void Delete(WorkShift workShift)
        {
            dAL_WorkShift.Delete(workShift);
        }

        // Lấy ca làm việc theo ngày và ca
        public WorkShift? GetShiftByDateAndType(DateOnly workDate, string shiftType, string branchId)
        {
            return dAL_WorkShift.GetShiftByDateAndType(workDate, shiftType, branchId);
        }

        // Hàm tạo mã tự động
        public string GenerateShiftId()
        {
            string prefix = "WSH" + DateTime.Now.ToString("yyMM");
            var all = dAL_WorkShift.GetAll()
                .Where(s => s.Id.StartsWith(prefix))
                .OrderByDescending(s => s.Id)
                .ToList();
            int nextNumber = 1;
            if (all.Any())
            {
                string lastId = all.First().Id;
                if (int.TryParse(lastId.Substring(7, 4), out int current))
                    nextNumber = current + 1;
            }
            return $"{prefix}{nextNumber:D4}";
        }
    }
}
