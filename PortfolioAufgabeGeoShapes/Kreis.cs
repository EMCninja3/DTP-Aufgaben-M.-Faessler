using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAufgabeGeoShapes
{
    public class Kreis
    {
        public Linie umfang;
        public Kreis(Linie umfang) {
            this.umfang = umfang;
        }

        public double BerechneUmfang()
        {
            return umfang.Laenge;
        }

        public double BerechneFlaeche()
        {
            double flaeche = 0;
            double radius = umfang.Laenge / (2 * Math.PI);
            flaeche = Math.Pow(radius, 2) * Math.PI;

            return flaeche;
        }
    }
}
