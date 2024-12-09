using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerApp_final_
{
    internal class Produkter
    {
        public int SalgsID { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public string Dato { get; set; }
        public int Minimumsbeholdning { get; set; }
        public int Maksimumsbeholdning { get; set; }

        public Produkter(int salgsID, string navn, string beskrivelse, string dato, int minimumsbeholdning, int maksimumsbeholdning)
        {
            SalgsID = salgsID;
            Navn = navn;
            Beskrivelse = beskrivelse;
            Dato = dato;
            Minimumsbeholdning = minimumsbeholdning;
            Maksimumsbeholdning = maksimumsbeholdning;
        }
    }
}
