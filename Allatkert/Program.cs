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
            

        }
    }
}
