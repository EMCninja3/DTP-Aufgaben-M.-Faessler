using Microsoft.VisualStudio.TestTools.UnitTesting;
using Funktionen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen.Tests
{
    [TestClass()]
    public class MyMathTests
    {
        [TestMethod()]
        public void Calc_kgVTest()
        {
            MyMath m = new MyMath();
            int a = 2;
            int b = 3;
            int result = m.Calc_kgV(a, b);

            Assert.AreEqual(6, result);
            //Assert.AreEqual(7, result);
        }

        [TestMethod()]
        public void Calc_kgVTestIsZero()
        {
            MyMath m = new MyMath();
            int a = 1;
            int b = 1;
            Assert.AreEqual(1, m.Calc_kgV(a, b));
        }
    }
}