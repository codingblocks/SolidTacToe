namespace SolidTacToe.Definitions
{
    public interface IGrid
    {
        int Size { get; set; }
        Token[,] Slots { get; set; }
        Token Get(int x, int y);
        void Set(Token t, int x, int y);
    }
}
