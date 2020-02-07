using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    //interface d'accès aux données wifi
    public interface IWifiRepository
    {

        IList<Wifi> GetAll();

        void Update(Wifi wifi);

        void Delete(Wifi wifi);

        void Add(Wifi wifi);
    }
}
