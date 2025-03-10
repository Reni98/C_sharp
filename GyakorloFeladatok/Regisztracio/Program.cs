using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regisztracio
{
    internal class Program
    {
        public static string connection = "server=localhost;database = regisztracio;user=root;password=;";
        static void Main(string[] args)
        {
            List<Regisztracio> felhasznalok = new List<Regisztracio>();
            string[] sorok = File.ReadAllLines("register.txt");
            foreach (string sor in sorok) {
                string[] adatok = sor.Split(';');
                Regisztracio ujfelhasznalo = new Regisztracio(adatok[0],adatok[1],adatok[2],adatok[3],adatok[4]);
                felhasznalok.Add(ujfelhasznalo);
            }

            foreach (var felh in felhasznalok) {
                Console.WriteLine($"{felh.nev},{felh.felhnev},{felh.email}, {felh.jelszo}, {felh.szuldatum}");
            }

          
                using (MySqlConnection conn = new MySqlConnection(connection)) {
                try
                {
                    conn.Open();
                    Console.WriteLine("Az adatbázis kapcsolat sikeresen létrejött!");
                }
                catch (Exception ex) {
                    Console.WriteLine("Hiba történ a kapcsolódás során" + ex.Message);
                }
            }
            Console.ReadKey();
        }

        /*static void FelhasznaloHozzaad(string nev,string felhnev,string email,string jelszo,DateTime szuldatum) { 
           
        }*/


    }
}
