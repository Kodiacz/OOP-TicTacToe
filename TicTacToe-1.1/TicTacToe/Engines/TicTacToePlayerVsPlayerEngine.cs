namespace TicTacToe.Engines
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;
    using TicTacToe.Fields;
    using TicTacToe.Marks;
    using TicTacToe.Players;

    public class TicTacToePlayerVsPlayerEngine : ITicTacToePlayerVsPlayerEngine
    {
        private const int StandartTicTacToeFildRowAndColumn = 3;
        private const int StandartNumberOfPlayers = 2;

        private readonly IRenderer renderer;
        private readonly GameInputs inputs;

        public TicTacToePlayerVsPlayerEngine(IRenderer renderer, GameInputs inputs)
        {
            this.Field = new Field(StandartTicTacToeFildRowAndColumn, StandartTicTacToeFildRowAndColumn);
            this.renderer = renderer;
            this.inputs = inputs;
            var players = inputs.GetPlayers(StandartNumberOfPlayers).ToList();
            this.SecondPlayer = players[0];
            this.FirstPlayer = players[1];
        }

        public IField Field { get; private set; }

        public IPlayer FirstPlayer { get; private set; }

        public IPlayer SecondPlayer { get; private set; }

        public void CheckForWiner()
        {
            throw new NotImplementedException();
        }

        public void MovePlayer(IPlayer player, Position position)
        {
            IMark mark = new Mark();
            mark.Symbol = player.Symbol;
            this.Field.MarkSymbol(mark, position);
        }

        private void CreatePlayers()
        {

        }
    }
}
