using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    // Enumération des savoirs que peut avoir un joueur
    public enum Savoirs
    {
        Culture,
        Chimie,
        Biologie,
        Aucun // il n'a aucun des trois savoirs ci dessus
    }

    // Classe Joueur qui hérite de la classe abstraite Personnage
    class Joueur : Personnage
    {
        Random alea = new Random();
        internal int _ptStress;
        internal int _ptForce;
        // internal List<Potion> _inventairePotions;
        internal List<Substances> _inventaireSubstances;
        internal List<Savoirs> _savoirs;

        // Constructeur de Joueur 
        public Joueur(string nom, int ptStress, int ptForce) : base(nom, 100)
        {
            _ptStress = ptStress;
            _ptForce = ptForce;
            _inventaireSubstances = new List<Substances>();
            _savoirs = new List<Savoirs>();
        }
        // Constucteur de Joueur, valeurs par défaut
        public Joueur(string nom) : this(nom, 0, 10) { }

        // Procédure permettant en début de partie de choisir, entre trois caractéristiques, celle que l'on veut attribuer au joueur
        //   La caractéristique choisie augmentera soit _ptForce soit _ptVie soit ajoutera le savoir Biologie à la liste de savoirs du joueur
        internal void AttribuerCaracteristique()
        {
            string[] car = new string[3] { "Force", "Résistance", "Intelligence" };
            string nouveauSavoir = "\n";

            // Présentation des trois caractéristiques possibles
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i + " : " + car[i - 1]);
            }

            Console.ResetColor();

            // Récupération du choix du joueur et gestion des erreurs de saisie
            int choix = Program.VerifSaisie(3);
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (choix)
            {
                case 1:
                    _ptForce = 50;
                    nouveauSavoir += " Et vous ne possédez aucun savoir pour le moment.\n"; 
                    break;

                case 2:
                    _ptVie = 150;
                    nouveauSavoir += " Et vous ne possédez aucun savoir pour le moment.\n";
                    break;

                case 3:
                    _savoirs.Add(Savoirs.Biologie);
                    nouveauSavoir+="Et vous possédez le savoir Biologie.\n";
                    break;
            }
            Console.WriteLine("\n Vous avez :\n {0} points de force\n {1} points de vie"+ nouveauSavoir, _ptForce,_ptVie);
        }

               /* Procédure permettant de répliquer à une attaque d'un personnage bagarreur
            En entrée : adversaire est le personnage à attaquer, coup est un entier représentant l'attaque choisie par le joueur pour répliquer 
            Cette procédure est utilisée dans la méthode Défier de la classe Bagarreur. */
         internal void Defier(Personnage adversaire, int coup)
         {
             if (coup == 1) // si le joueur a choisi de répliquer par un coup de pied
             {
                 // implémentation d'un facteur chance : le coup peut être esquivé par l'adversaire
                 int chance = alea.Next(1, 4);
                 if (chance == 2)
                 {
                     Console.WriteLine(adversaire._nom + " a esquivé l'attaque ! Vous ne lui infligez aucun dégât.");
                 }
                 else
                 {
                     adversaire._ptVie -= this._ptForce/4;
                     Console.Write("Vous attaquez " + adversaire._nom + " qui perd " + this._ptForce / 4 + " points de vie. ");
                     if (adversaire._ptVie <= 0)
                     { Console.WriteLine("Il ne lui reste aucun point de vie."); }
                     else
                     { Console.WriteLine("Il lui reste " + adversaire._ptVie + " points de vie."); }
                }
             }
              if (coup == 2) // si le joueur a choisi de répliquer par un coup de poing
             {
                 // implémentation d'un facteur chance : le coup peut être esquivé, rarement, par l'adversaire
                 int chance = alea.Next(1, 11);
                 if (chance == 3)
                 {
                     Console.WriteLine(adversaire._nom + " a esquivé l'attaque ! Vous ne lui infligez aucun dégât.");
                 }
                 else
                 {
                     adversaire._ptVie -= this._ptForce/6;
                     Console.Write("Vous attaquez " + adversaire._nom + " qui perd " + this._ptForce / 6 + " points de vie. ");
                     if (adversaire._ptVie <= 0)
                     { Console.WriteLine("Il ne lui reste aucun point de vie."); }
                     else
                     { Console.WriteLine("Il lui reste " + adversaire._ptVie + " points de vie."); }
                 }
             }
        }

        // Procédure permettant de déplacer le joueur directement dans le lit de la salle de repos
         // En entrée : l'ObjetSpecial correspondant au lit
         internal void SeReposer(ObjetSpecial lit)
         {
             Console.Clear();
            lit.Interagir(this);
         }

    /* Procédure permettant de déplacer le joueur vers une autre pièce
    * En entrée : la pièce lieu vers laquelle on veut qu'il se déplace
    * En sortie : un booléen indiquant si le joueur a pu entrer dans la piece
    */
    public bool Deplacer(Piece lieu)
        {
            //variable indiquant si le joueur a pu entrer ou non
            bool entree = false;
            
            // vérification que les conditions d'accès sont remplies
            Acces etatAcces = lieu.Acceder(_savoirs, _ptForce);
                      
            //Si l'accès est refusé, le booleen reste à false
            if (etatAcces != Acces.Autorise)
            {

                // Affichage de la raison du refus
                if (etatAcces == Acces.RefuseEntrainement)
                    Console.WriteLine("Accès refusé : vous n'êtes pas pas encore assez fort.\n");
                else if (etatAcces == Acces.RefuseEtude)
                    Console.WriteLine("Accès refusé : vous n'avez pas suffisamment étudié.\n");
            }
            //Si l'accès est autorisé le booléen passe à true
            else
            {
                entree = true;
                // Description du lieu
                Console.WriteLine(lieu);
            }

            return entree;
        }// fin de Déplacer(Piece lieu)


        // Procédure permettant d'intéragir avec un objet de la pièce
        // En entrée : la pièce lieu où le joueur se trouve
        public void DeplacerVersObjet(Piece lieu)
        {
            //Affichage des objets de la pièce
            lieu.Lister();
            int choix = Program.VerifSaisie(lieu._objets.Count);

            //Recherche de la correspondance entre le choix et l'un des objets de la pièce
            foreach (Objet objet in lieu._objets)
                {
                    if (objet.Num == choix)
                    {
                        objet.AfficheDescription();
                        //Recherche si l'objet délivre un savoir
                        if (objet.Verif() == true)
                        {
                            //Recherche si le savoir de l'objet est déjà dans les savoirs du joueur
                            if ((_savoirs.Count == 0) || (!TrouveSavoir(objet.Enseignement)))
                            {
                                _savoirs.Add(objet.Enseignement);
                                Console.WriteLine("Oh mais qu'est-ce que c'est... Vous obtenez le savoir {0} !", objet.Enseignement);
                            }
                        } 
                        //Recherche si l'objet a un effet spécial
                        else if (objet is ObjetSpecial)
                        {
                            objet.Interagir(this);
                        }
                    }
                }
        }

        // Méthode permettant de rechercher un savoir dans la liste de savoirs du joueur
        // En entrée : le savoir recherché
        // En sortie : un booléen qui vaut true si le savoir a été trouvé
        private bool TrouveSavoir(Savoirs s)
        {
            int compt = 0;
            bool stop = false;
            while ((compt < _savoirs.Count) && (stop == false))
            {
                stop = (_savoirs[compt] == s);
                compt++;
            }
            return stop;
        }

        // Redéfinition de la méthode ToString()
        // Méthode permettant de créer une chaîne de caractères comportant les caractéristiques du joueur
        // Renvoie cette chaîne de caractères en sortie
        public override string ToString()
        {
            string ch = ("\n   Personnage joueur :\n   " + _nom + "\n   Points de vie : " + _ptVie + "\n   Points de stress : " + _ptStress + "\n   Points de force : " + _ptForce + "\n");
            return ch;
        }
    }
}
