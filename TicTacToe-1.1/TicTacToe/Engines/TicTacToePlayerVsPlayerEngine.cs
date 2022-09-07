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
        private IMark mark = new Mark();

        public TicTacToePlayerVsPlayerEngine(IRenderer renderer, GameInputs inputs)
        {
            this.Field = new Field(StandartTicTacToeFildRowAndColumn, StandartTicTacToeFildRowAndColumn);
            this.renderer = renderer;
            this.inputs = inputs;
            var players = inputs.GetPlayers(StandartNumberOfPlayers).ToList();
            CreatePlayers(players);
        }

        public IField Field { get; private set; }

        public IPlayer FirstPlayer { get; private set; }

        public IPlayer SecondPlayer { get; private set; }

        public void CheckForWiner()
        {
            throw new NotImplementedException();
        }

        public void MoveFirstPlayer(Position position)
        {
            this.mark.Symbol = this.FirstPlayer.Symbol;

            ObjectValidator.IsMarked(this.Field, position);

            this.Field.MarkSymbol(mark, position);
        }

        public void MoveSecondPlayer(Position position)
        {
            this.mark.Symbol = this.FirstPlayer.Symbol;

            ObjectValidator.IsMarked(this.Field, position);

            this.Field.MarkSymbol(mark, position);
        }

        public void PrintFieldOnConsole()
        {
            renderer.RenderField(this.Field);
        }

        private void CreatePlayers(List<IPlayer> players)
        {
            this.FirstPlayer = players[0];
            this.SecondPlayer = players[1];
        }
    }
}
