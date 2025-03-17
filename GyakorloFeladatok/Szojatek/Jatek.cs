using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szojatek
{
    internal class Jatek
    {
        public string jatekos_nev;
        public int pont;
        public int jatek;
        static Random rnd = new Random();

        public Jatek(string jatekos_nev, int pont, int jatek)
        {
            this.jatekos_nev = jatekos_nev;
            this.pont = pont;
            this.jatek = jatek;
        }

       
       
        public string UjSzo() {

            //Véletlenszerű szót kiválaszt a szavak listából
            List<string> szavak = new List<string>
        {
            "kard", "pajzs", "varázslat", "ellenség", "páncél",
            "sárkány", "térkép", "labirintus", "arany", "kristály",
            "küldetés", "fegyver", "varázsital", "hős", "szörny",
            "pontszám", "élet", "futás", "ugrás", "boss",
            "multiplayer", "singleplayer", "co-op", "kihívás", "XP",
            "szintlépés", "loot", "kaszt", "NPC", "főellenség"
        };

            
            int index = rnd.Next(szavak.Count);
            string kivalasztott_szo = szavak[index];
            return kivalasztott_szo;
        }

        public  bool JatekFolytat(out string kivalasztott ) {
            //A játékos által megadott választól függ, hogy folytatódik a játék,akkor egy új véletlenül
            //kiválasztott szót kapunk a korábban elkészített UjSzo() metodusból.
            Console.WriteLine("Szeretnéd folytatni a játékot (igen/nem)");
            string valasz = Console.ReadLine();
           
            if (valasz == "igen")
            {
                kivalasztott = UjSzo();                                   
                return true;
            }
            else
            {
                kivalasztott = "";
                Console.WriteLine("Játék vége!");
                return false;
            }
        }

        public  (string,int,int) UjJatek() {

            string kivalasztott_szo = UjSzo();
            Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
            Console.WriteLine("Üdvözöllek a szójátékban, add meg a neved:");
            string jates_nev= Console.ReadLine();
            Console.WriteLine($"Jó játékot {jates_nev}.");

            int elet = 5;
            int pont = 0;
            int jatek = 1;

            while (elet > 0) {
               
                Console.WriteLine("Adj meg egy szót:");
                string bekert_szo = Console.ReadLine();
               
                if (kivalasztott_szo == bekert_szo)
                {
                    Console.WriteLine("Nyertél!");
                    pont ++;
                    string kivalasztott;

                    if (JatekFolytat(out kivalasztott))
                    {
                        elet = 5;
                        kivalasztott_szo = kivalasztott;
                        Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
                        jatek ++;
                    }
                    else {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Nem találtad el, próbáld újra!");
                    elet --;
                    if (elet == 0) {
                        string kivalasztott;
                        if (JatekFolytat(out kivalasztott))
                        {
                            kivalasztott_szo = kivalasztott;
                            elet = 5;
                            Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
                            jatek ++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine($"Játékos neve: {jates_nev}");
            Console.WriteLine($"Az elért pontszámod: {pont}");
            Console.WriteLine($"{jatek} kört játszottál.");


            return (jates_nev, pont, jatek);
        }

       
        
    }
}
