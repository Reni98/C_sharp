using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    internal class Rulett
    {
        public int sorszam;
        public string felhnev;
        public int fogadott_tet;
        public int szorzo;
        public string eredmeny;

        public Rulett(string sorszam, string felhnev, string fogadott_tet, string szorzo, string eredmeny)
        {
            this.sorszam = int.Parse(sorszam);
            this.felhnev = felhnev;
            this.fogadott_tet = int.Parse(fogadott_tet);
            this.szorzo =int.Parse(szorzo);
            this.eredmeny = eredmeny;
        }
    }
}
