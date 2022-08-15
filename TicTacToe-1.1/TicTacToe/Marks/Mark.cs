namespace TicTacToe.Marks
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;

    public class Mark : IMark
    {
        public Mark()
        {
            this.Symbol = new Symbol();
        }
        public Symbol Symbol { get; set; }
    }
}
