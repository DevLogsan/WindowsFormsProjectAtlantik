using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjectAtlantik
{
    class Liaison
    {
        private int noliaison;
        private string noport_depart, noport_arrivee;

        public Liaison(int noliaison, string noport_depart, string noport_arrivee)
        {
            this.noliaison = noliaison;
            this.noport_depart = noport_depart;
            this.noport_arrivee = noport_arrivee;
        }

        public int GetNumero()
        {
            return noliaison;
        }
        public override string ToString()
        {
            return noport_depart + " - " + noport_arrivee;
        }
    }
}
