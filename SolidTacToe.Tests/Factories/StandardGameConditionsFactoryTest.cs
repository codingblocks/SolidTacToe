using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SolidTacToe.Definitions;
using SolidTacToe.Factories;
using SolidTacToe.GameOverConditions;

namespace SolidTacToe.Tests.Factories
{
    [TestClass]
    public class StandardGameConditionsFactoryTest
    {
        private StandardGameConditionsFactory Target { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            var grid = new Mock<IGrid>().Object;
            Target = new StandardGameConditionsFactory { Grid = grid };
        }

        [TestMethod]
        public void SameNumberOfWinConditionsExistForAllTokens()
        {
            var result = Target.Create();
            var xCount = result.Count(x => x is IGameWonCondition && ((IGameWonCondition)x).Winner == Token.X);
            var yCount = result.Count(x => x is IGameWonCondition && ((IGameWonCondition)x).Winner == Token.O);

            Assert.AreEqual(xCount, yCount);
        }

        [TestMethod]
        public void NoMovesLeftConditionIsLast()
        {
            var result = Target.Create();
            Assert.IsTrue(result.Last() is NoMovesLeftCondition);
        }
    }
}
