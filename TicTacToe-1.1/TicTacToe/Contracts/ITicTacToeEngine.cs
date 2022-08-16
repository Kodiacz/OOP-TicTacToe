namespace TicTacToe.Contracts
{
    public interface ITicTacToeEngine
    {
        void RenderMainMenu();

        void RenderField(IField field);

        void MovePlayer(IPlayer player);

        void CheckForWiner();
    }
}
