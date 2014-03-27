namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Represents a game over condition where the game was won
    /// </summary>
    public interface IGameWonCondition : IGameStatusCondition
    {
        /// <summary>
        /// The winner of the game
        /// </summary>
        Token Winner { get; set; }
    }
}