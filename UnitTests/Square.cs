using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vsite.Oom.Battleshipe.UnitTests

namespace Vsite.Oom.Battleshipe.UnitTests
{
    [TestClass]
    public class TestSquare
    {
        [TestMethod]
        public void ConstructorCreatesSquareWitdCoordinatesProvided()
        {
            Square s = new Square(2, 3);
            Assert.AreEqual(2, s.Row);
            Assert.AreEqual(3, s.Column);

        }
    }
}
