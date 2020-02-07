using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Bienvenue dans le jeu ALCHIMED ! Pour la suite vous allez incarner un personnage,\nVeuillez entrer son nom");
            string nom = Console.ReadLine();
            Console.WriteLine("\nVeuillez entrer son prénom");
            string prenom = Console.ReadLine();
            Joueur Titan = new Joueur(prenom);
            Console.WriteLine("\nVeuillez choisir sa caractéristique principale");
            Titan.AttribuerCaracteristique();

            Console.WriteLine(Titan);

            Objet ob1 = new Objet("un lit", "un beau lit", "force2");
            Objet ob2 = new Objet("une table", "une belle table", "force2");
            Objet ob3 = new Objet("une chaise", "une belle chaise", "force2");
            Objet ob4 = new Objet("une couverture", "une belle couverture", "force2");
            Objet ob5 = new Objet("un tabouret", "un beau tabouret", "force2");

            List<Objet> objetsInfirmerie = new List<Objet>(){ob1,ob2,ob3};

            List<Objet> objetsBureau = new List<Objet>() { ob4, ob5 };
            
            Piece infirmerie = new Piece("l'infirmerie",objetsInfirmerie);

            Piece bureau = new Piece("le bureau", objetsBureau);

            

            infirmerie.Numeroter();

            Console.WriteLine(infirmerie);

            infirmerie.Lister();

       

            Titan.DeplacerVersObjet(infirmerie);

            Console.WriteLine(Titan);

            bureau.Numeroter();

            Console.WriteLine(bureau);

            bureau.Lister();

            Titan.DeplacerVersObjet(bureau);

        
    
        }
    }
}
