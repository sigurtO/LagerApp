﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagerApp_final_
{
    public class Raavare
    {
        public string Navn { get; set; }
        public int Antal { get; set; }
        public int MinimumsBeholding { get; set; }
        public int MaksimumsBeholdning { get; set; }
        public string Maal { get; set; }
        public int Vaegt { get; set; }
        public string Lokation { get; set; }
        public int MaterialeID { get; set; }
        public string MaterialeType { get; set; }

        public Raavare(string navn, int antal, int minimumsBeholding, int maksimumsBeholdning, string maal, int vaegt, string lokation, int materialeID, string materialeType)
        {
            Navn = navn;
            Antal = antal;
            MinimumsBeholding = minimumsBeholding;
            MaksimumsBeholdning = maksimumsBeholdning;
            Maal = maal;
            Vaegt = vaegt;
            Lokation = lokation;
            MaterialeID = materialeID;
            MaterialeType = materialeType;
        }
    }

}