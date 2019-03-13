using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom.Battleship.Model;
using System.Collections.Generic;

namespace Vsite.Oom.BattleshipUnitTests
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsReturnsListOf20arraysForGrid5x5AndShip4()
        {
            Grid g = new Grid(5,6);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());

        }
        [TestMethod]
        public void GetAvailablePlacementsReturnsListOf20arraysForGrid5x5AndShip4AfterEliminateingField2_2()
        {
            Grid g = new Grid(5, 6);
            var squares = new List<Square> { new Square(2, 2) };

            g.Eliminatesquares(squares);

            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(20, arr.Count());

        }
    }
}
