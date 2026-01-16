using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allatkert
{
    public class Allat
    {
        public string Nev;
        public string Faj;
        public int SzuletesiEv;
        public string Elohely;

        public Allat(string nev, string faj, int szuletesiEv, string elohely)
        {
            Nev = nev;
            Faj = faj;
            SzuletesiEv = szuletesiEv;
            Elohely = elohely;
        }

        public override string ToString()
        {
            return "Az állat neve:"+ Nev + ",Faja:"+ Faj + ",Szuletesiéve:"+ SzuletesiEv + ",Élőhelye" +Elohely ;
        }
        public int hanyeves()
        {
            return DateTime.Now.Year-SzuletesiEv;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 állat listába
            List<Allat> allatkert = new List<Allat>();
            allatkert.Add(new Allat("Péter", "Oroszlán", 2015, "szavanna"));
            allatkert.Add(new Allat("Jakab", "Elefánt", 2010, "szavanna"));
            allatkert.Add(new Allat("Zoltán", "Zebra", 2018, "szavanna"));
            allatkert.Add(new Allat("Bpapi", "Papagáj", 2012, "dzsungel"));
            allatkert.Add(new Allat("Attila", "Pingvin", 2016, "sarkvidék"));


        }
    }
}
