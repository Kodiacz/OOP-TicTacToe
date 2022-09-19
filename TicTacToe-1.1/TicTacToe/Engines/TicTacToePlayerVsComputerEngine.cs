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

        private IField field;
        private IPlayer player;
        private IPlayer npc;

        public TicTacToePlayerVsComputerEngine(IRenderer renderer, GameInputs input)
        {
            this.field = new Field(GlobalConstants.StandartRowLengthOnField, GlobalConstants.StandartRowLengthOnField);
            this.renderer = renderer;
            this.input = input;
            var player = input.GetPlayer();
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
            Random random = new Random();


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
