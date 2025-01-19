using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringkezelési_alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1. String létrehozása
                Egy stringet idézőjelek ("") közé zárva hozhatunk létre.*/

            //string string1 = "Hello, világ!";
            //string string2 = "Hello, C#!";


            /*2.String összefűzése
            Két vagy több string összefűzése(konkatenáció) a + operátorral vagy az String.Concat() metódussal történik.*/
            string string1 = "Hello";
            string string2 = "világ";
            string összefűzött_string = string1 + ", " + string2 + "!";
            Console.WriteLine(összefűzött_string);
            // Output: Hello, világ!
            string összefűzött_string2 = String.Concat(string1,",", string2);
            Console.WriteLine(összefűzött_string2);

            /*
             * 3. String hossza
                A string hosszát a Length property-vel kaphatjuk meg.
             */
            string str = "Hello, világ!";
            int hossz = str.Length;
            Console.WriteLine(hossz);
            // Output: 13

            /*4.Indexelés és szeletelés
            A stringekben karaktereket indexeléssel érhetünk el. Az indexelés 0 - tól kezdődik.*/

            string str2 = "Hello, világ!";
            char első_karakter = str2[0];
            Console.WriteLine(első_karakter);
            // Output: H

            char utolsó_karakter = str2[str2.Length - 1];
            Console.WriteLine(utolsó_karakter);
            // Output: !

            string szelet = str2.Substring(0, 5);
            Console.WriteLine(szelet);
            // Output: Hello

            /*
             * 5. String metódusok
                A C# is számos beépített metódust kínál a stringek manipulálására.
                ToUpper(): A string összes karakterét nagybetűssé alakítja.
                ToLower(): A string összes karakterét kisbetűssé alakítja.
                Replace(oldValue, newValue): Lecserél egy részstringet egy másikra.
                Split(delimiter): A stringet egy adott határoló mentén több részre bontja.
             * 
             */

            string str3 = "Hello, Világ!";

            // Nagybetűssé alakítás
            string nagybetűs = str3.ToUpper();
            Console.WriteLine(nagybetűs);
            // Output: HELLO, VILÁG!

            // Kisbetűssé alakítás
            string kisbetűs = str3.ToLower();
            Console.WriteLine(kisbetűs);
            // Output: hello, világ!

            // Csere
            string csere = str3.Replace("Világ", "C#");
            Console.WriteLine(csere);
            // Output: Hello, C#!

            
            Console.ReadKey();

        }
    }
}
