namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        void MovePlayer(IPlayer player);

        void CheckForWiner();
    }
}
