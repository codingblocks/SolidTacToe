using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    public class ValidMoveProvider : IMoveProvider
    {
        [Inject]
        public IMoveTracker MoveTracker { get; set; }

        [Inject]
        public IMoveValidator Validator { get; set; }

        public IMove GetMove()
        {
            var player = MoveTracker.GetCurrentPlayer();

            IMove move = null;
            while (move == null || Validator.InvalidMove(move))
            {
                move = player.GetMove();
            }

            MoveTracker.Next();

            return move;
        }
    }
}