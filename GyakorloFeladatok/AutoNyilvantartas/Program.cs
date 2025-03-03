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
            List<Auto> autok = new List<Auto>();
            string[] lines = File.ReadAllLines("nyilvantartas.txt");
            foreach (var line in lines)
            {
                string[] adatok = line.Split(',');
                Auto ujauto = new Auto(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]);
                autok.Add(ujauto);
            }
           

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");

                    /*
                    Console.WriteLine("Adj meg egy id-t:");
                    int id = int.Parse(Console.using MySql.Data.MySqlClient;
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
            List<Auto> autok = new List<Auto>();
            string[] lines = File.ReadAllLines("nyilvantartas.txt");
            foreach (var line in lines)
            {
                string[] adatok = line.Split(',');
                Auto ujauto = new Auto(adatok[0], adatok[1], adatok[2], adatok[3], adatok[4]);
                autok.Add(ujauto);
            }
           

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");

                    /*
                    Console.WriteLine("Adj meg egy id-t:");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ad meg a márkát");
                    string marka = Console.ReadLine();
                    Console.WriteLine("Adj meg egy rendszámot: ");
                    string rendszam = Console.ReadLine();
                    Console.WriteLine("Add meg az autó árát: ");
                    int ar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg, hány db van belőle: ");
                    int db = int.Parse(Console.ReadLine());
                    
                        UjAuto(id,marka, rendszam,ar,db);
                    
                    Console.WriteLine("Sikeresen hozzá lettek adva az adatok az adatbázishoz.");
                    */

                    //A TXT fájlban lévő sorok száma
                    int osszeg = Auto.Megszamol(autok);
                    Console.WriteLine($"Sorok száma:{osszeg}");
                    //Megszámolja hány drágább autó van a feltétel alapján
                    int draga = Auto.Dragabb(autok,9000000);
                    Console.WriteLine($"A feltétel alapján: {draga} db ilyen autó.");
                    //Markak megadása:
                   List<string> markak = Auto.MarkakMegad(autok);
                    /*foreach (var item in markak)
                    {
                        Console.WriteLine(item);
                    }*/
                    Console.WriteLine(string.Join(",",markak));

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
            string query = "INSERT INTO cars (id, automarka, rendszam, ar,db) VALUES (@id, @marka, @rendszam, @ar, @db)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@marka", automarka);
                    cmd.Parameters.AddWithValue("@rendszam", rendszam);
                    cmd.Parameters.AddWithValue("@ar", ar);
                    cmd.Parameters.AddWithValue("@db", db);



                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


    


ReadLine());
                    Console.WriteLine("Ad meg a márkát");
                    string marka = Console.ReadLine();
                    Console.WriteLine("Adj meg egy rendszámot: ");
                    string rendszam = Console.ReadLine();
                    Console.WriteLine("Add meg az autó árát: ");
                    int ar = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg, hány db van belőle: ");
                    int db = int.Parse(Console.ReadLine());
                    
                        UjAuto(id,marka, rendszam,ar,db);
                    
                    Console.WriteLine("Sikeresen hozzá lettek adva az adatok az adatbázishoz.");
                    */

                    //A TXT fájlban lévő sorok száma
                    int osszeg = Auto.Megszamol(autok);
                    Console.WriteLine($"Sorok száma:{osszeg}");
                    //Megszámolja hány drágább autó van a feltétel alapján
                    int draga = Auto.Dragabb(autok,9000000);
                    Console.WriteLine($"A feltétel alapján: {draga} db ilyen autó.");
                    //Markak megadása:
                   List<string> markak = Auto.MarkakMegad(autok);
                    /*foreach (var item in markak)
                    {
                        Console.WriteLine(item);
                    }*/
                    Console.WriteLine(string.Join(",",markak));

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
            string query = "INSERT INTO cars (id, automarka, rendszam, ar,db) VALUES (@id, @marka, @rendszam, @ar, @db)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@marka", automarka);
                    cmd.Parameters.AddWithValue("@rendszam", rendszam);
                    cmd.Parameters.AddWithValue("@ar", ar);
                    cmd.Parameters.AddWithValue("@db", db);



                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}


    


