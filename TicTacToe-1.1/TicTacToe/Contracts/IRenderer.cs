namespace TicTacToe.Contracts
{
    public interface IRenderer
    {
        void RenderMainMenu();

        void RenderField(IField field);
    }
}
