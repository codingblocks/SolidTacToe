using SolidTacToe.Definitions;

namespace SolidTacToe
{
    /// <summary>
    /// Keeps track of the current state of the game. This class
    /// should only change if the underlying data structure changes.
    /// </summary>
    public class Grid : IGrid
    {
        public Token[] Slots { get;  set; }
        public int Size { get; set; }

        public Token Get(int i)
        {
            return Slots[i];
        }

        public Token Get(int x, int y)
        {
            var i = CoordsToIndex(x, y);
            return Get(i);
        }

        public void Set(Token t, int i)
        {
            Slots[i] = t;
        }

        public void Set(Token t, int x, int y)
        {
            var i = CoordsToIndex(x, y);
            Set(t, i);
        }

        private int CoordsToIndex(int x, int y)
        {
            return x + (y * Size);
        }
    }
}
