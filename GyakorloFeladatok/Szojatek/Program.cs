using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szojatek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jatek jatekok = new Jatek("",0,0);
            var (jatekos_nev, pont, jatek) = jatekok.UjJatek();

            int jatekos_id = Create.JatekosAdatFeltolt(jatekos_nev);
            Create.JatekAdatFeltolt(pont,jatek,jatekos_id);
            Console.WriteLine("Az adatok sikeresen fellettek töltve az adatbázisba.");

            Console.ReadKey();
        }
    }
}
