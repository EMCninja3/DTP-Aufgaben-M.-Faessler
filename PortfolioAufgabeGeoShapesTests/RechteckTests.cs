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
    public class RechteckTests
    {
        [TestMethod()]
        public void BerechneUmfangTest()
        {

            Linie a = new Linie();
            a.Laenge = 10;
            Rechteck r1 = new Rechteck(a, a);
            Assert.AreEqual(a.Laenge*4, r1.BerechneUmfang());

        }

        [TestMethod()]
        public void BerechneFlaecheTest()
        {
            Linie a = new Linie();
            a.Laenge = 10;
            Rechteck r1 = new Rechteck(a, a);
            Assert.AreEqual(a.Laenge*a.Laenge, r1.BerechneFlaeche());
        }
    }
}