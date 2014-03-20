using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SolidTacToe.Definitions;
using SolidTacToe.Moves;

namespace SolidTacToe.Tests.Moves
{
    [TestClass]
    public class MoveTest
    {
        Mock<IGrid> Grid { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Grid = new Mock<IGrid>();
        }

        [TestMethod]
        public void Apply()
        {
            var target = new Move
                {
                    X = 2,
                    Y = 1,
                    Grid = Grid.Object,
                    Token = Token.X
                };
            target.Apply();
            Grid.Verify(x => x.Set(Token.X, 2, 1));
        }
    }
}
