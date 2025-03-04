using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

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

            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
                try
                {
                conn.Open();
                    /*
                Console.WriteLine("Sikeres kapcsolat az adatbázishoz!");
                    Console.WriteLine("Melyik soszámú játékot szeretnéd frissiteni?");
                    Console.WriteLine("Add meg a sorszámot: ");
                    int sorszam = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg a rangot:");
                    string rang = Console.ReadLine();
                    Console.WriteLine("Add meg a meccsek számát");
                    int meccsek = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg a vereségek számát");
                    int veresegek = int.Parse(Console.ReadLine());
                    Console.WriteLine("Add meg a karaktert");
                    string karakterek = Console.ReadLine();
                    Console.WriteLine("Add meg poziciókat:");
                    string pozicio = Console.ReadLine();
                    Console.WriteLine("Add meg a felhasználónevet");
                    string felhnev = Console.ReadLine();
                    //UjJatek(sorszam,rang,meccsek,veresegek,karakterek,pozicio,felhnev);
                    JatekFrissitese(sorszam, rang, meccsek, veresegek, karakterek, pozicio, felhnev);
                    */

                    int felhszama = LOL.JatekosMegszamol(jatekok);
                    Console.WriteLine($"A txt fájlban {felhszama} felhasználó van.");

                    List <string>nevek= LOL.NevekMegszamol(jatekok);
                    Console.WriteLine(string.Join(",",nevek));
                    Console.WriteLine($"S betűvel kezdődő nevek db száma: {nevek.Count}");

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
                    cmd.Parameters.AddWithValue("@meccsek", meccsek);
                    cmd.Parameters.AddWithValue("@veresegek", veresegek);
                    cmd.Parameters.AddWithValue("@karakterek", karakterek);
                    cmd.Parameters.AddWithValue("@pozicio", pozicio);
                    cmd.Parameters.AddWithValue("@felhnev", felhnev);




                    cmd.ExecuteNonQuery();
                }
            }
        }

        static void JatekFrissitese(int sorszam, string rang, int meccsek, int veresegek, string karakterek, string pozicio, string felhnev)
        {
            string query = "UPDATE meccsek SET rang = @rang, meccsek = @meccsek, veresegek = @veresegek, karakterek = @karakterek,pozicio = @pozicio,felhnev = @felhnev WHERE sorszam = @sorszam";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@sorszam", sorszam);
                    cmd.Parameters.AddWithValue("@rang", rang);
                    cmd.Parameters.AddWithValue("@meccsek", meccsek);
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
