namespace TicTacToe.Renderers
{
    using TicTacToe.Contracts;

    public class ConsoleRenderer : IRenderer
    {
        public void Render(string output)
        {
            Console.WriteLine(output);
        }
    }
}
