namespace SolidTacToe.Exe.Rendering
{
    internal static class TokenRenderExtensions
    {
        // TODO Smelly! - Token probably should have been a class
        internal static string GetString(this Token t)
        {
            var c = " - ";
            switch (t)
            {
                case Token.X:
                    c = " X ";
                    break;
                case Token.O:
                    c = " O ";
                    break;
            }
            return c;
        }
    }
}