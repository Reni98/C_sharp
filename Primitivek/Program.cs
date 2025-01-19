using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitívek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*A "primitív" típusok azok az alapvető adat - vagy adattípusok, amelyek közvetlenül 
            a nyelv részeként definiáltak, és nem összetettek vagy felhasználói által definiáltak. 
            Ezek a típusok egyszerűek, alapvető építőkövei a programoknak, és közvetlenül támogatják 
            a nyelv műveleteit és operátorait. A primitív típusok közé tartoznak például az egész számok, 
            a lebegőpontos számok, a karakterek és a logikai értékek.*/

            //Boolean(Logikai típus)
            //A bool típus széles körben alkalmazható különböző programozási helyzetekben,
            //például feltételek ellenőrzésére, ciklusok vezérlésére és logikai műveletek végrehajtására.
            // Boolean típusú változók deklarálása és inicializálása
            bool isCSharpFun = true;
            bool isFishTasty = false;

            // Logikai értékek kiírása
            Console.WriteLine(isCSharpFun);   // Kiírja: True
            Console.WriteLine(isFishTasty);   // Kiírja: False


            /*Magyarázat:
                Boolean változók deklarálása és inicializálása:

                isCSharpFun: Ez a változó true értéket kap, ami azt jelzi, hogy szerintünk a C# programozás szórakoztató.
                isFishTasty: Ez a változó false értéket kap, ami azt jelzi, hogy szerintünk a hal nem finom.

                Logikai értékek kiírása:
                A Console.WriteLine(isCSharpFun); sor kiírja a isCSharpFun változó értékét, ami true, 
                így a konzolon megjelenik: True.
                A Console.WriteLine(isFishTasty); sor kiírja a isFishTasty változó értékét, ami false, 
                így a konzolon megjelenik: False.
            */

            /*Int(Egész szám típus)
            Az int típus egész számokat tárol.Például, használhatjuk számlálásokhoz vagy matematikai műveletekhez.
            Példa:*/
            // Int típusú változó deklarálása és inicializálása
            int number = 10;

            // Néhány matematikai művelet
            int doubled = number * 2;
            int squared = number * number;

            // Eredmények kiírása
            Console.WriteLine("Szám: " + number);
            Console.WriteLine("Duplázva: " + doubled);
            Console.WriteLine("Négyzetre emelve: " + squared);

            /*Magyarázat:
            Ebben a példában a number nevű változó értéke 10.Ezt a számot megduplázzuk és négyzetre emeljük,
            majd kiírjuk az eredményeket.*/

            /*Double(Lebegőpontos szám típus)
            A double típus valós számokat tárol, amelyek lehetnek törtek is.
            Példa:*/
            // Double típusú változó deklarálása és inicializálása
            double temperature = 23.5;

            // Egy egyszerű művelet a double típusú változóval
            double halfTemperature = temperature / 2;

            // Eredmények kiírása
            Console.WriteLine("Hőmérséklet: " + temperature);
            Console.WriteLine("Hőmérséklet fele: " + halfTemperature);

            /*Magyarázat:
            Ebben a példában a temperature nevű változó értéke 23.5.Ezt a számot elosztjuk kettővel, 
            majd kiírjuk az eredményt.*/


            /*String(Szöveges típus)
            A string típus szöveges adatokat tárol.Ez lehet egyetlen karaktertől kezdve akár hosszú mondatokig bármi.
            Példa:*/
            // String típusú változó deklarálása és inicializálása
            string name = "John";

            // Szöveg összefűzése
            string greeting = "Hello, " + name + "!";

            // Eredmények kiírása
            Console.WriteLine(greeting);

            /*Magyarázat:
            Ebben a példában a name nevű változó értéke "John".Ezt a szöveget összefűzzük egy üdvözlő szöveggel, 
            majd kiírjuk: "Hello, John!".*/

            Console.ReadKey();
        }
    }
}
