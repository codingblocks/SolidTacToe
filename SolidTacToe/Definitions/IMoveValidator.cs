namespace SolidTacToe.Definitions
{
    public interface IMoveValidator
    {
        bool InvalidMove(IMove move);
    }
}