using SolidTacToe.Definitions;

namespace SolidTacToe.Factories
{
    /// <summary>
    /// Responsible for creating and initializing anf empty Grid (so long as it's newable)
    /// </summary>
    public class EmptyGridFactory : IGridFactory
    {
        /// <summary>
        /// Create a new Grid of size "size", and initialize to Token.Empty
        /// </summary>
        public T Create<T>(int size) where T : IGrid, new()
        {
            var slots = new Token[size,size];
            for (var x = 0; x < size; x++)
            {
                for (var y = 0; y < size; y++)
                {
                    slots[x, y] = Token.Empty;
                }
            }

            return new T { Size = size, Slots = slots };
        }
    }
}
