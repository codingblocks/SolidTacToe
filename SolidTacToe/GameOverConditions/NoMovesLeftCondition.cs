using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.GameOverConditions
{
    public class NoMovesLeftCondition : IGameStatusCondition, IGameTiedCondition
    {
        [Inject]
        public IGrid Grid { get; set; }

        public bool ConditionMet()
        {
            var max = Grid.Size*Grid.Size;
            for (var i = 0; i < max; i++)
            {
                if (Grid.Get(i) == Token.Empty)
                {
                    return false;
                }
            }
            return true;
        }
    }
}