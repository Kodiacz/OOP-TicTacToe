using TicTacToe.Common;

namespace TicTacToe.Contracts
{
    public interface ITicTacToePlayerVsComputerEngine : ITicTacToeEngine
    {
        void MovePlayer(Position position);

        void MoveNPC(Position position);
    }
}
