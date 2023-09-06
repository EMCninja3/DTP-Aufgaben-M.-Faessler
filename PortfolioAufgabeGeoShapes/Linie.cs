using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAufgabeGeoShapes
{
    /// <summary>
    /// Die Klasse Linie besitzt nur die Variabel Laenge.
    /// </summary>
    public class Linie
    {
        /// <summary>
        /// Länge ist in cm.
        /// </summary>
        public double Laenge { get; set; }

        public void GebeInformationenAus()
        {
            Console.WriteLine("Das ist eine Linie");
            Console.WriteLine($"Die Länge dieser Linie ist {Laenge} cm.");
        }
    }
}
