using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjectAtlantik
{
    class Tarif
    {
        private string lettrecategorie;
        private int notype;
        private string libelle;

        public Tarif(string lettrecategorie, int notype, string libelle)
        {
            this.lettrecategorie = lettrecategorie;
            this.notype = notype;
            this.libelle = libelle;
        }

        public int GetNoType()
        {
            return notype;
        }

        public override string ToString()
        {
            return lettrecategorie + notype + " - " + libelle + " :";
        }
    }
}
