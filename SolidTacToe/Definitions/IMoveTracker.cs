namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Acts as a queue that keeps track of, and advances the current player.
    /// </summary>
    public interface IMoveTracker
    {
        /// <summary>
        /// Changes the current player, and returns it. PlayerOne, PlayerTwo, PlayerOne etc.
        /// </summary>
        /// <returns></returns>
        IPlayer Next();

        /// <summary>
        /// Player that is currently attempting to move
        /// </summary>
        /// <returns></returns>
        IPlayer GetCurrentPlayer();
    }
}