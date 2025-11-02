using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Account
    {
        private readonly HighlandsContext context = new();

        public List<Account> GetAll()
        {
            return context.Accounts.ToList();
        }

        public Account GetById(string id)
        {
            return context.Accounts.FirstOrDefault(a => a.Id == id);
        }

        public void Add(Account account)
        {
            context.Accounts.Add(account);
            context.SaveChanges();
        }

        public void Remove(string id)
        {
            var account = context.Accounts.FirstOrDefault(x => x.Id == id);
            if (account != null)
            {
                context.Accounts.Remove(account);
                context.SaveChanges();
            }
        }

        public void Update(Account account)
        {
            var existing = context.Accounts.FirstOrDefault(y => y.Id == account.Id);
            if (existing != null)
            {
                existing.AccountName = account.AccountName;
                existing.Password = account.Password;
            }
        }
    }
}
