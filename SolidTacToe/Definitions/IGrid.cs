namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Contains the state of a TicTacToe game.
    /// </summary>
    public interface IGrid
    {
        /// <summary>
        /// Represents the width (and height) of a square TicTacToe grid
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// Return a token
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        Token Get(int x, int y);

        /// <summary>
        /// Set a token
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void Set(Token t, int x, int y);
    }
}
