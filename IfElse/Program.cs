using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Alapvető if példa
            Console.WriteLine("Kérlek, adj meg egy számot:");
            int szam = Convert.ToInt32(Console.ReadLine());

            if (szam > 0)
            {
                Console.WriteLine("A megadott szám pozitív.");
            }

            // 2. If-else szerkezet
            if (szam % 2 == 0)
            {
                Console.WriteLine("A szám páros.");
            }
            else
            {
                Console.WriteLine("A szám páratlan.");
            }

            // 3. If-else if-else szerkezet
            if (szam < 0)
            {
                Console.WriteLine("A megadott szám negatív.");
            }
            else if (szam == 0)
            {
                Console.WriteLine("A megadott szám nulla.");
            }
            else
            {
                Console.WriteLine("A megadott szám pozitív.");
            }

            // 4. Egymásba ágyazott if
            Console.WriteLine("Adj meg egy másik számot:");
            int masikSzam = Convert.ToInt32(Console.ReadLine());

            if (masikSzam > 0)
            {
                if (masikSzam % 5 == 0)
                {
                    Console.WriteLine("A szám pozitív és osztható 5-tel.");
                }
                else
                {
                    Console.WriteLine("A szám pozitív, de nem osztható 5-tel.");
                }
            }
            else
            {
                Console.WriteLine("A szám nem pozitív.");
            }
        }
    }
}
