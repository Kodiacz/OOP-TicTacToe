namespace TicTacToe.Players
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;

    public class Player : IPlayer
    {
        public Player(string name, Symbol symbol)
        {
            this.Name = name;
            this.Symbol = symbol;
        }

        public string Name { get; private set; }

        public Symbol Symbol { get; private set; }

        public int Points { get; private set; }

        public void IncreasePoints()
        {
            this.Points++;
        }
    }
}
