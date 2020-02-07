using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Modélise un compte d'un utilisateur
    /// </summary>
    public class Account
    {
        /// <summary>
        /// identifiant du compte
        /// </summary>
        public virtual int Id { get; set; }


        /// <summary>
        /// utilisateur du compte
        /// </summary>
        public virtual User User { get; set; }


        /// <summary>
        /// Titre d'un compte
        /// </summary>
        public virtual string Title { get; set; }


        /// <summary>
        /// mot de passe pour ce compte
        /// </summary>
        public virtual string Password { get; set; }


        /// <summary>
        /// nom d'utilisateur utilisé pour se connecter au compte
        /// </summary>
        public virtual string Login { get; set; }


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="login"></param>
        /// <param name="nom"></param>
        /// <param name="mdp"></param>
        /// <param name="id"></param>

        public Account() { }
        public Account(string login, string nom, string mdp, User u)
        {
            Title = nom;
            Login = login;
            Password = mdp;
            User = u;
        }

        /// <summary>
        /// Décrit un compte
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
