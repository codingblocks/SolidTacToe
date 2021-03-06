﻿using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.GameOverConditions
{
    /// <summary>
    /// Represents a game over condition where the game was won horizontally
    /// </summary>
    public class HorizontalWinCondition : IGameWonCondition
    {
        /// <summary>
        /// The winner of the game
        /// </summary>
        public Token Winner { get; set; }

        [Inject]
        public IGrid Grid { get; set; }

        /// <summary>
        /// True if game has been won horizontally
        /// </summary>
        /// <returns></returns>
        public bool ConditionMet()
        {
            for (var row = 0; row < Grid.Size; row++)
            {
                var met = true;
                for (var column = 0; column < Grid.Size; column++)
                {
                    met = met && Grid.Get(column, row) == Winner;
                }
                if (met)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
