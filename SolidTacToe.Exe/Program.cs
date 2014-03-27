using System;
using SolidTacToe.Definitions;
using SolidTacToe.Exe.Definitions;
using SolidTacToe.Exe.Rendering;

namespace SolidTacToe.Exe
{
    /// <summary>
    /// Starting point of the application
    /// </summary>
    class Program
    {
        /// <summary>
        /// Runs and renders the game to screen
        /// </summary>
        /// <param name="args"></param>
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

            condition.Render();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}