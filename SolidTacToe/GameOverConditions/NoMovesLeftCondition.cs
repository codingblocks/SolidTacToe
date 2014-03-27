using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.GameOverConditions
{
    /// <summary>
    /// Represents a game over condition where there are no more moves left in the game. You need to be careful to check this condition after all win conditions.
    /// </summary>
    public class NoMovesLeftCondition : IGameTiedCondition
    {
        [Inject]
        public IGrid Grid { get; set; }

        /// <summary>
        /// True if there are no more moves left in the game
        /// </summary>
        /// <returns></returns>
        public bool ConditionMet()
        {
            for (var x = 0; x < Grid.Size; x++)
            {
                for (var y = 0; y < Grid.Size; y++)
                {
                    if (Grid.Get(x,y) == Token.Empty)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}