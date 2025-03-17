using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szojatek
{
    internal class Create
    {
        public static string connection = "server=localhost;database=szojatek;user=root;password=;";
        public static int JatekosAdatFeltolt(string jatekos_nev)
        {
            string query = "INSERT INTO jatekos (jatekos_nev) VALUES (@jatekos_nev)";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@jatekos_nev", jatekos_nev);
                    cmd.ExecuteNonQuery();

                    string getidquery = "SELECT LAST_INSERT_ID()";
                    using (MySqlCommand cmdid = new MySqlCommand(getidquery, conn)) { 
                        int jatekos_id = Convert.ToInt32(cmdid.ExecuteScalar());
                        return jatekos_id;
                    }
                }
            }
        }

        public static void JatekAdatFeltolt(int pont,int jatek,int jatekos_id)
        {
            string query = "INSERT INTO jatek (pont,jatek,jatekos_id) VALUES (@pont,@jatek,@jatekos_id)";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@pont", pont);
                    cmd.Parameters.AddWithValue("@jatek", jatek);
                    cmd.Parameters.AddWithValue("@jatekos_id", jatekos_id);
                    cmd.ExecuteNonQuery();

                   
                }
            }
        }
    }
}
