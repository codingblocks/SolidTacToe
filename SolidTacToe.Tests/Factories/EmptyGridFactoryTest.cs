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
            Assert.AreEqual(Token.Empty, result.Get(0, 0));
            Assert.AreEqual(Token.Empty, result.Get(0, 1));
            Assert.AreEqual(Token.Empty, result.Get(1, 0));
            Assert.AreEqual(Token.Empty, result.Get(1, 1));
        }
    }

    internal class GridFake : IGrid, IGridMatrix
    {
        public Token[,] Slots { set; private get; }
        public int Size { get; set; }
        public Token Get(int x, int y)
        {
            return Slots[x, y];
        }

        public void Set(Token t, int x, int y)
        {
            Slots[x, y] = t;
        }
    }

}
