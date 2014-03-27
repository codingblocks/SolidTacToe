using System.Collections.Generic;
using Ninject;
using SolidTacToe.Definitions;
using SolidTacToe.GameOverConditions;

namespace SolidTacToe.Factories
{
    /// <summary>
    /// Create the "normal" rules for a "normal" game of TicTacToe in the appropriate order
    /// </summary>
    public class StandardGameConditionsFactory : IGameConditionsFactory
    {
        [Inject]
        public IGrid Grid { get; set; }

        /// <summary>
        /// Returns the "normal" rules for a "normal" game of TicTacToe in the appropriate order
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IGameStatusCondition> Create()
        {
            return new List<IGameStatusCondition>
                {
                    new DiagonalWinCondition { Winner = Token.X, Grid = Grid },
                    new DiagonalWinCondition { Winner = Token.O, Grid = Grid },
                    new HorizontalWinCondition { Winner = Token.X, Grid = Grid },
                    new HorizontalWinCondition { Winner = Token.O, Grid = Grid },
                    new VerticalWinCondition { Winner = Token.X, Grid = Grid },
                    new VerticalWinCondition { Winner = Token.O, Grid = Grid },
                    new NoMovesLeftCondition { Grid = Grid },
                };
        }
    }
}
