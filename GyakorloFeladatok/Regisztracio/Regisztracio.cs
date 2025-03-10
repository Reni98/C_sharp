using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regisztracio
{
    internal class Regisztracio
    {
        public string nev;
        public string felhnev;
        public string email;
        public string jelszo;
        public DateTime szuldatum;

        public Regisztracio(string nev, string felhnev, string email, string jelszo, string szuldatum)
        {
            this.nev = nev;
            this.felhnev = felhnev;
            this.email = email;
            this.jelszo = jelszo;
            this.szuldatum = Convert.ToDateTime(szuldatum);
        }
    }
}
