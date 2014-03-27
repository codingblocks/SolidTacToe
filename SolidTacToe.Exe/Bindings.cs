using System.Reflection;
using Ninject;
using Ninject.Modules;
using SolidTacToe.Definitions;
using SolidTacToe.Exe.Definitions;
using SolidTacToe.Exe.Rendering;
using SolidTacToe.Factories;
using SolidTacToe.Moves;

namespace SolidTacToe.Exe
{
    /// <summary>
    /// Contains our IOC bindings that composes the pieces of our application.
    /// </summary>
    public class Bindings : NinjectModule
    {
        private static readonly IKernel Container;

        static Bindings()
        {
            Container = new StandardKernel();
            Container.Load(Assembly.GetExecutingAssembly());
        }

        /// <summary>
        /// Get an implementation of the specified interface
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Container.Get<T>();
        }

        /// <summary>
        /// Defines interface -> concrete mappings. Where the magic happens.
        /// </summary>
        public override void Load()
        {
            const int gridSize = 3;
            Bind<IMoveTracker>()
                .To<MoveTracker>()
                .InSingletonScope()
                .WithPropertyValue("PlayerOne", new HumanPlayer { Token = Token.X })
                .WithPropertyValue("PlayerTwo", new HumanPlayer { Token = Token.O });

            Bind<IMove>().To<Move>();
            Bind<IMoveValidator>().To<MoveValidator>();
            Bind<Token>().ToMethod(x => Get<IMoveTracker>().GetCurrentPlayer().Token);
            Bind<IGridFactory>().To<EmptyGridFactory>();

            Bind<IGridRenderable,IGrid>()
                .ToMethod(x => Get<IGridFactory>().Create<ConsoleGrid>(gridSize))
                .InSingletonScope()
                .WithPropertyValue("Size", x => gridSize);

            Bind<IGameConditionsFactory>()
                .To<StandardGameConditionsFactory>();

            Bind<IMoveProvider>().To<ValidMoveProvider>();

            Bind<IGameRunner>()
                .To<GameRunner>()
                .WithPropertyValue("MoveProvider", Get<IMoveProvider>())
                .WithPropertyValue("GameOverConditions", Get<IGameConditionsFactory>().Create());
        }
    }
}