using TicTacToe.Common;
using TicTacToe.Contracts;
using TicTacToe.Fields;
using TicTacToe.Marks;
using TicTacToe.Players;
using TicTacToe.Renderers;

namespace TicTacToe.Engines
{
    public class TicTacToePlayerVsComputerEngine : ITicTacToePlayerVsComputerEngine
    {
        private GameInputs input;
        private IRenderer renderer;
        private IMark mark;

        private IField field;
        private IPlayer player;
        private IPlayer npc;

        public TicTacToePlayerVsComputerEngine(IRenderer renderer, GameInputs input)
        {
            this.mark = new Mark();
            this.field = new Field(GlobalConstants.StandartRowLengthOnField, GlobalConstants.StandartRowLengthOnField);
            this.renderer = renderer;
            this.input = input;
            var player = input.GetPlayer();
            CreatePlayers(player);
        }

        public bool CheckForWinner(IPlayer player)
        {
            this.renderer.AddNewLine();

            if (EngineLogic.CheckRowForMatch(player.Symbol, this.field) || EngineLogic.CheckColumnForMatch(player.Symbol, this.field) ||
               EngineLogic.CheckRightLeftDiagonalForMatch(player.Symbol, this.field) || EngineLogic.CheckLeftRightDiagonalForMatch(player.Symbol, this.field))
            {
                this.renderer.AnnounceWinner(player);
                this.renderer.RenderField(this.field);
                return true;
            }
            else if (this.field.IsFull())
            {
                this.renderer.PrintDraw();
                this.renderer.RenderField(this.field);
            }

            return false;
        }

        public void MoveNPC(Position position)
        {
            this.mark.Symbol = this.npc.Symbol;

            ObjectValidator.IsMarked(this.field, position);

            this.field.MarkSymbol(this.mark, position);
        }

        public void MovePlayer(Position position)
        {
            this.mark.Symbol = this.player.Symbol;

            ObjectValidator.IsMarked(this.field, position);

            this.field.MarkSymbol(this.mark, position);
        }

        public void Play()
        {
            int totalMovesOnField = this.field.TotalRows * this.field.TotalCols;
            int isEven = player.Symbol == Symbol.X ? 0 : 1;

            for (int i = 0; i < totalMovesOnField; i++)
            {
                this.renderer.Clear();
                this.renderer.RenderField(this.field);

                Position position;

                if (i % 2 == isEven)
                {
                    position = input.GetPositinInput();

                    MovePlayer(position);

                    if (CheckForWinner(this.player))
                    {
                        break;
                    }
                }
                else
                {
                    position = GenerateNPCPosition();

                    MoveNPC(position);

                    if (CheckForWinner(this.npc))
                    {
                        break;
                    }
                }
            }
        }

        public void PrintFieldOnConsole()
        {
            throw new NotImplementedException();
        }

        private void CreatePlayers(IPlayer player)
        {
            this.player = player;

            Symbol npcSymbol = player.Symbol == Symbol.X ? Symbol.O : Symbol.X;

            this.npc = new Player("Computer", npcSymbol);
        }

        private Position GenerateNPCPosition()
        {
            Random randomRow = new Random();
            Random randomCol = new Random();
            Position position;

            while (true)
            {
                try
                {
                    int row = randomRow.Next(1, 4);
                    char col = (char)randomCol.Next(97, 100);

                    position = new Position(row, col);

                    ObjectValidator.IsMarked(this.field, position);

                    return position;
                }
                catch (Exception)
                {
                    Console.Write("...");
                    Console.Clear();
                }
            }
        }
    }
}
