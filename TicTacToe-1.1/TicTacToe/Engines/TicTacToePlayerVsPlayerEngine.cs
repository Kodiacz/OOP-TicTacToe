namespace TicTacToe.Engines
{
    using TicTacToe.Contracts;
    using TicTacToe.Fields;
    using TicTacToe.Players;

    public class TicTacToePlayerVsPlayerEngine : ITicTacToePlayerVsPlayerEngine
    {
        private const int StandartTicTacToeFildRowAndColumn = 3;

        private readonly IRenderer renderer;

        public TicTacToePlayerVsPlayerEngine(IPlayer firstPlayer, IPlayer secondPlayer, string firstPlayerName, string secondPlayerName, IRenderer renderer)
        {
            this.Field = new Field(StandartTicTacToeFildRowAndColumn, StandartTicTacToeFildRowAndColumn);
            this.FirstPlayer = new Player(firstPlayerName);
            this.SecondPlayer = new Player(secondPlayerName);
            this.renderer = renderer;
        }

        public IField Field { get; private set; }

        public IPlayer FirstPlayer { get; private set;  }

        public IPlayer SecondPlayer { get; private set;  }

        public void CheckForWiner()
        {
            throw new NotImplementedException();
        }

        public void MovePlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }
    }
}
