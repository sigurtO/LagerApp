using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerApp_final_
{
    public class Produkter
    {
		public int ProduktID { get; set; }
		public string Navn { get; set; }
		public int SalgsID { get; set; }
		public int Antal { get; set; }
		public int Vægt { get; set; }
		public string Mål { get; set; }
		public string Beskrivelse { get; set; }
        public string Dato { get; set; }
        public int Minimumsbeholdning { get; set; }
        public int Maksimumsbeholdning { get; set; }
		public string Moebeltype { get; set; }
		public string Materialer { get; set; }
		public int Kostpris { get; set; }
		public int SalgsPris { get; set; }

		public Produkter(int produktID, string navn, int salgsID, int antal, int vægt, string mål, string beskrivelse, string dato, int minimumsbeholdning, int maksimumsbeholdning, string moebeltype, string materialer, int kostpris, int salgsPris)
		{
			ProduktID = produktID;
			Navn = navn;
			SalgsID = salgsID;
			Antal = antal;
			Vægt = vægt;
			Mål = mål;
			Beskrivelse = beskrivelse;
			Dato = dato;
			Minimumsbeholdning = minimumsbeholdning;
			Maksimumsbeholdning = maksimumsbeholdning;
			Moebeltype = moebeltype;
			Materialer = materialer;
			Kostpris = kostpris;
			SalgsPris = salgsPris;
		}




		//public int Pris { get; set; }



		//Pris = pris;
        public Produkter()
        {

        }
    }
}
