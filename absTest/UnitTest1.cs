using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using лаба2;

namespace absTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquare()
        {
            var calc = new Square(10.2, 21.2);

            var calcRez = (10.2 * 21.2) * 2;
            var rez = calc.Value();

            Assert.AreEqual(calcRez, rez);

        }

        [TestMethod]
        public void TestQube()
        {
            var calc = new Qube(10.2, 21.2);

            var calcRez = (10.2 * 21.2) * 3;
            var rez = calc.Value();

            Assert.AreEqual(calcRez, rez);
        }
    }
}
