namespace TicTacToe.Renderers
{
using TicTacToe.Common;
    using TicTacToe.Contracts;

    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "Tic-Tac-Toe";

        public void RenderField(IField field)
        {
            for (int row = 0; row < field.TotalRows; row++)
            {
                for (int col = 0; col < field.TotalCols; col++)
                {
                    //ConsoleHelper.CenterConsoleCursor(field.GetField[row, col].Symbol.ToString());

                    Console.Write(field.GetField[row, col].Symbol);
                }

                Console.WriteLine();
            }
        }

        public void RenderMainMenu()
        {
            ConsoleHelper.CenterConsoleCursor(Logo);

            // TODO: add main menu
            Thread.Sleep(1000);

            Console.WriteLine(Logo);
        }
    }
}
