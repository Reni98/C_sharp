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
        static Random rnd = new Random();
        public static string connection = "server=localhost;database=szojatek;user=root;password=;";
        public static string UjSzo() {

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

        public static bool JatekFolytat(out string kivalasztott ) {
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

        public static void UjJatek() {

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
                    pont += 1;
                    string kivalasztott;

                    if (JatekFolytat(out kivalasztott))
                    {
                        elet = 5;
                        kivalasztott_szo = kivalasztott;
                        Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
                        jatek += 1;
                    }
                    else {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Nem találtad el, próbáld újra!");
                    elet -= 1;
                    if (elet == 0) {
                        string kivalasztott;
                        if (JatekFolytat(out kivalasztott))
                        {
                            kivalasztott_szo = kivalasztott;
                            elet = 5;
                            Console.WriteLine($"Kiválasztott szó: {kivalasztott_szo}");
                            jatek += 1;
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

            JatekAdatFeltolt(jates_nev, pont, jatek);
            Console.WriteLine("Az adatok sikeresen fel lettek töltve az adatbázisba.");

        }

        public static void JatekAdatFeltolt(string jatekos_nev,int elertpont,int lejatszottkor) {
            string query = "INSERT INTO jatek (jatekos_nev,elertpont,lejatszottkor) VALUES (@jatekos_nev,@elertpont,@lejatszottkor)";
            using (MySqlConnection conn = new MySqlConnection(connection)) {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@jatekos_nev",jatekos_nev);
                    cmd.Parameters.AddWithValue("@elertpont", elertpont);
                    cmd.Parameters.AddWithValue("@lejatszottkor", lejatszottkor);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        
    }
}
