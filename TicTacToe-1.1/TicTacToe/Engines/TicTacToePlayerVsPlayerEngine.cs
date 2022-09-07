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
            this.mark.Symbol = this.SecondPlayer.Symbol;

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

        private bool CheckRowForMatch()
        {
            IMark[,] field = this.Field.GetField;

            for (int row = 0; row < this.Field.TotalRows; row++)
            {

                if (field[row, 0].Symbol == field[row, 1].Symbol && field[row, 0].Symbol == field[row, 2].Symbol)
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckColumnForMatch()
        {
            IMark[,] field = this.Field.GetField;

            for (int col = 0; col < this.Field.TotalCols; col++)
            {
                if (field[0, col].Symbol == field[1, col].Symbol && field[0, col].Symbol == field[2, col].Symbol)
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckLeftRightDiagonalForMatch()
        {
            IMark[,] field = this.Field.GetField;

            if (field[0, 0].Symbol == field[1, 1].Symbol && field[0, 0].Symbol == field[2, 2].Symbol)
            {
                return true;
            }

            return false;
        }

        private bool CheckRightLeftDiagonalForMatch()
        {
            IMark[,] field = this.Field.GetField;

            if (field[0, 2].Symbol == field[1, 1].Symbol && field[0, 2].Symbol == field[2, 0].Symbol)
            {
                return true;
            }

            return false;
        }
    }
}
