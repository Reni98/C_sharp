using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomb_Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1.Feladat");
            Console.WriteLine("Adj meg egy időpontot 1-24 óra között:");
            int ora = int.Parse(Console.ReadLine());

            if (ora >= 1 && ora <= 8)
            {
                Console.WriteLine("Jó reggelt!");
            }
            else if (ora >= 9 && ora <= 18)
            {
                Console.WriteLine("Jó napot!");
            }
            else if (ora >= 19 && ora <= 24)
            {
                Console.WriteLine("Jó estét!");
            }
            else {
                Console.WriteLine("Nem megfelelő számot adtál meg.");
            }
           
             Console.WriteLine("2.Feladat");
            int osszeg = 0;
            int[] tomb = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < tomb.Length; i++) {
                tomb[i] += 2;
                Console.WriteLine(tomb[i]);               
            }

            foreach (var item in tomb)
            {
               osszeg +=item;                
            }
            Console.WriteLine($"foreach-al {osszeg}");
            
            Console.WriteLine("3.Feladat");
            var rnd = new Random();
            int[] idojaraselorejelzes = new int[30];
            for (int i = 0; i < idojaraselorejelzes.Length; i++)
            {
                idojaraselorejelzes[i] = rnd.Next(-5,36);

            }

            foreach (var item in idojaraselorejelzes)
            {
                Console.WriteLine(item);
            }

            int hideg = int.MaxValue;
            int meleg = int.MinValue;
            int harmincfelett = 0;
            int osszeg = 0;
            for (int i = 0; i < idojaraselorejelzes.Length; i++)
            {
                osszeg += idojaraselorejelzes[i];
                if (idojaraselorejelzes[i] < hideg)
                {
                    hideg = idojaraselorejelzes[i];

                }
                else if (idojaraselorejelzes[i] > meleg) {
                    meleg = idojaraselorejelzes[i];
                }
                if (idojaraselorejelzes[i] > 30) {
                    harmincfelett++;
                }
            }

            int leghidegebb = idojaraselorejelzes.Min();
            int legmelegebb = idojaraselorejelzes.Max();
            Console.WriteLine($"A leghidegebb hőmérséklet: {hideg}, A legmelegebb hőmérséklet: {meleg}");
            Console.WriteLine($"A leghidegebb : {leghidegebb}, A legmelegebb : {legmelegebb}");
            Console.WriteLine($"Ennyiszer volt 30 C felett a hőmérséklet: {harmincfelett}");
            Console.WriteLine($"Az átlag hőmérséklet: {osszeg/idojaraselorejelzes.Length}");
            */
            /* 
             * 4. Vásárlói kosár szimulációja
            Tárolj egy tömbben különböző termékek árát, majd:

             Számold ki a teljes összeget
             Keresd meg a legdrágább és legolcsóbb terméket
             
            int[] arak = { 2500, 4990, 1500, 8990, 3490 };

            int osszeg = 0;
            for (int i = 0; i < arak.Length; i++)
            {
                osszeg += arak[i];
            }

            int legolcsobb = arak.Min();
            int legdragabb = arak.Max();
            Console.WriteLine($"Az összeg: {osszeg}");
            Console.WriteLine($"A legdrágább: {legdragabb}, legolcsobb: {legolcsobb}");
            
            List<int> szamok = new List<int>();
            
            szamok.Add(4);
            szamok.Add(3);
            szamok.Add(2);
            szamok.Add(1);
           
           

            szamok.Remove(1);
            // List<T> elemeinek kiírása
            foreach (int item in szamok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(szamok.Count);

            bool bennevan2 = szamok.Contains(2);
            Console.WriteLine(bennevan2);

            int index3 = szamok.IndexOf(3);
            Console.WriteLine($"A 3-as szám indexe: {index3}");

            //szamok.Sort();
            szamok.Clear();
            foreach (int item in szamok)
            {
                Console.WriteLine(item);
            }

            

            List<string> nevek = new List<string>();
            nevek.Add("Anna");
            nevek.Add("Béla");
            nevek.Add("Cili");

            while (true) {
                Console.WriteLine("Adj meg neveket: ");
                string nev = Console.ReadLine();
                nevek.Add(nev);

                Console.WriteLine("Szeretnél-e még nevet megadni?(i/n)");
                string valasz = Console.ReadLine();
                if (valasz.Equals("n")) {
                    break;
                }
            }
            foreach (string nev in nevek)
            {
                Console.WriteLine(nev);
            }

            Console.WriteLine($"A nevek száma a listában: {nevek.Count}");
            

            List<string> termekek = new List<string>();
            while (true) {
                Console.WriteLine("Milyen műveltet szeretnél?(Hozzaad, Kosar megtekintese, Torles, Kilepes)");
 
                string valasztottmuvelet = Console.ReadLine();
                if (valasztottmuvelet.Equals("Hozzaad"))
                {
                    Console.WriteLine("Add meg a terméket: ");
                    string termek = Console.ReadLine();
                    termekek.Add(termek);
                }
                else if (valasztottmuvelet.Equals("Kosar megtekintese"))
                {
                    foreach (string kosar in termekek)
                    {
                        Console.WriteLine(kosar);
                    }
                }
                else if (valasztottmuvelet.Equals("Torles"))
                {
                    Console.WriteLine("Add meg melyik terméket szeretnéd törölni:");
                    string torles = Console.ReadLine();
                    for (int i = 0; i < termekek.Count; i++)
                    {
                        if (termekek[i] == torles)
                        {
                            termekek.Remove(torles);
                        }
                    }


                }
                else if (valasztottmuvelet.Equals("Kilepes")) {
                    Console.WriteLine("Köszönjük a vásárlást.");
                    break;
                
                }
            

        }
            
            List<int> jegyek = new List<int>();
            int osszeg = 0;
            while (true) {
                Console.WriteLine("Megadni, Törölni vagy Átlagot számolni szeretnél(M,T,Á)");
                string muvelet = Console.ReadLine();
                if (muvelet == "M")
                {
                    Console.WriteLine("Add meg az érdem jegyeket: ");
                    int jegy = int.Parse(Console.ReadLine());
                    jegyek.Add(jegy);
                }
                else if (muvelet == "T")
                {
                    Console.WriteLine("Melyik jegyet szeretnéd törölni");
                    int jegytorles = int.Parse(Console.ReadLine());
                    jegyek.Remove(jegytorles);
                }
                else if (muvelet == "Á")
                {

                    foreach (int atlag in jegyek)
                    {
                        osszeg += atlag;
                    
                    }
                    Console.WriteLine($"A jegyek átlaga: {osszeg / jegyek.Count}");
                }
                else {
                    Console.WriteLine("A művelet befejeződött.");
                    break;
                }
           
        }
             */
            /*Bevásárlás
             * Egy listához hozzá kell adni árakat,
             * Tudjon választani a felhasználó,hogy árat adna hozzá, törölne,
             * megnézné a tartalmát listának, vagy a végösszeget szeretné kiíratni.
             * Kilépés beírása esetén álljon le a program.
             */

            List<int> arak = new List<int>();

            while (true) {
                Console.WriteLine("Adja meg a művletet: (H,T,M,V)");
                string muvelet = Console.ReadLine();
                if (muvelet.Equals("H"))
                {
                    Console.WriteLine("Add meg az árat: ");
                    int ar = int.Parse(Console.ReadLine());
                    arak.Add(ar);
                }

                else if (muvelet.Equals("T"))
                {
                    Console.WriteLine("Add meg az árat amit törölni szeretnél: ");
                    int artorles = int.Parse(Console.ReadLine());
                    arak.Remove(artorles);

                }
                else if (muvelet.Equals("M"))
                {
                    foreach (var item in arak)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (muvelet.Equals("V"))
                {
                    int osszeg = arak.Sum();
                    Console.WriteLine($"A végösszeg: {osszeg}");
                }
                else if (muvelet.Equals("Kilép")){
                    Console.WriteLine("Viszlát");
                    break;
                }

            }


            Console.ReadKey();
        }
    }
}
