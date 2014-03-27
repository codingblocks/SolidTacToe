namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Responsible for actually executing the game
    /// </summary>
    public interface IGameRunner
    {
        /// <summary>
        /// Advances the game one turn
        /// </summary>
        /// <returns></returns>
        IGameStatusCondition ExecuteTurn();
    }
}