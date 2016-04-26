using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelKlasserEksamen
{
    class Lokaler
    {
        public string Adresse { get; set; }
        public int LokaleNr { get; set; }

        public Lokaler(string adresse, int lokaleNr)
        {
            Adresse = adresse;
            LokaleNr = lokaleNr;
        }

        public Lokaler()
        {
            
        }
    }
}
