using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SolidTacToe.Definitions;
using SolidTacToe.GameOverConditions;

namespace SolidTacToe.Tests.GameOverConditions
{
    [TestClass]
    public class NoMovesLeftConditionTest
    {
        private NoMovesLeftCondition Target { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Target = new NoMovesLeftCondition();
        }

        [TestMethod]
        public void FalseIfEmptyExists()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Size).Returns(2);
            grid.SetupSequence(x => x.Get(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(Token.X)
                .Returns(Token.Empty);
            Target.Grid = grid.Object;

            var result = Target.ConditionMet();
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TrueIfNoEmptyExists()
        {
            var grid = new Mock<IGrid>();
            grid.Setup(x => x.Size).Returns(2);
            grid.SetupSequence(x => x.Get(It.IsAny<int>(), It.IsAny<int>()))
                .Returns(Token.X)
                .Returns(Token.O)
                .Returns(Token.X)
                .Returns(Token.O);
            Target.Grid = grid.Object;

            var result = Target.ConditionMet();
            Assert.IsTrue(result);
        }
    }
}