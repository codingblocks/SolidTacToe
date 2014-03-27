using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.GameOverConditions
{
    /// <summary>
    /// Represents a game over condition where the game was won diagonally
    /// </summary>
    public class DiagonalWinCondition : IGameWonCondition
    {
        /// <summary>
        /// The winner of the game
        /// </summary>
        public Token Winner { get; set; }

        [Inject]
        public IGrid Grid { get; set; }

        /// <summary>
        /// True if game has been won diagonally
        /// </summary>
        /// <returns></returns>
        public bool ConditionMet()
        {
            var met = true;
            for (var i = 0; i < Grid.Size; i++)
            {
                if (Grid.Get(i, i) != Winner)
                {
                    met = false;
                    break;
                }
            }

            if (met)
            {
                return true;
            }

            met = true;
            var j = 0;
            for (var i = Grid.Size - 1; i >= 0; i--)
            {
                if (Grid.Get(j, i) != Winner)
                {
                    met = false;
                    break;
                }
                j++;
            }

            return met;
        }
    }
}
