using System;
using SolidTacToe.GameOverConditions;

namespace SolidTacToe.Exe.Rendering
{
    public class ConsoleHorizontalWinCondition : HorizontalWinCondition, IRenderable
    {
        public void Render()
        {
            Console.WriteLine("Yay, player {0} won horizontally!");
        }
    }
}
