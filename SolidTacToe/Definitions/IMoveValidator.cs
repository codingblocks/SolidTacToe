namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Validates the given move for a specific IGrid.
    /// </summary>
    public interface IMoveValidator
    {
        /// <summary>
        /// True if move should NOT be made.
        /// </summary>
        /// <param name="move"></param>
        /// <returns></returns>
        bool InvalidMove(IMove move);
    }
}