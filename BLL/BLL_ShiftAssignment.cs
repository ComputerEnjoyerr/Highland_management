using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_ShiftAssignment
    {
        private readonly DAL_ShiftAssignment dAL_ShiftAssignment = new();

        public List<ShiftAssignment> GetAll() { return dAL_ShiftAssignment.GetAll(); }

        public ShiftAssignment GetById(string id)
        {
            var shiftAssignment = dAL_ShiftAssignment.GetById(id);
            if (shiftAssignment == null)
            {
                return new ShiftAssignment();
            }
            return shiftAssignment;
        }

        public void Add(ShiftAssignment shiftAssignment)
        {
            dAL_ShiftAssignment.Add(shiftAssignment);
        }

        public void Delete(ShiftAssignment shiftAssignment)
        {
            dAL_ShiftAssignment.Delete(shiftAssignment);
        }

        public void Update(ShiftAssignment shiftAssignment)
        {
            dAL_ShiftAssignment.Update(shiftAssignment);
        }

        // Lấy ca làm việc theo ngày và ca
        public List<ShiftAssignment> GetByDateAndShift(int day, int month, int year, string shift)
        {
            return dAL_ShiftAssignment.GetByDateAndShift(day, month, year, shift);
        }

        // Hàm tạo ID tự động
        public string GenerateShiftAssignmentId()
        {
            string prefix = "SA" + DateTime.Now.ToString("yyMM");

            // Lấy danh sách đăng ký có Id bắt đầu bằng prefix (trong cùng tháng)
            var assignmentsThisMonth = dAL_ShiftAssignment.GetAll()
                .Where(a => a.Id.StartsWith(prefix))
                .ToList();

            // Tìm số thứ tự lớn nhất trong tháng
            int nextNumber = 1;
            if (assignmentsThisMonth.Any())
            {
                string lastId = assignmentsThisMonth
                    .OrderByDescending(a => a.Id)
                    .First().Id;

                // Lấy 4 số cuối
                string numberPart = lastId.Substring(6, 4);
                if (int.TryParse(numberPart, out int currentNumber))
                {
                    nextNumber = currentNumber + 1;
                }
            }

            // Tạo mã mới
            string newId = $"{prefix}{nextNumber:D4}";
            return newId.Length > 20 ? newId.Substring(0, 10) : newId;
        }

        // Hàm lấy lịch sử phân công ca làm việc của nhân viên theo ID nhân viên
        public List<ShiftAssignment> GetByEmployeeId(string employeeId)
        {
            return dAL_ShiftAssignment.GetByEmployeeId(employeeId);
        }

        public List<ShiftAssignment> GetShiftAssignmentsForToday()
        {
            return dAL_ShiftAssignment.GetShiftAssignmentsForToday();
        }

    }
}
