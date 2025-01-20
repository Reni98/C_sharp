using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bevezetés a switch-case szerkezetbe
                A switch-case egy döntési szerkezet, amely több ágra oszthatja a program vezérlését 
                az alapján, hogy egy kifejezés értéke milyen. Különösen hasznos akkor, ha több if-else ágat kellene egymás után írnunk, mert sokkal olvashatóbb és hatékonyabb megoldást nyújt.

            Általános szintaxis
            switch (kifejezés)
{
                case érték1:
                 // Kód, ha a kifejezés értéke érték1
                     break;

                case érték2:
                // Kód, ha a kifejezés értéke érték2
                    break;

                default:
                // Kód, ha egyik érték sem egyezik
                    break;

            Fontos részek
            switch (kifejezés): Az a változó vagy kifejezés, amit ellenőrizni szeretnénk.
            case érték:: Egy lehetséges érték, amire a kifejezés egyezhet.
            break: Megszakítja a switch blokk végrehajtását, különben a következő ágra is átlépne (ez az ún. "fall-through" viselkedés).
            default:: Opcionális ág, ami akkor fut, ha egyik case sem teljesül.
}

             */

            Console.WriteLine("Válassz egy opciót:");
            Console.WriteLine("1 - Kávé");
            Console.WriteLine("2 - Tea");
            Console.WriteLine("3 - Víz");
            Console.Write("Írd be a választott számot: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Kávét választottál.");
                    break;
                case 2:
                    Console.WriteLine("Teát választottál.");
                    break;
                case 3:
                    Console.WriteLine("Vizet választottál.");
                    break;
                default:
                    Console.WriteLine("Érvénytelen választás.");
                    break;
            }


            /*
             * Mikor érdemes használni a switch-case-t?
                1. Több lehetséges érték ellenőrzésekor
                    Ha egy változó több különböző értéket vehet fel, és mindegyikhez más-más művelet tartozik, akkor a switch-case tisztább és olvashatóbb megoldás.

                    Miért jobb ez, mint az if-else?

                    Az if-else struktúra nehezen olvashatóvá válik, ha sok ágat kell kezelni.
                    A switch-case esetén az egyes ágak elkülönülnek, így könnyebben karbantartható a kód.

                2. Egymáshoz hasonló logika esetén
                    Ha az egyes esetek ugyanazt a változót vizsgálják és hasonló műveleteket hajtanak végre, a switch-case egyszerűsíti a kódot.

                3. Rövid, jól elkülöníthető esetekhez
                A switch-case jól működik, ha az egyes ágak kódja rövid és egyszerű. Ha bonyolult logikát kell kezelni, érdemes inkább függvényeket hívni a case ágakban.

                4. Számok és szövegek kezelésére
                A switch-case támogatja az egész számokat, a szövegeket és a logikai értékeket is (C# 7.0 óta). Ha a feltétel logikai értéken vagy egy adott számításon alapul, szintén jó választás.


                ### **Összefoglalva**
                Használj **`switch-case`-t**, ha:
                - Egy változó több lehetséges értékét kell kezelni.
                - Az értékek egymástól függetlenek.
                - A kód olvashatóságát és karbantarthatóságát szeretnéd javítani.

                Használj **`if-else`-t**, ha:
                - Komplex feltételekkel kell dolgozni.
                - Az ellenőrzés nem determinisztikus vagy dinamikus.
             */
        }
    }
}
