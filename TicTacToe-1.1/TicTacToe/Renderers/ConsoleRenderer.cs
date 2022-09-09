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
                if (row == 0)
                {
                    Console.WriteLine("   a  b  c");
                }

                for (int col = 0; col < field.TotalCols; col++)
                {
                    if (col == 0)
                    {
                        Console.Write(field.TotalCols - row + " ");
                    }

                    if (field.GetField[row, col].Symbol == Symbol.Empty)
                    {
                        Console.Write(StringFormatSymbolEmpty);
                    }
                    else if (field.GetField[row, col].Symbol == Symbol.X)
                    {
                        Console.Write(StringFormatSymbolX);
                    }
                    else
                    {
                        Console.Write(StringFormatSymbolO);
                    }

                    if (col == field.TotalCols - 1)
                    {
                        Console.Write(" " + (field.TotalCols - row));
                    } 
                }

                Console.WriteLine();

                if (row == field.TotalRows - 1)
                {
                    Console.Write("   a  b  c");
                }
            }

            Console.WriteLine();
        }

        public void RenderMainMenu()
        {
            ConsoleHelper.CenterConsoleCursor(Logo);

            // TODO: add main menu
            Thread.Sleep(1000);

            Console.WriteLine(Logo);
        }

        public void AnnounceWinner(IPlayer player)
        {
            Console.WriteLine($"{player.Name} wins");
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
