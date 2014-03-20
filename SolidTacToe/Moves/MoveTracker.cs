using SolidTacToe.Definitions;

namespace SolidTacToe.Moves
{
    /// <summary>
    /// Toggles between players
    /// </summary>
    public class MoveTracker : IMoveTracker
    {
        public IPlayer PlayerOne { get; set; }
        public IPlayer PlayerTwo { get; set; }

        private int _turn;

        /// <summary>
        /// Returns PlayerStrategyOne, PlayerStrategyTwo, PlayerStrategyOne etc
        /// </summary>
        /// <returns></returns>
        public IPlayer Next()
        {
            return GetPlayer(++_turn);
        }

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
