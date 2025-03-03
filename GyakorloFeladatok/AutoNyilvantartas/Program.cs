using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Program
    {
        public static string connectionString = "server=localhost;database=nyilvantartas;user=root;password=;";
        static void Main(string[] args)
        {
            List<string> autok = new List<string>();
            string[] lines = File.ReadAllLines("nyilvantartas.txt");

            foreach (string line in lines)
            {
                string[] adatok = line.Split(',');
                autok.Add(adatok[0]);
                autok.Add(adatok[1]);
                autok.Add(adatok[2]);
                autok.Add(adatok[3]);
                autok.Add(adatok[4]);
            }

          
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");

                    //UjFelhasznalo("Kiss Péter", "peter@example.com");
                    //UjFelhasznalo("Nagy Anna", "anna@example.com");

                    for (int i = 0; i < autok.Count; i++)
                    {
                        UjAuto(int.Parse(autok[1]), autok[1], autok[1], int.Parse(autok[1]), int.Parse(autok[1]));
                      
                    }



                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba a kapcsolat során: " + ex.Message);
                }







                Console.ReadKey();
            }
        }

        static void UjAuto(int id, string automarka, string rendszam, int ar, int db)
        {
            string query = "INSERT INTO cars (id, automarka, rendszam, ar,db) VALUES (@id, @automarka, @rendszam, @ar, @db)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@automarka", automarka);
                    cmd.Parameters.AddWithValue("@rendszam", rendszam);
                    cmd.Parameters.AddWithValue("@ar", ar); 
                    cmd.Parameters.AddWithValue("@db", db);



                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
