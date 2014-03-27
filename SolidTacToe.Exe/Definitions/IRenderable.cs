namespace SolidTacToe.Exe.Definitions
{
    /// <summary>
    /// Represents objects that know how to render themselves to screen
    /// </summary>
    internal interface IRenderable
    {
        /// <summary>
        /// Render state to screen in a human friendly-ish manner
        /// </summary>
        void Render();
    }
}