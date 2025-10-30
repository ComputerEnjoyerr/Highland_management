using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class ValidationData
    {
        // ======== CHUỖI CƠ BẢN ========

        public static bool IsNotEmpty(string? input) =>
            !string.IsNullOrWhiteSpace(input);

        public static bool HasMaxLength(string? input, int maxLength) =>
            input != null && input.Length <= maxLength;

        // ======== KIỂM TRA CỤ THỂ ========

        public static bool IsValidName(string? name)
        {
            // Chỉ cho phép chữ cái (cả có dấu tiếng Việt), khoảng trắng, và dấu '-'
            if (string.IsNullOrWhiteSpace(name)) return false;
            string pattern = @"^[\p{L}\s'-]{2,50}$";
            return Regex.IsMatch(name.Trim(), pattern);
        }

        public static bool IsValidPhone(string? phone)
        {
            // 0xxxxxxxxx hoặc +84xxxxxxxxx
            if (string.IsNullOrWhiteSpace(phone)) return false;
            string pattern = @"^(0|\+84)\d{9,10}$";
            return Regex.IsMatch(phone.Trim(), pattern);
        }

        public static bool IsValidEmail(string? email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email.Trim(), pattern, RegexOptions.IgnoreCase);
        }

        public static bool IsValidCitizenId(string? id)
        {
            // CCCD hoặc CMND: 9-12 chữ số
            if (string.IsNullOrWhiteSpace(id)) return false;
            string pattern = @"^\d{9,12}$";
            return Regex.IsMatch(id.Trim(), pattern);
        }

        //public static bool IsValidCode(string? id)
        //{
        //    // Mã có thể dạng như AC25/09/24/07/41/01 hoặc BR250924074101
        //    if (string.IsNullOrWhiteSpace(id)) return false;
        //    string pattern = @"^[A-Z]{1,4}[\d/]{6,20}$";
        //    return Regex.IsMatch(id.Trim(), pattern);
        //}

        public static bool IsValidGender(string? gender)
        {
            if (string.IsNullOrWhiteSpace(gender)) return false;
            return gender is "Nam" or "Nữ" or "Khác";
        }

        public static bool IsValidRole(string? role)
        {
            if (string.IsNullOrWhiteSpace(role)) return false;
            return role is "Quản lý" or "Nhân viên" or "Thời vụ";
        }

        // ======== KIỂM TRA GIỚI HẠN NGÀY / SỐ ========

        public static bool IsValidDateOfBirth(DateTime date)
        {
            // Tuổi phải >= 16
            return date <= DateTime.Now.AddYears(-16);
        }

        public static bool IsValidDecimal(decimal value, decimal min = 0, decimal max = decimal.MaxValue)
        {
            return value >= min && value <= max;
        }

        public static bool IsValidInt(int value, int min = 0, int max = int.MaxValue)
        {
            return value >= min && value <= max;
        }

        // ======== KIỂM TRA ĐỊA CHỈ ========

        public static bool IsValidAddress(string? address)
        {
            if (string.IsNullOrWhiteSpace(address)) return false;
            string pattern = @"^[\p{L}\d\s,./-]{5,100}$";
            return Regex.IsMatch(address.Trim(), pattern);
        }

        // ======== KIỂM TRA THỜI GIAN ========

        public static bool IsValidTimeRange(TimeSpan start, TimeSpan end)
        {
            return start < end;
        }

        // ======== KIỂM TRA MẬT KHẨU / TÀI KHOẢN ========

        //public static bool IsValidAccountName(string? name)
        //{
        //    // Cho phép chữ, số, dấu gạch dưới, tối thiểu 4 ký tự
        //    if (string.IsNullOrWhiteSpace(name)) return false;
        //    string pattern = @"^[A-Za-z0-9_]{4,30}$";
        //    return Regex.IsMatch(name.Trim(), pattern);
        //}

        //public static bool IsValidPassword(string? password)
        //{
        //    // Ít nhất 8 ký tự, có 1 chữ hoa, 1 số
        //    if (string.IsNullOrWhiteSpace(password)) return false;
        //    string pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";
        //    return Regex.IsMatch(password, pattern);
        //}

        // ======== KIỂM TRA KHÁC ========

        public static bool IsValidPromotionType(string? type)
        {
            if (string.IsNullOrWhiteSpace(type)) return false;
            return type is "Voucher" or "Chương trình khuyến mãi";
        }

        public static bool IsValidDiscountType(string? type)
        {
            if (string.IsNullOrWhiteSpace(type)) return false;
            return type is "Phần trăm" or "Tiền" or "Mua x tặng y";
        }

        public static bool IsValidStatus(string? status)
        {
            // Áp dụng cho BRANCH.Status, EMPLOYEE.CurrentStatus, PRODUCT.Status,...
            if (string.IsNullOrWhiteSpace(status)) return false;

            string[] validStatus = new[]
            {
                "Đang hoạt động", "Đã đóng", "Đóng vĩnh viễn", // Branch
                "Đang làm việc", "Đã nghỉ",                   // Employee
                "Đang bán", "Ngừng bán"                       // Product
            };

            foreach (var s in validStatus)
            {
                if (status.Equals(s, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            return false;
        }
    }
}
