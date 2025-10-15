using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string _id;
        private string _accountName;
        private string _password;
        private string _employeeId;
        private DateTime _createdDate;

        public Account(string id, string accountName, string password, string employeeId, DateTime createdDate)
        {
            Id = id;
            AccountName = accountName;
            Password = password;
            EmployeeId = employeeId;
            CreatedDate = createdDate;
        }

        public string Id { get => _id; set => _id = value; }
        public string AccountName { get => _accountName; set => _accountName = value; }
        public string Password { get => _password; set => _password = value; }
        public string EmployeeId { get => _employeeId; set => _employeeId = value; }
        public DateTime CreatedDate { get => _createdDate; set => _createdDate = value; }
    }
}
