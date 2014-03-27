namespace SolidTacToe.Definitions
{
    public interface IGameWonCondition : IGameStatusCondition
    {
        Token Winner { get; set; }
    }
}