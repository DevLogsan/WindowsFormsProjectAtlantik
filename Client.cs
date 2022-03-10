using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjectAtlantik
{
    class Client
    {
        private int noclient;
        private string nom;
        private string prenom;

        public Client(int noclient, string nom, string prenom)
        {
            this.noclient= noclient;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int GetNumeroClient()
        {
            return noclient;
        }

        public override string ToString()
        {
            return nom + " " + prenom;
        }
    }
}
