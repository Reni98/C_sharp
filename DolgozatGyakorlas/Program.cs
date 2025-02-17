using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatGyakorlas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *1. Feladat
                Készíts egy programot ahol létrehozunk egy paratlan nevü listát adjunk hozzá 32 db véletlenszerű számot 
                1-50 között és ki kell írni, hogy a szám páros vagy páratlan, 
                de a listához csak a páratlan számokat adjuk hozzá. 
                Írjuk ki a lista tartalmát egymás mellé vesszővel elválasztva. 
                Írjuk ki a lista hosszát is.

             */
            /*
            var rnd = new Random();
            List<int> paratlan = new List<int>();
            
            while (paratlan.Count < 32) { 
                int szam = rnd.Next(1,50);
                if (szam % 2 == 0)
                {
                    Console.WriteLine($"A szám páros{szam}.");
                }
                else {
                    Console.WriteLine($"A szám páratlan {szam}");
                    paratlan.Add(szam);
                }
            }

            Console.WriteLine(string.Join(";",paratlan));
            Console.WriteLine($"A lista hossza: {paratlan.Count}");
            */


            /*
             * 2. Feladat
                Készítsünk egy szamok nevű listát, 
                kérjünk be a felhasználótól 7 db számot, 
                és növeljük meg a bekért számok értékét kettővel és ha nagyobb, 
                mint 20 és kisebb mint 100 akkor adjuk hozzá a listához. 
                Számoljuk, hanyadik szám lett a listához adva 
                és a végén írjuk ki a lista hosszát.
            
             */

            List  <int> szamok = new List<int>();
            int db = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Adj meg egy számot");
                int szam = int.Parse(Console.ReadLine());
                int megnovelt = szam + 2;
                if (megnovelt > 20 && megnovelt < 100)
                {
                    szamok.Add(megnovelt);
                    db++;
                    Console.WriteLine($"{db} szám lett a listához adva.");
                    
                }
                else {
                    Console.WriteLine("A szám nem lett a listához adva.");
                }
            }

            Console.WriteLine($"A lista hossza: {szamok.Count}");

            Console.ReadKey();
        }
    }
}
