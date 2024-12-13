using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerApp_final_
{
    public class Ordre
    {

            public int OrdreId { get; set; }
            public string Dato { get; set; }
            public string Leverandoer { get; set; }
            public string Info { get; set; }
            public int KundeID { get; set; }
            public string KundeNavn { get; set; }

            // Konstruktor
            public Ordre(int ordreId, string dato, string leverandoer, string info, int kundeID, string kundeNavn)
            {
                OrdreId = ordreId;
                Dato = dato;
                Leverandoer = leverandoer;
                Info = info;
                KundeID = kundeID;
                KundeNavn = KundeNavn;
            }

            // Parameterløs konstruktor (hvis påkrævet)
            public Ordre() { }
        }
    }

