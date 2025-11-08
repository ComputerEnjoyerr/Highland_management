using DTO;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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

        // Hàm in report
        public DataTable GetScheduleByDate(DateTime selectedDate)
        {
            var sql = @"
            SET DATEFIRST 1;
            WITH Params AS (
                SELECT 
                    CAST(@SelectedDate AS DATE) AS SelectedDate,
                    DATEADD(DAY, 1 - DATEPART(WEEKDAY, CAST(@SelectedDate AS DATE)), CAST(@SelectedDate AS DATE)) AS WeekStart,
                    DATEADD(DAY, 7 - DATEPART(WEEKDAY, CAST(@SelectedDate AS DATE)), CAST(@SelectedDate AS DATE)) AS WeekEnd
            ),
            WeekDays AS (
                SELECT WeekStart AS WorkDate FROM Params
                UNION ALL
                SELECT DATEADD(DAY, 1, WorkDate)
                FROM WeekDays, Params
                WHERE WorkDate < Params.WeekEnd
            )
            SELECT 
                WD.WorkDate,
                CASE DATEPART(WEEKDAY, WD.WorkDate)
                    WHEN 1 THEN N'Chủ nhật'
                    WHEN 2 THEN N'Thứ hai'
                    WHEN 3 THEN N'Thứ ba'
                    WHEN 4 THEN N'Thứ tư'
                    WHEN 5 THEN N'Thứ năm'
                    WHEN 6 THEN N'Thứ sáu'
                    WHEN 7 THEN N'Thứ bảy'
                END AS ThuTrongTuan,
                DATEPART(WEEKDAY, WD.WorkDate) AS ThuSo,

                P.WeekStart,
                P.WeekEnd,

                ISNULL(E.Id, N'Không có nhân viên làm việc') AS Id,
                E.EmployeeName,
                B.BranchName,
                A.Name,
                WSHIFT.ShiftType,
                WSHIFT.StartTime,
                WSHIFT.EndTime,
                ISNULL(SA.Note, N'') AS Note,
                M.EmployeeName AS CreatedByName

            FROM WeekDays WD
            CROSS JOIN Params P
            LEFT JOIN WORK_SHIFT WSHIFT ON CAST(WSHIFT.WorkDate AS DATE) = WD.WorkDate
            LEFT JOIN SHIFT_ASSIGNMENT SA ON SA.ShiftId = WSHIFT.Id
            LEFT JOIN WORK_SCHEDULE WS ON WSHIFT.ScheduleId = WS.Id
            LEFT JOIN EMPLOYEE E ON SA.EmployeeId = E.Id
            LEFT JOIN BRANCH B ON WS.BranchId = B.Id
            LEFT JOIN ADDRESS A ON A.Id = B.AddressId
            LEFT JOIN EMPLOYEE M ON WS.CreatedBy = M.Id

            ORDER BY WD.WorkDate, WSHIFT.ShiftType, E.EmployeeName
            OPTION (MAXRECURSION 0);";

            // Thực thi bằng Entity Framework (DataTable)
            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
            {
                cmd.CommandText = sql;
                cmd.Parameters.Add(new SqlParameter("@SelectedDate", selectedDate));

                _context.Database.OpenConnection();

                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
        }
    }
}
