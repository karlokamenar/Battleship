using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vsite.Oom.Battleship.Model;

namespace Vsite.Oom.Battleship.UnitTests
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void ConstructorCreatesSquareWitdhCoordinatesProvided()
        {
            Square s = new Square(2, 3);
            Assert.AreEqual(2, s.Row);
            Assert.AreEqual(2, s.Column);
        }
    }
}
