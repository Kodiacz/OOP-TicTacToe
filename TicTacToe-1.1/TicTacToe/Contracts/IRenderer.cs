namespace TicTacToe.Contracts
{
    public interface IRenderer
    {
        void RenderMainMenu();

        void RenderField(IField field);

        void AnnounceWinner(IPlayer player);

        void Clear();

        void AddNewLine();
    }
}
