using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vsite.Oom.Battleship.Model;
using System.Linq;
using System.Collections.Generic;

namespace Vsite.Oom.Battleship.UnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementReturnesListOf27ArraysForGrid5x6AndShip4()
        {
            Grid g = new Grid(5, 6);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());
        }

        [TestMethod]
        public void GetAvailablePlacementReturnesListOf27ArraysForGrid5x6AndShip4AfterEliminatingField2_2()
        {
            Grid g = new Grid(5, 6);
            g.EliminateSquares(new List<Square> { new Square(2, 2) });
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());
        }
    }
}
