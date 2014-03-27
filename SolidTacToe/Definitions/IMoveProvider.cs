namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Returns moves that are not guarunteed to be valid, unless otherwise stated by implementor.
    /// </summary>
    public interface IMoveProvider
    {
        /// <summary>
        /// Returns a move that is not guarunteed to be valid, unless otherwise stated by implementor.
        /// </summary>
        IMove GetMove();
    }
}