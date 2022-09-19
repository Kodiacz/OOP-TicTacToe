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

        private readonly IRenderer renderer;
        private readonly GameInputs inputs;
        private IMark mark = new Mark();

        public TicTacToePlayerVsPlayerEngine(IRenderer renderer, GameInputs inputs)
        {
            this.Field = new Field(StandartTicTacToeFildRowAndColumn, StandartTicTacToeFildRowAndColumn);
            this.renderer = renderer;
            this.inputs = inputs;
            var players = this.inputs.GetPlayers().ToList();
            CreatePlayers(players);
        }

        public IField Field { get; private set; }

        public IPlayer FirstPlayer { get; private set; }

        public IPlayer SecondPlayer { get; private set; }

        public bool CheckForWinner(IPlayer player)
        {
            this.renderer.AddNewLine();

            if (EngineLogic.CheckRowForMatch(player.Symbol, this.Field) || EngineLogic.CheckColumnForMatch(player.Symbol, this.Field) ||
               EngineLogic.CheckRightLeftDiagonalForMatch(player.Symbol, this.Field) || EngineLogic.CheckLeftRightDiagonalForMatch(player.Symbol, this.Field))
            {
                this.renderer.AnnounceWinner(player);
                this.renderer.RenderField(this.Field);
                return true;
            }
            else if (this.Field.IsFull())
            {
                this.renderer.PrintDraw();
                this.renderer.RenderField(this.Field);
            }

            return false;
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

        public void Play()
        {
            int totalMovesOnField = this.Field.TotalRows * this.Field.TotalCols;

            for (int i = 0; i < totalMovesOnField; i++)
            {
                this.renderer.Clear();
                this.renderer.RenderField(this.Field);

                if (i % 2 == 0)
                {
                    renderer.PrintPlayerTurn(this.FirstPlayer);
                    Position position = inputs.GetPositinInput();
                    MoveFirstPlayer(position);

                    if (CheckForWinner(this.FirstPlayer))
                    {
                        break;
                    }
                }
                else
                {
                    renderer.PrintPlayerTurn(this.SecondPlayer);
                    Position position = inputs.GetPositinInput();
                    MoveSecondPlayer(position);

                    if (CheckForWinner(this.SecondPlayer))
                    {
                        break;
                    }
                }

            }
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
