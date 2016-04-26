using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelKlasserEksamen
{
    class Deltagere
    {
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Navn  { get; set; }
        public int TlfNr { get; set; }

        public Deltagere(string adresse, string email, string navn, int tlfNr)
        {
            Adresse = adresse;
            Email = email;
            Navn = navn;
            TlfNr = tlfNr;
        }

        public Deltagere()
        {
            
        }
    }
}
