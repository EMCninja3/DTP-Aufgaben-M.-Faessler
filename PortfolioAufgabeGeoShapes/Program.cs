namespace PortfolioAufgabeGeoShapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program GeoShapes Portfolio");
            Console.WriteLine("M. Fässler\n\n\n");

            Linie a = new Linie();
            a.Laenge = 10;
            Kreis k = new Kreis(a);
            Rechteck r1 = new Rechteck(a, a);
            Dreieck d1 = new Dreieck(a);

            Formenbehaelter f = new Formenbehaelter(k, r1, r1);
            f.DreieckHinzufuegen(d1);
            f.GebeInformationenAus();
        }
    }
}