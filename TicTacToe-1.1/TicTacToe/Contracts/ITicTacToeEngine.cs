using TicTacToe.Common;

namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        bool CheckForWinner(IPlayer player);

        void PrintFieldOnConsole();

        public void Play();
    }
}
