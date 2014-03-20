using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SolidTacToe.Definitions;
using SolidTacToe.Moves;

namespace SolidTacToe.Tests
{
    [TestClass]
    public class GameRunnerTest
    {
        public Mock<IMove> Move { get; set; }
        public Mock<IMoveProvider> MoveProvider { get; set; }
        public IEnumerable<IGameStatusCondition> Conditions { get; set; }
        public GameRunner Target { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Move = new Mock<IMove>();
            MoveProvider = new Mock<IMoveProvider>();
            MoveProvider.Setup(x => x.GetMove()).Returns(Move.Object);

            var condition = new Mock<IGameStatusCondition>();
            condition.SetupSequence(x => x.ConditionMet())
                .Returns(false)
                .Returns(true)
                .Returns(true)
                .Returns(true);

            Conditions = new List<IGameStatusCondition> {condition.Object};

            Target = new GameRunner
                {
                    GameOverConditions = Conditions,
                    MoveProvider = MoveProvider.Object
                };
        }

        [TestClass]
        public class ExecuteTurn : GameRunnerTest
        {
            [TestMethod]
            [ExpectedException(typeof(NoMoveAvailableException))]
            public void ExceptionWhenGameOver()
            {
                Target.ExecuteTurn();
                Target.ExecuteTurn();
            }

            [TestMethod]
            public void MoveApplied()
            {
                Target.ExecuteTurn();
                Move.Verify(x => x.Apply(),Times.Once);
            }

            [TestMethod]
            public void SecondStatusReturned()
            {
                var status = Target.ExecuteTurn();
                Assert.IsNotNull(status);
            }
        }
    }
}
