using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

using Vsite.Oom.Battleship.Model;
using System.Collections.Generic;

namespace Vsite.Oom.Battleship.UnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsReturnListOf27ArraysDorGrid5X6AndShip4()
        {
            Grid g = new Grid(5, 6);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());
        }

        [TestMethod]
        public void GetAvailablePlacementsReturnListOf22ArraysDorGrid5X6AndShip4AfterEliminatingFild2_2()
        {
            Grid g = new Grid(5, 5);
            var squares= new  List<Square> { new Square(2, 2) };
            g.EliminateSquares(squares);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(22, arr.Count());
        }
    }
}
