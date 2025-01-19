using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritmetikai__és_matematikai_műveletek__zárójelezés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Az aritmetikai és matematikai műveletek a számokkal végzett alapvető műveletek, 
             *  amelyeket gyakran használunk a programozás során. A C# nyelvben ezek az operátorok egyszerűen 
             *  alkalmazhatók a számokkal végzett különféle számításokra.
             */

            /*Aritmetikai Műveletek C#-ban
            1.Összeadás(+)*/
            int ab = 10;
            int b = 5;
            int sum = ab + b;
            Console.WriteLine("Összeg: " + sum); // Kimenet: Összeg: 15

            //2.Kivonás(-)
            int x = 20;
            int y = 8;
            int difference = x - y;
            Console.WriteLine("Különbség: " + difference); // Kimenet: Különbség: 12

            //3.Szorzás(*)
            int p = 7;
            int q = 3;
            int product = p * q;
            Console.WriteLine("Szorzat: " + product); // Kimenet: Szorzat: 21

            //4. Osztás (/)
            //Az osztás művelete két szám hányadosát számolja ki.
            int m = 15;
            int n = 4;
            int quotient = m / n;
            Console.WriteLine("Hányados: " + quotient); // Kimenet: Hányados: 3

            //5.Maradékos Osztás(%)
            //A maradékos osztás művelete két szám hányadosának maradékát adja meg.
            int r = 29;
            int s = 5;
            int remainder = r % s;
            Console.WriteLine("Maradék: " + remainder); // Kimenet: Maradék: 4

            //Matematikai műveletek C#-ban
            /*1.Math.Abs(int value)
            Leírás: Az abszolút érték visszaadása. Az abszolút érték mindig pozitív vagy nulla.
            Példa:*/
            int a = -10;
            int absValue = Math.Abs(a);  // absValue = 10
            Console.WriteLine(absValue);


            /*2.Math.Acos(double val)
            Leírás: Az inverz koszinusz(arkoszinusz) számítása.A visszatérési érték radiánban van.
            Példa:*/
            double angleInRadians = Math.Acos(0.5);  // angleInRadians ≈ 1.0472 rad (60 fok)
            Console.WriteLine(angleInRadians);


            /*3.Math.Asin(double val)
            Leírás: Az inverz szinusz(arkszinusz) számítása.A visszatérési érték radiánban van.
            Példa:*/
            double angleInRadians2 = Math.Asin(0.5);  // angleInRadians ≈ 0.5236 rad (30 fok)
            Console.WriteLine(angleInRadians2);

            /*
             * 4. Math.Atan(double val)
               Leírás: Az inverz tangens (arktangens) számítása. A visszatérési érték radiánban van.
               Példa:
             */
            double angleInRadians3 = Math.Atan(1);  // angleInRadians ≈ 0.7854 rad (45 fok)
            Console.WriteLine(angleInRadians3);

            /*5.Math.Ceiling(decimal val) és Math.Ceiling(double val)
             Leírás: A szám felfelé kerekítése a legközelebbi egész számra.
             Példa:
            */
            double value1 = 7.001;
            double ceilingValue1 = Math.Ceiling(value1);  // ceilingValue1 = 8
            Console.WriteLine(ceilingValue1);

            double value2 = -7.001;
            double ceilingValue2 = Math.Ceiling(value2);  // ceilingValue2 = -7
            Console.WriteLine(ceilingValue2);


            /*6.Math.Cos(double val)
            Leírás: A koszinusz számítása.A paraméter szög radiánban van.
            Példa:
            */

            double cosValue = Math.Cos(Math.PI / 3);  // cosValue = 0.5 (60 fok)
            Console.WriteLine(cosValue);

            /*
             * 7. Math.Exp(double val)
                Leírás: Az Euler szám (e) kitevőre emelése.
                Példa:
             */

            double expValue = Math.Exp(1);  // expValue ≈ 2.7183 (e^1)
            Console.WriteLine(expValue);

            /*8.Math.Floor(decimal val) és Math.Floor(double val)
            Leírás: A szám lefelé kerekítése a legközelebbi egész számra.
            Példa:*/
            double value11 = 7.9;
            double floorValue1 = Math.Floor(value11);  // floorValue1 = 7
            Console.WriteLine(floorValue1);

            double value22 = -7.9;
            double floorValue2 = Math.Floor(value22);  // floorValue2 = -8
            Console.WriteLine(floorValue2);

            /* 9.Math.Log(double val)
             Leírás: Logaritmus számítása az Euler szám(e) alapjával.
             Példa:*/
            double logValue = Math.Log(10);  // logValue ≈ 2.3026 (log_e(10))
            Console.WriteLine(logValue);

            /*
             10. Math.Log(double val, double base)
            Leírás: Logaritmus számítása egy adott alaphoz.
               Példa:*/

            double logBase10 = Math.Log(100, 10);  // logBase10 = 2 (log_10(100))
            Console.WriteLine(logBase10);

            /* 11.Math.Log10(double val)
             Leírás: Tízes alapú logaritmus számítása.
             Példa:*/

            double log10Value = Math.Log10(100);  // log10Value = 2
            Console.WriteLine(log10Value);


            /*12.Math.Max(value1, value2)
            Leírás: Két érték közül a nagyobbik visszaadása.
            Példa:*/
            int maxValue = Math.Max(5, 10);  // maxValue = 10
            Console.WriteLine(maxValue);


            /*13.Math.Min(value1, value2)
            Leírás: Két érték közül a kisebbik visszaadása.
            Példa:*/
            int minValue = Math.Min(5, 10);  // minValue = 5
            Console.WriteLine(minValue);

            /*14.Math.Pow(double val, double exponent)
            Leírás: Hatványozás.Az első paraméter a hatvány alapja, a második paraméter a kitevő.
            Példa:*/

            /*
             * 15. Math.Round(decimal val) és Math.Round(double val)
                Leírás: A szám kerekítése a legközelebbi egész számra.        
                Példa:
             */
            double roundValue1 = Math.Round(7.5);  // roundValue1 = 8
            Console.WriteLine(roundValue1);
            double roundValue2 = Math.Round(7.4);  // roundValue2 = 7
            Console.WriteLine(roundValue2);

            /*16.Math.Round(decimal val, int digits) és Math.Round(double val, int digits)
            Leírás: A szám kerekítése a megadott tizedesjegyekre.

            Példa:*/
            double roundToTwoDecimal = Math.Round(7.4567, 2);  // roundToTwoDecimal = 7.46
            Console.WriteLine(roundToTwoDecimal);

            //Zárójelezés
            /*
             * Kerek zárójelek (()): Ezek a legfontosabbak, és a műveleteket a legnagyobb prioritásúak. A zárójelekben lévő kifejezéseket mindig először kiértékeljük.
                1. Alapvető Példák

                Példa 1: Alapvető Zárójelezés
             */
            int ac = 5;
            int bb = 3;
            int result = (ac + bb) * 2;
            Console.WriteLine(result); // Kimenet: 16

            //Példa 2: Többszörös Zárójelezés
            int e = 10;
            int f = 5;
            int z = 2;
            int result1 = (e + f) * (f - z);
            Console.WriteLine(result1); // Kimenet: 45


            //Példa 3: Zárójelezés nélkül
            int pp = 6;
            int qq = 3;
            int result2 = pp + qq * 2;
            Console.WriteLine(result2); // Kimenet: 12

            //Példa 4: Összetett Zárójelezés
            int aa = 2;
            int bc = 3;
            int c = 4;
            int result3 = (aa + bc) * (c - bc) / 2;
            Console.WriteLine(result3); // Kimenet: 2


            Console.ReadKey();

        }
    }
}
