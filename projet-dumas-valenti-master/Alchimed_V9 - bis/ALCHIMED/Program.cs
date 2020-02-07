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
            //Initialisation du joueur
            Console.WriteLine("Bienvenue dans le jeu ALCHIMED ! Pour la suite vous allez incarner un personnage,\nVeuillez entrer son nom");
            string nom = Console.ReadLine();
            Console.WriteLine("\nVeuillez entrer son prénom");
            string prenom = Console.ReadLine();
            Joueur Titan = new Joueur(prenom);
            Console.WriteLine("\nVeuillez choisir sa caractéristique principale");
            Titan.AttribuerCaracteristique();
            
            //Affichage des caractéristiques du joueur
            Console.WriteLine(Titan);

            //Initialisation de l'environnement de jeu
            Bagarreur edgar = new Bagarreur("Edgar", 20);

            Objet ob1 = new Objet("un lit", "un beau lit");
            Objet ob2 = new ObjetSpecial("une table", "une belle table", Effets.force1);
            Objet ob3 = new ObjetSpecial("une chaise", "une belle chaise", Effets.force2);
            Objet ob4 = new Objet("une couverture", "une belle couverture");
            Objet ob44 = new Objet("un plaid", "un plaid moche");
            Objet ob5 = new ObjetSpecial("un tabouret", "un beau tabouret", Effets.force3);
            Objet ob6 = new Objet("une armoire", "une belle armoire remplie");
            Objet ob66 = new Objet("une penderie", "une penderie mal rangée");
            Objet ob7 = new ObjetSpecial("une blouse", "un très belle blouse", Effets.vieM);

            Piece salleRepos = new Piece("la salle de repos", new List<Objet>(){ob1,ob2,ob3});

            Piece salleEtude = new Piece("la salle d'étude", new List<Objet>() {ob4, ob44, ob5});
            salleEtude.AttribuerSavoir();

            Piece laboratoire = new Piece("le laboratoire", new List<Objet>() { ob6, ob66, ob7 });

            //Simulation des actions dans le labo :
            //prendre une substance dans la commode
            Titan._inventaireSubstances.Add(Substances.sub1);

            //Etre attaqué par un bagarreur
            bool prendlafuite = edgar.Defier(Titan);
            if (prendlafuite == true) { Titan.Deplacer(salleRepos); }
            
            //Simulation des actions possibles dans une pièce        
            Titan.DeplacerVersObjet(salleRepos);

            Titan.DeplacerVersObjet(salleRepos);

            Titan.DeplacerVersObjet(salleRepos);

            //Affichage des caractéristiques du joueur 
            //--> décider quand les afficher : au choix ou systématiquement après telle ou telle action ?
            Console.WriteLine(Titan);
            
            /* Test d'ajout des savoirs
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

            //Liste des pièces et proposition de déplacement
            Console.WriteLine("Où voulez vous aller ?");

            for (int i=0; i< pieces.Count; i++)
            {
                Console.WriteLine((i+1 + " : " +pieces[i]._nom + "\n");
            }

            Console.ResetColor();
            
            Titan.Deplacer(laboratoire);
            */


        }
    }
}
