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
    public class DAL_Bill
    {
        private readonly HighlandsContext context = new();

        public List<Bill> GetAll()
        {
            return context.Bills
                .Include(b => b.Branch)
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .ToList();
        }

        public Bill? GetById(string id)
        {
            return context.Bills
                .Include(b => b.Branch)
                .Include(b => b.Customer)
                .Include(b => b.Employee)
                .FirstOrDefault(b => b.Id == id);
        }
        public void Add(Bill bill)
        {
            context.Bills.Add(bill);
            context.SaveChanges();
        }

        public void Delete(string id)
        {
            var bill = context.Bills.FirstOrDefault(b => b.Id == id);
            if (bill != null)
            {
                context.Bills.Remove(bill);
                context.SaveChanges();
            }
        }

        public void Update(Bill bill)
        {
            var existingBill = context.Bills.FirstOrDefault(b => b.Id == bill.Id);
            if (existingBill != null)
            {
                existingBill.BranchId = bill.BranchId;
                existingBill.EmployeeId = bill.EmployeeId;
                existingBill.CustomerId = bill.CustomerId;
                existingBill.CreateDate = bill.CreateDate;
                existingBill.Status = bill.Status;
                context.SaveChanges();
            }
        }

        // Lấy thông tin header của Bill
        public DataTable GetBillHeader(string billId)
        {
            var dt = new DataTable("BillHeader");

            try
            {
                var connection = context.Database.GetDbConnection();
                bool wasOpen = connection.State == System.Data.ConnectionState.Open;

                if (!wasOpen)
                    connection.Open();

                // Tạo sp lấy thông tin chung hóa đơn (chi nhánh, nhân viên,....)
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "sp_GetBillForPrint";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BillId", billId));

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }

                if (!wasOpen)
                    connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin Bill: {ex.Message}", ex);
            }

            return dt;
        }

        // Lấy chi tiết sản phẩm của Bill
        public DataTable GetBillDetail(string billId)
        {
            var dt = new DataTable("BillDetail");

            try
            {
                var connection = context.Database.GetDbConnection();
                bool wasOpen = connection.State == System.Data.ConnectionState.Open;

                if (!wasOpen)
                    connection.Open();

                // Tạo sp để lấy chi tiết hóa đơn (sản phẩm, tổng giá mỗi sp)
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "sp_GetBillForReport";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@BillId", billId));

                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }

                if (!wasOpen)
                    connection.Close();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy chi tiết Bill: {ex.Message}", ex);
            }

            return dt;
        }

        // Hàm test
        public DataSet GetBillForPrint(string billId)
        {
            DataSet ds = new DataSet("BillDataSet");

            try
            {
                // Lấy header
                var headerTable = GetBillHeader(billId);
                headerTable.TableName = "BillHeader";
                ds.Tables.Add(headerTable);

                // Lấy detail
                var detailTable = GetBillDetail(billId);
                detailTable.TableName = "BillDetail";
                ds.Tables.Add(detailTable);

                if (ds.Tables == null || ds.Tables["BillHeader"] == null || ds.Tables["BillDetail"] == null)
                {
                    throw new Exception("Không thể tạo DataSet vì thiếu bảng BillHeader hoặc BillDetail.");
                }

                if (headerTable.Columns.Contains("BillId") && detailTable.Columns.Contains("BillId"))
                {
                    ds.Relations.Add("BillHeaderDetail",
                        ds.Tables["BillHeader"].Columns["BillId"],
                        ds.Tables["BillDetail"].Columns["BillId"], false);
                }

                //// Tạo relation giữa 2 bảng 
                //if (ds.Tables["BillHeader"].Rows.Count > 0)
                //{
                //    ds.Relations.Add("BillHeaderDetail",
                //        ds.Tables["BillHeader"].Columns["BillId"],
                //        ds.Tables["BillDetail"].Columns["BillId"], false);
                //}
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tạo DataSet cho Bill: {ex.Message}", ex);
            }

            return ds;
        }
    }
}
