using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SzamlaMuveletek
    {
        public static string connect = "server=localhost;database = bank;user = root; password = ;";

        public static void EgyenlegLekeres() {
            string query = "SELECT szamlaszam,egyenleg FROM szamlak";
            using (MySqlConnection conn = new MySqlConnection(connect)) {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query,conn)) {
                    using (MySqlDataReader reader = cmd.ExecuteReader()) {
                        while (reader.Read()) {
                            string szamlaszam = reader.GetString("szamlaszam");
                            decimal egyenleg = reader.GetDecimal("egyenleg");
                        }

                        Console.WriteLine("------Számla adatai-------");
                        Console.WriteLine($"Szamlaszam: {reader["szamlaszam"]},\n Egyenleg: {reader["egyenleg"]}");

                    }
                
                }
            }
        
    }

        public static (int,decimal,string) Befizetes(string szamlaszam,decimal osszeg) {
            Console.WriteLine("Add meg a számlaszámod:");
             szamlaszam = Console.ReadLine();
            Console.WriteLine("Add meg az összeget:");
             osszeg = decimal.Parse(Console.ReadLine());

            string tipus = "Befizetés";
            int szamla_id = 0;
            using (MySqlConnection mySqlConnection = new MySqlConnection(connect)){
                mySqlConnection.Open();

                string szamlaID = "SELECT szamla_id FROM szamlak WHERE szamlaszam = @szamlaszam";
                using (MySqlCommand idCmd = new MySqlCommand(szamlaID,mySqlConnection)) {
                    idCmd.Parameters.AddWithValue("@szamlaszam", szamlaszam);
                   object szamlai = idCmd.ExecuteScalar();
                     szamla_id = Convert.ToInt32(szamlai);

                    
                }
            
            }

            using (MySqlConnection conn = new MySqlConnection(connect)) {
                conn.Open();
                string query = "UPDATE szamlak SET egyenleg = egyenleg + @osszeg WHERE szamlaszam = @szamlaszam";
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@szamlaszam", szamlaszam);
                    cmd.Parameters.AddWithValue("@osszeg", osszeg);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Sikeresen módosítva lett az egyenleg.");
                }
            
            }
            return (szamla_id, osszeg, tipus);
        }

        public static (int,decimal,string) Penzfelvetel(string szamlaszam,decimal osszeg) {
            Console.WriteLine("Add meg számlaszámod:");
            szamlaszam = Console.ReadLine();
            Console.WriteLine("Add meg, hogy mekkora összeget szeretnél felvenni:");
            osszeg = decimal.Parse(Console.ReadLine());

            string tipus = "Felvesz";

            int szamla_id = 0;
            using (MySqlConnection mySqlConnection = new MySqlConnection(connect))
            {
                mySqlConnection.Open();

                string szamlaID = "SELECT szamla_id FROM szamlak WHERE szamlaszam = @szamlaszam";
                using (MySqlCommand idCmd = new MySqlCommand(szamlaID, mySqlConnection))
                {
                    idCmd.Parameters.AddWithValue("@szamlaszam", szamlaszam);
                    object szamlai = idCmd.ExecuteScalar();
                    szamla_id = Convert.ToInt32(szamlai);


                }

            }
            using (MySqlConnection conn = new MySqlConnection(connect)) {
                conn.Open();

                string query = "UPDATE szamlak SET egyenleg = egyenleg - @osszeg WHERE szamlaszam = @szamlaszam";
                using (MySqlCommand cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@szamlaszam", szamlaszam);
                    cmd.Parameters.AddWithValue("@osszeg", osszeg);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Sikeres volt a pénzfelvétel.");

                }
            }

            return(szamla_id,osszeg,tipus);
        }
}

}
