using System.Collections.Generic;
using Ninject;
using SolidTacToe.Definitions;
using SolidTacToe.GameOverConditions;

namespace SolidTacToe.Factories
{
    public class StandardGameConditionsFactory : IGameConditionsFactory
    {
        [Inject]
        public IGrid Grid { get; set; }

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
