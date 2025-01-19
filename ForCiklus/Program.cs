using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCiklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * For ciklus alapja C#-ban
            A for ciklus segítségével olyan műveleteket végezhetünk el, amelyeket többször meg kell ismételni. 
            A ciklus három fő részből áll: az inicializálásból, a feltételből és az iterálásból.
             */

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            /*
             * Magyarázat:

                int i = 0: A ciklusváltozó i értékét 0-ra állítjuk be.
                i < 10: A ciklus akkor fut, amíg i kisebb, mint 10.
                i++: A ciklus minden iterációja után növeljük i értékét 1-tel.
                A fenti kód kiírja a számokat 0-tól 9-ig.
             */

            /* Páros számok kiírása*/

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i);
            }

            /*Revertered (fordított) ciklus*/

            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            /*
             * A for ciklus hasznos eszköz a kódok ismételt végrehajtására. 
             * Általában akkor használjuk, amikor pontosan tudjuk, hányszor kell egy műveletet végrehajtani, 
             * például tömbök, listák vagy sorozatok kezelésére.
             */
            Console.ReadKey();
        }
    }
}
