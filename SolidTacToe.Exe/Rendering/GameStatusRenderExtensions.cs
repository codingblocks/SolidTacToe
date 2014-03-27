using System;
using SolidTacToe.Definitions;

namespace SolidTacToe.Exe.Rendering
{
    /// <summary>
    /// Extension methods for rendering IGameStatusCondition
    /// </summary>
    public static class GameStatusRenderExtensions
    {
        /// <summary>
        /// Render an IGameStatusCondition to screen
        /// </summary>
        /// <param name="condition"></param>
        public static void Render(this IGameStatusCondition condition)
        {
            var gameWon = condition as IGameWonCondition;
            var message = gameWon != null
                ? string.Format("Yay, player {0} won diagonally!", gameWon.Winner)
                : "Tie game, boo!";
            Console.WriteLine(message);
        }
    }
}
