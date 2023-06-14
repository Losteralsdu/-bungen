using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPÜbung_2022
{
    public class Kunde
    {
        string sVorname;
        string sNachname;
        DateTime dGeburtsdatum;

        public Kunde(string sV, string sN, DateTime dGeb)
        {
            sVorname = sV;
            sNachname = sN;
            dGeburtsdatum = dGeb;
        }

        public string getVorname()
        {
            return sVorname;
        }

        public string getNachname()
        {
            return sNachname;
        }

        public override string ToString()
        {
            return $"{sNachname} {sVorname}, {dGeburtsdatum.ToShortDateString()}";
        }
    }
}
