using System;

namespace SolidTacToe.Moves
{
    [Serializable]
    public class NoMoveAvailableException : Exception
    {
        public NoMoveAvailableException(string message) : base(message) { }
    }
}