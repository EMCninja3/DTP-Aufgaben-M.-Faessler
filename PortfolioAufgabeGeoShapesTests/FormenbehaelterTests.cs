using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortfolioAufgabeGeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioAufgabeGeoShapes.Tests
{
    [TestClass()]
    public class FormenbehaelterTests
    {
        [TestMethod()]
        public void EntferneErsterKreisTest()
        {
            Linie a = new Linie();
            a.Laenge = 10;
            Kreis k = new Kreis(a);
            Rechteck r1 = new Rechteck(a, a);
            Dreieck d1 = new Dreieck(a);

            Formenbehaelter f = new Formenbehaelter(k, r1, r1);

            f.EntferneErsterKreis();
            f.EntferneErsterKreis();
            f.EntferneErsterKreis();
            f.EntferneErsterKreis();
            f.EntferneErsterKreis();
            f.EntferneErsterKreis();
            Assert.AreEqual(f.kreise.Count, 1);

        }
    }
}