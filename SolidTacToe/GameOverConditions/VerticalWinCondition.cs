using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.GameOverConditions
{
    public class VerticalWinCondition : IGameStatusCondition, IGameWonCondition
    {
        public Token Winner { get; set; }

        [Inject]
        public IGrid Grid { get; set; }

        public bool ConditionMet()
        {
            for (var column = 0; column < Grid.Size; column++)
            {
                var met = true;
                for (var row = 0; row < Grid.Size; row++)
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
