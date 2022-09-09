namespace TicTacToe.Contracts
{
    public interface IRenderer
    {
        void AddNewLine();

        void AnnounceWinner(IPlayer player);

        void Clear();

        void PrintPlayerTurn(IPlayer player);

        void RenderField(IField field);

        void RenderMainMenu();

        void PrintDraw();
    }
}
