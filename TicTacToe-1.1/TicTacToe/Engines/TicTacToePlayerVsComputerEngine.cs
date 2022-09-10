using TicTacToe.Common;
using TicTacToe.Contracts;
using TicTacToe.Renderers;

namespace TicTacToe.Engines
{
    public class TicTacToePlayerVsComputerEngine : ITicTacToePlayerVsComputerEngine
    {
        private GameInputs input;
        private IRenderer renderer;

        public TicTacToePlayerVsComputerEngine(IRenderer renderer, GameInputs input)
        {

        }

        public IField Field => throw new NotImplementedException();

        public IPlayer Player => throw new NotImplementedException();

        public IPlayer NPC => throw new NotImplementedException();

        public bool CheckForWiner(IPlayer player)
        {
            throw new NotImplementedException();
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
