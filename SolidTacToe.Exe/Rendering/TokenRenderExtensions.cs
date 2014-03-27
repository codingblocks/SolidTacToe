namespace SolidTacToe.Exe.Rendering
{
    /// <summary>
    /// Extension methods for rendering Token
    /// </summary>
    internal static class TokenRenderExtensions
    {
        // TODO Smelly! - Token probably should have been a class :(
        /// <summary>
        /// Returns string representation of a token
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
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