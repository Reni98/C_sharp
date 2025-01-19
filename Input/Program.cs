using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_input_beolvasása_konzolról
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Az inputról olvasás azt jelenti, hogy a program képes adatokat fogadni a felhasználótól futásidőben. 
             C#-ban az input olvasására gyakran használjuk a Console.ReadLine metódust, amely a konzolról beolvasott 
             adatokat sztringként adja vissza. Az ilyen bemeneteket gyakran parse-olni kell, hogy a szükséges típusú változóként
             tudjuk felhasználni őket.
            */


            Console.WriteLine("Please enter your name:");

            // Beolvasás a konzolról
            string name = Console.ReadLine();

            // Kiírás a konzolra
            Console.WriteLine("Hello, " + name + "!");

            /*
             * Magyarázat
                Konzol kimenet: A Console.WriteLine("Please enter your name:"); sor kiír egy üzenetet, 
                amely kéri a felhasználót, hogy adja meg a nevét.
                Beolvasás a konzolról: A string name = Console.ReadLine(); 
                sor beolvassa a felhasználó által megadott nevet, és sztringként tárolja a name változóban.
                Kiírás a konzolra: A Console.WriteLine("Hello, " + name + "!"); sor kiír egy üdvözlő üzenetet a megadott névvel.
             */

            Console.WriteLine("Please enter your age:");

            // Beolvasás a konzolról és parse-olás
            string input = Console.ReadLine();
            int age = int.Parse(input);

            // Az életkor kiírása
            Console.WriteLine("Your age is: " + age);

            /*
             * Magyarázat
            Konzol kimenet: A Console.WriteLine("Please enter your age:");sor kiír egy üzenetet, amely kéri a felhasználót, hogy adja meg az életkorát.
            Beolvasás és parse-olás: A string input = Console.ReadLine();
            sor beolvassa a felhasználó által megadott sztringet. A int age = int.Parse(input);
            sor parse-olja ezt a sztringet és int típusú változóként tárolja.
            Kiírás: A Console.WriteLine("Your age is: " + age); sor kiírja a felhasználó életkorát.
             */
            Console.ReadKey();

        }
    }
}
