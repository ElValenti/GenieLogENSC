using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    /// <summary>
    /// Interface d'accès aux comptes
    /// </summary>
    public interface IAccountRepository
    {
        IList<Account> GetAll();

        void Update(Account account);

        void Delete(Account account);

        void Add(Account account);
    }

}
