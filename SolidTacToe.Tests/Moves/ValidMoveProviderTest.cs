using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SolidTacToe.Definitions;
using SolidTacToe.Moves;

namespace SolidTacToe.Tests.Moves
{
    public class ValidMoveProviderTest
    {
        // CODE SMELL: Lots of stuff going on here, how would Demeter feel about this?
        Mock<IMoveTracker> Tracker { get; set; }
        Mock<IMoveValidator> Validator { get; set; }
        Mock<IMove> Move { get; set; }
        Mock<IPlayer> Player { get; set; }
        ValidMoveProvider Target { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Move = new Mock<IMove>();

            Validator = new Mock<IMoveValidator>();

            // NOTE: How cool is this!?
            Validator.SetupSequence(x => x.InvalidMove(It.IsAny<IMove>()))
                     .Returns(true)
                     .Returns(false);

            var player = new Mock<IPlayer>();
            player.Setup(x => x.GetMove()).Returns(Move.Object);
            Player = player;

            Tracker = new Mock<IMoveTracker>();
            Tracker.Setup(x => x.Next()).Returns(Player.Object);
            Tracker.Setup(x => x.GetCurrentPlayer()).Returns(Player.Object);

            Target = new ValidMoveProvider
                {
                    MoveTracker = Tracker.Object,
                    Validator = Validator.Object
                };
        }

        [TestClass]
        public class GetMove : ValidMoveProviderTest
        {
            [TestMethod]
            public void GetNextPlayerCalledOnce()
            {
                Target.GetMove();
                Tracker.Verify(x => x.Next(), Times.Once);
            }

            [TestMethod]
            public void GetMoveCalledTwice()
            {
                Target.GetMove();
                Player.Verify(x => x.GetMove(), Times.Exactly(2));
            }
        }
    }
}