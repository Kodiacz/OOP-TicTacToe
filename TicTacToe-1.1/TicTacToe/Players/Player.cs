namespace TicTacToe.Players
{
    using TicTacToe.Common;
    using TicTacToe.Contracts;

    public class Player : IPlayer
    {
        public Player(string name)
        {
            this.Name = name;
            this.Symbol = new Symbol();
        }

        public Player(string name, Symbol symbol)
            : this(name)
        {
            this.Symbol = Symbol;
        }

        public string Name { get; private set; }

        public Symbol Symbol { get; private set; }

        public int Points { get; private set; }

        private void IncreasePoints()
        {
            this.Points++;
        }
    }
}
