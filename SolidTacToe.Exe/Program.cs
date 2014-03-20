using System;
using SolidTacToe.Definitions;
using SolidTacToe.Exe.Rendering;

namespace SolidTacToe.Exe
{
    class Program
    {
        static void Main(string[] args)
        {
            IGameStatusCondition condition = null;
            var grid = Bindings.Get<IGridRenderable>();

            while(condition == null)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Welcome to SolidTacToe!");

                grid.Render();

                condition = Bindings.Get<IGameRunner>().ExecuteTurn();
            }

            var gameOver = (IRenderable)condition;
            gameOver.Render();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
