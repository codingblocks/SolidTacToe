using System.Collections.Generic;
using System.Reflection;
using Ninject;
using Ninject.Modules;
using SolidTacToe.Definitions;
using SolidTacToe.Exe.Rendering;
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

        public override void Load()
        {
            Bind<IMoveTracker>()
                .To<MoveTracker>()
                .InSingletonScope()
                .WithPropertyValue("PlayerOne", new HumanPlayerStrategy { Token = Token.X })
                .WithPropertyValue("PlayerTwo", new HumanPlayerStrategy { Token = Token.O });

            Bind<IMove>().To<Move>();
            Bind<IMoveValidator>().To<MoveValidator>();
            Bind<Token>().ToMethod(x => Get<IMoveTracker>().GetCurrentPlayer().Token);

            var slots = new[]
                {
                    Token.Empty, Token.Empty, Token.Empty,
                    Token.Empty, Token.Empty, Token.Empty,
                    Token.Empty, Token.Empty, Token.Empty,
                };

            Bind<IGridRenderable,IGrid>()
                .To<ConsoleGrid>()
                .InSingletonScope()
                .WithPropertyValue("Slots", x => slots)
                .WithPropertyValue("Size", x => 3);

            var conditions = new List<IGameStatusCondition>
                {
                    new ConsoleNoMovesLeftCondition { Grid = Get<IGrid>() },
                    new ConsoleDiagonalWinCondition {Token = Token.X, Grid = Get<IGrid>()},
                    new ConsoleDiagonalWinCondition {Token = Token.O, Grid = Get<IGrid>()},
                    new ConsoleHorizontalWinCondition {Token = Token.X, Grid = Get<IGrid>()},
                    new ConsoleHorizontalWinCondition {Token = Token.O, Grid = Get<IGrid>()},
                    new ConsoleVerticalWinCondition {Token = Token.X, Grid = Get<IGrid>()},
                    new ConsoleVerticalWinCondition {Token = Token.O, Grid = Get<IGrid>()},
                };

            Bind<IMoveProvider>().To<ValidMoveProvider>();

            Bind<IGameRunner>()
                .To<GameRunner>()
                .WithPropertyValue("MoveProvider", Get<IMoveProvider>())
                .WithPropertyValue("GameOverConditions", conditions);
        }
    }
}