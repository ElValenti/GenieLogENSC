using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Contenant : Objet
    {
        internal List<Objet> _contenus;
        // Constructeur d'Objet
        public Contenant(string nom, string descr, List<Objet> contenu) : base(nom, descr)
        {
            _contenus = contenu;
        }

        // Procédure d'affichage lors d'interaction passive avec l'objet
        internal new void AfficheDescription()
        {
            string ch = "\nEn fouillant, vous trouvez : ";
            foreach (Objet element in _contenus)
            {
                ch += element + ", ";
            }
            Console.WriteLine(ch);
        }

        internal void Lister()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nQuel élément voulez-vous examiner ? Taper le numéro de l'élément souhaité\n");
            int compteur = 0;
            foreach (Objet element in _contenus)
            {
                compteur++;
                element.Num = compteur;
                Console.WriteLine(element.Num + " : " + element.Nom);
            }
            Console.ResetColor();
        }

        // Procédure qui 
        // En entrée : le joueur pj souhaitant interagir avec l'objet
        internal bool Melanger(Joueur pj)
        {
            if (pj.NbSubstances >= 3)
            {
                Console.WriteLine("Quelles substances souhaitez-vous ajouter pour réaliser une potion avec ce bécher ?\n");
                pj.AfficheInventaire();
                int subN = 0;
                while (subN < 4)
                {
                    subN++;
                    Console.WriteLine("Choisissez la substance numéro {0} à ajouter.", subN);
                    int indexSub = Program.VerifSaisie(pj.NbSubstances);
                }
                Console.WriteLine("Préparation en cours");
                return true;
            }
            else if (pj.NbSubstances > 0)
            {
                Console.WriteLine("Il vous manque {0} substance pour faire une potion.\n", 3 - pj.NbSubstances);
                return true;
            }
            else 
                return false;
        }

        // Redéfinition de la méthode ToString()
        // Méthode permettant de créer une chaîne de caractères comportant les caractéristiques du conteant
        public override string ToString()
        {
           return _description;
        }
    }
}
