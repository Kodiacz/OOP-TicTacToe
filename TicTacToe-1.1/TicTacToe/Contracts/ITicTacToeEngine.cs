using TicTacToe.Common;

namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        void CheckForWiner();

        void PrintFieldOnConsole();
    }
}
