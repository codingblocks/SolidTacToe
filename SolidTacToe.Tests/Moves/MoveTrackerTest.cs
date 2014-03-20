using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidTacToe.Definitions;
using SolidTacToe.Moves;

namespace SolidTacToe.Tests.Moves
{
    [TestClass]
    public class MoveTrackerTest
    {
        [TestClass]
        public class Next
        {
            IPlayer PlayerOne { get; set; }
            IPlayer PlayerTwo { get; set; }
            MoveTracker Target { get; set; }

            [TestInitialize]
            public void Initialize()
            {
                PlayerOne = new Mock<IPlayer>().Object;
                PlayerTwo = new Mock<IPlayer>().Object;

                Target = new MoveTracker
                {
                    PlayerOne = PlayerOne,
                    PlayerTwo = PlayerTwo
                };
            }

            [TestMethod]
            public void PlayerOneGoesFirst()
            {
                Assert.AreEqual(PlayerOne, Target.GetCurrentPlayer());
            }

            [TestMethod]
            public void PlayerTwoGoesSecond()
            {
                Assert.AreEqual(PlayerTwo, Target.Next());
            }

            [TestMethod]
            public void PlayerOneGoesThird()
            {
                Target.Next();
                Assert.AreEqual(PlayerOne, Target.Next());
            }
        }
    }
}
