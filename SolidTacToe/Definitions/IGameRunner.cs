namespace SolidTacToe.Definitions
{
    public interface IGameRunner
    {
        IGameStatusCondition ExecuteTurn();
    }
}