using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAufgabeGeoShapes
{
    public class Kreis
    {
        private Linie umfang;
        public Kreis(Linie umfang) {
            this.umfang = umfang;
        }
        /// <summary>
        /// Umfang dieses Kreises.
        /// Die angegebene Linie ist schon der Umfang
        /// Somit wird die Länger der Linie ausgeben.
        /// </summary>
        /// <returns>Länge der Linie</returns>
        public double BerechneUmfang()
        {
            return umfang.Laenge;
        }
        /// <summary>
        /// Berechnet die Fläche des Kreises.
        /// </summary>
        /// <returns>Fläche als double</returns>
        public double BerechneFlaeche()
        {
            double flaeche = 0;
            double radius = umfang.Laenge / (2 * Math.PI);
            flaeche = Math.Pow(radius, 2) * Math.PI;
            return flaeche;
        }

        public void GebeInformationenAus()
        {
            Console.WriteLine("Das ist ein Kreis.");
            Console.WriteLine("Es besitzt nur 1 Linie.");
            Console.WriteLine($"Die Linie ist der Umfang und ist {umfang.Laenge} cm lang.");
        }
    }
}
