using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelKlasserEksamen
{
    class Underviser
    {
        public string Adresse { get; set; }
        public string Email { get; set; }
        public string Navn { get; set; }
        public int Tlf { get; set; }

        public Underviser(string adresse, string email, string navn, int tlf)
        {
            Adresse = adresse;
            Email = email;
            Navn = navn;
            Tlf = tlf;
        }
        public Underviser()
        {
            
        }
    }
}
