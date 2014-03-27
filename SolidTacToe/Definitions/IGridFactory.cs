namespace SolidTacToe.Definitions
{
    /// <summary>
    /// Responsible for creating grids initialized to a particular state
    /// </summary>
    public interface IGridFactory
    {
        /// <summary>
        /// Creates any IGrid,new and initializes to a particular state
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="size"></param>
        /// <returns></returns>
        T Create<T>(int size) where T : IGrid, IGridMatrix, new();
    }
}