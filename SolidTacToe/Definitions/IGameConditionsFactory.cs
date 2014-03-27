using System.Collections.Generic;

namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Create a set of rules for a game of TicTacToe
    /// </summary>
    public interface IGameConditionsFactory
    {
        /// <summary>
        /// Returns a set of rules for a game of TicTacToe
        /// </summary>
        IEnumerable<IGameStatusCondition> Create();
    }
}