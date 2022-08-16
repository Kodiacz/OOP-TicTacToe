namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        void RenderMainMenu();

        void MovePlayer(IPlayer player);

        void CheckForWiner();
    }
}
