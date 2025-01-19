using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String__Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*C#-ban a szöveges típusok leggyakrabban használt fajtája a string. 
             * Ezen kívül van még a char típus is, ami egyetlen karaktert tárol.
             */

            /*string Típus
            A string típus egy karakterláncot(karakterek sorozatát) tárol.
            A string változókat kettős idézőjelbe("") tesszük.*/

            // String létrehozása
            string greeting = "Hello, World!";
            Console.WriteLine(greeting); // Kimenet: Hello, World!

            // Karakterek száma a stringben
            int length = greeting.Length;
            Console.WriteLine($"A greeting hossza: {length}"); // Kimenet: A greeting hossza: 13

            // String összefűzése
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Teljes név: {fullName}"); // Kimenet: Teljes név: John Doe

            // String formázás
            string formattedString = string.Format("My name is {0} {1}.", firstName, lastName);
            Console.WriteLine(formattedString); // Kimenet: My name is John Doe.

            /*
             Magyarázat:
                string.Format metódus: A string.Format metódus segítségével formázott szövegeket hozhatunk létre. 
                Ez a metódus Placeholdereket ({0}, {1}, stb.) tartalmazó szöveget vesz át, 
                és a placeholderek helyére behelyettesíti a metódus további argumentumaiban megadott értékeket.

                Placeholder:(A placeholder kifejezés egy olyan jelölőt vagy szimbólumot jelent, amely ideiglenesen
                helyet foglal el egy adat vagy érték számára, 
                amelyet később behelyettesítenek. ) A helyőrzők nullától kezdődően indexeltek. 

                A {0} az első argumentumot (itt firstName), a {1} a második argumentumot (itt lastName) helyettesíti be.
                Eredmény: Az eredmény egy új string lesz, ahol a placeholderek a megfelelő értékekkel lettek kicserélve.
                Ebben az esetben a firstName értéke "John", a lastName értéke "Doe", így a végeredmény: "My name is John Doe.".
             
         
             */




            // Interpoláció
            string interpolatedString = $"My name is {firstName} {lastName}.";
            Console.WriteLine(interpolatedString); // Kimenet: My name is John Doe.

            /*
             * Magyarázat:
                String interpoláció: A string interpoláció egy modern és kényelmes módszer a stringek formázására
                C#-ban. Ezt a $ szimbólummal jelezzük a string elején.
                Behelyettesítés: Az interpolált stringben a kapcsos zárójelek {} 
                közé írhatunk változókat vagy kifejezéseket, amelyeket a C# futásidőben behelyettesít
                a megfelelő értékkel.
                Eredmény: A firstName és lastName változók értékei ("John" és "Doe") 
                közvetlenül behelyettesítésre kerülnek a stringbe. A végeredmény: "My name is John Doe.".
             */


            // Részstring kivágása
            string subString = greeting.Substring(7, 5);
            Console.WriteLine($"Kivágott részstring: {subString}"); // Kimenet: Kivágott részstring: World

            /*
             * Magyarázat:
            Substring metódus: A Substring metódus egy string egy részét adja vissza. 
            Az első argumentum az induló index (nullától indexelve), a második argumentum pedig a hossz, 
            hány karaktert kell kivágni.
            Induló index: Az induló index azt jelzi, hogy a string melyik karakterénél kezdjük a kivágást. 
            Itt 7-es indexszel indulunk, ami a "H" karakter utáni első karakter ("W") lesz a "Hello, World!" stringben.
            Hossz: A második argumentum 5, tehát 5 karaktert vágunk ki a 7-es indextől kezdve. 
            Így a kivágott részstring "World" lesz.
            Eredmény: A subString változó értéke "World" lesz.
             */

            // String keresése
            int indexOfWorld = greeting.IndexOf("World");
            Console.WriteLine($"'World' kezdő indexe: {indexOfWorld}"); // Kimenet: 'World' kezdő indexe: 7
            /*
             * Magyarázat:
                IndexOf metódus: Az IndexOf metódus megkeresi az első előfordulási helyét egy adott
                részstringnek a stringben. Ha megtalálja, visszaadja az első karakterének indexét, 
                ha nem, -1-et ad vissza.
                Keresett string: Itt a "World" stringet keressük a greeting stringben ("Hello, World!").
                Eredmény: Mivel a "World" string a greeting string 7-es indexénél kezdődik, 
                az indexOfWorld értéke 7 lesz.
             */


            /*
             * Char Típus
               A char típus egyetlen karakter tárolására szolgál. A char változókat egyszeres idézőjelbe ('') tesszük.
             */

            // Char létrehozása
            char letter = 'A';
            Console.WriteLine($"A betű: {letter}"); // Kimenet: A betű: A

            // Karakter kódjának megszerzése(Az ASCII kód 0 és 127 közötti egész számokból áll, ahol minden szám egy konkrét karaktert jelöl.)
            int asciiCode = (int)letter;
            Console.WriteLine($"A betű ASCII kódja: {asciiCode}"); // Kimenet: A betű ASCII kódja: 65
            /*
             * Itt a letter változót egy int típusú változóba konvertáljuk. 
             * Ez a konverzió úgy történik, hogy az 'A' karakter Unicode (vagy ASCII) kódját kapjuk meg.
                Az (int) kifejezés egy explicit típuskonverzió, amely a letter karaktert annak megfelelő 
                egész számú Unicode kódjává (ASCII kódjává) alakítja.
                Az 'A' karakter Unicode kódja (és ASCII kódja) 65, így a asciiCode változó értéke 65 lesz.
             */

            // Karakter létrehozása ASCII kódból
            char letterFromCode = (char)65;
            Console.WriteLine($"A 65 kódból létrehozott betű: {letterFromCode}"); // Kimenet: A 65 kódból létrehozott betű: A

            // String karaktereinek elérése
            string greetings = "Hello";
            char firstChar = greetings[0];
            Console.WriteLine($"Az első karakter a greeting stringből: {firstChar}"); // Kimenet: Az első karakter a greeting stringből: H

            /*
             * Itt egy char típusú változót firstChar néven hozunk létre.
                A greetings[0] kifejezés a greetings string első karakterét adja vissza. 
                A karakterláncok indexelése nullától kezdődik, így az első karakter indexe 0.
                Ebben az esetben a greetings[0] értéke 'H', mivel ez a "Hello" string első karaktere.
                A firstChar változó értéke tehát 'H' lesz.
             */
            Console.ReadKey();
        }
    }
}
