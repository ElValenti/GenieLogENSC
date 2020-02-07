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
            Console.WriteLine("Bienvenue dans le jeu ALCHIMED ! Pour la suite vous allez incarner un personnage,\nVeuillez entrer son prénom");
            string prenom = Console.ReadLine();
            Joueur Titan = new Joueur(prenom,0,100);
            Console.WriteLine("\nVeuillez choisir sa caractéristique principale");
            Titan.AttribuerCaracteristique();
            
            Console.WriteLine(Titan);

            Bagarreur edgar = new Bagarreur("Edgar", 20);

            ObjetSpecial ob1 = new ObjetSpecial("un lit", "un beau lit",Effets.regenerateur);
            ObjetSpecial ob2 = new ObjetSpecial("une table", "une belle table", Effets.force1);
            ObjetSpecial ob3 = new ObjetSpecial("une chaise", "une belle chaise", Effets.force2);
            Objet ob4 = new Objet("une couverture", "une belle couverture");
            Objet ob44 = new Objet("un plaid", "un plaid moche");
            ObjetSpecial ob5 = new ObjetSpecial("un tabouret", "un beau tabouret", Effets.force3);
            Objet ob6 = new Objet("une armoire", "une belle armoire remplie");
            Objet ob66 = new Objet("une penderie", "une penderie mal rangée");
            ObjetSpecial ob7 = new ObjetSpecial("une blouse", "un très belle blouse", Effets.vieM);

            Piece salleRepos = new Piece("la salle de repos", new List<Objet>(){ob1,ob2,ob3});

            Piece salleEtude = new Piece("la salle d'étude", new List<Objet>() {ob4, ob44, ob5});
            salleEtude.AttribuerSavoir();

            Piece laboratoire = new Piece("le laboratoire", new List<Objet>() { ob6, ob66, ob7 });

            // salleRepos.Numeroter();

            Titan._inventaireSubstances.Add(Substances.phytoménadione);

           bool prendlafuite = edgar.Defier(Titan);
           if (prendlafuite == true) { Titan.SeReposer(ob1); }
            
                       
            Titan.DeplacerVersObjet(salleRepos);

            Titan.DeplacerVersObjet(salleRepos);

            Titan.DeplacerVersObjet(salleRepos);

            Console.WriteLine(Titan);

            
            /*salleEtude.Numeroter();

            Console.WriteLine(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Titan.DeplacerVersObjet(salleEtude);

            Console.WriteLine(Titan);

            Titan._savoirs.Add(Savoirs.Chimie);
            Titan._savoirs.Add(Savoirs.Culture);

            List<Piece> pieces = new List<Piece> { salleRepos, salleEtude, laboratoire };

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Où voulez vous aller ?");

            foreach (Piece piece in pieces)
            {
                Console.WriteLine(piece._nom + "\n");
            }

            Console.ResetColor();
            
            Titan.Deplacer(laboratoire);
            */


        }
    }
}
