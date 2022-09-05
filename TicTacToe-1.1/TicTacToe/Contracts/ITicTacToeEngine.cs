using TicTacToe.Common;

namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        void MovePlayer(IPlayer player, Position position);

        void CheckForWiner();
    }
}
