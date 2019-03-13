using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Vsite.Oom.Battleship.Model;

namespace Vsite.Oom.Battleship.UnitsTests
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class TestGrid
    {
       

        [TestMethod]
        public void GetAvailablePlacementReturnsListOf27ArraysForGrid5x6AndShip4()
        {
            Grid g = new Grid(5,6);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());
        }

        [TestMethod]
        public void GetAvailablePlacementReturnsListOf22ArraysForGrid5x6AndShip4AfterEliminatingField2_2()
        {
            Grid g = new Grid(5, 6);
            var squares = new List<Square> { new Square(2, 2) };
            g.EliminateSquares(squares);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());
        }
    }
}
