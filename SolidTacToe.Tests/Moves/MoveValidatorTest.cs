using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SolidTacToe.Definitions;
using SolidTacToe.Moves;

namespace SolidTacToe.Tests.Moves
{
    [TestClass]
    public class MoveValidatorTest
    {
        Mock<IGrid> Grid { get; set; }
        IMoveValidator Target { get; set; }
        
        [TestInitialize]
        public void Initialize()
        {
            Grid = new Mock<IGrid>();
            Grid.Setup(x => x.Size).Returns(2);
            Grid.Setup(x => x.Get(0, 0)).Returns(Token.Empty);
            Grid.Setup(x => x.Get(1, 1)).Returns(Token.O);
            Target = new MoveValidator
                {
                    Grid = Grid.Object
                };
        }

        [TestClass]
        public class InvalidMove : MoveValidatorTest
        {
            [TestMethod]
            public void ValidIsValid()
            {
                var move = new Mock<IMove>();
                move.Setup(x => x.X).Returns(0);
                move.Setup(x => x.Y).Returns(0);

                var result = Target.InvalidMove(move.Object);
                Assert.IsFalse(result);
            }

            [TestMethod]
            public void NonEmptyIsInvalid()
            {
                var move = new Mock<IMove>();
                move.Setup(x => x.X).Returns(1);
                move.Setup(x => x.Y).Returns(1);

                var result = Target.InvalidMove(move.Object);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void MinimumXIsInvalid()
            {
                var move = new Mock<IMove>();
                move.Setup(x => x.X).Returns(-1);
                move.Setup(x => x.Y).Returns(1);

                var result = Target.InvalidMove(move.Object);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void MinimumYIsInvalid()
            {
                var move = new Mock<IMove>();
                move.Setup(x => x.X).Returns(1);
                move.Setup(x => x.Y).Returns(-1);

                var result = Target.InvalidMove(move.Object);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void MaximumXIsInvalid()
            {
                var move = new Mock<IMove>();
                move.Setup(x => x.X).Returns(3);
                move.Setup(x => x.Y).Returns(1);

                var result = Target.InvalidMove(move.Object);
                Assert.IsTrue(result);
            }

            [TestMethod]
            public void MaximumYIsInvalid()
            {
                var move = new Mock<IMove>();
                move.Setup(x => x.X).Returns(1);
                move.Setup(x => x.Y).Returns(3);

                var result = Target.InvalidMove(move.Object);
                Assert.IsTrue(result);
            }

        }
    }
}
