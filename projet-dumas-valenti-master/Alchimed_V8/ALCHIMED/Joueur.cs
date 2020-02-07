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
        {
        }

        // permet au joueur de choisir entre trois caractéristiques, celle qu'il veut attribuer à son personnage
        // la caractéristique choisie agira soit sur ptVie soit sur ptForce soit sur les savoirs
        public void AttribuerCaracteristique()
        {
            string[] car = new string[3] { "Force", "Résistance", "Intelligence" };

            //Liste des caractériques avec un numéro pour chacune
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

        public void Defier(Personnage adversaire, int coup)
        {
            if (coup == 1)
            {
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
            Acces etatAcces = lieu.Acceder(_savoirs, _ptForce);
            if (etatAcces != Acces.Autorise)
            {
                if (etatAcces == Acces.RefuseEntrainement)
                    Console.WriteLine("Accès refusé : vous n'êtes pas pas encore assez fort.");
                else if (etatAcces == Acces.RefuseEtude)
                    Console.WriteLine("Accès refusé : vous n'avez pas suffisamment étudié.");
            }
            else
            {
                Console.WriteLine(lieu);
            }
            

        }

        // Intéragir avec un objet de la pièce
        public void DeplacerVersObjet(Piece lieu)
        {
            lieu.Lister();
            int choix = int.Parse(Console.ReadLine());

            foreach (Objet objet in lieu._objets)
                {
                    if (objet.Num == choix)
                    {
                        if (objet.Verif() == true)
                        {
                            if ((_savoirs.Count == 0) || ((_savoirs.Count != 0) && (!TrouveSavoir(objet.Enseignement))))
                            {
                                _savoirs.Add(objet.Enseignement);
                                Console.WriteLine("Vous obtenez le savoir " + objet.Enseignement);
                            }
                        } 
                        objet.AfficheDescription();

                        if (objet is ObjetSpecial)
                        {
                            objet.Interagir(this);
                        }
                    }
                }
        }

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

        // Créer une chaîne de caractères comportant les caractéristiques de la pièce
        public override string ToString()
        {
            string ch = ("\n   Personnage joueur :\n   " + _nom + "\n   Points de vie : " + _ptVie + "\n   Points de stress : " + _ptStress + "\n   Points de force : " + _ptForce + "\n");
            return ch;
        }
    }
}
