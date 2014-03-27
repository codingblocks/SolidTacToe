using System.Collections.Generic;

namespace SolidTacToe.Definitions
{
    public interface IGameConditionsFactory
    {
        IEnumerable<IGameStatusCondition> Create();
    }
}