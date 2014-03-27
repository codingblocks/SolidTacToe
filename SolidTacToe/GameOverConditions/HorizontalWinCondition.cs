using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.GameOverConditions
{
    public class HorizontalWinCondition : IGameStatusCondition, IGameWonCondition
    {
        public Token Winner { get; set; }

        [Inject]
        public IGrid Grid { get; set; }

        public bool ConditionMet()
        {
            for (var row = 0; row < Grid.Size; row++)
            {
                var met = true;
                for (var column = 0; column < Grid.Size; column++)
                {
                    met = met && Grid.Get(column, row) == Winner;
                }
                if (met)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
