using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    public class Move : IMove
    {
        [Inject]
        public IGrid Grid { get; set; }

        [Inject]
        public Token Token { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public void Apply()
        {
            Grid.Set(Token,X,Y);
        }
    }
}
