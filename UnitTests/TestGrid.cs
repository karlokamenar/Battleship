using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vsite.Oom.Battleship.Model;

namespace Vsite.Oom.Battleship.UnitTest6
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsReturnsListOf27ArraysForGrid5x6AndShip4()
        {
            Grid g = new Grid(5, 6);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());
        }

        [TestMethod]
        public void GetAvailablePlacementsReturnsListOf22ArraysForGrid5x6AndShip4AfterEliminatingField2_2()
        {
            Grid g = new Grid(5, 6);
            var squares = new List<Square>{ new Square(2, 2) };
            g.EliminateSquares(squares);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(22, arr.Count());
        }
    }
}
