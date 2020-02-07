using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
   public class WifiRepository : Repository, IWifiRepository
    {
        public IList<Wifi> GetAll()
        {
            return Session.Query<Wifi>().ToList();
        }

        public void Update(Wifi account)
        {
            Session.SaveOrUpdate(account);
            Session.Flush();
        }

        public void Delete(Wifi account)
        {
            Session.Delete(account);
            Session.Flush();
        }

        public void Add(Wifi account)
        {
            Session.Save(account);
            Session.Flush();
        }
    }
}
