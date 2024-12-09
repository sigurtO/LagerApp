using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerApp_final_
{
    public class Produkter
    {
        public int SalgsID { get; set; }
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }
        public string Dato { get; set; }
        public int Minimumsbeholdning { get; set; }
        public int Maksimumsbeholdning { get; set; }
        //public int Pris { get; set; }

        public Produkter(int salgsID, string navn, string beskrivelse, string dato, int minimumsbeholdning, int maksimumsbeholdning) //int pris
        {
            SalgsID = salgsID;
            Navn = navn;
            Beskrivelse = beskrivelse;
            Dato = dato;
            Minimumsbeholdning = minimumsbeholdning;
            Maksimumsbeholdning = maksimumsbeholdning;
            //Pris = pris;
        }
        public Produkter(string navn, string beskrivelse, string dato, int minimumsbeholdning, int maksimumsbeholdning) //int pris
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
            Dato = dato;
            Minimumsbeholdning = minimumsbeholdning;
            Maksimumsbeholdning = maksimumsbeholdning;
            //Pris = pris
        }
        public Produkter()
        {

        }
    }
}
