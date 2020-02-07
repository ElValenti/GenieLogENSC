using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    public enum Savoirs
    {
        Culture,
        Chimie,
        Biologie,
        Aucun
    }

    class Joueur : Personnage
    {
        Random alea = new Random();
        public int _ptStress;
        public int _ptForce;
        // public List<Potion> _inventairePotions;
        public List<Substances> _inventaireSubstances;
        public List<Savoirs> _savoirs;

        // Constructeur 
        public Joueur(string nom, int ptStress, int ptForce) : base(nom, 100)
        {
            _ptStress = ptStress;
            _ptForce = ptForce;
            _inventaireSubstances = new List<Substances>();
            _savoirs = new List<Savoirs>();
        }
        //Constucteur des valeurs par défaut
        public Joueur(string nom) : this(nom, 0, 10)
        { }

        // permet au joueur de choisir entre trois caractéristiques, celle qu'il veut attribuer à son personnage
        // la caractéristique choisie augementera soit les points de vie soit les points de Force 
        //ou ajoutera le savoir Biologie à la liste des savoirs
        public void AttribuerCaracteristique()
        {
            string[] car = new string[3] { "Force", "Résistance", "Intelligence" };

            //Présentation des caractériques numérotées
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine(i + " : " + car[i - 1]);
            }
            //Récupération du choix du joueur
            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    _ptForce = 50;
                    break;

                case 2:
                    _ptVie = 150;
                    break;

                case 3:
                    _savoirs.Add(Savoirs.Biologie);
                    break;
            }
        }

        /* La methode permettant de répondre à une attque d'un personnage non joueur.
         En entrée : adversaire est le personnage à attaquer, coup est l'attaque choisie par lejoeur pour répliquer. 
         Cette procédure est utilisée dans la fonction Défier de la classe Bagarreur.
         */
        public void Defier(Personnage adversaire, int coup)
        {
            if (coup == 1)
            {
                //implémentation d'un facteur chance : le coup peut être esquivé
                int chance = alea.Next(1, 4);
                if (chance == 3)
                {
                    Console.WriteLine("Votre adversaire a esquivé l'attaque ! Vous ne lui infligez aucun dégât.");
                }
                else
                {

                    adversaire._ptVie -= 25;
                    Console.WriteLine("Vous attaquez " + adversaire._nom + " Il perd 25 points de vie. Il lui reste " +
                    adversaire._ptVie + " points de vie.");
                }
            }
            if (coup == 2)
            {
                //implémentation d'un facteur chance : le coup peut rarement être esquivé
                int chance = alea.Next(1, 11);
                if (chance == 2)
                {
                    Console.WriteLine("Votre adversaire a esquivé l'attaque ! Vous ne lui infligez aucun dégât.");
                }
                else
                {

                    adversaire._ptVie -= 15;
                    Console.WriteLine("Vous attaquez " + adversaire._nom + " Il perd 15 points de vie. Il lui reste " +
                    adversaire._ptVie + " points de vie.");
                }
            }

        }

        // Se déplacer vers une autre pièce
        public void Deplacer(Piece lieu)
        {
            // vérification que les conditions d'accès sont remplies
            Acces etatAcces = lieu.Acceder(_savoirs, _ptForce);
            
            //Si l'accès est refusé
            if (etatAcces != Acces.Autorise)
            {
                // Affichage de la raison du refus
                if (etatAcces == Acces.RefuseEntrainement)
                    Console.WriteLine("Accès refusé : vous n'êtes pas pas encore assez fort.");
                else if (etatAcces == Acces.RefuseEtude)
                    Console.WriteLine("Accès refusé : vous n'avez pas suffisamment étudié.");
            }
            //Si l'accès est autorisé
            else
            {
                // description du lieu choisi
                Console.WriteLine(lieu);
            }
            

        }

        // Méthode permettant d'intéragir avec un objet de la pièce
        //En entrée : la pièce où l'on se trouve
        public void DeplacerVersObjet(Piece lieu)
        {
            //Affichage des objets de la pièce
            lieu.Lister();        
            int choix = int.Parse(Console.ReadLine());

            //Recherche de la correspondance entre le choix et un des objets de la pièce
            foreach (Objet objet in Piece._objets)
                {
                    if (objet.Num == choix)
                    {
                        objet.AfficheDescription();
                        //Recherche si l'objet peut délivrer un savoir
                        if (objet.Verif() == true)
                        {
                            //Recherche si le savoir de l'objet est déjà dans les savoirs du joueur
                            if ((_savoirs.Count == 0) || (!TrouveSavoir(objet.Enseignement)))
                            {
                                _savoirs.Add(objet.Enseignement);
                                Console.WriteLine("Vous obtenez le savoir " + objet.Enseignement);
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

        //Cherche un savoir dans la liste de savoirs du joueur
        //En entrée : le savoir recherché
        //En sortie : un booléen qui vaut True si le savoir a été trouvé
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

        // Créer une chaîne de caractères comportant les caractéristiques du joueur
        //Renvoie cette chaîne de caractères en sortie
        public override string ToString()
        {
            string ch = ("\n   Personnage joueur :\n   " + _nom + "\n   Points de vie : " + _ptVie + "\n   Points de stress : " + _ptStress + "\n   Points de force : " + _ptForce + "\n");
            return ch;
        }
    }
}
