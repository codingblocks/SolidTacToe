namespace SolidTacToe.Definitions
{
    public interface IGridFactory
    {
        T Create<T>(int size) where T : IGrid, new();
    }
}