using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjectAtlantik
{
    class Periode
    {
        private int noperiode;
        private string datedebut, datefin;

        public Periode(int noperiode, string datedebut, string datefin)
        {
            this.noperiode = noperiode;
            this.datedebut = datedebut;
            this.datefin = datefin;
        }

        public int GetNumero()
        {
            return noperiode;
        }
        public override string ToString()
        {
            return datedebut + " au " + datefin;
        }
    }
}
