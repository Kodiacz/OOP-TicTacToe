namespace TicTacToe.Common
{
    public static class ConsoleHelper
    {
        public static void CenterConsoleCursor(string text)
        {
            int centerRow = Console.WindowHeight / 2;
            int centerCol = Console.WindowWidth / 2 - text.Length / 2;

            Console.SetCursorPosition(centerCol, centerRow);
        }
    }
}
