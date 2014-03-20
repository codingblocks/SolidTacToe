using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    public class MoveValidator : IMoveValidator
    {
        [Inject]
        public IGrid Grid { get; set; }
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

            if (Grid.Get(move.X, move.Y) != Token.Empty)
            {
                return true;
            }

            return false;
        }
    }
}
