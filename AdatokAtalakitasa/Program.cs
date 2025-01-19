using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdatokAtalakitasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A parszolás C#-ban az adatok különböző típusok közötti konvertálását jelenti.
             * Például egy stringből számot, dátumot vagy más adattípust készítesz. 
             */

            /*
             * Pars függvények használata
                C#-ban az alábbi metódusokkal parszolhatsz stringből:

                int.Parse - Egész szám parszolása.
                double.Parse - Lebegőpontos szám parszolása.
                bool.Parse - Logikai érték (true, false) parszolása.
                DateTime.Parse - Dátum és idő parszolása.

            /*
            TryParse
            A TryParse biztonságosabb, mert ellenőrzi, hogy a parszolás sikeres volt-e, és elkerülhető vele a futási időben dobott hiba. Például:
            */

            int szam;
            if (int.TryParse("123", out szam))
            {
                Console.WriteLine("Pars sikeres, az érték: " + szam);
            }
            else
            {
                Console.WriteLine("Pars sikertelen.");
            }


            /*1. Egyszerű számok parszolása*/
            Console.WriteLine("Adj meg egy egész számot:");
            string input = Console.ReadLine();

          
                int sz = int.Parse(input);
                Console.WriteLine("Sikeres parszolás! A szám: " + sz);


            /*2. Lebegőpontos szám és TryParse*/
            Console.WriteLine("Adj meg egy lebegőpontos számot (pl. 3.14):");
            string bekert = Console.ReadLine();

            
            if (double.TryParse(bekert, out double bekertSzam))
            {
                Console.WriteLine("Sikeres parszolás! A szám: " + bekertSzam);
            }
            else
            {
                Console.WriteLine("Hiba: Nem sikerült lebegőpontos számként értelmezni a bemenetet.");
            }

            /*3. Dátum és idő parszolása*/
            Console.WriteLine("Adj meg egy dátumot (pl. 2025-01-01):");
            string ido = Console.ReadLine();

            
            if (DateTime.TryParse(ido, out DateTime datum))
            {
                Console.WriteLine("Sikeres parszolás! A dátum: " + datum.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine("Hiba: Nem sikerült dátumként értelmezni a bemenetet.");
            }

            /*4. Logikai érték parszolása*/
            Console.WriteLine("Adj meg egy logikai értéket (true/false):");
            string logikai = Console.ReadLine();

            if (bool.TryParse(logikai, out bool l))
            {
                Console.WriteLine("Sikeres parszolás! Az érték: " + l);
            }
            else
            {
                Console.WriteLine("Hiba: Nem sikerült logikai értékként értelmezni a bemenetet.");
            }


          
        }
    }
}
