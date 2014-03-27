using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    /// <summary>
    /// Returns moves that ARE guarunteed to be valid, according to it's validator.
    /// </summary>
    public class ValidMoveProvider : IMoveProvider
    {
        [Inject]
        public IMoveTracker MoveTracker { get; set; }

        [Inject]
        public IMoveValidator Validator { get; set; }

        /// <summary>
        /// Returns a move that is guarunteed to be valid, according to it's validator.
        /// </summary>
        /// <returns></returns>
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