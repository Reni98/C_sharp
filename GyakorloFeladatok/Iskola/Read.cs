using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;


namespace suli
{
    internal class Read
    {
        public static string connection = "server=localhost; database=iskola;user=root;password=;";

        public static void AdatKiolvas() {
            using (MySqlConnection conn = new MySqlConnection(connection)) {
                try
                {
                    string query = "SELECT * FROM diak";
                    string file = "diakok.txt";

                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader read = cmd.ExecuteReader())
                    {
                        using (StreamWriter sr = new StreamWriter(file))
                        {
                           

                                while (read.Read())
                                {
                                    int diak_id = read.GetInt32("diak_id");
                                    string dveznev = read.GetString("dveznev");
                                    string dkernev = read.GetString("dkernev");
                                    string osztaly = read.GetString("osztaly");

                                sr.WriteLine($"ID:{diak_id}");
                                sr.WriteLine($"Vezetéknév: {dveznev}");
                                sr.WriteLine($"Keresztnév: {dkernev}");
                                sr.WriteLine($"Osztály: {osztaly}");


                                    Console.WriteLine($"ID:{read["diak_id"]},Vezetéknév: {read["dveznev"]},Keresztnév: {read["dkernev"]},Osztály: {read["osztaly"]}");
                                }
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba" + ex.Message);
                }
        }
        }
    }
}
