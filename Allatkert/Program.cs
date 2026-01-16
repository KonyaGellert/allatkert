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
            return "Az állat neve:"+ Nev + ", Faja:"+ Faj + ", Szuletesiéve:"+ SzuletesiEv + ", Élőhelye" +Elohely ;
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

            //Feladat 1: Határozd meg, hány állat tartozik a „szavanna” élőhelyhez.
            int db = 0;
            foreach (var allat in allatkert)
            {
                if (allat.Elohely == "szavanna")
                {
                    db++;
                }
            }
            Console.WriteLine($"{db}db állat lakik szavannán");
            //Feladat 2: Találd meg a legkorábban született állatot, (nem idén).
            Allat legkorabbi = allatkert[0];
            foreach (var allat in allatkert)
            {
                if (allat.SzuletesiEv < legkorabbi.SzuletesiEv)
                {
                    legkorabbi = allat;
                }
            }
            Console.WriteLine($"A legkorábban született állat: {legkorabbi.Nev}");
            //Feladat 3: Számold ki az állatok átlagéletkorát a jelenlegi év alapján, használd a hanyeves függvényt.
            int osszEletkor = 0;
            foreach (var allat in allatkert)
            {
                osszEletkor += allat.hanyeves();
            }
            double atlagEletkor = (double)osszEletkor / allatkert.Count;
            Console.WriteLine($"Az allatok atlageletkora: {atlagEletkor} ev");
            //Feladat 4: Listázd ki azokat az állatokat, amelyek 2015 után születtek.
            Console.WriteLine("2015 után született állatok:");
            foreach (var allat in allatkert)
            {
                if (allat.SzuletesiEv > 2015)
                {
                    Console.WriteLine(allat.Nev);
                }


            }
            //Feladat 5: Olvasd be konzolról egy új állat adatait. Ha még nincs ilyen nevű add hozzá, Ha van ilyen töröld a listából!
            Console.WriteLine("Add meg az állat nevét: ");
            string nev = Console.ReadLine();

            Console.WriteLine("Add meg az állat faját: ");
            string faj = Console.ReadLine();

            Console.WriteLine("Add meg az állat születési évét: ");
            int szuletesiEv = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg az állat élőhelyét: ");
            string elohely = Console.ReadLine();

            Allat ujallat = new Allat(nev, faj, szuletesiEv, elohely);
            bool letezik = false;
            foreach (var allat in allatkert)
            {
                if (allat.Nev == ujallat.Nev)
                {
                    letezik = true;
                    allatkert.Remove(allat);
                    Console.WriteLine("Már van ilyen állat");
                    break;
                }
            }
            if (!letezik)
            {
                allatkert.Add(ujallat);
                Console.WriteLine("Az állat hozzá lett adva a listához.");
            }




        }
    }
}
