namespace TicTacToe.Renderers
{
    using TicTacToe.Contracts;

    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "Tic-Tac-Toe";

        public void RenderField(IField field)
        {
            throw new NotImplementedException();
        }

        public void RenderMainMenu()
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2 - Logo.Length / 2;

            Console.SetCursorPosition(centerCol, centerRow);

            // TODO: add main menu
            Thread.Sleep(1000);

            Console.WriteLine(Logo);
        }
    }
}
