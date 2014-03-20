namespace SolidTacToe.Definitions
{
    public interface IMoveTracker
    {
        /// <summary>
        /// Returns PlayerStrategyOne, PlayerStrategyTwo, PlayerStrategyOne etc
        /// </summary>
        /// <returns></returns>
        IPlayer Next();

        IPlayer GetCurrentPlayer();
    }
}