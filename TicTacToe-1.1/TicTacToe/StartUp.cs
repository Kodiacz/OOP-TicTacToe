namespace TicTacToe
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;
    using TicTacToe.Fields;
    using TicTacToe.Marks;
    using TicTacToe.Renderers;

    public class StartUp
    {
        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();
            Console.ReadLine();
        }
    }
}