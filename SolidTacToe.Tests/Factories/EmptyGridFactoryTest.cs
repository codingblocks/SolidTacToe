using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidTacToe.Definitions;
using SolidTacToe.Factories;

namespace SolidTacToe.Tests.Factories
{
    [TestClass]
    public class EmptyGridFactoryTest
    {
        [TestMethod]
        public void AllSlotsCreatedEmpty()
        {
            var target = new EmptyGridFactory();
            var result = target.Create<GridFake>(2);
            Assert.AreEqual(Token.Empty, result.Slots[0, 0]);
            Assert.AreEqual(Token.Empty, result.Slots[0, 1]);
            Assert.AreEqual(Token.Empty, result.Slots[1, 0]);
            Assert.AreEqual(Token.Empty, result.Slots[1, 1]);
        }

        [TestMethod]
        public void CorrectSizeReturned()
        {
            var target = new EmptyGridFactory();
            var result = target.Create<GridFake>(2);
            Assert.AreEqual(2, result.Size);
        }

        [TestMethod]
        public void CorrectSlotsReturned()
        {
            var target = new EmptyGridFactory();
            var result = target.Create<GridFake>(2);
            Assert.AreEqual(4, result.Slots.Length);
        }
    }

    internal class GridFake : IGrid, IGridMatrix
    {
        public Token[,] Slots { set; get; }
        public int Size { get; set; }
        public Token Get(int x, int y)
        {
            throw new NotImplementedException("Shoudln't need this");
        }

        public void Set(Token t, int x, int y)
        {
            Slots[x, y] = t;
        }
    }

}
