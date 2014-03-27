using System;

namespace SolidTacToe.Moves
{
    /// <summary>
    /// To be used when there are no more moves to make, the game is over.
    /// </summary>
    [Serializable]
    public class NoMoveAvailableException : Exception
    {
        public NoMoveAvailableException(string message) : base(message) { }
    }
}