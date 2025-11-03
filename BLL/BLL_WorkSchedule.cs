using DAL;
using DTO;
using System;
using System.Collections.Generic;
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
    }
}
