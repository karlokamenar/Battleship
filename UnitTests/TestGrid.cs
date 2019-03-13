using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom.Battleship.Model;

namespace Vsite.Oom.Battleship.UnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsReturnsListOf20ArraysForGrid5v5AndShip4()
        {
            Grid g = new Grid(5, 5);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(20, arr.Count());
        }
        [TestMethod]
        public void GetAvailablePlacementsReturnsListOf22ArraysForGrid5v6AndShip4AfterEliminatingField2_2()
        {
            Grid g = new Grid(5, 6);
            var squares = new List<Square> { new Square(2, 2) };
            g.EliminateSquares(squares);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(20, arr.Count());
        }
    }
}
