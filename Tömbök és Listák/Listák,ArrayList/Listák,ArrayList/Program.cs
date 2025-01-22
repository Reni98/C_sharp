using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listák_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A listák dinamikusan bővíthető adatszerkezetek, amelyek különböznek a fix méretű tömböktől.
             * A C# nyelvben két fő típusú lista létezik, amelyeket használhatunk: ArrayList és List<T>. 
             * Az ArrayList a régebbi típus, míg a List<T> a generikus típus, amely modernebb és típusbiztosabb.
             * 
             * Mi az a Lista?
               A lista egy olyan adatszerkezet, amelyben több elemet tárolhatunk, 
                és amely lehetővé teszi az elemek dinamikus hozzáadását, eltávolítását és módosítását.

            ArrayList: A régebbi típusú lista, amely nem biztosít típusbiztonságot, mivel az elemek object típusúak. 
            Ezért minden elemnek a megfelelő típusra kell konvertálódnia használat előtt.

            List<T>: A generikus lista, ahol T a lista elemeinek típusa. 
            Például List<int> egy egész számokat tartalmazó lista. Ez típusbiztos és általában ajánlott a használata.
             */

            /*
             * ArrayList és List<T> Definiálása és Inicializálása
             * 
                ArrayList
                Az ArrayList az System.Collections névtérben található. 
                Az elemek bármilyen típusúak lehetnek, mivel az ArrayList csak object típusú elemeket tárol.
             

            // ArrayList definiálása és inicializálása
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Hello");
            arrayList.Add(3.14);

            // ArrayList elemeinek kiírása
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            */

            /*
             * List<T>
                A List<T> az System.Collections.Generic névtérben található, és típusbiztos, azaz az elemek típusát a lista deklarációja határozza meg.
            

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // List<T> elemeinek kiírása
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

         */


            /*
             * Elem Módosítása és Bejárás
                ArrayList Elem Módosítása
                Az ArrayList elemeit módosíthatjuk indexelés segítségével.
             */

            // ArrayList definiálása és inicializálása
            ArrayList arrayList = new ArrayList { 1, 2, 3 };

            // Elem módosítása
            arrayList[1] = 20; // A második elem (index 1) értéke most 20

            // ArrayList elemeinek kiírása
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            /*
             * List<T> Elem Módosítása
               A List<T> elemeit indexelés segítségével is módosíthatjuk.
             */

            // List<T> definiálása és inicializálása
            List<int> list = new List<int> { 1, 2, 3 };

            // Elem módosítása
            list[1] = 20; // A második elem (index 1) értéke most 20

            // List<T> elemeinek kiírása
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            /*
             * Iterátorok és Ciklusok Segítségével Történő Bejárás
                ArrayList Bejárása
                Az ArrayList bejárásához használhatunk foreach ciklust.
             */

            // ArrayList bejárása foreach ciklussal
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }


            /*
             * List<T> Bejárása
               A List<T> bejárásához is használhatunk foreach ciklust.
             */

            // List<T> bejárása foreach ciklussal
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

            /*
             * Összefoglalás
                Listák (ArrayList és List<T>): A listák dinamikus adatszerkezetek, amelyek lehetővé teszik az elemek hozzáadását, eltávolítását és módosítását.
                ArrayList: Nem típusbiztos, object típusú elemeket tárol. A régebbi típus.
                List<T>: Típusbiztos, az T típusú elemeket tárol. A modern és ajánlott típus.
                Elemek Módosítása: Az elemeket indexeléssel módosíthatjuk, mind ArrayList, mind List<T> esetén.

                Bejárás: A listák elemei bejárhatók foreach ciklus segítségével, amely egyszerűsíti az elemek kezelését.


            Generikus Lista (List<T>)
            A List<T> egy generikus lista, ahol T a lista elemeinek típusát jelöli. Ez azt jelenti, hogy amikor létrehozunk egy List<T> példányt, 
            meg kell adnunk, hogy a lista milyen típusú elemeket fog tartalmazni.
             */

            /*
             * Gyakorlati Példa: List<int> Használata
             * 
                Hozzunk létre egy List<int>-et, amelyben tárolni fogunk egész számokat.
                Adjuk hozzá a listához néhány számot.
                Módosítsuk egy szám értékét.
                Távolítsunk el egy számot a listából.
                Írjuk ki a lista elemeit a konzolra.


             */

            // 1. List<int> definiálása és inicializálása
            List<int> numbers = new List<int>();

            // 2. Elek hozzáadása a listához
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            Console.WriteLine("Lista elemei hozzáadás után:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // 3. Elem módosítása (pl. a második elem értékének módosítása)
            numbers[1] = 25; // A második elem (index 1) most 25

            Console.WriteLine("\nLista elemei módosítás után:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // 4. Elem eltávolítása (pl. az első elem eltávolítása)
            numbers.Remove(10); // Eltávolítja az első előfordulást a listából

            Console.WriteLine("\nLista elemei eltávolítás után:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // 5. Lista méretének kiírása
            Console.WriteLine("\nLista elemeinek száma: " + numbers.Count);


            /*
             * Magyarázat
                Lista Definiálása és Inicializálása:
                A List<int> típusú numbers nevű lista létrehozása és inicializálása.
                Az Add metódussal egész számokat adunk hozzá a listához.

                Elemek Hozzáadása:
                Az Add metódus segítségével számokat adunk hozzá a listához.

                Elem Módosítása:
                A lista elemeit indexeléssel módosíthatjuk. Itt a numbers[1] = 25 kód módosítja a lista második elemét (index 1) 25-re.

                Elem Eltávolítása:
                Az Remove metódussal eltávolítunk egy elemet a listából. Itt az Remove(10) eltávolítja az első előfordulást a 10 értékű elemnek.

                Lista Elemeinek Kiírása:
                A foreach ciklussal bejárjuk a listát, és kiírjuk a benne lévő elemeket.

                Lista Méretének Kiírása:
                A Count tulajdonsággal lekérdezzük a lista jelenlegi méretét (az elemek számát).

             */


            Console.WriteLine("Műveletek Listával:");
            // Elem keresése
            bool contains30 = numbers.Contains(30);
            Console.WriteLine("Lista tartalmazza a 30-at: " + contains30);

            // Elem indexének megkeresése
            int indexOf40 = numbers.IndexOf(40);
            Console.WriteLine("A 40 indexe: " + indexOf40);

            // Lista rendezése
            numbers.Sort();
            Console.WriteLine("Rendezett lista:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Lista szűrése
            List<int> greaterThan20 = numbers.FindAll(x => x > 20);
            Console.WriteLine("Elemek nagyobbak mint 20:");
            foreach (int number in greaterThan20)
            {
                Console.WriteLine(number);
            }

            // Elem eltávolítása
            numbers.Remove(30);
            Console.WriteLine("Lista eltávolítás után:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Lista kiürítése
            numbers.Clear();
            Console.WriteLine("Lista kiürítése után, méret: " + numbers.Count);
        
        Console.ReadKey();
        }
    }
}
