namespace TicTacToe
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;
    using TicTacToe.Engines;
    using TicTacToe.Fields;
    using TicTacToe.Marks;
    using TicTacToe.Players;
    using TicTacToe.Renderers;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IField field = new Field(3, 3);
            GameInputs input = new GameInputs();
            IRenderer renderer = new ConsoleRenderer();
            ITicTacToePlayerVsPlayerEngine engine = new TicTacToePlayerVsPlayerEngine(renderer, input);
            renderer.RenderMainMenu();
            engine.PrintFieldOnConsole();
            Position position = input.GetPositinInput();
            engine.MoveFirstPlayer(position);

            Console.ReadLine();

            engine.PrintFieldOnConsole();
        }
    }
}

