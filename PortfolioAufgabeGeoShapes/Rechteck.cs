using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAufgabeGeoShapes
{
    /// <summary>
    /// Rechteck brauch zwei Seiten.
    /// Anhand dieser werden die gegenüberliegenden Seiten erstellt.
    /// </summary>
    public class Rechteck
    {

        private Linie a;
        private Linie b;
        private Linie c;
        private Linie d;

        /// <summary>
        /// Rechteck braucht zwei Seiten.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Rechteck(Linie a, Linie b)
        { 
            this.a = a;
            this.b = b;
            this.c = new Linie();
            this.c.Laenge = a.Laenge;
            this.d = new Linie();
            this.d.Laenge = b.Laenge;
        }

        /// <summary>
        /// Gibt den Umfang des Rechtecks
        /// Umfang = 2 * (Seita a + Seite b)
        /// </summary>
        /// <returns>Umfang als double</returns>
        public double BerechneUmfang()
        {
            return a.Laenge + b.Laenge + c.Laenge + d.Laenge;
        }

        /// <summary>
        /// Gibt die Fläche des Rechtecks aus.
        /// Fläche berechnet sich mit a * b
        /// </summary>
        /// <returns>Fläche als double</returns>
        public double BerechneFlaeche()
        {
            return a.Laenge * b.Laenge;
        }

        public void GebeInformationenAus()
        {
            Console.WriteLine("Das ist ein Rechteck.");
            Console.WriteLine($"Die Linie a ist {a.Laenge} cm lang.");
            Console.WriteLine($"Die Linie b ist {b.Laenge} cm lang.");
            Console.WriteLine($"Die Linie c ist {c.Laenge} cm lang.");
            Console.WriteLine($"Die Linie d ist {d.Laenge} cm lang.");
        }
    }
}
