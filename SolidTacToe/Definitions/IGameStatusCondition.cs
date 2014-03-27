namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Represents a game state condition, such as when the game is tied or won.
    /// </summary>
    public interface IGameStatusCondition
    {
        /// <summary>
        /// True if this status is valid given the current game
        /// </summary>
        /// <returns></returns>
        bool ConditionMet();
    }
}