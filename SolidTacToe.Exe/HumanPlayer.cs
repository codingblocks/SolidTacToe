using System;
using SolidTacToe.Definitions;

namespace SolidTacToe.Exe
{
    internal class HumanPlayerStrategy : IPlayer
    {
        public Token Token { get; set; }
        public IMove GetMove()
        {
            var move = Bindings.Get<IMove>();
            while (true)
            {
                Console.WriteLine("Please enter a coordinate. 0,0 for example");
                var line = Console.ReadLine();
                try
                {                   
                    var parts = line.Split(',');
                    move.X = int.Parse(parts[0]);
                    move.Y = int.Parse(parts[1]);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid format, yo. Try something like 2,2");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid range, yo. Try numbers between 0 and 2: ");
                }
            }
            return move;
        }

    }
}
