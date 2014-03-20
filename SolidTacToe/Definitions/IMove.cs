namespace SolidTacToe.Definitions
{
    public interface IMove
    {
        Token Token { get; set; }
        int X { get; set; }
        int Y { get; set; }
        void Apply();
    }
}