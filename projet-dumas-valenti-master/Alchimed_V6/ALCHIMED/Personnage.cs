﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALCHIMED
{
    abstract class Personnage
    {
        public string _nom;
        public int _ptVie;

        // Constructeur 
        public Personnage(string nom, int ptVie)
        {
            _nom = nom;
            _ptVie = ptVie;
        }

        public abstract void Defier(Personnage p);



    }
}
