using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    internal class Auto
    {
        
        public int id;
        public string marka;
        public string rendszam;
        public int ar;
        public int db;

        public Auto(string id, string marka, string rendszam, string ar, string db)
        {
            this.id = int.Parse(id);
            this.marka = marka;
            this.rendszam = rendszam;
            this.ar = int.Parse(ar);
            this.db = int.Parse(db);
        }

        public static int Megszamol(List<Auto> autolista) { 
            return autolista.Count();
        }

        public static int Dragabb(List<Auto> autolista, int d) {
            int dragabb = 0;
            foreach (var item in autolista)
            {
                if (item.ar > d)
                {
                    dragabb++;
                }
                else {
                    Console.WriteLine("Érvénytelen ár.");
                }
            }
            return dragabb;
        }
    }
}
