using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Modélise un utilisateur de l'application
    /// </summary>
    public class User
    {
        public virtual int Id { get; set; } //va permettre la jointure avec les comptes de l'utilisateur
        public virtual string NameUser { get; set; }
        public virtual string MainPassword { get; set; } //mdp pour se connecter au gestionnaire de mdp
        
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="mdp"></param>
        /// <param name="id"></param>
        public User(string nom, int id, string password)
        {
            Id = id;
            NameUser = nom;
            MainPassword = password;
        }

        public User()
        {
        }

        /// <summary>
        /// Décrit un utilisateur
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return NameUser;
        }
    }
}
