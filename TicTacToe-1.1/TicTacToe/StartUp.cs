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
            IField field = new Field(3, 3);
            IRenderer renderer = new ConsoleRenderer();
            renderer.RenderMainMenu();
            renderer.RenderField(field);
            Console.ReadLine();
        }
    }
}