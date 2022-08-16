namespace TicTacToe.Engines
{
    using TicTacToe.Contracts;
    using TicTacToe.Fields;
    using TicTacToe.Players;

    public class TicTacToePlayerVsPlayerEngine
    {
        private const int StandartTicTacToeFildRowAndColumn = 3;

        public TicTacToePlayerVsPlayerEngine(IPlayer firstPlayer, IPlayer secondPlayer, string firstPlayerName, string secondPlayerName)
        {
            this.Field = new Field(StandartTicTacToeFildRowAndColumn, StandartTicTacToeFildRowAndColumn);
            this.FirstPlayer = new Player(firstPlayerName);
            this.SecondPlayer = new Player(secondPlayerName);
        }

        public IField Field { get; private set; }

        public IPlayer FirstPlayer { get; private set;  }

        public IPlayer SecondPlayer { get; private set;  }
    }
}
