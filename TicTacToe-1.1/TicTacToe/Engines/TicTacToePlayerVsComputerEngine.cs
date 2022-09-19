using TicTacToe.Common;
using TicTacToe.Contracts;
using TicTacToe.Fields;
using TicTacToe.Renderers;

namespace TicTacToe.Engines
{
    public class TicTacToePlayerVsComputerEngine : ITicTacToePlayerVsComputerEngine
    {
        private GameInputs input;
        private IRenderer renderer;

        public TicTacToePlayerVsComputerEngine(IRenderer renderer, GameInputs input)
        {
            this.Field = new Field(GlobalConstants.StandartRowLengthOnField, GlobalConstants.StandartRowLengthOnField);
            this.renderer = renderer;
            this.input = input;
        }

        public IField Field { get; private set; }

        public IPlayer Player { get; private set; }

        public IPlayer NPC { get; private set; }

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

        public void MoveNPC(Position position)
        {
            throw new NotImplementedException();
        }

        public void MovePlayer(Position position)
        {
            throw new NotImplementedException();
        }

        public void PrintFieldOnConsole()
        {
            throw new NotImplementedException();
        }
    }
}
