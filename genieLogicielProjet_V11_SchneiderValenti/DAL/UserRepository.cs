using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class UserRepository : Repository, IUserRepository
    {
        public IList<User> GetAll()
        {
            return Session.Query<User>().ToList();
        }

        public void connexion(string login, string mdp)
        {
            Session.CreateQuery("select util_nom, util_mdpPrincipal from utilisateur WHERE util_nom=" + login + "AND util_mdpPrincipal=" + mdp);
        }
    }

}
