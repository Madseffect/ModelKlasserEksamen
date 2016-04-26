using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelKlasserEksamen
{
    class Kurser
    {
        public List<Deltagere> Deltagere { get; set; }
        public int KursusId { get; set; }
        public int LokaleNr { get; set; }
        public string Navn { get; set; }
        public string Underviser { get; set; }

        public Kurser(List<Deltagere> deltagere, int kursusId, int lokaleNr, string navn, string underviser)
        {
            Deltagere = deltagere;
            KursusId = kursusId;
            LokaleNr = lokaleNr;
            Navn = navn;
            Underviser = underviser;
        }

        public Kurser()
        {
            
        }
    }
}
