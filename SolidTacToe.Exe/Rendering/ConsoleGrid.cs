using System;
using System.Text;
using SolidTacToe.Exe.Definitions;

namespace SolidTacToe.Exe.Rendering
{
    /// <summary>
    /// Grid that knows how to render itself to screen
    /// </summary>
    internal class ConsoleGrid : Grid, IGridRenderable
    {
        /// <summary>
        /// Write state out to screen in a human friendly-ish manner
        /// </summary>
        public void Render()
        {
            var builder = new StringBuilder();
            for (var y = 0; y < Size; y++)
            {
                for (var x = 0; x < Size; x++)
                {
                    var t = Get(x, y);
                    builder.Append(t.GetString());
                }
                builder.Append(Environment.NewLine);
            }
            Console.WriteLine(builder.ToString());
        }
    }
}
