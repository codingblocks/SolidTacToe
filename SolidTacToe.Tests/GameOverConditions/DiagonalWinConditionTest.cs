using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SolidTacToe.Definitions;
using SolidTacToe.GameOverConditions;

namespace SolidTacToe.Tests.GameOverConditions
{
    [TestClass]
    public class DiagonalWinConditionTest
    {
        [TestClass]
        public class ConditionMet
        {
            // TODO Duplicated in HorizontalWinCondition!!!
            private Mock<IGrid> GetEmptyGridMock()
            {
                const int size = 3;
                var grid = new Mock<IGrid>();
                grid.Setup(x => x.Size).Returns(size);

                for (var i = 0; i < size; i++)
                {
                    for (var j = 0; j < size; j++)
                    {
                        grid.Setup(x => x.Get(i, j)).Returns(Token.Empty);
                    }
                }
                return grid;
            }

            [TestMethod]
            public void FalseForEmptyGrid()
            {
                var grid = GetEmptyGridMock();
                var target = new DiagonalWinCondition { Grid = grid.Object, Token = Token.O };
                var result = target.ConditionMet();
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void TrueForTopLeftDiagonalWin()
            {
                var grid = GetEmptyGridMock();
                grid.Setup(x => x.Get(0, 0)).Returns(Token.O);
                grid.Setup(x => x.Get(1, 1)).Returns(Token.O);
                grid.Setup(x => x.Get(2, 2)).Returns(Token.O);

                var target = new DiagonalWinCondition { Grid = grid.Object, Token = Token.O };
                var result = target.ConditionMet();
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void TrueForTopRightDiagonalWin()
            {
                var grid = GetEmptyGridMock();
                grid.Setup(x => x.Get(2, 0)).Returns(Token.O);
                grid.Setup(x => x.Get(1, 1)).Returns(Token.O);
                grid.Setup(x => x.Get(0, 2)).Returns(Token.O);

                var target = new DiagonalWinCondition { Grid = grid.Object, Token = Token.O };
                var result = target.ConditionMet();
                Assert.IsTrue(result);
            }
        }
    }
}

