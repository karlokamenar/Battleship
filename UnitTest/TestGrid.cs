using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.Oom.Battleship.Model;
using System.Linq;
namespace Vsite.Oom.Battleship.UnitTest
{
    [TestClass]
    public class TestGrid
    {
        [TestMethod]
        public void GetAvailablePlacementsReturnsListOf27ArraysForGrid5x6()
        {
            Grid g = new Grid(5, 6);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());
            
        }


        public void GetAvailablePlacementsReturnsListOf27ArraysForGrid5x6AfterEliminatingField2_2()
        {

            Grid g = new Grid(5, 6);
            var squares = new List<Square>{ new Square(2, 2) };
            g.EliminateSquares(squares);
            var arr = g.GetAvailablePlacements(4);
            Assert.AreEqual(27, arr.Count());

        }
    }
}
