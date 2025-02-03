using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Whitespace_és_escape_karakterek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Whitespace Karakterek
                A whitespace karakterek olyan karakterek, amelyek nem láthatóak, 
                de helyet foglalnak el a szövegben. Ezek a karakterek közé tartoznak:

                    Szóköz (space):
                    Tabulátor (tab): \t
                    Új sor (newline): \n
                    Kocsi vissza (carriage return): \r
                    Függőleges tabulátor (vertical tab): \v


            Escape Karakterek
            Az escape karakterek speciális karakterek, amelyeket a \ (backslash) előz meg, és amelyek nem nyomtatható vagy különleges karakterek beillesztésére használhatók. Néhány gyakori escape karakter:

                    \\ – Backslash
                    \' – Egyes idézőjel
                    \" – Kettős idézőjel
                    \n – Új sor
                    \r – Kocsi vissza
                    \t – Tabulátor
                    \b – Backspace
                    \f – Form feed
             */
            // Szóköz és tabulátor használata
            string szoveg = "Hello\tvilág";
            Console.WriteLine(szoveg);
            // Output: Hello   világ

            // Új sor és kocsi vissza használata
            string szoveg2 = "Hello\nvilág\rC#";
            Console.WriteLine(szoveg2);
            // Output:
            // Hello
            // C#

            // Kettős idézőjel és egyes idézőjel használata
            string szoveg3 = "Ez egy \"idézet\" és ez egy \'másik idézet\'.";
            Console.WriteLine(szoveg3);
            // Output: Ez egy "idézet" és ez egy 'másik idézet'.

            // Backslash használata
            string szoveg4 = "A fájl útvonala: C:\\Felhasználók\\Nyilvános";
            Console.WriteLine(szoveg4);
            // Output: A fájl útvonala: C:\Felhasználók\Nyilvános

            // Összesített példa minden escape karakterrel
            string szoveg5 = "Szóköz:\t\t|\nÚj sor:\n|\rKocsi vissza:\r|\nTabulátor:\t|\nBackslash: \\|";
            Console.WriteLine(szoveg5);
            // Output:
            // Szóköz:         |
            // Új sor:
            // |
            // Kocsi vissza:|
            // Tabulátor:     |
            // Backslash: \|


            /*
             * Magyarázat
                Szóköz és tabulátor:

                A \t escape karakter egy tabulátort ad a szöveghez, amely több szóköznyi helyet foglal el.
                Új sor és kocsi vissza:

                A \n escape karakter egy új sort kezd.
                A \r escape karakter a kocsi vissza karaktert helyezi be, amely a kurzort a sor elejére viszi vissza.
                Kettős idézőjel és egyes idézőjel:

                A \" escape karakter egy kettős idézőjelet ad a szöveghez.
                A \' escape karakter egy egyes idézőjelet ad a szöveghez.
                Backslash:

                A \\ escape karakter egy backslash karaktert ad a szöveghez.
             */


            //A \r karakter használatának hatását a következő egyszerű példa bemutatja:
            // Sor vége és kocsi vissza használata
            Console.Write("Hello, World!\rHi");
            // Output: Hi, World!


            /*
             * Eredet és Magyarázat
                Eredet: Az "kocsi vissza" kifejezés az írógépek világából származik. 
                Az írógépeken a \r karakter parancsot adott a gépnek arra, hogy a papírt visszavezesse az
                eredeti pozícióba, azaz a sor elejére. Ez a karakter úgy működött, hogy a nyomtatófejet vagy 
                a "kocsit" visszahúzta a sor elejére.

                Számítástechnikai használat: A számítástechnikában a \r karakter használata a kocsi vissza
                (carriage return) funkcióját szimulálja, amely a kurzort a sor elejére helyezi, és így a 
                következő karakterek az aktuális sor elejére íródnak.
             */


            //Példa a \b használatára
            // Szöveg tartalmaz backspace karaktert
            Console.Write("Hello\b World!");
            // Output: Hell World!

            /*
             * Magyarázat:

                A \b karakter a "Hello" szövegben a "o" karaktert visszalép a sorba, 
                majd a " World!" szöveget írja ki, ami felülírja a "o" karaktert.
                Így az "Hello" szóból "Hell" marad, és a " World!" hozzáadódik.
             
             */

               

            Console.ReadKey();

        }
    }
}

