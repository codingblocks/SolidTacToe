using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidTacToe.Definitions;

namespace SolidTacToe.Tests
{
    [TestClass]
    public class GridTest
    {
        protected IGrid Target { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var slots = new[] { Token.X, Token.Empty, Token.O, Token.Empty };
            Target = new Grid
            {
                Slots = slots,
                Size = 2
            };
        }

        [TestClass]
        public class Get : GridTest
        {
            [TestMethod]
            [ExpectedException(typeof(IndexOutOfRangeException))]
            public void ExceptionThrownForInvalidIndex()
            {
                Target.Get(10);
            }

            [TestMethod]
            [ExpectedException(typeof(IndexOutOfRangeException))]
            public void ExceptionThrownForInvalidCoords()
            {
                Target.Get(0, -1);
            }

            [TestMethod]
            public void ExpectedValueAtIndex()
            {
                var result = Target.Get(2);
                Assert.AreEqual(Token.O, result);
            }

            [TestMethod]
            public void ExpectedValueAtCoords()
            {
                var result = Target.Get(1,1);
                Assert.AreEqual(Token.Empty, result);
            }
        }

        [TestClass]
        public class Set : GridTest
        {
            [TestMethod]
            [ExpectedException(typeof(IndexOutOfRangeException))]
            public void ExceptionThrownForInvalidIndex()
            {
                Target.Set(Token.X, -1);
            }

            [TestMethod]
            [ExpectedException(typeof(IndexOutOfRangeException))]
            public void ExceptionThrownForInvalidCoords()
            {
                Target.Set(Token.X, 2, 2);
            }

            [TestMethod]
            public void ExpectedValueForSetIndex()
            {
                const Token token = Token.X;
                const int index = 0;

                Target.Set(token, index);
                var result = Target.Get(index);

                Assert.AreEqual(token, result);
            }

            [TestMethod]
            public void ExpectedValueForSetCoords()
            {
                const Token token = Token.X;

                Target.Set(token, 1, 1);
                var result = Target.Get(1, 1);

                Assert.AreEqual(token, result);
            }
        }

        [TestClass]
        public class Size
        {
            [TestMethod]
            public void AppropriateSizeReturned()
            {
                const int size = 3;
                var grid = new Grid() { Size = size };
                Assert.AreEqual(size, grid.Size);
            }
        }
    }
}
