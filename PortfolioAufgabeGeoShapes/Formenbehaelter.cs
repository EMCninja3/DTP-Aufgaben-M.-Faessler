using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAufgabeGeoShapes
{
    /// <summary>
    /// Formenbehaelter braucht zwei Rechtecke und ein Kreis
    /// Es kann bis zu drei Kreise haben, mindestens eins.
    /// Es kann 0 bis 4 Dreiecke haben.
    /// </summary>
    public class Formenbehaelter
    {
        public List<Rechteck> rechtecke = new List<Rechteck>();
        public List<Kreis> kreise = new List<Kreis>();
        public List<Dreieck> dreiecke = new List<Dreieck>();

        /// <summary>
        /// Braucht zwei Rechtecke und einen Kreis
        /// </summary>
        /// <param name="kreis"></param>
        /// <param name="rechteck1"></param>
        /// <param name="rechteck2"></param>
        public Formenbehaelter (Kreis kreis, Rechteck rechteck1, Rechteck rechteck2)
        {
            this.rechtecke.Add(rechteck1);
            this.rechtecke.Add(rechteck2);
            this.kreise.Add(kreis);
        }

        /// <summary>
        /// Es können maximal 4 Dreiecke hinzugefügt werden.
        /// </summary>
        /// <param name="dreieck"></param>
        public void DreieckHinzufuegen(Dreieck dreieck)
        {
            if (this.dreiecke.Count < 4)
            {
                this.dreiecke.Add(dreieck);
            }
            else
            {
                Console.WriteLine("Es können keine weitere Dreiecke hinzugefügt werden!");
            }
        }

        /// <summary>
        /// Es können maximal 3 Kreise hinzugefügt werden
        /// </summary>
        /// <param name="kreis"></param>
        public void KreisHinzufuegen(Kreis kreis)
        {
            if (this.kreise.Count < 3)
            {
                this.kreise.Add(kreis);
            }
            else
            {
                Console.WriteLine("Es können keine weitere Kreise hinzugefügt werden!");
            }
        }

        /// <summary>
        /// Das erste Dreieck wird entfernt und zurückgegeben.
        /// </summary>
        /// <returns>erstes Dreieck</returns>
        public Dreieck EntferneErstesDreieck()
        {
            if (this.dreiecke.Count > 0)
            {
                Dreieck entferntesDreieck = dreiecke[0];
                dreiecke.RemoveAt(0);
                return entferntesDreieck;
            }
            else
            {
                Console.WriteLine("Es git keine Dreiecke mehr!");
                return null;
            }
        }

        /// <summary>
        /// Der erste Kreis wird entfernt und zurückgegeben.
        /// </summary>
        /// <returns>erster Kreis</returns>
        public Kreis EntferneErsterKreis()
        {
            if (this.kreise.Count > 1)
            {
                Kreis entfernterKreis = kreise[0];
                kreise.RemoveAt(0);
                return entfernterKreis;
            }
            else
            {
                Console.WriteLine("Es kann kein Kreis entfernt werden!\n" +
                    "Es muss mindestens 1 Kreis besitzen.");
                return null;
            }
        }

        /// <summary>
        /// Gibt die Informationen von allen Objekten aus.
        /// </summary>
        public void GebeInformationenAus()
        {
            Console.WriteLine("Das ist ein Formenbehaelter.");
            Console.WriteLine($"Es besitzt {kreise.Count} Kreise.");
            kreise.ForEach(e => { e.GebeInformationenAus(); });
            Console.WriteLine("\n\n");

            Console.WriteLine($"Es besitzt {rechtecke.Count} Rechtecke.");
            rechtecke.ForEach(e => { e.GebeInformationenAus(); });
            Console.WriteLine("\n\n");

            Console.WriteLine($"Es besitzt {dreiecke.Count} Dreiecke.");
            dreiecke.ForEach(e => { e.GebeInformationenAus(); });
        }
    }
}
