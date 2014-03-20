using System;
using SolidTacToe.GameOverConditions;

namespace SolidTacToe.Exe.Rendering
{
    public class ConsoleNoMovesLeftCondition : NoMovesLeftCondition, IRenderable
    {
        public void Render()
        {
            Console.WriteLine("Aww, nobody won.");
        }
    }
}
