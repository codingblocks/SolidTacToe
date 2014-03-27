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
                    new DiagonalWinCondition { Token = Token.X, Grid = Grid },
                    new DiagonalWinCondition { Token = Token.O, Grid = Grid },
                    new HorizontalWinCondition { Token = Token.X, Grid = Grid },
                    new HorizontalWinCondition { Token = Token.O, Grid = Grid },
                    new VerticalWinCondition { Token = Token.X, Grid = Grid },
                    new VerticalWinCondition { Token = Token.O, Grid = Grid },
                    new NoMovesLeftCondition { Grid = Grid },
                };
        }
    }
}
