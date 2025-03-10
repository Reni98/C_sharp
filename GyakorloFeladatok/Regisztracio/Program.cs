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

            

          
                using (MySqlConnection conn = new MySqlConnection(connection)) {
                try
                {
                    conn.Open();
                    Console.WriteLine("Az adatbázis kapcsolat sikeresen létrejött!");
                    /*foreach (var felh in felhasznalok)
                    {
                        FelhasznaloHozzaad(felh.nev,felh.felhnev,felh.email, felh.jelszo, felh.szuldatum);

                    }
                    Console.WriteLine("Sikeresen fel lettek töltve az adatok az adatbázisba!");
                    */

                    FelhasznaloListazas();
                }
                catch (Exception ex) {
                    Console.WriteLine("Hiba történ a kapcsolódás során" + ex.Message);
                }
            }
            Console.ReadKey();
        }

        static void FelhasznaloHozzaad(string nev,string felhnev,string email,string jelszo,DateTime szuldatum) {
            string query = "INSERT INTO userek (nev,felhnev,email,jelszo,szuldatum) VALUES (@nev,@felhnev,@email,@jelszo,@szuldatum)";
            using (MySqlConnection conn = new MySqlConnection(connection)) {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@nev",nev);
                    cmd.Parameters.AddWithValue("@felhnev",felhnev);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@jelszo", jelszo);
                    cmd.Parameters.AddWithValue("@szuldatum", szuldatum);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        static void FelhasznaloListazas() {
            string query = "SELECT * FROM userek";

            using (MySqlConnection conn = new MySqlConnection(connection)) {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query,conn)) {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read())
                        {
                         int id = reader.GetInt32("id");
                        string nev = reader.GetString("nev");
                        string felhnev = reader.GetString("felhnev");
                        string email = reader.GetString("email");
                        string jelszo = reader.GetString("jelszo");
                        DateTime szuldatum = reader.GetDateTime("szuldatum");


                      
                         Console.WriteLine($"ID: {reader["id"]}, Nev: {reader["nev"]}, Felhasználónév: {reader["felhnev"]},Email: {reader["email"]}, Jelszó: {reader["jelszo"]}, Születési dátum: {reader["szuldatum"]}");
                        }
                    }
                }

            }
        }


    }
}
