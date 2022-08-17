namespace TicTacToe.Renderers
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;

    public class ConsoleRenderer : IRenderer
    {
        private const string Logo = "Tic-Tac-Toe";
        private const string StringFormatSymbolEmpty = "| |";
        private const string StringFormatSymbolX = "|X|";
        private const string StringFormatSymbolO = "|O|";

        public void RenderField(IField field)
        {
            for (int row = 0; row < field.TotalRows; row++)
            {
                for (int col = 0; col < field.TotalCols; col++)
                {
                    if (field.GetField[row, col].Symbol == Symbol.Empty)
                    {
                        Console.Write(StringFormatSymbolEmpty);
                    }
                    else if (field.GetField[row, col].Symbol == Symbol.X)
                    {
                        Console.WriteLine(StringFormatSymbolX);
                    }
                    else
                    {
                        Console.WriteLine(StringFormatSymbolO);
                    }
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
