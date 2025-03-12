using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suli
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            /*int diak_id = 17;
            string dveznev = "Fehér";
            string dkernev = "László";
            string osztaly = "11C";

            Create.UjDiak(diak_id,dveznev,dkernev,osztaly);
            Console.WriteLine("Sikeresen hozzá lett adva");*/

            Read.AdatKiolvas();
            Console.ReadKey();
        }
    }
}
