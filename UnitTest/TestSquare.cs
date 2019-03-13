using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom.Battleship.Model;

namespace UnitTest
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void ConstructorCreateSquareWithCoordinatesProvided()
        {
            Square s = new Square(2, 3);
            Assert.AreEqual(2, s.Row);
            Assert.AreEqual(3, s.Column);
        }
    }
}
