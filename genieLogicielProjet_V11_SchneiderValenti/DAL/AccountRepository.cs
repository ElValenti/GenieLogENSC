using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class AccountRepository : Repository, IAccountRepository
    {
        public IList<Account> GetAll()
        {
            return Session.Query<Account>().ToList();
        }

        public void Update(Account account)
        {
            Session.SaveOrUpdate(account);
            Session.Flush();
        }

        public void Delete(Account account)
        {
            Session.Delete(account);
            Session.Flush();
        }

        public void Add(Account account)
        {
            Session.SaveOrUpdate(account);
            Session.Flush();
        }
    }
}
