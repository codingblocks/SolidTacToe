namespace SolidTacToe.Definitions
{
    public interface IGameWonCondition : IGameStatusCondition
    {
        Token Token { get; set; }
    }
}