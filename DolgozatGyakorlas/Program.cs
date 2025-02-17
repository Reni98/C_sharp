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
            */

            /*
             *3. Feladat
                Hozzunk létre 5 elemű tömböt, adjunk hozzá 5 db tantárgyat, 
                írjuk ki, hogy van-e benne Informatika tantárgy, 
                ha nincs írjuk ki, hogy nem található a tömben, 
                ha van akkor írjuk ki, hogy van benne informatika tantárgy. 
                Írjuk ki egymás mellé, milyen tantárgyak vannak a tömben.
             

            string[] tantargyak = { "Informatika", "Matek", "Angol", "Német", "Történelem" };
            if (tantargyak.Contains("Informatika"))
            {
                Console.WriteLine("Benne van a tömben az Informatika tantárgy.");
            }
            else {
                Console.WriteLine("Nincs a tömben az Informatika tantárgy.");
            }

            Console.WriteLine(string.Join(",",tantargyak));
           

            string[] tantargyak = new string[5];
            for (int i = 0; i < tantargyak.Length; i++)
            {
                Console.WriteLine("Adj meg egy tantárgyat: ");
                string targy = Console.ReadLine();
                tantargyak[i] = targy;

            }
            if (tantargyak.Contains("Informatika"))
            {
                Console.WriteLine("Benne van a tömben az Informatika tantárgy.");
            }
            else
            {
                Console.WriteLine("Nincs a tömben az Informatika tantárgy.");
            }

            Console.WriteLine(string.Join(",", tantargyak));

             */
            /*
             *4. Feladat
            string[] nevek = { "Anna", "Elemér", "Béla", "John", "Jenna", "Kinga" };
            Az alábbi tömbben nézzük meg, hogy van-e Anna név benne, 
            ha van cseréljük le a nevet Katára,
            majd írjuk ki a tömb tartalmát vesszővel elválasztva.

             
             
            string[] nevek = { "Anna", "Elemér", "Béla", "John", "Jenna", "Kinga" };
            for (int i = 0; i < nevek.Length; i++)
            {
                if (nevek.Contains("Anna")) {
                    nevek[i] = "Kata";               
                }
            }

            Console.WriteLine(string.Join(";",nevek));
            */

            /*
             *5. Feladat
                Hozzunk létre egy  rendezett nevű listát, 
                kérjünk be a felhasználótól számokat, 
                és ha 0 ír be álljon le a program futása, 
                rendezze a listát növekvő sorrendbe, 
                írja ki a lista tartalmát, 
                és add meg a listában lévő legkisebb és legnagyobb számot.
             

            List<int> rendezett = new List<int>();
            while (true) {
                Console.WriteLine("Adj meg számokat: ");
                int szam = int.Parse(Console.ReadLine());
                rendezett.Add(szam);

                if (szam == 0) {
                    break;
                }
            }
            rendezett.Sort();
            Console.WriteLine(string.Join(";",rendezett));
            Console.WriteLine($"A legkisebb szám: {rendezett.Min()}");
            Console.WriteLine($"A legnagyobb szám: {rendezett.Max()}");
            */

            /*
             *6. Feladat
                Hozz létre egy listát, kérj be számokat a felhasználótól 
                a lista hossza legalább 8 számból álljon 
                és a felhasználó bármikor kitudjon utána lépni, 
                keresd meg a legnagyobb elemet a listában 
                és a legnagyobb elemhez adj hozzá 2-őt, 
                majd cseréld le erre a számra. 
                Rendezd csökkenő sorrendbe a lista tartalmát 
                és írja ki a lista tartalmát.
            
            List <int> szamok = new List<int>();
            while (true) {
                Console.WriteLine("Adj meg egy számot: ");
                int szam = int.Parse(Console.ReadLine());
                szamok.Add(szam);

                if (szamok.Count > 8) {
                    Console.WriteLine("Szeretnéd még folytatni?(i/n):");
                    string folytat = Console.ReadLine();
                    if (folytat == "n") {
                        break;
                    }
                }
            }
            int legnagyobb = szamok.Max();
            Console.WriteLine($"A legnagyobb szám: {legnagyobb}");
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] == legnagyobb) {
                    legnagyobb += 2;
                    szamok[i] = legnagyobb;
                }
            }

            szamok.Sort();
            szamok.Reverse();
            Console.WriteLine(string.Join(",",szamok));

             */

            /*
             *7. Feladat
            string[] kavek = { "Espresso", "Americano", "Latte", "Cappuccino", 
            "Macchiato", "Flat White", "Mocha", "Affogato", "Cortado", "Ristretto" };

            Írd ki, hogy a Cortado kávé hanyas indexen található meg a tömben.

             
            string[] kavek = { "Espresso", "Americano", "Latte", "Cappuccino",
            "Macchiato", "Flat White", "Mocha", "Affogato", "Cortado", "Ristretto" };

            int index = Array.IndexOf(kavek, "Cortado");
            Console.WriteLine($"A Cortado kávé a {index}. indexen van.");
            */

            /*
             *8. Feladat
                int[] szamok = { 5, 10, 15, 20, 25, 30 };
                Kérj be a felhasználótól egy számot és vizsgáld meg, 
                hogy benne van-e a tömben, ha igen írd ki,
                hogy melyik indexen, ha nincs írja ki, 
                hogy nincs ilyen szám a tömben.
             
                int[] szamok = { 5, 10, 15, 20, 25, 30 };
            
            Console.WriteLine("Adj meg egy számot:");
            int szam = int.Parse(Console.ReadLine());
            if (szamok.Contains(szam))
            {
                int index2 = Array.IndexOf(szamok, szam);
                Console.WriteLine($"A megadott szám: {index2}. indexen van.");
            }
            else {
                Console.WriteLine("Nincs ilyen szám a tömben.");
            }
            */

            /*
             * 9. Feladat
                List<int> szamok = new List<int> 
                { 5, 12, 7, 20, 12, 30, 12, 40, 70,45, 12,21,34,78  };
                Kérj be a felhasználótól számot és számold meg melyik indexen vannak, 
                ha egy szám többször is szerepel írd ki az indexeket a consolra.

             

            List<int> indexek = new List<int>();
            List<int> szamok = new List<int>{ 5, 12, 7, 20, 12, 30, 12, 40, 70,45, 12,21,34,78  };
            Console.WriteLine("Adj meg egy számot: ");
            int bekertszam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szamok.Count; i++)
            {
                if (szamok[i] == bekertszam) {
                    indexek.Add(i);
                }
            }
            
            Console.WriteLine($"A megadott szám indexei: {string.Join(";",indexek)}");
            */
            Console.ReadKey();
        }
    }
}
