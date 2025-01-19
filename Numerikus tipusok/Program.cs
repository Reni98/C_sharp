using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numerikus_típusok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * A C# programozási nyelvben a numerikus típusok azok az adattípusok, amelyek számértékeket tárolnak 
             * és különböző matematikai műveletek elvégzésére használhatók. A numerikus típusok kategóriákra oszthatók,
             * például egész számok (integer) és tört számok (floating-point). Ezeket a típusokat gyakran használjuk 
             * számítások során, mint például aritmetikai műveletek, statisztikai elemzések, és pénzügyi számítások.
             */

            /*1.Integer Típusú Primitívek
            1.1. byte(8 - bit unsigned integer)

            Tartomány: 0 és 255 között.
            Használat: Általában akkor használjuk, ha biztosak vagyunk benne, hogy az érték mindig 0 és 255 között lesz,
            például színkomponensek tárolásakor.*/
            byte ageInMonths = 24; // Számok, amik 0 és 255 között mozognak
            Console.WriteLine(ageInMonths); // Kimenet: 24

            /*
             1.2. short (16-bit signed integer)
            Tartomány: -32,768 és 32,767 között.
            Használat: Olyan esetekben használható, amikor az értékek elérhetik ezt a tartományt,
            és a memóriahatékonyság fontos.*/
            short temperature = -10; // Számok, amik -32,768 és 32,767 között mozognak
            Console.WriteLine(temperature); // Kimenet: -10

            /*
             * 1.3. int (32-bit signed integer)
                Tartomány: -2,147,483,648 és 2,147,483,647 között.
                Használat: A leggyakrabban használt típus egész számok tárolására, 
               amikor nagyobb tartományra van szükség.
             */

            int population = 1500000; // Számok, amik -2,147,483,648 és 2,147,483,647 között mozognak
            Console.WriteLine(population); // Kimenet: 1500000

            /*
             * 1.4. long (64-bit signed integer)           
            Tartomány: -9,223,372,036,854,775,808 és 9,223,372,036,854,775,807 között.
            Használat: Olyan esetekben használatos, amikor az értékek extrém nagy tartományra van szükség, 
            például nagy adatbázisok vagy tudományos számítások esetén.
             */

            long distanceToSun = 149597870700L; // Nagy számok tárolása
            Console.WriteLine(distanceToSun); // Kimenet: 149597870700

            /*
            2.Lebegőpontos Típusok
            2.1. float(32 - bit floating - point)

            Tartomány: Körülbelül ±1.5 x 10 ^−45 to ±3.4 x 10 ^ 38.
            Használat: Ha a memória hatékonyság fontos, és nem szükséges a nagy pontosság, 
            használhatjuk például grafikai számításokhoz vagy közelítő értékekhez.*/

            float pi = 3.14F; // Lebegőpontos számok, ahol a pontosság nem kritikus
            Console.WriteLine(pi); // Kimenet: 3.14


            /*2.2. double(64 - bit floating - point)

            Tartomány: Körülbelül ±5.0 x 10 ^−324 to ±1.7 x 10 ^ 308.
            Használat: Ha nagyobb pontosságra van szükség a számítások során, például tudományos számításokhoz 
            vagy pénzügyi alkalmazásokhoz.*/
            double distanceToMoon = 384400000.0; // Nagyobb pontosságú lebegőpontos számok
            Console.WriteLine(distanceToMoon); // Kimenet: 384400000


            /*
             Különbségek és Használat
                Tartomány: A különböző típusok különböző tartományokat kínálnak. 
            Például, ha a számok mindig kis tartományban vannak, használhatunk byte-ot vagy short-ot a 
            memória takarékosság érdekében, míg nagyobb számokhoz int vagy long szükséges.

            Pontosság: Az egész szám típusok (byte, short, int, long) pontosan tárolják az értékeket,
            míg a lebegőpontos típusok (float, double) közelítő értékeket adnak vissza, ami a pontosság 
            és a memória igénye között egyensúlyt teremt.

            Memória Használat: A kisebb típusok, mint a byte és short, kevesebb memóriát használnak, 
            míg a nagyobb típusok, mint a long és double, több memóriát igényelnek.
             */

            Console.ReadKey();
        }
    }
}
