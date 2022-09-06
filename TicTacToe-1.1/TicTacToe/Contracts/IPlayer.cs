namespace TicTacToe.Contracts
{
    using TicTacToe.Common;

    public interface IPlayer
    {
        public string Name { get; }

        public Symbol Symbol { get; }

        public int Points { get; }
    }
}
