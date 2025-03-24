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
            string szamlaszama = "";
            decimal osszege = 0;
            DateTime datum = DateTime.Now;

            Console.WriteLine("Nálunk bankol már?");
            string valasz = Console.ReadLine();

            if (valasz == "nem")
            {
                SzamlaTulajdonos tulajdonos = new SzamlaTulajdonos("", 0, 0);
                var (tulajdonos_nev, azonosito, pinkod) = tulajdonos.TulajdonosAdatai();
                int tulajdonos_id = Create.TulajdonosAdatFeltolt(tulajdonos_nev, azonosito, pinkod);
                Console.WriteLine("Sikeres volt az adatfeltöltés.");

                Szamla szamla = new Szamla();
                 var (szamlaszam, egyenleg) = szamla.SzamlaLetrehozas();
                Create.SzamlaFeltolt(tulajdonos_id, szamlaszam,egyenleg);
                Console.WriteLine("A számla sikeresn létre lett hozva.");



            }
            else {
                if (Ellenorzes.AdatEllenorzes(tulajdonos_neve, azonositas, pinkodmegad))
                {
                    Console.WriteLine("Sikeresen belépett a fiókjába.");
                    Console.WriteLine("Melyik válassza válassza:\n 1.Egyenleg lekérés, \n 2.Befizetés, \n 3.Pénz felvétel");
                    string muvelet = Console.ReadLine();
                    switch (muvelet) {
                        case "1": {
                                SzamlaMuveletek.EgyenlegLekeres();
                                break;
                            }
                        case "2": {
                                var (szamla_id,osszeg,tipus) = SzamlaMuveletek.Befizetes(szamlaszama,osszege);
                                Create.TranzakcioFeltolt(szamla_id,datum,osszeg,tipus);
                                
                                break;
                            }

                        case "3": {
                                var (szamla_id,osszeg,tipus)=SzamlaMuveletek.Penzfelvetel(szamlaszama,osszege);
                                Create.TranzakcioFeltolt(szamla_id, datum, osszeg, tipus);
                                break;
                            }
                    }
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
