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
            Position position = new Position(1, 'a');
            GameInputs input = new GameInputs();
            IRenderer renderer = new ConsoleRenderer();
            ITicTacToePlayerVsPlayerEngine engine = new TicTacToePlayerVsPlayerEngine(renderer, input);
            engine.MoveFirstPlayer(position);
            IMark[,] secondField = field.GetField;
            secondField[0, 1].Symbol = Symbol.O;

            renderer.RenderMainMenu();
            engine.PrintFieldOnConsole();
            Console.ReadLine();

            engine.PrintFieldOnConsole();
        }
    }
}

