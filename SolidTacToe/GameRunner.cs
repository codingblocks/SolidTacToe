using System.Collections.Generic;
using System.Linq;
using Ninject;
using SolidTacToe.Definitions;
using SolidTacToe.Moves;

namespace SolidTacToe
{
    public class GameRunner : IGameRunner
    {
        [Inject]
        public IMoveProvider MoveProvider { get; set; }

        [Inject]
        public IEnumerable<IGameStatusCondition> GameOverConditions { get; set; }

        public IGameStatusCondition ExecuteTurn()
        {
            var status = GetStatus();
            if (status != null)
            {
                throw new NoMoveAvailableException("No more moves are available, the game is finished: " + status.GetType().Name);
            }
            var move = MoveProvider.GetMove();
            move.Apply();

            return GetStatus();
        }

        private IGameStatusCondition GetStatus()
        {
            return GameOverConditions.FirstOrDefault(x => x.ConditionMet());
        }
    }
}
