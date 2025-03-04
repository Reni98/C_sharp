using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOL
{
    internal class LOL
    {
        public int sorszam;
        public string rang;
        public int meccsek;
        public int veresegek;
        public string karakterek;
        public string pozicio;
        public string felhnev;

        public LOL(string sorszam, string rang, string meccsek, string veresegek, string karakterek, string pozicio, string felhnev)
        {
            this.sorszam = int.Parse(sorszam);
            this.rang = rang;
            this.meccsek = int.Parse(meccsek);
            this.veresegek =int.Parse( veresegek);
            this.karakterek = karakterek;
            this.pozicio = pozicio;
            this.felhnev = felhnev;
        }
    }
}
