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
            engine.MovePlayer(player, position);

            renderer.RenderMainMenu();
            renderer.RenderField(field);
            Console.ReadLine();
            GameInputs inputs = new GameInputs();
            var players = inputs.GetPlayers(2).ToList();

            Console.WriteLine(players[0].Symbol);
            Console.WriteLine(players[1].Symbol);

            renderer.RenderField(field);
        }
    }
}

