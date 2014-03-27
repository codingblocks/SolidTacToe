using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    /// <summary>
    /// Validates the given move for the given grid.
    /// </summary>
    public class MoveValidator : IMoveValidator
    {
        [Inject]
        public IGrid Grid { get; set; }

        /// <summary>
        /// True if move should NOT be made.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        public bool InvalidMove(IMove move)
        {
            if (move.X >= Grid.Size || move.X < 0)
            {
                return true;
            }

            if (move.Y >= Grid.Size || move.Y < 0)
            {
                return true;
            }

            return Grid.Get(move.X, move.Y) != Token.Empty;
        }
    }
}
