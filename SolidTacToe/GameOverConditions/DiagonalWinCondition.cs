﻿using Ninject;
using SolidTacToe.Definitions;

namespace SolidTacToe.GameOverConditions
{
    public class DiagonalWinCondition : IGameStatusCondition, IGameWonCondition
    {
        public Token Token { get; set; }

        [Inject]
        public IGrid Grid { get; set; }

        public bool ConditionMet()
        {
            var met = true;
            for (var i = 0; i < Grid.Size; i++)
            {
                if (Grid.Get(i, i) != Token)
                {
                    met = false;
                    break;
                }
            }

            if (met)
            {
                return true;
            }

            met = true;
            var j = 0;
            for (var i = Grid.Size - 1; i >= 0; i--)
            {
                if (Grid.Get(j, i) != Token)
                {
                    met = false;
                    break;
                }
                j++;
            }

            return met;
        }
    }
}