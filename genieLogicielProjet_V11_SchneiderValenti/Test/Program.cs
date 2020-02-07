using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liste des utilisateurs :");
            IUserRepository utilRepo = new UserRepository();
            IList<User> utils = utilRepo.GetAll();
            foreach (User util in utils) {
                Console.WriteLine(util);
            }
            Console.WriteLine();
            Console.WriteLine("Liste des comptes :");
            IAccountRepository compteRepo = new AccountRepository();
            foreach (Account compte in compteRepo.GetAll())
            {
                Console.WriteLine(compte);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Liste des points Wifi :");
            IWifiRepository wifiRepo = new WifiRepository();
            foreach (Wifi wifi in wifiRepo.GetAll())
            {
                Console.WriteLine(wifi);
                Console.WriteLine(wifi.SSID);
                Console.WriteLine(wifi.Password);
                Console.WriteLine();
            }
            
            Console.WriteLine();
            Console.Write("Ajout d'un nouveau compte... ");
            Account compteAjout = new Account();
            compteAjout.Title = "Test";
            compteAjout.Login = "testeur";
            compteAjout.Password = "mdp2test";
            compteAjout.User = utils[1];

            compteRepo.Add(compteAjout);
            Console.WriteLine("Id : " + compteAjout.Id);
            /*
            Console.WriteLine();
            Console.Write("Enregistrement d'un retour... ");
            compte.Rendu = true;
            empruntRepo.Save(compte);
            Console.WriteLine("Terminé");*/

            Console.WriteLine("\nTests OK !");

            Console.ReadKey();
        }
    }
}
