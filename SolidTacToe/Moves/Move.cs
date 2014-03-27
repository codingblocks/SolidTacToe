using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    /// <summary>
    /// Simple implementation of IMove. Changes the state of the IGrid when applied.
    /// </summary>
    public class Move : IMove
    {
        /// <summary>
        /// The IGrid that will modified by the move
        /// </summary>
        [Inject]
        public IGrid Grid { get; set; }

        /// <summary>
        /// Represents the player that is making the move
        /// </summary>
        [Inject]
        public Token Token { get; set; }

        /// <summary>
        /// The column to which the move will be applied
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// The row to which the move will be applied
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Actually make the move, change the state of the IGrid
        /// </summary>
        public void Apply()
        {
            Grid.Set(Token,X,Y);
        }
    }
}
