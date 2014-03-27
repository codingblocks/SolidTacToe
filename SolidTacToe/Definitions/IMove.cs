namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Responsible for changing the state of the game.
    /// </summary>
    public interface IMove
    {
        /// <summary>
        /// Represents the player that is making the move
        /// </summary>
        Token Token { get; set; }

        /// <summary>
        /// The column to which the move will be applied
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// The row to which the move will be applied
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Actually make the move, change the state of the IGrid
        /// </summary>
        void Apply();
    }
}