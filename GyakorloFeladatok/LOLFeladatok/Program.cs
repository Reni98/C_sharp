using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace LOL
{
    internal class Program
    {
        public static string connectionString = "server=localhost;database=lol;user=root;password=;";

        static void Main(string[] args)
        {
            List <LOL> jatekok = new List<LOL>();
            string[] sorok = File.ReadAllLines("lol.txt");
            foreach (var item in sorok)
            {
                string[] adatok = item.Split(',');
                LOL ujjatek = new LOL(adatok[0],adatok[1],adatok[2], adatok[3], adatok[4], adatok[5], adatok[6]);
                jatekok.Add(ujjatek);
            }

            foreach (var item in jatekok)
            {
                Console.WriteLine($"{item.sorszam},{item.rang},{item.meccsek},{item.veresegek},{item.karakterek},{item.pozicio},{item.felhnev}");
            }
            using (MySqlConnection conn = new MySqlConnection(connectionString))
                try
                {
                conn.Open();
                Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");

                //UjFelhasznalo("Kiss Péter", "peter@example.com");
                //UjFelhasznalo("Nagy Anna", "anna@example.com");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba a kapcsolat során: " + ex.Message);
            }
            Console.ReadKey();
        }

        static void UjJatek(int sorszam,string rang,int meccsek, int veresegek, string karakterek, string pozicio, string felhnev)
        {
            string query = "INSERT INTO meccsek (sorszam, rang,meccsek,veresegek,karakterek,pozicio, felhnev) VALUES (@sorszam, @rang,@meccsek,@veresegek,@karakterek,@pozicio, @felhnev)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sorszam", sorszam);
                    cmd.Parameters.AddWithValue("@rang", rang);
                    cmd.Parameters.AddWithValue("@veresegek", veresegek);
                    cmd.Parameters.AddWithValue("@karakterek", karakterek);
                    cmd.Parameters.AddWithValue("@pozicio", pozicio);
                    cmd.Parameters.AddWithValue("@felhnev", felhnev);




                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
