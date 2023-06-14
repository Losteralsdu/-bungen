using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP2021
{
    public class Sportart
    {
        private string sBezeichnung;
        private double dKilokalorien;

        public Sportart(string sB, double dK)
        {
            sBezeichnung = sB;
            dKilokalorien = dK;
        }

        public string getBezeichnung()
        {
            return sBezeichnung;
        }

        public double getKilokalorien()
        {
            return dKilokalorien;
        }

        public override string ToString()
        {
            return $"{sBezeichnung}: {dKilokalorien} kcal";
        }
    }
}
