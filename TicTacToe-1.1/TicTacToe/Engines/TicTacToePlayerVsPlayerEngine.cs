namespace TicTacToe.Engines
{
    using TicTacToe.Contracts;
    using TicTacToe.Fields;
    using TicTacToe.Players;

    public class TicTacToePlayerVsPlayerEngine : ITicTacToeEngine
    {
        private const int StandartTicTacToeFildRowAndColumn = 3;

        public void Initializer(IPlayer firstPlayer, IPlayer secondPlayer, string firstPlayerName, string secondPlayerName)
        {
            this.Field = new Field(StandartTicTacToeFildRowAndColumn, StandartTicTacToeFildRowAndColumn);
            this.FirstPlayer = new Player(firstPlayerName);
            this.SecondPlayer = new Player(secondPlayerName);
        }

        public IField Field { get; private set; }

        public IPlayer FirstPlayer { get; set;  }

        public IPlayer SecondPlayer { get; set;  }
    }
}
