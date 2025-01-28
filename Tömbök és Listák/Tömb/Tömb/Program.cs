using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Tömb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Tömbök bevezetése
                Egy tömb (array) egy olyan adatszerkezet, amely több azonos típusú elemet képes tárolni egyetlen változóként. 
                Az elemekhez indexek segítségével férhetünk hozzá, ahol az indexelés 0-tól kezdődik.


                Tömb definiálása és inicializálása
                Tömb definiálása
                A tömb definiálása során megadjuk az elem típusát és a tömb nevét.
                 int[] numbers
                Ebben a példában egy numbers nevű tömböt definiálunk, amely int típusú elemeket tartalmaz.
             */
            ;



            /*Tömb inicializálása
            A tömb inicializálása során megadjuk a tömb méretét vagy elemeit.
            Méret megadásával
            numbers = new int[5];
            Ez egy 5 elemű tömböt hoz létre, amely alapértelmezés szerint 0 értékeket tartalmaz.
            */




            /*Elemmel történő inicializálás
            //numbers = new int[] { 1, 2, 3, 4, 5 };
            Ez egy 5 elemű tömböt hoz létre, amely a megadott értékeket tartalmazza.*/



            //A definíciót és inicializálást egy lépésben is megtehetjük:
            int[] numbers = { 1, 2, 3, 4, 5 };


            //Tömb elemének módosítása
            //A tömb elemeit indexek segítségével módosíthatjuk.
            numbers[0] = 10; // Az első elem értékének módosítása
            numbers[4] = 50; // Az utolsó elem értékének módosítása (5 elemű tömb esetén)


            /*
             * Tömb bejárása ciklusok segítségével
                A tömb elemeit ciklus segítségével járhatjuk be.
                A leggyakrabban használt ciklus erre a célra a for ciklus, de használhatunk foreach ciklust is.

                for ciklus használata
                
             */
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Elem " + i + ": " + numbers[i]);
            }

            //foreach ciklus használata
            foreach (int number in numbers)
            {
                Console.WriteLine("Elem: " + number);
            }

            /*
             * Magyarázat:
                Tömb definiálása és inicializálása: A numbers tömböt inicializáljuk az értékekkel { 1, 2, 3, 4, 5 }.
                Elemek módosítása: Az első és utolsó elemek értékét módosítjuk.
                Bejárás for ciklussal: A for ciklus segítségével végigmegyünk a tömb minden elemén, és kiírjuk az értékeket.
                Bejárás foreach ciklussal: A foreach ciklus segítségével egyszerűen végigmegyünk a tömb minden elemén és kiírjuk az értékeket.
             */

            /*
             * Készítsünk egy gyakorlati példaprogramot, amely egy egyszerű feladatot old meg egy egydimenziós tömb segítségével. 
             * Tegyük fel, hogy van egy bolt, ahol a napi eladásokat szeretnénk nyomon követni. A programunk képes lesz:

                Inicializálni egy tömböt a heti eladási adatokkal.
                Kiszámítani és megjeleníteni az összes napi eladást.
                Kiszámítani és megjeleníteni az átlagos napi eladást.
                Kikeresni és megjeleníteni a legnagyobb és legkisebb napi eladást.
                Gyakorlati Példa: Heti Eladások Nyomon Követése
             */

            // Tömb definiálása és inicializálása a heti eladási adatokkal
            int[] dailySales = { 150, 200, 170, 300, 250, 100, 180 };

            // Összes eladás kiszámítása
            int totalSales = 0;
            for (int i = 0; i < dailySales.Length; i++)
            {
                totalSales += dailySales[i];
            }
            Console.WriteLine("Összes heti eladás: " + totalSales);

            // Átlagos napi eladás kiszámítása
            double averageSales = (double)totalSales / dailySales.Length;
            Console.WriteLine("Átlagos napi eladás: " + averageSales);

            // Legnagyobb és legkisebb napi eladás kikeresése
            int maxSales = dailySales[0];
            int minSales = dailySales[0];

            for (int i = 1; i < dailySales.Length; i++)
            {
                if (dailySales[i] > maxSales)
                {
                    maxSales = dailySales[i];
                }
                if (dailySales[i] < minSales)
                {
                    minSales = dailySales[i];
                }
            }

            Console.WriteLine("Legnagyobb napi eladás: " + maxSales);
            Console.WriteLine("Legkisebb napi eladás: " + minSales);

            /*
             * Magyarázat:
                Tömb definiálása és inicializálása:
                dailySales nevű tömb inicializálása a heti eladási adatokkal.

                Összes eladás kiszámítása:
                A totalSales változót inicializáljuk 0-val.
                A for ciklus segítségével végigmegyünk a dailySales tömb minden elemén, és hozzáadjuk az értéket a totalSales változóhoz.
                Az összesített eladást kiírjuk a konzolra.

                Átlagos napi eladás kiszámítása:
                Az átlagos napi eladást kiszámítjuk úgy, hogy az totalSales értékét elosztjuk a dailySales tömb hosszával (dailySales.Length).
                Az átlagos eladást kiírjuk a konzolra.

                Legnagyobb és legkisebb napi eladás kikeresése:
                A maxSales és minSales változókat inicializáljuk a dailySales tömb első elemével.
                A for ciklus segítségével végigmegyünk a dailySales tömb minden elemén (kivéve az elsőt, amit már figyelembe vettünk).
                Ha a tömb aktuális eleme nagyobb, mint a maxSales, akkor frissítjük a maxSales értékét.
                Ha a tömb aktuális eleme kisebb, mint a minSales, akkor frissítjük a minSales értékét.
                A legnagyobb és legkisebb napi eladást kiírjuk a konzolra.

                
             */

            /* 
 * Tömbök műveletei
   - Elemet hozzáadni, eltávolítani, módosítani
   - Tömbök összehasonlítása, keresése, sorrendezés
 */

/* Tömb elemének módosítása */
int[] numbers = { 1, 2, 3, 4, 5 };
numbers[0] = 10; // Az első elem értékének módosítása
numbers[4] = 50; // Az utolsó elem értékének módosítása (5 elemű tömb esetén)

/* Tömbök összehasonlítása és keresése */
int[] numbersToCompare = { 10, 20, 30, 40, 50 };
bool areArraysEqual = numbers.SequenceEqual(numbersToCompare);
Console.WriteLine("A tömbök egyenlőek? " + areArraysEqual);

/* Tömb elem keresése */
int searchNumber = 40;
int index = Array.IndexOf(numbers, searchNumber);
if (index != -1)
{
    Console.WriteLine("A szám " + searchNumber + " megtalálható a " + index + " indexen.");
}
else
{
    Console.WriteLine("A szám nem található meg a tömbben.");
}

/* Tömb sorrendezése */
Array.Sort(numbers);
Console.WriteLine("Rendezett tömb: ");
foreach (int num in numbers)
{
    Console.WriteLine(num);
}



/* Tömb bejárása ciklusokkal */
Console.WriteLine("For ciklussal való bejárás:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Elem " + i + ": " + numbers[i]);
}

/* Gyakorlati példa: Heti eladások nyomon követése */
int[] dailySales = { 150, 200, 170, 300, 250, 100, 180 };

// Összes eladás kiszámítása
int totalSales = 0;
for (int i = 0; i < dailySales.Length; i++)
{
    totalSales += dailySales[i];
}
Console.WriteLine("Összes heti eladás: " + totalSales);

// Átlagos napi eladás kiszámítása
double averageSales = (double)totalSales / dailySales.Length;
Console.WriteLine("Átlagos napi eladás: " + averageSales);


Console.WriteLine("Legnagyobb napi eladás: " + maxSales);
Console.WriteLine("Legkisebb napi eladás: " + minSales);

 // Eredeti tömb
        int[] tomb = { 12, 5, 8, 20, 3 };

        Console.WriteLine("Eredeti tömb:");
        foreach (int szam in tomb)
        {
            Console.Write(szam + " ");
        }

        // Tömb megfordítása
        Array.Reverse(tomb);

        Console.WriteLine("\nMegfordított tömb:");
        foreach (int szam in tomb)
        {
            Console.Write(szam + " ");
        }
/* Magyarázat:
   - Tömbök műveletei közé tartozik az elem hozzáadása (ha Listával dolgozunk), törlés, keresés, sorrendezés.
   - A `SequenceEqual` metódus segítségével összehasonlíthatjuk két tömb tartalmát.
   - Az `Array.IndexOf` segítségével kereshetünk egy adott elemet a tömbben.
   - A `Array.Sort` segítségével rendezzük a tömb elemeit.
   - Az `Array`-ből `List`-et készíthetünk, hogy elvégezhessük az eltávolítást, majd visszaalakíthatjuk tömbbé.
   - A napi eladások példájában végigjárjuk a tömböt a szokásos `for` ciklussal és megjelenítjük az eredményeket.
*/
            Console.ReadKey();
        }
    }
}
