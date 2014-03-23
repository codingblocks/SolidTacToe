namespace SolidTacToe.Definitions
{
    public interface IGrid
    {
        int Size { get; }
        Token Get(int x, int y);
        void Set(Token t, int x, int y);
    }
}
