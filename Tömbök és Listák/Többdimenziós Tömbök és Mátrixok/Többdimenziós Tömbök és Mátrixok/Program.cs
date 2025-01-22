using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Többdimenziós_Tömbök_és_Mátrixok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  többdimenziós tömbök, más néven mátrixok, egy olyan adatszerkezetek, amelyek több dimenzióban tárolnak adatokat. 
             *  Ezek hasznosak lehetnek különböző matematikai, statisztikai és vizuális feladatokhoz. 
             *  
             *  Többdimenziós Tömbök és Mátrixok
                Mi az a Többdimenziós Tömb?
                A többszörös dimenziójú tömbök olyan adatszerkezetek, ahol az elemek nem csak egy dimenzióban vannak elrendezve, hanem több dimenzióban is. 
                A leggyakoribb többdimenziós tömb a mátrix, ami egy két dimenziós tömb.

                Mátrix Definíció
                Mátrix: Egy m x n méretű mátrix egy olyan táblázat, amely m sorból és n oszlopból áll.
                Az elemeket általában sorok és oszlopok alapján indexeljük.

                Mátrix Kezelése
                A mátrixok kezelése során fontos, hogy tudjuk, hogyan definiálhatunk, inicializálhatunk és bejárhatunk egy mátrixot.
             */

            /*
             * Mátrix Definiálása és Inicializálása
             * int[,] matrix = new int[3, 4];
             * Ez egy 3 x 4 méretű mátrixot jelent, ahol 3 sor és 4 oszlop van.
             */

            /*
             * Mátrix Inicializálása Értékekkel
               A mátrixot közvetlenül is inicializálhatjuk értékekkel:
                int[,] matrix = 
                    {
                        { 1, 2, 3, 4 },
                        { 5, 6, 7, 8 },
                        { 9, 10, 11, 12 }
                    };

             */

            /*
             * Mátrix Elemének Hozzáférés
               Az egyes elemeket sor- és oszlopindexek segítségével érhetjük el:
                 int value = matrix[1, 2]; // A 2. sor 3. oszlopa (6)

             */

            /*
             * Gyakorlati Példa: Mátrix Összegzése
                Most nézzünk meg egy egyszerű példát, ahol egy 3 x 3 mátrixot inicializálunk, és kiszámítjuk a mátrix elemeinek összegét.
             */

            // Mátrix definiálása és inicializálása
            int[,] matrix =
            {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            // Mátrix elemeinek kiírása
            Console.WriteLine("A mátrix elemei:");
            for (int i = 0; i < matrix.GetLength(0); i++) // Sorok
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Oszlopok
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine(); // Sorok között üres sor
            }

            // Mátrix összegének kiszámítása
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++) // Sorok
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // Oszlopok
                {
                    sum += matrix[i, j];
                }
            }

            // Összeg kiírása
            Console.WriteLine("A mátrix elemeinek összege: " + sum);


            /*
             * Magyarázat
                Mátrix Definiálása és Inicializálása:
                A matrix nevű kétdimenziós tömböt inicializáljuk egy 3 x 3 mátrix értékeivel.

                Mátrix Elemeinek Kiírása:
                A for ciklusok segítségével bejárjuk a mátrix sorait és oszlopait, és kiírjuk az értékeket a konzolra.
                matrix.GetLength(0) adja meg a sorok számát, míg matrix.GetLength(1) adja meg az oszlopok számát.

                Mátrix Összegének Kiszámítása:
                Egy új for ciklust használunk az összes elem összegzésére.
                Az összegzés után a sum változót kiírjuk a konzolra.
             */
            Console.ReadKey();
        }
    }
}
