using System;
using SolidTacToe.Definitions;

namespace SolidTacToe.Exe.Rendering
{
    public static class GameStatusRenderExtensions
    {
        public static void Render(this IGameStatusCondition condition)
        {
            var gameWon = condition as IGameWonCondition;
            var message = gameWon != null
                ? string.Format("Yay, player {0} won diagonally!", gameWon.Token)
                : "Tie game, boo!";
            Console.WriteLine(message);
        }
    }
}
