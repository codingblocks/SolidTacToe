using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    /// <summary>
    /// Acts as a queue that keeps track of, and advances the current player.
    /// </summary>
    public class MoveTracker : IMoveTracker
    {
        public IPlayer PlayerOne { get; set; }
        public IPlayer PlayerTwo { get; set; }

        private int _turn;

        /// <summary>
        /// Changes the current player, and returns it. PlayerOne, PlayerTwo, PlayerOne etc.
        /// </summary>
        /// <returns></returns>
        public IPlayer Next()
        {
            return GetPlayer(++_turn);
        }

        /// <summary>
        /// Player that is currently attempting to move
        /// </summary>
        /// <returns></returns>
        public IPlayer GetCurrentPlayer()
        {
            return GetPlayer(_turn);
        }

        private IPlayer GetPlayer(int turn)
        {
            return (turn & 1) == 0 ? PlayerOne : PlayerTwo;
        }
    }
}
