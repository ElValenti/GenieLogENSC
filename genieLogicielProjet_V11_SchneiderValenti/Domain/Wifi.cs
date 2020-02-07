using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Modélise un point d'accès wifi
    /// </summary>
    public class Wifi
    {
        
        
        public virtual int WifiId { get; set; } //identifiant du point wifi
        public virtual string Title { get; set; } //titre du point wifi
        public virtual string Password { get; set; }//mdp pour le point wifi

        public virtual string SSID { get; set; }//SSID du point wifi

        public virtual User User { get; set; }//reference à l'utilisateur

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="mdp"></param>
        /// <param name="id"></param>

        public Wifi() { }
        public Wifi(string nom, string mdp, int id)
        {
            WifiId = id;
            Title = nom;
            Password = mdp;
        }

        /// <summary>
        /// Décrit un point d'accès wifi
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Title;
        }
    }
}
