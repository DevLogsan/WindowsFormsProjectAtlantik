using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjectAtlantik
{
    class Secteur
    {
        private int nosecteur;
        private string nom;

        public Secteur(int nosecteur, string nom)
        {
            this.nosecteur = nosecteur;
            this.nom = nom;
        }

        public int GetSecteur()
        {
            return nosecteur;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}