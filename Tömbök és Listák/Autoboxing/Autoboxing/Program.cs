using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autoboxing
{
    
    internal class Program
    {
        static void DisplayValue(object value)
        {
            Console.WriteLine("Érték: " + value);
        }
        static void Main(string[] args)
        {
            /*
             * Az autoboxing és unboxing olyan koncepciók, amelyeket a C# és más .NET nyelvek használnak, 
             * hogy lehetővé tegyék az alapvető típusok (például int, char, double) és a referenciaként kezelt típusok (például object) közötti átalakítást.
             */

            /*
             * Mi az az Autoboxing?
               Autoboxing az a folyamat, amelyben egy alapvető típusú (érték típusú) változót automatikusan konvertál egy referenciatípusú object típusra. 
                Ez akkor történik, amikor egy alapvető típusú változót egy object típusú változóba helyezünk.

                Mi az az Unboxing?
                Unboxing az a folyamat, amikor egy object típusú változót visszakonvertálunk az eredeti alapvető típusra.

                Példa Autoboxing és Unboxing
                Nézzük meg egy példán keresztül, hogyan történik az autoboxing és az unboxing a C# nyelvben.
             */

            // Autoboxing példa
            int number = 123;         // 'number' egy érték típusú változó
            object obj = number;      // Az 'obj' változóba való átkonvertálás (autoboxing)

            // 'obj' most már egy 'object' típusú változó, amely az 'int' értéket tartalmazza
            Console.WriteLine("Autoboxing:");
            Console.WriteLine("obj értéke: " + obj);

            // Unboxing példa
            int unboxedNumber = (int)obj;  // Az 'obj' visszakonvertálása 'int' típusra (unboxing)

            Console.WriteLine("Unboxing:");
            Console.WriteLine("unboxedNumber értéke: " + unboxedNumber);

            /*
             * Magyarázat
                Autoboxing:

                A number változó egy int típusú változó, amely egy érték típus.
                Amikor az int változót (number) egy object típusú változóba (obj) helyezzük, az automatikusan átkonvertálódik egy object típusú referenciává.
                Ezt az automatikus konverziót autoboxingnak nevezzük.

                Unboxing:

                Az obj változó most már egy object típusú referenciát tartalmaz, amely az int értéket tárolja.
                Az unboxing folyamat során az obj változót visszakonvertáljuk int típusú változóvá (unboxedNumber). 
                Ehhez explicit típuskonverzió szükséges, ami azt jelenti, hogy a fordító tudja, hogy az obj ténylegesen egy int típusú értéket tartalmaz.
             */

            // Autoboxing: Érték típusú változó konvertálása referenciává
            double pi = 3.14159;          // 'pi' egy double érték típusú változó
            object objPi = pi;            // 'pi' autoboxolása az 'objPi' referenciába

            Console.WriteLine("Autoboxing:");
            Console.WriteLine("objPi értéke: " + objPi);

            // Unboxing: Referencia típusú változó visszakonvertálása érték típusúvá
            try
            {
                double unboxedPi = (double)objPi; // Unboxing: Visszakonvertáljuk 'objPi' 'double' típusra
                Console.WriteLine("Unboxing:");
                Console.WriteLine("unboxedPi értéke: " + unboxedPi);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Hiba történt az unboxing során: " + ex.Message);
            }

            // Az unboxing hibát okozhat, ha nem a megfelelő típusra próbáljuk konvertálni
            object objString = "Hello"; // 'objString' egy string típusú object
            try
            {
                int wrongUnboxing = (int)objString; // Ezen próbálkozás hibát fog okozni
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Hiba történt a helytelen unboxing során: " + ex.Message);
            }

            /*
             * Magyarázat
             * 
                Autoboxing:
                A pi változót, amely egy double típusú érték, automatikusan átkonvertáljuk object típusúra az objPi változóban.

                Unboxing:
                Az objPi változó, amely object típusú, visszakonvertálásra kerül double típusúra az unboxedPi változóban.
                Az unboxing folyamat során biztosítani kell, hogy az object változó valóban az eredeti típusú értéket tartalmazza,
                különben InvalidCastException kivételt okoz.

                Hibakezelés:

                Az utolsó részben bemutatott hibakezelés megmutatja, hogy az unboxing hibát okozhat, 
                ha az object változó nem a megfelelő típusú értéket tartalmaz. Ilyen esetekben a InvalidCastException kivételt kapunk, amit kezelhetünk try-catch blokkban.
                
                Összefoglalás
                Autoboxing: Az alapvető típusok automatikus konvertálása object típusú referenciává.
                Unboxing: Az object típusú referenciák visszakonvertálása az eredeti alapvető típusra.
                Az autoboxing automatikusan történik a C# nyelvben, de az unboxing explicit konverziót igényel. 
                A helytelen unboxing kivételt okozhat, ezért fontos a megfelelő típusellenőrzés.
             */

            //Mire hasznájuk a gyakorlatban?
            /*
             * 1. Általános Adatkezelés és Kompatibilitás
                Autoboxing és unboxing lehetővé teszi, hogy az alapvető típusokat (mint int, double, char) object típusú változókba tároljuk. 
                Ez különösen hasznos lehet az olyan helyzetekben, ahol az adatok különböző típusait kell kezelni egy egységes adatstruktúrában, például:

                Kollektív Adatstruktúrák: Az ArrayList osztály (a generikus List<T> helyett) például csak object típusú elemeket tud tárolni. 
                Ezért ha érték típusú adatokat kell tárolnunk benne, azok automatikusan autoboxolódnak.
             */

            ArrayList list = new ArrayList();
            int numbers = 123; // Érték típus
            list.Add(numbers); // Autoboxing történik itt

            // Az elemet ki lehet olvasni objectként, és unboxolni
            int retrievedNumber = (int)list[0]; // Unboxing történik itt

            Console.WriteLine("Az elem értéke: " + retrievedNumber);

            /*
             * Általános Programozási Minták
                Polimorfizmus: Ha egy metodus olyan adatot vár, amely lehet bármilyen típusú érték, használhatjuk az object típust. 
                A metódus belsejében autoboxing történik, amikor alapvető típusokat kell tárolni az object típusú paraméterekben.
             */

            int intValue = 42;
            double doubleValue = 3.14;

            DisplayValue(intValue); // Autoboxing
            DisplayValue(doubleValue); // Autoboxing

            /*
             * 3. Kód Kompatibilitás
                Az autoboxing és unboxing lehetővé teszi, hogy a régebbi kódok, amelyek nem használják a generikus adatstruktúrákat, 
                még mindig működjenek újabb környezetekben. Például:

                Régi Adatstruktúrák: Ha egy régi könyvtárat vagy API-t használunk, amely nem támogatja a generikus típusokat, autoboxingot 
                és unboxingot alkalmazhatunk az érték típusok és referenciatípusok közötti interoperabilitás érdekében.


                4. Kézi Adatkonverzió
                A Dictionary és más generikus gyűjtemények használata esetén néha szükség lehet arra, hogy az alapvető típusokat object típusú
                értékekké konvertáljuk. Ez akkor hasznos, amikor olyan adatstruktúrákat használunk, amelyek nem generikusak.

                Példa Generikus Kollektív Adatstruktúrákra
                A generikus kollekciók, mint a List<T>, a Dictionary<TKey, TValue> és a HashSet<T>, 
                elkerülik az autoboxingot és unboxingot, mert közvetlenül kezelik az alapvető típusokat is.

                 List<int> numbers = new List<int>();
                 numbers.Add(10); // Nincs autoboxing

        // Lista bejárása
        foreach (int number in numbers)
        {
            Console.WriteLine("Szám: " + number);
        }
             */

            /*
             * Előnyök
            Teljesítmény: Az autoboxing és unboxing hozzáad egy extra költséget az adatok kezelése során. 
            Generikus típusok használatával elkerülhetjük ezt a költséget.
            Kód Könnyebbség: Könnyebb kezelni különböző típusú adatokat egységes típusú adatstruktúrákban (például object típusú listák), 
            ha az autoboxing és unboxing be van építve.

            Hátrányok
            Teljesítmény: Az autoboxing és unboxing extra memória- és teljesítményköltségeket vonhat maga után, 
            különösen akkor, ha nagy mennyiségű adatot kezelünk.

            Típusbiztonság: Az alapvető típusok és object típus közötti konverziók veszélyeztethetik a típusbiztonságot,
            és futási időben hibákat okozhatnak, ha az unboxing nem megfelelően történik.

            Összefoglalás
            Az autoboxing és unboxing hasznos eszközök a C# nyelvben, amelyek lehetővé teszik az alapvető típusok és az object típus közötti átkonvertálást.
            Ezek a technikák segíthetnek az adatkezelés rugalmasságában, azonban fontos tudni, hogy ezek milyen költségekkel járhatnak, 
            és hogy a generikus típusokkal ezeket a költségeket minimalizálhatjuk.
             */

            Console.ReadKey();
        }
    }
}
