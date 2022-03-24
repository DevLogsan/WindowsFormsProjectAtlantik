using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjectAtlantik
{
    class Reservation
    {
        private string libelle;
        private int quantite;

        public Reservation(string libelle, int quantite)
        {
            this.libelle = libelle;
            this.quantite = quantite;
        }

        public int GetQuantite()
        {
            return quantite;
        }

        public override string ToString()
        {
            return libelle + " : " + quantite;
        }
    }
}
