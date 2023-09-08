using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAufgabeGeoShapes
{
    /// <summary>
    /// Gleichseitiges Dreieck
    /// Diese Klasse bildet ein gleichseitiges Dreieck ab.
    /// Fläche berechnet sich mit a^2 * sqrt(3) / 4
    /// </summary>
    public class Dreieck
    {
        private Linie a;
        private Linie b;
        private Linie c;

        /// <summary>
        /// Gleichseitiges Dreieck
        /// Diese Klasse bildet ein gleichseitiges Dreieck ab.
        /// </summary>
        /// <param name="a">Länge einer Seite</param>
        public Dreieck(Linie a) {
            
            this.a = a;
            this.b = new Linie();
            b.Laenge = a.Laenge;
            this.c = new Linie();
            c.Laenge = a.Laenge;
        }

        /// <summary>
        /// Gibt den Umfang des Dreiecks
        /// Umfang = Seita a + Seite b + Seite c
        /// </summary>
        /// <returns>Umfang als double</returns>
        public double BerechneUmfang()
        {
            return a.Laenge + b.Laenge + c.Laenge;
        }

        /// <summary>
        /// Gibt die Fläche des gleichseitigen Dreiecks aus.
        /// Fläche berechnet sich mit a^2 * sqrt(3) / 4
        /// </summary>
        /// <returns>Fläche als double</returns>
        public double BerechneFlaeche()
        {
            return Math.Pow(a.Laenge, 2) * Math.Sqrt(3.0) / 4.0;
        }
        /// <summary>
        /// Diese Methode gibt alle Eigenschaften dieses Objektes auf die Console aus.
        /// </summary>
        public void GebeInformationenAus()
        {
            Console.WriteLine("Das ist ein Dreieck");
            Console.WriteLine("Es besitzt 3 Seiten.");
            Console.WriteLine($"Die Linie a ist {a.Laenge} cm lang.");
            Console.WriteLine($"Die Linie b ist {b.Laenge} cm lang.");
            Console.WriteLine($"Die Linie c ist {c.Laenge} cm lang.");
        }
    }
}
