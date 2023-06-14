using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPÜbung_2022
{
    public class Fahrzeug
    {
        string sModell;
        int iAntriebsart;
        double dLeihgebuehr;

        public Fahrzeug(string sM, int iA, double dL)
        {
            sModell = sM;
            iAntriebsart = iA;
            dLeihgebuehr = dL;
        }

        public string getModell()
        {
            return sModell;
        }

        public double getGeb()
        {
            return dLeihgebuehr;
        }

        public bool istAntriebsart(int iA)
        {
            if(iAntriebsart == iA)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
