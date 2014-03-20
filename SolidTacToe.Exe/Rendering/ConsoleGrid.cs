using System;
using System.Text;

namespace SolidTacToe.Exe.Rendering
{
    internal class ConsoleGrid : Grid, IGridRenderable
    {
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
