using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace While_and_Do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * While és Do-While ciklusok 
             * A while és do-while ciklusok olyan vezérlési szerkezetek, amelyek lehetővé teszik, hogy egy kódrészletet addig ismételj, amíg egy feltétel igaz. 
             * Ezek különböznek a for ciklustól abban, hogy inkább akkor használjuk őket, ha nem tudjuk előre, hogy hányszor kell végrehajtani a ciklust.

            1. A while ciklus
                A while ciklus az ismétlés előtt ellenőrzi a feltételt, és csak akkor hajtja végre a ciklusmagot, ha a feltétel igaz.

                Szintaxis:

                while (feltétel)
                  {
                    // Kód, ami ismétlődik, ha a feltétel igaz
                   }   
   

                Példa:
             Addig kérünk be számokat a felhasználótól, amíg nullát nem ír be:
             */

            Console.WriteLine("Írj be számokat! A ciklus nullával ér véget.");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                Console.WriteLine($"A beírt szám: {number}");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("A ciklus véget ért.");



            /*
             * 2. A do-while ciklus
            A do-while ciklus legalább egyszer végrehajtja a ciklusmagot, mivel a feltételt csak az ismétlés után ellenőrzi.

            Szintaxis:
            do
               {
                // Kód, ami legalább egyszer végrehajtódik
                }while (feltétel);

             Példa:
            A program legalább egyszer bekéri a felhasználó nevét, még akkor is, ha az első próbálkozás sikertelen:
             */

            string name;

            do
            {
                Console.Write("Írd be a neved (legalább 3 karakter): ");
                name = Console.ReadLine();
            } while (name.Length < 3);

            Console.WriteLine($"Üdv, {name}!");


            /*
             * 3. Fő különbségek a while és a do-while között
                Tulajdonság	            while	                                    do-while
                Feltétel ellenőrzése	Az ismétlés előtt	                        Az ismétlés után
                Legalább egyszer fut?	Nem garantált	                            Legalább egyszer végrehajtódik
                Használat	            Ha a feltétel már kezdetben hamis	        Ha a ciklust legalább egyszer végre kell hajtani

             */

            Console.ReadKey();
        }
    }
}
