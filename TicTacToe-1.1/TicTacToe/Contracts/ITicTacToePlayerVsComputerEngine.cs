using TicTacToe.Common;

namespace TicTacToe.Contracts
{
    public interface ITicTacToePlayerVsComputerEngine : ITicTacToeEngine
    {
        IField Field { get; }

        IPlayer Player { get; }

        IPlayer NPC { get;  }

        void MovePlayer(Position position);

        void MoveNPC(Position position);
    }
}
