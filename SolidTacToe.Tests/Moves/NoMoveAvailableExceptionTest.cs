using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolidTacToe.Moves;

namespace SolidTacToe.Tests.Moves
{
    [TestClass]
    public class NoMoveAvailableExceptionTest
    {
        [TestMethod]
        public void ConstructorSetsMessage()
        {
            const string expected = "test message";
            var exception = new NoMoveAvailableException(expected);
            Assert.AreEqual(expected, exception.Message);
        }
    }
}
