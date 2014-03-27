namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Implementation details some kinds of IGrid that are useful for initializing
    /// </summary>
    public interface IGridMatrix
    {
        /// <summary>
        /// The underlying data structure upon which this particular kind of grid depends on
        /// </summary>
        Token[,] Slots { set; }
    }
}