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