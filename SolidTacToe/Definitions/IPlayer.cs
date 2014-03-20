namespace SolidTacToe.Definitions
{
    public interface IPlayer
    {
        Token Token { get; set; }
        IMove GetMove();
    }
}