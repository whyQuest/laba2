using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using laboratorna4;

namespace TestLaba4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TriangleResz()
        {
            var tri = new Triangle(0, 0, 3, 5, 6, 30);
            var testRez = (6.0, 10.0, 12.0);
            var rez = tri.Resize(2);
            Assert.AreEqual(testRez, rez);
        }

        [TestMethod]
        public void TriangleMove()
        {
            var tri = new Triangle(0, 0, 3, 5, 6, 30);
            var testRez = (50, 50);
            var rez = tri.Move(50, 50);
            Assert.AreEqual(testRez, rez);
        }

        [TestMethod]
        public void TriangleColour()
        {
            var tri = new Triangle(0, 0, 3, 5, 6, 30);
            var colour = "clay";
            var rez = tri.ChangeColour(colour);
            Assert.AreEqual(colour, rez);
        }

        [TestMethod]
        public void EqTriangleMove()
        {
            var tri = new Triangle(0, 0, 3, 5, 6, 30);
            var rez = (50, 50);
            Assert.AreEqual(tri.Move(50, 50), rez);
        }

        [TestMethod]
        public void EqTriangleRotate()
        {
            var tri = new Triangle(0, 0, 3, 5, 6, 30);
            var rez = 90;
            Assert.AreEqual(tri.Rotate(90.0), rez);
        }
    }
}
