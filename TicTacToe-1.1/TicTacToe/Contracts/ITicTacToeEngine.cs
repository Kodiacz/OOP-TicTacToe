using TicTacToe.Common;

namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        bool CheckForWiner(IPlayer player);

        void PrintFieldOnConsole();
    }
}
