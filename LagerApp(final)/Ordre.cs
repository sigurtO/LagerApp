using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerApp_final_
{
    public class Ordre
    {

        public class OrdreLager
        {
            public int OrdreId { get; set; }
            public string Dato { get; set; }
            public string Leverandoer { get; set; }
            public string Info { get; set; }
            public int KundeID { get; set; }

            // Konstruktor
            public OrdreLager(int ordreId, string dato, string leverandoer, string info, int kundeID)
            {
                OrdreId = ordreId;
                Dato = dato;
                Leverandoer = leverandoer;
                Info = info;
                KundeID = kundeID;
            }

            // Parameterløs konstruktor (hvis påkrævet)
            public OrdreLager() { }
        }
    }
}

