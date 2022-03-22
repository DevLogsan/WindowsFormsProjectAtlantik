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
        private double montanttotal;

        public Reservation(string libelle, int quantite, double montanttotal)
        {
            this.libelle = libelle;
            this.quantite = quantite;
            this.montanttotal = montanttotal;
        }

        public int GetQuantite()
        {
            return quantite;
        }

        public double GetMontantTotal()
        {
            return montanttotal;
        }

        public override string ToString()
        {
            return libelle + " : " + quantite;
        }
    }
}
