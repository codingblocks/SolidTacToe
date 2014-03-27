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
    public class Bindings : NinjectModule
    {
        private static readonly IKernel Container;

        static Bindings()
        {
            Container = new StandardKernel();
            Container.Load(Assembly.GetExecutingAssembly());
        }

        public static T Get<T>()
        {
            return Container.Get<T>();
        }

        private const int GridSize = 3;

        public override void Load()
        {
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
                .ToMethod(x => Get<IGridFactory>().Create<ConsoleGrid>(GridSize))
                .InSingletonScope()
                .WithPropertyValue("Size", x => GridSize);

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