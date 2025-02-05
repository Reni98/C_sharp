using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Típukonverzió
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Típuskonverzió C#-ban
             * A C#-ban az "automatic promotion" fogalom alatt általában az implicit típuskonverziót értjük.
                C#-ban kétféle típuskonverzió létezik:

                    Implicit Konverzió
                    Explicit Konverzió

                1. Implicit Konverzió
                Az implicit konverzió akkor történik, amikor egy típus automatikusan konvertálható 
                egy másik típusra anélkül, hogy explicit módon megadnánk a konverziót. 
                Például a kisebb típusok (mint például int) automatikusan konvertálhatók nagyobb 
                típusokra (mint például double).

                Példa:
             */
            int a = 10;
            double b = a; // Az int automatikusan konvertálódik double típusra
            Console.WriteLine(b); // 10.0

            //Ebben az esetben az int típusú változó (a) automatikusan konvertálódik a double típusra (b).

            // Ellenőrizzük a b változó típusát
            if (b.GetType() == typeof(double))
            {
                Console.WriteLine("b változó típusa double.");
            }
            else
            {
                Console.WriteLine("b változó típusa nem double.");
            }

            /*
             * A b.GetType() metódus visszaadja a b változó típusát, és a typeof(double) kifejezés az double 
             * típusú objektumot reprezentálja. Ezeket összehasonlítva tudhatjuk meg, hogy a változó valóban double-e.
             */

            //float és double konverzió
            /*
             A C# nyelvben a tizedes törteket alapértelmezés szerint double típusúként kezeli, 
            ami egy 64 bites lebegőpontos szám. A float viszont egy 32 bites lebegőpontos szám.
            Amikor egy float változót szeretnénk inicializálni egy tizedes tört értékkel, 
            az f vagy F suffix hozzáadásával jelezzük a fordítónak, hogy a szám float típusú legyen.
             */
            float myFloat = 3.14f; // float típusú változó
            double myDouble = myFloat; // implicit konverzió double típusra

            Console.WriteLine("Float value: " + myFloat);
            Console.WriteLine("Double value: " + myDouble);

            //Ebben a példában a float típusú myFloat változót automatikusan konvertáljuk double típusúvá,
            //mivel a double nagyobb és pontosabb, mint a float.

            /*Amikor 3.14-et próbálunk egy float változóba tenni, fordítói hibát kapunk, 
             * mert a 3.14 alapértelmezés szerint double típusú, és a double típusú értéket nem
             * lehet implicit módon float-ra konvertálni adatvesztés nélkül.

            A float és double összehasonlítása:
            float: 32 bites lebegőpontos szám, kevesebb precizitással és kisebb hatókörrel.
            double: 64 bites lebegőpontos szám, nagyobb precizitással és nagyobb hatókörrel.
            Az f suffix nélkül a fordító feltételezi, hogy a szám double típusú, 
            ezért explicit módon jelezni kell, hogy float típust szeretnénk.*/


            /*
             * 2. Explicit Konverzió
                Az explicit konverzió akkor szükséges, amikor egy típus nem konvertálható 
                automatikusan egy másik típusra, és a programozónak kifejezetten jeleznie kell, 
                hogy a konverziót végrehajtja. Az explicit konverzió általában akkor szükséges, 
                amikor egy nagyobb típusú értéket szeretnénk kisebb típusú értékre konvertálni, 
                ami adatvesztéssel járhat.

                Példa:
             */

            double x = 10.5;
            int y = (int)x; // Explicit konverzió double-ről int-re
            Console.WriteLine(y); // 10

            /*
             * Itt a double típusú x változó értéke (int) kifejezés által int típusúvá konvertálódik.
             * Mivel az int típus nem tudja kezelni a double típusú törtrészeket, az érték 10-re kerekítődött.
             */

            int myInt = 100;       // int típusú változó
            long myLong = myInt;   // implicit konverzió long típusra
            float Floats = myInt; // implicit konverzió float típusra
            double Doubles = myInt; // implicit konverzió double típusra

            Console.WriteLine("Integer value: " + myInt);
            Console.WriteLine("Long value: " + myLong);
            Console.WriteLine("Float value: " + Floats);
            Console.WriteLine("Double value: " + Doubles);




            double mDouble = 123.45; // double típusú változó
            int mInt = (int)mDouble; // explicit konverzió int típusra

            long mLong = 9876543210; // long típusú változó
            int myIntFromLong = (int)mLong; // explicit konverzió int típusra

            Console.WriteLine("Double value: " + myDouble);
            Console.WriteLine("Integer value after casting from double: " + mInt);
            Console.WriteLine("Long value: " + myLong);
            Console.WriteLine("Integer value after casting from long: " + myIntFromLong);

            /*
             * Magyarázat
                double to int: A double lebegőpontos szám tizedes értékekkel, míg az int egész szám.
                Az explicit konverzió során a tizedes érték elveszik, így a 123.45 123 lesz.
                 long to int: A long 64 bites egész szám, míg az int 32 bites. Ha a long értéke nagyobb, 
                mint amit az int képes tárolni, akkor adatvesztés történik. Ebben az esetben a 9876543210 átkonvertálása -539222987 
                értéket ad (túlcsordulás miatt).

            Összefoglalva
            A számérték-konverziók során fontos figyelembe venni, hogy melyik típus konvertálódik melyikbe,
            és hogy ez az átalakítás biztonságos-e. Az implicit konverziók automatikusan történnek, ha biztonságosak,
            míg az explicit konverziókat manuálisan kell végezni, és figyelni kell az esetleges adatvesztésre vagy túlcsordulásra.
             
             */

            /*
             * Egyéb típuskonverziós példák
                Convert Osztály
                A C# Convert osztályának metódusai segíthetnek a típusok közötti konverziók végrehajtásában.
                Példa:
             */

            string str = "123";
            int number = Convert.ToInt32(str); // String konvertálása int típusra
            Console.WriteLine(number); // 123

            /*
             * Parse és TryParse Metódusok
               A Parse és TryParse metódusok a konvertálást szöveges formátumról a
                megfelelő típusra teszik lehetővé.
                Példa Parse:
             */
            string str2 = "456";
            int number2 = int.Parse(str2); // String konvertálása int típusra
            Console.WriteLine(number2); // 456

            /*
             * Példa TryParse:
             */
            string str3 = "789";
            if (int.TryParse(str3, out int result))
            {
                Console.WriteLine(result); // 789
            }
            else
            {
                Console.WriteLine("A konverzió nem sikerült.");
            }

            /*A TryParse metódus biztonságosabb, mivel nem dob kivételt, ha a konverzió nem sikerül, 
             * hanem false - ot ad vissza.*/
            Parse:

            A Parse metódus a sztringet egész számra konvertálja, és ha a bemeneti sztring nem konvertálható (például nem érvényes szám), akkor kivételt dob, konkrétan egy FormatException-t.
                Ha a sztring nem szám, pl. "abc", akkor hibát kapunk:
                string s = "abc";
                int result = int.Parse(s);  // Hiba: FormatException

            ToInt32:

            A ToInt32 metódus az objektum típusának a konvertálására szolgál, és általában a Convert osztály részeként használják.
            Ha a konvertálás nem lehetséges, akkor InvalidCastException-t dob.
                object obj = "abc";
                int result = Convert.ToInt32(obj);  // Hiba: FormatException

            TryParse:

            A TryParse egy sokkal biztonságosabb megoldás, mert nem dob kivételt, hanem egy bool értékkel jelzi, hogy sikerült-e a konvertálás.
            Ha a konvertálás sikeres, akkor az eredményt egy kimeneti változóban kapjuk, különben a kimeneti változó 0 lesz, és a metódus false értéket ad vissza.
                Ha a sztring nem szám, például "abc", akkor nem dob hibát, hanem a kimeneti változó 0 lesz, és false-t ad vissza:
                string s = "abc";
                if (int.TryParse(s, out int result)) {
                Console.WriteLine(result);  // Nem kerül végrehajtásra
                } else {
                    Console.WriteLine("Hiba a konvertáláskor.");  // Kiírás: Hiba a konvertáláskor.
                        }



            Parse dob kivételt, ha a konvertálás nem lehetséges.                
            ToInt32 a Convert osztály használatával konvertál, és hasonlóan dob kivételt, ha nem sikerül a konvertálás.
            TryParse nem dob kivételt, hanem logikai értékkel és a kimeneti változóval jelzi, hogy sikerült-e a konvertálás.
            A TryParse a legbiztonságosabb megoldás, mivel elkerüli a kivételek kezelését.

            Console.ReadKey();

        }
    }
}
