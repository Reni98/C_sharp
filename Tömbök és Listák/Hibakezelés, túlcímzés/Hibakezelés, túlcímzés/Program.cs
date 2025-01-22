using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hibakezelés__túlcímzés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A C# nyelvben a hibakezelést try-catch blokkokkal valósítjuk meg.
             * A try blokkban írjuk a potenciálisan hibát okozó kódot, a catch blokkban pedig megadjuk, hogyan kezeljük a hibát.
             * 
             * 
             * A hibakezelés célja, hogy a programunk képes legyen megfelelően reagálni a futási időben előforduló hibákra (kivétel, exception). Ezáltal megbízhatóbb és stabilabb alkalmazásokat készíthetünk, amelyek nem omlanak össze váratlan hibák miatt.

               Alapfogalmak
                Kivétel (Exception): A futásidőben bekövetkező rendellenes esemény, amely megszakítja a program normál működését.
                Try-catch blokk: A kivételek kezelésére szolgál. A try blokkban helyezzük el a potenciálisan hibás kódot, a catch blokkban pedig megadjuk, 
                hogyan kezeljük a kivételt.
                Finally blokk: Opcionális blokk, amely mindig végrehajtódik, függetlenül attól, hogy történt-e kivétel vagy sem.
                Általában erőforrások felszabadítására használják.

                Hibakezelés Alapjai
                Try-catch Blokk

                        try
                            {
                                // Potenciálisan hibás kód
                             }
                        catch (ExceptionType ex)
                            {
                                // Kivétel kezelése
                                Console.WriteLine("Hiba: " + ex.Message);
                            }



            Finally Blokk
            try
            {
                    // Potenciálisan hibás kód
             }
            catch (ExceptionType ex)
            {
                // Kivétel kezelése
                 Console.WriteLine("Hiba: " + ex.Message);
              }
            finally
            {
                // Erőforrások felszabadítása
            }

            Túlcímzés (IndexOutOfRangeException)
            A túlcímzés akkor fordul elő, amikor egy tömb (vagy más indexelhető adatszerkezet) olyan indexét próbáljuk elérni, 
            amely kívül esik az érvényes tartományon. Például egy 5 elemű tömb esetén az érvényes indexek 0-tól 4-ig terjednek. Ha a numbers[5] indexet próbáljuk elérni, IndexOutOfRangeException kivétel keletkezik.

            Példa Túlcímzésre
             int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[5]); // IndexOutOfRangeException kivételt eredményez

             Példa Hibakezelésre és Túlcímzésre
             */
            int[] numbers = { 1, 2, 3, 4, 5 };

            try
            {
                // Helyes indexelés
                Console.WriteLine("A tömb első eleme: " + numbers[0]);

                // Túlcímzés szimulálása
                Console.WriteLine("A tömb hatodik eleme: " + numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                // Hibakezelés: IndexOutOfRangeException kezelése
                Console.WriteLine("Hiba történt: Túlcímzés. " + ex.Message);
            }

            // Program folytatása
            Console.WriteLine("A program folytatódik...");

            /*
             * Jegyek Átlagának Számítása
                Ebben a példában megkérjük a felhasználót, hogy adjon meg egy sor jegyet (pontszámokat),
                majd kiszámítjuk és megjelenítjük az átlagot. 
                Közben kezeljük a potenciális hibákat, például ha a felhasználó nem számot ad meg.
             */

            try
            {
                // Kérjük meg a felhasználót, hogy adja meg a jegyek számát
                Console.WriteLine("Hány jegyet szeretne megadni?");
                int numberOfGrades = int.Parse(Console.ReadLine());

                // Tömb inicializálása a megadott mérettel
                int[] grades = new int[numberOfGrades];

                // Kérjük be a felhasználótól a jegyeket
                for (int i = 0; i < numberOfGrades; i++)
                {
                    Console.WriteLine($"Adja meg a(z) {i + 1}. jegyet:");
                    grades[i] = int.Parse(Console.ReadLine());
                }

                // Jegyek összegének kiszámítása
                int sum = 0;
                for (int i = 0; i < grades.Length; i++)
                {
                    sum += grades[i];
                }

                // Átlag kiszámítása
                double average = (double)sum / grades.Length;

                // Az eredmény kiírása
                Console.WriteLine("A jegyek átlaga: " + average);
            }
            catch (FormatException ex)
            {
                // Hibakezelés: Rossz formátumú bemenet
                Console.WriteLine("Hiba történt: Nem megfelelő formátumú adatot adott meg. Kérem, számokat adjon meg.");
            }
            catch (Exception ex)
            {
                // Általános hibakezelés
                Console.WriteLine("Hiba történt: " + ex.Message);
            }

            // Program folytatása
            Console.WriteLine("A program befejeződött.");

            /*
             * Magyarázat
             * 
                Felhasználói bemenet kezelése:
                A felhasználót megkérjük, hogy adja meg a jegyek számát. Ezt a numberOfGrades változóban tároljuk.
                Inicializáljuk a grades tömböt a megadott mérettel.
                Egy for ciklussal megkérjük a felhasználót, hogy adja meg a jegyeket, és ezeket az értékeket a grades tömbben tároljuk.

                Hibakezelés:
                A try blokkban elhelyezzük a potenciálisan hibát okozó kódot.
                Ha a felhasználó nem számot ad meg, FormatException keletkezik. Ezt a hibát a catch blokkban kezeljük, 
                és megjelenítünk egy érthető üzenetet a felhasználónak.
                Egy általános catch blokkot is hozzáadunk, hogy minden egyéb hibát kezeljünk.

                Jegyek összegének és átlagának kiszámítása:
                A sum változót inicializáljuk 0-val.
                Egy for ciklussal végigmegyünk a grades tömb minden elemén, és összeadjuk az értékeket.
                Az átlagot úgy számítjuk ki, hogy az sum értékét elosztjuk a grades.Length értékével. Az eredményt kiírjuk a konzolra.
                Program folytatása:

                Miután a hibákat kezeltük és az átlagot kiszámítottuk, a program kiírja, hogy befejeződött.
             */
            Console.ReadKey();
        }
    }
}
