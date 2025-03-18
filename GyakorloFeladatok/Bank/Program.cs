using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int azonositas = 0;
            int pinkodmegad = 0;
            string tulajdonos_neve = "";
            

            Console.WriteLine("Nálunk bankol már?");
            string valasz = Console.ReadLine();

            if (valasz == "nem")
            {
                SzamlaTulajdonos tulajdonos = new SzamlaTulajdonos("", 0, 0);
                var (tulajdonos_nev, azonosito, pinkod) = tulajdonos.TulajdonosAdatai();
                Create.TulajdonosAdatFeltolt(tulajdonos_nev, azonosito, pinkod);
                Console.WriteLine("Sikeres volt az adatfeltöltés.");

            }
            else {
                if (Ellenorzes.AdatEllenorzes(tulajdonos_neve, azonositas, pinkodmegad))
                {
                    Console.WriteLine("Sikeresen belépett a fiókjába.");
                }
                else
                {
                    Console.WriteLine("Hibás adatot adott meg.");
                }
            }


           
           
         
            Console.ReadKey();
        }
    }
}
